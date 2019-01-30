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
        public void  AddUnit(Unit unit)
        {
            
            using (var client = new MyCouchClient("http://31.132.4.108:5984", "dropzoneunits"))
            {
                string output = JsonConvert.SerializeObject(unit);
                Console.WriteLine(output);

                var response = client.Documents.PostAsync(output);

                Console.WriteLine(response.IsCompleted);
                Console.WriteLine(response.Result.Reason);

                MessageBox.Show("Unit Added Sucesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
        }

        public async Task<List<Unit>> GetAllUnitsforFactionAsync(string faction)
        {
            List<Unit> factionUnits = new List<Unit>();

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync("http://31.132.4.108:5984/dropzoneunits/_design/ucmunits/_view/allunits");
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();

                    Console.WriteLine(responseBody);

                    var units = Units.FromJson(responseBody);

                    units.Rows.ForEach()
                }

                catch(HttpRequestException e)
                {
                    Console.WriteLine("Exception " + e + " caught");
                }
            }

                return factionUnits;
        }

        
    }
}
