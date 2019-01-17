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
    class UnitController
    {
        public void  AddUnit(Unit unit)
        {
            
            using (var client = new MyCouchClient("http:31.132.4.108:5984", "dropzoneunits"))
            {
                string output = JsonConvert.SerializeObject(unit);

                var response = client.Documents.PostAsync(output);

                MessageBox.Show("Unit Added Sucesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
        }
    }
}
