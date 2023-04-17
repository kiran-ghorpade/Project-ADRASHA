using Microsoft.Data.Sqlite;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ZXing;

namespace ADRASHA_Main.Forms
{
    public partial class Member_Profile : Form
    {
        MyFunctions functions = new MyFunctions();
        int member_id=5;
        int family_id = 1;

        public Member_Profile()
        {
            InitializeComponent();
            SetOutputData();
        }
        public Member_Profile(int member_id)
        {
            InitializeComponent();
            this.member_id=member_id;
            SetOutputData();
        }

        private void SetOutputData()
        {
            int partner_id=5;
            string marital_status="single";
            try {
                using (SqliteConnection conn = DatabaseClass.GetConnection())
                {
                    // personal details from member details
                    SqliteCommand cmd = new SqliteCommand("select * from member_details where member_id =" + member_id, conn);
                    SqliteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string name = reader["first_name"].ToString() + " " + reader["middle_name"].ToString() + " " + reader["last_name"].ToString();
                        lblHeadName.Text = name;
                        family_id = Convert.ToInt32(reader["family_Id"]);
                        lblPersonalId.Text = reader["member_id"].ToString();
                        lblFamilId.Text = family_id.ToString();
                        lblBirthDate.Text = reader["birth_date"].ToString();
                        lblBirthPlace.Text = reader["Birth_Place"].ToString();
                        lblGender.Text = reader["Gender"].ToString();
                        lblEducation.Text = reader["Education"].ToString();
                        lblOccupationName.Text = reader["Occupation_name"].ToString();
                        lblWorkPlace.Text = reader["work_place"].ToString();
                        lblWorkType.Text = reader["work_type"].ToString();
                        lblABHAId.Text = reader["abha_number"].ToString();
                        lblAdharId.Text = reader["adhar_number"].ToString();
                        lblMobileNo.Text = reader["mobile_number"].ToString();

                        marital_status = reader["marital_status"].ToString();
                        lblMaritalStatus.Text = marital_status;
                        lblMarriageDate.Text = reader["marriage_Date"].ToString();
                        lblNoOfChild.Text = reader["child_number"].ToString();

                        if (marital_status.Equals("Married"))
                        {
                            partner_id = int.Parse(reader["partner_id"].ToString());
                            lblPartnerPersonalId.Text = partner_id.ToString();
                            DataTable dt = DatabaseClass.GetDataTable("select first_name, middle_name, last_name from member_details where member_Id=" + partner_id);
                            lblPartnerName.Text = dt.Rows[0]["first_Name"].ToString() + dt.Rows[0]["middle_Name"].ToString() + dt.Rows[0]["last_Name"].ToString();
                        }
                        else
                        {
                            lblPartnerName.Text = "None";
                            lblPartnerPersonalId.Text = "None";
                            lblNoOfChild.Text = "None";
                            lblMarriageDate.Text = "None";
                        }

                    }

                    // residential details from family details
                    SqliteCommand cmd1 = new SqliteCommand("select * from family_details where family_id =" + family_id, conn);
                    SqliteDataReader reader1 = cmd1.ExecuteReader();
                    while (reader1.Read())
                    {
                        lblVillage.Text = reader1["village"].ToString();
                        lblPinCode.Text = reader1["PinCode"].ToString();
                        lblTaluka.Text = reader1["taluka"].ToString();
                        lblDistrict.Text = reader1["district"].ToString();
                        lblState.Text = reader1["state"].ToString();
                        lblCountry.Text = reader1["country"].ToString();
                    }

                    if (marital_status.Equals("Married"))
                    {
                        // partner details from member details
                        SqliteCommand cmd2 = new SqliteCommand("select * from member_details where member_id =" + partner_id, conn);
                        SqliteDataReader reader2 = cmd2.ExecuteReader();
                        while (reader2.Read())
                        {
                            string name = reader["first_name"].ToString() + " " + reader["middle_name"].ToString() + " " + reader["last_name"].ToString();
                            lblPartnerName.Text = name;
                        }
                    }
                }
                
            }
            catch
            {
                return;
            }

        }

        private void btnpersonal_Click(object sender, EventArgs e)
        {
            functions.nextpanel_code(pnlPersonal);
        }

        private void btnmarital_Click(object sender, EventArgs e)
        {
            functions.nextpanel_code(pnlMaritalInfo);
        }

        private void btnresident_Click(object sender, EventArgs e)
        {
            functions.nextpanel_code(pnlResidential);
        }

        void Submit()
        {
            DataManipulation dm = new DataManipulation();
            dm.InsertData("member",this);
        }

        private void MemberProfile_Load(object sender, EventArgs e)
        {

            var text = member_id.ToString();

            var barcodeBitmap = GenerateQRCode(text);

            QRImage.Image = barcodeBitmap;
        }

        private void btnFamilyProfile_Click(object sender, EventArgs e)
        {
            this.Dispose();
            MyFunctions.LoadChildForm(new Family_Profile(family_id), MDI.childformpanel);
        }

        private void btnHealthProfile_Click(object sender, EventArgs e)
        {
            this.Dispose();
            MyFunctions.LoadChildForm(new Health_Profile(member_id),MDI.childformpanel);
        }

        private void btnOccupationInfo_Click(object sender, EventArgs e)
        {
            functions.nextpanel_code(pnlOccupation);
        }

        private Bitmap GenerateQRCode(string text)
        {
            var writer = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,

                Options = new ZXing.Common.EncodingOptions
                {
                    Height = QRImage.Height,

                    Width = QRImage.Width
                }
            };
            var barcodeBitmap = writer.Write(text);

            return barcodeBitmap;
        }

    }
}
