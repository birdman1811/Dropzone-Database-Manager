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
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }

        private void UnitsButton_Click(object sender, EventArgs e)
        {
            UnitMenu newScreen = new UnitMenu();
            newScreen.Show();
            Close();
        }
    }
}
