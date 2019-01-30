using Dropzone_Database_Manager.Controllers;
using Dropzone_Database_Manager.DataStore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dropzone_Database_Manager.View
{
    public partial class StartMenu : Form
    {
        UnitController unitControl = new UnitController();
        
        public StartMenu()
        {
            InitializeComponent();
            var unitList = unitControl.GetAllUnitsforFactionAsync("ucmunits");

            Console.WriteLine(unitList);


        }

        private void UnitsButton_Click(object sender, EventArgs e)
        {
            UnitMenu newScreen = new UnitMenu();
            newScreen.Show();
            Close();
        }

        private void FactionsButton_Click(object sender, EventArgs e)
        {
            FactionMenu newScreen = new FactionMenu();
            newScreen.Show();
            Close();
        }
    }
}
