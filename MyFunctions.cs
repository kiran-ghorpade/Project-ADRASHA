using ADRASHA_Main.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADRASHA_Main
{
    internal class MyFunctions 
    {
        private static Form activeform = null;


        public static void LoadChildForm(Form childform, Panel parentPanel)
        {

               if (activeform != null)
            {
                if (activeform.GetType() == childform.GetType())
                {
                    return;
                }
                else
                activeform.Dispose();
                //activeform.Close();
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

        public Panel switch_panel_button(Panel next, PanelControl background, Button button, PanelControl backbutton)
        {
            //switch panel
            background.BringToFront();
            backbutton.BringToFront();
            button.BringToFront();
            next.BringToFront();
            return next;
        }

        public void closebtn_code(Form currentForm)
        {
            //close button code
            currentForm.Close();
        }
       
        public static int CalculateAge(string birth_date)
        {
            int age = 0;
 
            //check if value of birthdate is null or not
            if (birth_date == "")
            {
                age = 0;
            }
            else
            {
                DateTimeConverter timeConverter = new DateTimeConverter();
                DateTime birthdate = (DateTime)timeConverter.ConvertFromString(birth_date);
                // Save today's date.
                var today = DateTime.Today;

                // Calculate the age.
                age = today.Year - birthdate.Year;

                // Go back to the year in which the person was born in case of a leap year
                if (birthdate.Date > today.AddYears(-age)) age--;
            }
            return age;
        }
    }
}

