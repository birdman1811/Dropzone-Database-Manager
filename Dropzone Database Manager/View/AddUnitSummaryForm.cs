﻿using Dropzone_Database_Manager.Controllers;
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
        UnitClass newUnit;
        public AddUnitSummaryForm(UnitClass unit)
        {
            InitializeComponent();
            newUnit = unit;
            uniqueRulesListBox.DataSource = newUnit.ExtraRules;
            uniqueRulesListBox.DisplayMember = "ExtraRules";
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            StartMenu newScreen = new StartMenu();
            newScreen.Show();
            Close();
        }

        private void UnitCompleteButton_Click(object sender, EventArgs e)
        {
            newUnit.Id = newUnit.Faction + newUnit.Name;
            UnitController unitControl = new UnitController();
            unitControl.AddUnit(newUnit);
            UnitMenu newScreen = new UnitMenu();
            newScreen.Show();
            Close();
        }

        private void AddRuleButton_Click(object sender, EventArgs e)
        {
            newUnit.AddExtraRule(UniqueRuleText.Text);
            uniqueRulesListBox.DataSource = null;
            uniqueRulesListBox.DataSource = newUnit.ExtraRules;
            uniqueRulesListBox.DisplayMember = "ExtraRules";
            UniqueRuleText.Clear();
        }

        private void UniqueRulesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void RemoveRuleButton_Click(object sender, EventArgs e)
        {
            string ruleRemove = (string)uniqueRulesListBox.SelectedValue;
            newUnit.RemoveExtraRule(ruleRemove);
            uniqueRulesListBox.DataSource = null;
            uniqueRulesListBox.DataSource = newUnit.ExtraRules;
            uniqueRulesListBox.DisplayMember = "ExtraRules";
        }
    }
}
