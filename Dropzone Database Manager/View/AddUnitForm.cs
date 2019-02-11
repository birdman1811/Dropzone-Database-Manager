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
    public partial class AddUnitForm : Form
    {

        UnitClass newUnit = new UnitClass();
        public AddUnitForm()
        {
            InitializeComponent();
            cmListBox.DataSource = newUnit.CounterMeasures;
            cmListBox.DisplayMember = "CounterMeasure";
            SCListBox.DataSource = newUnit.SquadSizeCoherancy;
            SCListBox.DisplayMember = "SquadSizeCoherancy";
            transportListBox.DataSource = newUnit.TransportOptions;
            transportListBox.DisplayMember = "TransportOptions";
            specialListBox.DataSource = newUnit.Special;
            specialListBox.DisplayMember = "Special";
            infrantryGroup.Visible = false;
            groupBox4.Visible = false;
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            StartMenu newScreen = new StartMenu();
            newScreen.Show();
            Close();
        }

        private void WeaponButton_Click(object sender, EventArgs e)
        {
            
            AddWeaponsForm newScreen = new AddWeaponsForm(newUnit);
            newScreen.Show();
            Close();
            
        }

        private void NameText_TextChanged(object sender, EventArgs e)
        {
            newUnit.Name = nameText.Text;
        }

        private void ArmourSelect_ValueChanged(object sender, EventArgs e)
        {
            newUnit.Armour = (int)armourSelect.Value;
        }

        private void MoveSelect_ValueChanged(object sender, EventArgs e)
        {
            newUnit.Move = (int)moveSelect.Value;
        }

        private void DamageSelect_ValueChanged(object sender, EventArgs e)
        {
            newUnit.DamagePoints = (int)DamageSelect.Value;
        }

        private void PointsSelect_ValueChanged(object sender, EventArgs e)
        {
            newUnit.Points = (int)pointsSelect.Value;
        }

        private void TypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            newUnit.Type = (string)TypeCombo.SelectedItem;
            if (newUnit.Type == "Infantry")
            {
                infrantryGroup.Visible = true;
                groupBox4.Visible = false;
            } 
            if (newUnit.Type == "Aircraft")
            {
                groupBox4.Visible = true;
                infrantryGroup.Visible = false;
            }
            if (newUnit.Type == "Vehicle")
            {
                infrantryGroup.Visible = false;
                groupBox4.Visible = false;
            }
        }

        private void CategoryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            newUnit.Category = (string)categoryCombo.SelectedItem;
        }

        private void LandingZoneCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            newUnit.LandingZone = (string)LandingZoneCombo.SelectedItem;
        }

        private void CQBSelect_ValueChanged(object sender, EventArgs e)
        {
            newUnit.Cqb = CQBSelect.Value;
        }

        private void FortitudeSelect_ValueChanged(object sender, EventArgs e)
        {
            newUnit.Fortitude = (int)FortitudeSelect.Value;
        }

        private void AddCMButton_Click(object sender, EventArgs e)
        {
            newUnit.AddCM(cmText.Text);
            cmListBox.DataSource = null;
            cmListBox.DataSource = newUnit.CounterMeasures;
            cmListBox.DisplayMember = "CounterMeasure";
            cmText.Clear();
        }

        private void RemoveCMButton_Click(object sender, EventArgs e)
        {
            string removeCM = (string)cmListBox.SelectedValue;
            newUnit.RemoveCM(removeCM);
            cmListBox.DataSource = null;
            cmListBox.DataSource = newUnit.CounterMeasures;
            cmListBox.DisplayMember = "CounterMeasure";
        }

        private void SCAddButton_Click(object sender, EventArgs e)
        {
            newUnit.AddSC(SCText.Text);
            SCListBox.DataSource = null;
            SCListBox.DataSource = newUnit.SquadSizeCoherancy;
            SCListBox.DisplayMember = "SquadSizeCoherancy";
            SCText.Clear();
        }

        private void SCRemoveButton_Click(object sender, EventArgs e)
        {
            string removeSC = (string)SCListBox.SelectedValue;
            newUnit.RemoveSC(removeSC);
            SCListBox.DataSource = null;
            SCListBox.DataSource = newUnit.SquadSizeCoherancy;
            SCListBox.DisplayMember = "SquadSizeCoherancy";
        }

        private void AddTransportButton_Click(object sender, EventArgs e)
        {
            newUnit.AddTransport(transportText.Text);
            transportListBox.DataSource = null;
            transportListBox.DataSource = newUnit.TransportOptions;
            transportListBox.DisplayMember = "TransportOptions";
            transportText.Clear();
        }

        private void RemoveTransportButton_Click(object sender, EventArgs e)
        {
            string removeTransport = (string)transportListBox.SelectedValue;
            newUnit.RemoveTransport(removeTransport);
            transportListBox.DataSource = null;
            transportListBox.DataSource = newUnit.TransportOptions;
            transportListBox.DisplayMember = "TransportOptions";
        }

        private void AddSpecialButton_Click(object sender, EventArgs e)
        {
            newUnit.AddSpecialRule(specialText.Text);
            specialListBox.DataSource = null;
            specialListBox.DataSource = newUnit.Special;
            specialListBox.DisplayMember = "Special";
            specialText.Clear();
        }

        private void RemoveSpecialButton_Click(object sender, EventArgs e)
        {
            string removeSpecial = (string)specialListBox.SelectedValue;
            newUnit.RemoveSpecialRule(removeSpecial);
            specialListBox.DataSource = null;
            specialListBox.DataSource = newUnit.Special;
            specialListBox.DisplayMember = "Special";
        }

        private void FactionCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            newUnit.Faction = (string)factionCombo.SelectedItem;
        }
    }
}
