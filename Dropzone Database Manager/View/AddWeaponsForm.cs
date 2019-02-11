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
    public partial class AddWeaponsForm : Form
    {
        UnitClass unit;
        Weapon newWeapon = new Weapon();
        public AddWeaponsForm(UnitClass newUnit)
        {
            InitializeComponent();
            unit = newUnit;
            TitleLabel.Text = "Add Weapons For " + unit.Faction + " " + unit.Name;
            WeaponsListBox.DataSource = unit.Weapons;
            WeaponsListBox.DisplayMember = "fullString";
            RulesListBox.DataSource = newWeapon.Special;
            RulesListBox.DisplayMember = "Special";
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            StartMenu newScreen = new StartMenu();
            newScreen.Show();
            Close();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            AddUnitSummaryForm newScreen = new AddUnitSummaryForm(unit);
            newScreen.Show();
            Close();

        }

        private void NameText_TextChanged(object sender, EventArgs e)
        {
            newWeapon.Name = nameText.Text;
        }

        private void EnergySelect_ValueChanged(object sender, EventArgs e)
        {
            newWeapon.Energy = (int)energySelect.Value;
        }

        private void ShotsSelect_ValueChanged(object sender, EventArgs e)
        {
            newWeapon.Shots = (int)ShotsSelect.Value;
        }

        private void AccuracySelect_ValueChanged(object sender, EventArgs e)
        {
            newWeapon.Accuracy = (int)accuracySelect.Value;
        }

        private void FullRangeText_TextChanged(object sender, EventArgs e)
        {
            newWeapon.RangeFull = fullRangeText.Text;
        }

        private void CounteredRangeText_TextChanged(object sender, EventArgs e)
        {
            newWeapon.RangeCountered = counteredRangeText.Text;
        }

        

        private void FireArcsText_TextChanged(object sender, EventArgs e)
        {
            newWeapon.Arc = FireArcsText.Text;
        }

        private void IsOptionalCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            newWeapon.Optional = isOptionalCheckBox.Checked;
        }

        private void OptionalCostSelect_ValueChanged(object sender, EventArgs e)
        {
            newWeapon.OptionalCost = (int)OptionalCostSelect.Value;
        }

        private void AddRuleButton_Click(object sender, EventArgs e)
        {
            newWeapon.AddRule(SpecialRuleText.Text);
            RulesListBox.DataSource = null;
            RulesListBox.DataSource = newWeapon.Special;
            RulesListBox.DisplayMember = "Special";
        }

        private void RemoveRuleButton_Click(object sender, EventArgs e)
        {
            string removeRule = (string)RulesListBox.SelectedValue;
            newWeapon.RemoveRule(removeRule);
            RulesListBox.DataSource = null;
            RulesListBox.DataSource = newWeapon.Special;
            RulesListBox.DisplayMember = "Special";
        }

        private void RemoveWeaponButton_Click(object sender, EventArgs e)
        {
            Weapon weaponToRemove = (Weapon)WeaponsListBox.SelectedItem;
            unit.RemoveWeapon(weaponToRemove);
            WeaponsListBox.DataSource = null;
            WeaponsListBox.DataSource = unit.Weapons;
            WeaponsListBox.DisplayMember = "fullString";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            unit.AddWeapon(newWeapon);
            AddWeaponsForm newScreen = new AddWeaponsForm(unit);
            newScreen.Show();
            Close();
        }

        private void MFText_TextChanged(object sender, EventArgs e)
        {
            newWeapon.MoveFire = MFText.Text;
        }
    }
}
