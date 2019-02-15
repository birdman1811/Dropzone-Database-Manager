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
    public partial class EditUniqueRulesForm : Form
    {
        UnitClass editUnit = new UnitClass();
        UnitController unitControl = new UnitController();

        public EditUniqueRulesForm(UnitClass unit)
        {
            editUnit = unit;
            InitializeComponent();
            TitleLabel.Text = "Edit Unique Rules For " + editUnit.Faction + " " + editUnit.Name;
            uniqueRulesListBox.DataSource = editUnit.ExtraRules;
            uniqueRulesListBox.DisplayMember = "ExtraRules";
        }

        private void removeRuleButton_Click(object sender, EventArgs e)
        {
            string removeRule = (string)uniqueRulesListBox.SelectedItem;
            editUnit.RemoveExtraRule(removeRule);
            uniqueRulesListBox.DataSource = null;
            uniqueRulesListBox.DataSource = editUnit.ExtraRules;
            uniqueRulesListBox.DisplayMember = "ExtraRules";
        }

        private void EditRuleButton_Click(object sender, EventArgs e)
        {
            UniqueRuleText.Text = (string)uniqueRulesListBox.SelectedItem;
            UpdateCompleteButton.Visible = true;
            uniqueRulesListBox.Enabled = false;
        }

        private void UpdateCompleteButton_Click(object sender, EventArgs e)
        {
            string editRule = (string)uniqueRulesListBox.SelectedItem;
            editUnit.RemoveExtraRule(editRule);
            editRule = UniqueRuleText.Text;
            editUnit.AddExtraRule(editRule);
            UpdateCompleteButton.Visible = false;
            uniqueRulesListBox.Enabled = true;
            uniqueRulesListBox.DataSource = null;
            uniqueRulesListBox.DataSource = editUnit.ExtraRules;
            uniqueRulesListBox.DisplayMember = "ExtraRules";
            UniqueRuleText.Clear();
        }

        private void addRuleButton_Click(object sender, EventArgs e)
        {
            AddThisRuleButton.Visible = true;            
        }

        private void AddThisRuleButton_Click(object sender, EventArgs e)
        {
            string newRule = UniqueRuleText.Text;
            editUnit.AddExtraRule(newRule);
            AddThisRuleButton.Visible = false;
            uniqueRulesListBox.DataSource = null;
            uniqueRulesListBox.DataSource = editUnit.ExtraRules;
            uniqueRulesListBox.DisplayMember = "ExtraRules";
            UniqueRuleText.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            unitControl.UpdateUnit(editUnit);            
            UnitMenu newScreen = new UnitMenu();
            newScreen.Show();
            Close();
        }
    }
}
