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
    public partial class EditUnitMenu : Form
    {
        FactionController factionControl = new FactionController();
        UnitController unitControl = new UnitController();
        List<UnitClass> unitList = new List<UnitClass>();
        List<FactionClass> factionList = new List<FactionClass>();
        FactionClass selectedFaction = new FactionClass();
        UnitClass selectedUnit = new UnitClass();

        public EditUnitMenu()
        {
            InitializeComponent();
            UnitPanel.Visible = false;

            var getFactionTask = Task.Run(() => GetFactions());
            bool factionsGot = CheckTaskComplete(getFactionTask);
            while (factionsGot == false)
            {
                factionsGot = CheckTaskComplete(getFactionTask);
            }

            FactionCombo.DataSource = factionList;
            FactionCombo.DisplayMember = "Name";                         
            
        }

        private async Task<List<FactionClass>> GetFactions()
        {            
            factionList = await Task.Run(() => factionControl.GetAllFactions());
            return factionList;
        }

        private async Task<List<UnitClass>> GetUnits()
        {

            unitList = await Task.Run(() => unitControl.GetAllUnitsforFactionAsync(selectedFaction));
            return unitList;
        }

        private bool CheckTaskComplete(Task task)
        {
            bool isComplete = false;

            if (task.IsCompleted == true)
            {
                isComplete = true;
            }            

            return isComplete;
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            StartMenu newScreen = new StartMenu();
            newScreen.Show();
            Close();
        }

        private void FactionSelectButton_Click(object sender, EventArgs e)
        {
            selectedFaction = (FactionClass)FactionCombo.SelectedItem;
            string factionName = selectedFaction.Name;
            var getUnitsTask = Task.Run(() => GetUnits());
            bool unitsGot = false;
            while (unitsGot == false)
            {
                unitsGot = CheckTaskComplete(getUnitsTask);
            }

            UnitCombo.DataSource = unitList;
            UnitCombo.DisplayMember = "Name";
            panel1.Visible = false;
            UnitPanel.Visible = true;
        }

        private void ChangeFactionButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            UnitCombo.DataSource = null;
            UnitPanel.Visible = false;
        }

        private void SelectUnitButton_Click(object sender, EventArgs e)
        {
            selectedUnit = (UnitClass)UnitCombo.SelectedItem;
            UnitSheet newScreen = new UnitSheet(selectedUnit);
            newScreen.Show();
            Close();

        }
    }
}
