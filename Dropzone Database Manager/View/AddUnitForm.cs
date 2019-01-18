﻿using Dropzone_Database_Manager.DataStore;
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

        Unit newUnit = new Unit();
        public AddUnitForm()
        {
            InitializeComponent();
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
    }
}
