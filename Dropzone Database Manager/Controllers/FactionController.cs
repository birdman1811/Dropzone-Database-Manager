using Dropzone_Database_Manager.DataStore;
using MyCouch;
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
    class FactionController
    {

        public void AddFaction(FactionClass faction)
        {

            using (var client = new MyCouchClient("http://31.132.4.108:5984", "dropzonefactions"))
            {
                string output = JsonConvert.SerializeObject(faction);
                Console.WriteLine(output);

                var response = client.Documents.PostAsync(output);

                Console.WriteLine(response.IsCompleted);
                Console.WriteLine(response.Result.Reason);

                MessageBox.Show("Faction Added Sucesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        public async Task<List<FactionClass>> GetAllFactions()
        {
            List<FactionClass> factionList = new List<FactionClass>();

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string address = "http://31.132.4.108:5984/dropzonefactions/_design/factions/_view/allfactions?include_docs=true";

                    HttpResponseMessage response = await client.GetAsync(address);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();

                    Console.WriteLine(responseBody);

                    var factions = FactionQT.Factions.FromJson(responseBody);

                    foreach(var row in factions.Rows)
                    {
                        FactionClass newFaction = new FactionClass();
                        newFaction.SetCouchID(row.Key);
                        newFaction.Name = row.Doc.Name;
                        newFaction.Lore = row.Doc.Lore;
                        newFaction.GamePlay = row.Doc.GamePlay;
                        newFaction.Imageurl = row.Doc.Imageurl;
                    }


                }

                catch (HttpRequestException e)
                {
                    Console.WriteLine("Exception " + e + " caught");
                }
            }

            return factionList;
        }
    }
}
