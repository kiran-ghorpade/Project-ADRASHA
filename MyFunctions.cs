using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADRASHA_Main
{
    internal class MyFunctions
    {
        private Form activeform = null;
        public void LoadChildForm(Form childform, Panel parentPanel)
        {
            if (activeform != null)
            {
                activeform.Close();
            }
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            parentPanel.Controls.Clear();
            parentPanel.Controls.Add(childform);
            parentPanel.Tag = childform;
            childform.BringToFront();
            childform.Show();

        }

        public Panel nextpanel_code(Panel next)
        {
            //method for next button for panel only
            next.BringToFront();
            return next;
        }

        public void closebtn_code(Form currentForm)
        {
            //close button code
            currentForm.Close();
        }

        private void SetProperty(Control ctr)
        {
            //to set same property for all type of controls
            foreach (Control control in ctr.Controls)
            {
                if (control is TextBox)
                {
                    control.ContextMenu = new ContextMenu();
                }
                else
                {
                    if (control.HasChildren)
                    {
                        SetProperty(control);
                    }
                }
            }
        }

        void SetControl(ContextMenu menu, Control control)
        {
            //to set same action or properties on all types of control
            if (control is TextBox)
                control.ContextMenu = menu;
            else
            {
                foreach (Control c in control.Controls)
                    SetControl(menu, c);
            }
        }
    }
}
