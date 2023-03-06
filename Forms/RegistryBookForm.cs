using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADRASHA_Main
{
    public partial class RegistryBookForm : Form
    {
        MyFunctions functions = new MyFunctions();

        public RegistryBookForm()
        {
            InitializeComponent();
        }

        private void main_panelcontrol_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            functions.LoadChildForm(new AddNewFamily(), MDI.childformpanel);
        }
    }
}
