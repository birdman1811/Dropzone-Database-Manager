using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dropzone_Database_Manager.DataStore;
using Dropzone_Database_Manager.Controllers;

namespace Dropzone_Database_Manager.View
{
    public partial class AddFactionForm : Form
    {

        FactionController factionControl = new FactionController();
        FactionClass newFaction = new FactionClass();

        public AddFactionForm()
        {
            InitializeComponent();
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            StartMenu newScreen = new StartMenu();
            newScreen.Show();
            Close();
        }

        private void NameText_TextChanged(object sender, EventArgs e)
        {
            newFaction.Name = nameText.Text;
        }

        private void ImageText_TextChanged(object sender, EventArgs e)
        {
            newFaction.Imageurl = imageText.Text;
        }

        private void LoreText_TextChanged(object sender, EventArgs e)
        {
            newFaction.Lore = LoreText.Text;
        }

        private void GamePlayText_TextChanged(object sender, EventArgs e)
        {
            newFaction.GamePlay = gamePlayText.Text;
        }

        private void AddFactionButton_Click(object sender, EventArgs e)
        {
            factionControl.AddFaction(newFaction);
            AddFactionForm newScreen = new AddFactionForm();
            newScreen.Show();
            Close();
        }
    }
}
