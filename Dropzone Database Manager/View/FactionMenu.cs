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
    public partial class FactionMenu : Form
    {
        public FactionMenu()
        {
            InitializeComponent();
        }

        private void AddFactionButton_Click(object sender, EventArgs e)
        {
            AddFactionForm newScreen = new AddFactionForm();
            newScreen.Show();
            Close();
        }
    }
}
