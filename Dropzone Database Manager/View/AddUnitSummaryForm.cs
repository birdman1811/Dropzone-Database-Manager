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
    public partial class AddUnitSummaryForm : Form
    {
        Unit newUnit;
        public AddUnitSummaryForm(Unit unit)
        {
            InitializeComponent();
            newUnit = unit;
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            StartMenu newScreen = new StartMenu();
            newScreen.Show();
            Close();
        }

        private void UnitCompleteButton_Click(object sender, EventArgs e)
        {
            UnitController unitControl = new UnitController();
            unitControl.AddUnit(newUnit);
            UnitMenu newScreen = new UnitMenu();
            newScreen.Show();
            Close();
        }
    }
}
