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
    public partial class UnitSheet : Form
    {
        UnitClass editUnit = new UnitClass();
        public UnitSheet(UnitClass unit)
        {
            InitializeComponent();
            editUnit = unit;
            nameText.Text = editUnit.Name;
            armourSelect.Value = editUnit.Armour;
            moveSelect.Value = editUnit.Move;
            DamageSelect.Value = editUnit.DamagePoints;
            pointsSelect.Value = editUnit.Points;
            CQBSelect.Value = editUnit.Cqb;
            FortitudeSelect.Value = editUnit.Fortitude;
            TypeCombo.SelectedItem = editUnit.Type;
            categoryCombo.SelectedItem = editUnit.Category;
            factionCombo.SelectedItem = editUnit.Faction;
            LandingZoneCombo.SelectedItem = editUnit.LandingZone;
            CQBSelect.Value = editUnit.Cqb;
            FortitudeSelect.Value = editUnit.Fortitude;
            cmListBox.DataSource = editUnit.CounterMeasures;
            cmListBox.DisplayMember = "CounterMeasure";
            SCListBox.DataSource = editUnit.SquadSizeCoherancy;
            SCListBox.DisplayMember = "SquadSizeCoherancy";
            transportListBox.DataSource = editUnit.TransportOptions;
            transportListBox.DisplayMember = "TransportOptions";
            specialListBox.DataSource = editUnit.Special;
            specialListBox.DisplayMember = "Special";
            if (editUnit.Type == "Aircraft")
            {
                AircraftGroup.Visible = true;
            }
            if (editUnit.Type == "Infantry")
            {
                infrantryGroup.Visible = true;
            }
        }

        private void nameText_TextChanged(object sender, EventArgs e)
        {
            editUnit.Name = nameText.Text;
        }

        private void armourSelect_ValueChanged(object sender, EventArgs e)
        {
            editUnit.Armour = (int)armourSelect.Value;
        }

        private void DamageSelect_ValueChanged(object sender, EventArgs e)
        {
            editUnit.DamagePoints = (int)DamageSelect.Value;
        }

        private void pointsSelect_ValueChanged(object sender, EventArgs e)
        {
            editUnit.Points = (int)pointsSelect.Value;
        }

        private void TypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            editUnit.Type = (string)TypeCombo.SelectedItem;
            if (editUnit.Type == "Infantry")
            {
                infrantryGroup.Visible = true;
                AircraftGroup.Visible = false;
            }
            if (editUnit.Type == "Aircraft")
            {
                AircraftGroup.Visible = true;
                infrantryGroup.Visible = false;
            }
            if (editUnit.Type == "Vehicle")
            {
                infrantryGroup.Visible = false;
                AircraftGroup.Visible = false;
            }
        }

        private void categoryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            editUnit.Category = (string)categoryCombo.SelectedItem;
        }

        private void factionCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            editUnit.Faction = (string)factionCombo.SelectedItem;
            
        }

        private void LandingZoneCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            editUnit.LandingZone = (string)LandingZoneCombo.SelectedItem;
        }

        private void CQBSelect_ValueChanged(object sender, EventArgs e)
        {
            editUnit.Cqb = CQBSelect.Value;
        }

        private void FortitudeSelect_ValueChanged(object sender, EventArgs e)
        {
            editUnit.Fortitude = (int)FortitudeSelect.Value;
        }

        private void addCMButton_Click(object sender, EventArgs e)
        {
            string newCM = cmText.Text;
            editUnit.AddCM(newCM);
            cmListBox.DataSource = null;
            cmListBox.DataSource = editUnit.CounterMeasures;
            cmListBox.DisplayMember = "CounterMeasures";
        }

        private void removeCMButton_Click(object sender, EventArgs e)
        {
            string removeCM = (string)cmListBox.SelectedItem;
            editUnit.RemoveCM(removeCM);
            cmListBox.DataSource = null;
            cmListBox.DataSource = editUnit.CounterMeasures;
            cmListBox.DisplayMember = "CounterMeasures";
        }

        private void SCAddButton_Click(object sender, EventArgs e)
        {
            string addSC = SCText.Text;
            editUnit.AddSC(addSC);
            SCListBox.DataSource = null;
            SCListBox.DataSource = editUnit.SquadSizeCoherancy;
            SCListBox.DisplayMember = "SquadSizeCoherancy";
        }

        private void SCRemoveButton_Click(object sender, EventArgs e)
        {
            string removeSC = (string)SCListBox.SelectedItem;
            editUnit.RemoveSC(removeSC);
            SCListBox.DataSource = null;
            SCListBox.DataSource = editUnit.SquadSizeCoherancy;
            SCListBox.DisplayMember = "SquadSizeCoherancy";
        }

        private void addTransportButton_Click(object sender, EventArgs e)
        {
            string addTransport = transportText.Text;
            editUnit.AddTransport(addTransport);
            transportListBox.DataSource = null;
            transportListBox.DataSource = editUnit.TransportOptions;
            transportListBox.DisplayMember = "TransportOPtions";
        }

        private void removeTransportButton_Click(object sender, EventArgs e)
        {
            string removeTransport = (string)transportListBox.SelectedItem;
            editUnit.RemoveTransport(removeTransport);
            transportListBox.DataSource = null;
            transportListBox.DataSource = editUnit.TransportOptions;
            transportListBox.DisplayMember = "TransportOPtions";
        }

        private void addSpecialButton_Click(object sender, EventArgs e)
        {
            string newSpecial = specialText.Text;
            editUnit.AddSpecialRule(newSpecial);
            specialListBox.DataSource = null;
            specialListBox.DataSource = editUnit.Special;
            specialListBox.DisplayMember = "Special";
        }

        private void removeSpecialButton_Click(object sender, EventArgs e)
        {
            string removeSpecial = (string)specialListBox.SelectedItem;
            editUnit.RemoveSpecialRule(removeSpecial);
            specialListBox.DataSource = null;
            specialListBox.DataSource = editUnit.Special;
            specialListBox.DisplayMember = "Special";
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {            
            EditWeaponForm newScreen = new EditWeaponForm(editUnit);
            newScreen.Show();
            Close();
        }
    }

}
