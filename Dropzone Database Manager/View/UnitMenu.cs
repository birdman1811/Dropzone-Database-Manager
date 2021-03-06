﻿using System;
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
    public partial class UnitMenu : Form
    {
        public UnitMenu()
        {
            InitializeComponent();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            StartMenu newScreen = new StartMenu();
            newScreen.Show();
            Close();
        }

        private void AddUnitBUtton_Click(object sender, EventArgs e)
        {
            AddUnitForm newScreen = new AddUnitForm();
            newScreen.Show();
            Close();
        }

        private void editUnitButton_Click(object sender, EventArgs e)
        {
            EditUnitMenu newScreen = new EditUnitMenu();
            newScreen.Show();
            Close();
        }
    }
}
