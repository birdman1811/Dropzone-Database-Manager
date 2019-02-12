using Dropzone_Database_Manager.DataStore;
using MyCouch;
using MyCouch.Requests;
using MyCouch.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dropzone_Database_Manager.Controllers
{
    class UnitController
    {
        public void  AddUnit(UnitClass unit)
        {
            
            using (var client = new MyCouchClient("http://31.132.4.108:5984", "dropzoneunits"))
            {
                string output = JsonConvert.SerializeObject(unit);                

                var response = client.Documents.PostAsync(output);                

                MessageBox.Show("Unit Added Sucesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
        }

        public async Task<List<UnitClass>> GetAllUnitsforFactionAsync(FactionClass faction)
        {
            List<UnitClass> factionUnits = new List<UnitClass>();

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string address = "http://31.132.4.108:5984/dropzoneunits/_design/" + faction.Name.ToLower() + "units/_view/allunits";
                    
                    HttpResponseMessage response = await client.GetAsync(address);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();

                    Console.WriteLine(responseBody);

                    var units = UnitQT.Units.FromJson(responseBody);

                    foreach (var row in units.Rows)
                    {
                        UnitClass newUnit = new UnitClass();
                        newUnit.SetCouchID(row.Key.KeyId);
                        newUnit.Id = row.Key.Id;
                        newUnit.Name = row.Key.Name;
                        newUnit.Armour = (int)row.Key.Armour;
                        newUnit.Move = (int)row.Key.Move;
                        foreach(string cm in row.Key.CounterMeasures)
                        {
                            newUnit.AddCM(cm.ToString());
                        }
                        newUnit.DamagePoints = (int)row.Key.DamagePoints;
                        newUnit.Points = (int)row.Key.Points;
                        newUnit.Type = row.Key.Type;
                        newUnit.Category = row.Key.Category;
                        newUnit.Cqb = (decimal)row.Key.Cqb;
                        newUnit.Fortitude = (int)row.Key.Fortitude;
                        foreach(string ssc in row.Key.SquadSizeCoherancy)
                        {
                            newUnit.AddSC(ssc);
                        }
                        newUnit.LandingZone = row.Key.LandingZone;
                        foreach(string to in row.Key.TransportOptions)
                        {
                            newUnit.AddTransport(to);
                        }
                        foreach(string exRule in row.Key.ExtraRules)
                        {
                            newUnit.AddExtraRule(exRule);
                        }
                        foreach(string special in row.Key.Special)
                        {
                            newUnit.AddSpecialRule(special);
                        }
                        foreach(UnitQT.Weapon weapon in row.Key.Weapons)
                        {
                            Weapon newWeapon = new Weapon();
                            newWeapon.Name = weapon.Name;
                            newWeapon.Energy = (int)weapon.Energy;
                            newWeapon.Shots = (int)weapon.Shots;
                            newWeapon.Accuracy = (int)weapon.Accuracy;
                            newWeapon.RangeFull = weapon.RangeFull;
                            newWeapon.RangeCountered = weapon.RangeCountered;
                            newWeapon.MoveFire = weapon.MoveFire;
                            newWeapon.Arc = weapon.Arc;
                            newWeapon.Optional = weapon.Optional;
                            newWeapon.OptionalCost = (int)weapon.OptionalCost;
                            foreach(string special in row.Key.Special)
                            {
                                newWeapon.AddRule(special);
                            }
                            newUnit.AddWeapon(newWeapon);
                        }
                        newUnit.Faction = row.Key.Faction;
                        factionUnits.Add(newUnit);
                    }
                    Console.WriteLine(factionUnits.Count);
                   
                }

                catch (HttpRequestException e)
                {
                    Console.WriteLine("Exception " + e + " caught");
                }
            }

                return factionUnits;
        }

        
    }
}
