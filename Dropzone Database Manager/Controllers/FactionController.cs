using Dropzone_Database_Manager.DataStore;
using MyCouch;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
