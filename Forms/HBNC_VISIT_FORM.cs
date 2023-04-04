using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADRASHA_Main.Forms
{
    public partial class HBNC_VISIT_FORM : Form
    {
        int id;
        public HBNC_VISIT_FORM(int member_id , string name)
        {
            InitializeComponent();
            this.id = member_id;
            lblMemberName.Text = name;
        }

        private void btnPersonalProfile_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Previous_Pregnancies_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.Only_Numeric(sender,e);
        }

        private void HBNC_VISIT_FORM_Load(object sender, EventArgs e)
        {
            Validation.SetComboBox(this);
            DataTable dt = DatabaseClass.GetDataTable("select count(hbnc_visit_Id) from hbnc_visits where member_id="+id);
            HBNC_visit.Text = dt.Rows[0][0].ToString();
            HBNC_visit.Enabled = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (
                 Meal.Text == "" ||
                 Temperature.Text == ""||
                 weight.Text == ""||
                 baby_temperature.Text==""
                )
            {
                MessageBox.Show("All Fields Required.");
                return;
            }

            Dictionary<string, object> hbnc_visits_map = new Dictionary<string, object>
            {
                 {"HBNC_VISIT_DATE",HBNC__VISIT_DATE.Value.Date},
                 {"MEMBER_ID",id},
                 {"HBNC_VISIT_NO",HBNC_visit.Text},
                 {"Meal",Meal.Text},
                 {"kept_warm",Kept_Warm.SelectedItem},
                 {"baby_feed_proparly",Baby_feed_properly.SelectedItem},
                 {"baby_crying",baby_crying.SelectedItem},
                 {"TEMPERATURE",Temperature.Text},
                 {"foul_smelling",foul_smelling.SelectedItem},
                 {"Speaking_abnormally",Speaking_Abnormally.SelectedItem},
                 {"No_milk",No_milk.SelectedItem},
                 {"Cracked_Nipples",Cracked_nipples.SelectedItem},
                 {"eye_swollen",eye_swollen.SelectedItem},
                 {"Weight",weight.Text},
                 {"baby_temperature",baby_temperature.Text},
                 {"Skin",Skin.SelectedItem},
                 {"Crack_Redness",Crack_Redness.SelectedItem},
                 {"Yellowness",Yellowness.SelectedItem}

            };
            
            DatabaseClass db = new DatabaseClass();
            if (db.InsertRow("hbnc_visits", hbnc_visits_map))
            {
                MessageBox.Show("Visit Added.");
                this.Dispose();
            }
        }
    }
}
