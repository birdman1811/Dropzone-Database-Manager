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
    public partial class EditWeaponForm : Form
    {
        UnitClass editUnit = new UnitClass();
        Weapon editWeapon = new Weapon();

        public EditWeaponForm(UnitClass unit)
        {
            InitializeComponent();
            editUnit = unit;
            TitleLabel.Text = "Edit Weapons For " + editUnit.Faction + " " + editUnit.Name;
            WeaponsListBox.DataSource = editUnit.Weapons;
            WeaponsListBox.DisplayMember = "Fullstring";
        }

        private void WeaponsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            editWeapon = (Weapon)WeaponsListBox.SelectedItem;
        }

        private void RemoveWeaponButton_Click(object sender, EventArgs e)
        {
            editUnit.RemoveWeapon(editWeapon);
            WeaponsListBox.DataSource = null;
            WeaponsListBox.DataSource = editUnit.Weapons;
            WeaponsListBox.DisplayMember = "Fullstring";
        }

        private void CloneWeaponButton_Click(object sender, EventArgs e)
        {
            Weapon newWeapon = new Weapon
            {
                Name = editWeapon.Name,
                Accuracy = editWeapon.Accuracy,
                Arc = editWeapon.Arc,
                Energy = editWeapon.Energy,
                MoveFire = editWeapon.MoveFire,
                Optional = editWeapon.Optional,
                OptionalCost = editWeapon.OptionalCost,
                RangeCountered = editWeapon.RangeCountered,
                RangeFull = editWeapon.RangeFull,
                Shots = editWeapon.Shots,
                Special = editWeapon.Special
            };
            editUnit.AddWeapon(newWeapon);
            WeaponsListBox.DataSource = null;
            WeaponsListBox.DataSource = editUnit.Weapons;
            WeaponsListBox.DisplayMember = "Fullstring";
        }

        private void EditShowButton_Click(object sender, EventArgs e)
        {
            editWeapon = (Weapon)WeaponsListBox.SelectedItem;
            EditWeaponButton.Visible = true;
            groupBox1.Visible = true;
            statsGroupBox.Visible = true;
            RulesListBox.DataSource = editUnit.Special;
            RulesListBox.DisplayMember = "Special";
            nameText.Text = editWeapon.Name;
            energySelect.Value = editWeapon.Energy;
            ShotsSelect.Value = editWeapon.Shots;
            accuracySelect.Value = editWeapon.Accuracy;
            fullRangeText.Text = editWeapon.RangeFull;
            counteredRangeText.Text = editWeapon.RangeCountered;
            MFText.Text = editWeapon.MoveFire;
            FireArcsText.Text = editWeapon.Arc;
        }

        private void AddRuleButton_Click(object sender, EventArgs e)
        {
            string newrule = SpecialRuleText.Text;
            editWeapon.AddRule(newrule);
            RulesListBox.DataSource = null;
            RulesListBox.DataSource = editUnit.Special;
            RulesListBox.DisplayMember = "Special";
        }

        private void RemoveRuleButton_Click(object sender, EventArgs e)
        {
            string removeRule = (string)RulesListBox.SelectedItem;
            editWeapon.RemoveRule(removeRule);
            RulesListBox.DataSource = null;
            RulesListBox.DataSource = editUnit.Special;
            RulesListBox.DisplayMember = "Special";
        }

        private void IsOptionalCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            editWeapon.Optional = isOptionalCheckBox.Checked;
        }

        private void OptionalCostSelect_ValueChanged(object sender, EventArgs e)
        {
            editWeapon.OptionalCost = (int)OptionalCostSelect.Value;
        }

        private void NameText_TextChanged(object sender, EventArgs e)
        {
            editWeapon.Name = nameText.Text;
        }

        private void EnergySelect_ValueChanged(object sender, EventArgs e)
        {
            editWeapon.Energy = (int)energySelect.Value;
        }

        private void ShotsSelect_ValueChanged(object sender, EventArgs e)
        {
            editWeapon.Shots = (int)ShotsSelect.Value;
        }

        private void AccuracySelect_ValueChanged(object sender, EventArgs e)
        {
            editWeapon.Accuracy = (int)accuracySelect.Value;
        }

        private void FullRangeText_TextChanged(object sender, EventArgs e)
        {
            editWeapon.RangeFull = fullRangeText.Text;
        }

        private void CounteredRangeText_TextChanged(object sender, EventArgs e)
        {
            editWeapon.RangeCountered = counteredRangeText.Text;
        }

        private void MFText_TextChanged(object sender, EventArgs e)
        {
            editWeapon.MoveFire = MFText.Text;
        }

        private void FireArcsText_TextChanged(object sender, EventArgs e)
        {
            editWeapon.Arc = FireArcsText.Text;
        }

        private void EditWeaponButton_Click(object sender, EventArgs e)
        {
            WeaponsListBox.DataSource = null;
            WeaponsListBox.DataSource = editUnit.Weapons;
            WeaponsListBox.DisplayMember = "Fullstring";
            EditWeaponButton.Visible = false;
            groupBox1.Visible = false;
            statsGroupBox.Visible = false;
            editWeapon = new Weapon();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            editWeapon = new Weapon();
            groupBox1.Visible = true;
            statsGroupBox.Visible = true;
            AddWeapon.Visible = true;
        }

        private void AddWeapon_Click(object sender, EventArgs e)
        {
            editUnit.AddWeapon(editWeapon);
            WeaponsListBox.DataSource = null;
            WeaponsListBox.DataSource = editUnit.Weapons;
            WeaponsListBox.DisplayMember = "Fullstring";
            AddWeapon.Visible = false;
            groupBox1.Visible = false;
            statsGroupBox.Visible = false;
            editWeapon = new Weapon();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            EditUniqueRulesForm newScreen = new EditUniqueRulesForm(editUnit);
            newScreen.Show();
            Close();
        }
    }
}
