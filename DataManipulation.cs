using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Microsoft.Data.Sqlite;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.AxHost;

namespace ADRASHA_Main
{
    internal class DataManipulation
    {
        // Create a dictionary to store the control names and corresponding parameter names
        Dictionary<string, object> Asha_DetailsMap = new Dictionary<string, object>()
        {
            {"First_Name","@first_name" },
            {"Middle_Name","@middle_name" },
            {"Last_Name","@last_name" } ,
            {"Birth_Date" ,"@birth_date"},
            {"Mobile_NO" ,"@mobile_no"},
            {"Marital_Status","@marital_info" },
            {"Qualifications","@qualifications" },
            {"Center","@center"},
            {"Sub_Center","@sub_center" }, 
            {"Village","@village" },     
            {"PinCode","@pincode" },       
            {"Taluka","@taluka" },       
            {"District","@district" },    
            {"State","@state" },
            {"Total_Families","@total_families" },
            {"Total_Population","@total_population" },
            {"Village_Type","@village_type" }
        };

        Dictionary<string, object> MemberInfoMap = new Dictionary<string, object>
            {   
                //values for table memberinfo
                {"Member_Id", "@Member_Id"},
                {"Family_Id", "@Family_id"},
                {"First_Name", "@FirstName"},
                {"Middle_Name", "@MiddleName"},
                {"Last_Name", "@LastName"},
                {"Birth_Date", "@BirthDate"},
                {"Birth_Place","@birthplace" },
                {"Gender", "@Gender"},
                {"Mobile_Number", "@PhoneNumber"},
                {"Email", "@Email"},
                {"Adhar_Number", "@Adhar"},
                {"ABHA_Number", "@abhaid"},
                {"Occupation_Name", "@occupation"},
                {"Work_Place", "@workPlace"},
                {"Work_Type", "@worktype"},
                {"Education", "@education"},
                {"Marital_Status", "@maritalstatus"},
                {"Marriage_Date", "@marriagedate"},
                {"Partner_Id", "@partnerid"},
                {"Child_Number", "@childnumber"}
            };

        Dictionary<string, object> FamilyInfoMap = new Dictionary<string, object>
            {
                //values for table familyinfo
                {"House_Type", "@house_type"},
                {"Total_Members", "@total_members"},
                {"Vehicle", "@vehicle"},
                {"Toilet_Type", "@toilet_type"},
                {"Fuel_Type", "@fuel_type"},
                {"Poverty_Status", "@poverty_status"},
                {"Residence_Type", "@residence_type"},
                {"Water_Supply", "@water_supply"},
                {"Electricity_Type", "@electricity_supply"},

                {"Village", "@Address"},
                {"Taluka", "@taluka"},
                {"District", "@District"},
                {"State", "@State"},
                {"Country", "@Country"},
                {"PinCode", "@ZipCode"}
            };

            Dictionary<string, object> CBAC_detailsMap = new Dictionary<string, object>
            {
                  {"Visit_Date","@"},
                  {"Age","@"},
                  {"Gutka","@"},
                  {"History","@"},
                  {"Exercise","@"},
                  {"Waist","@"},
                  {"Alcohol","@"},
                  {"Total_Score","@"},
                  {"Veginal_foul_smelling","@"},
                  {"Intercourse_Bleeding","@"},
                  {"Periods_bleeding","@"},
                  {"Nipple_Blood","@"},
                  {"Voice_Changed","@"},
                  {"Ulcer","@"},
                  {"Menopause_bleeding","@"},
                  {"Breast_Size_Changed","@"},
                  {"Mouth_Opening","@"},
                  {"Fits","@"},
                  {"Coughing_2weeks","@"},
                  {"Blood_In_Sputum","@"},
                  {"Breath_shortness","@"}
            };

        Dictionary<string, object> Vaccination_Data = new Dictionary<string, object>
        {

        };
                Dictionary<string, object> temp_tbMap = new Dictionary<string, object>
            {
                //values for table familyinfo
                {"txtid", "@id"}
                
            };
                

        private readonly DatabaseClass db;
        private Dictionary<string, object> selectedDictionary = null;

        public DataManipulation()
        {
            
            db = new DatabaseClass();
        }
  
        private void SelectDictionary(string table)
        {
            if (table == "asha_profile")
                selectedDictionary = Asha_DetailsMap;
            if (table == "member_details")
                selectedDictionary = MemberInfoMap;
            if (table == "family_details")
                selectedDictionary = FamilyInfoMap;
            if(table == "CBAC_details")
                selectedDictionary = CBAC_detailsMap; 

        }

        //public bool InsertData( string tablename,Form parentform)
        //{
        //    //method to select data dictionary to insert
        //    SelectDictionary(tablename);

        //    foreach (Control control in parentform.Controls[])
        //    {
        //        // Check if the control is a TextBox, DateTimePicker or ComboBox
        //        if (control is TextBox || control is DateTimePicker || control is ComboBox) 
        //        {
        //            // Get the parameter name from the dictionary
        //            object parameterName;
        //            if (!selectedDictionary.TryGetValue(control.Name, out parameterName))
        //            {
        //                // If the control name is not in the dictionary, skip this control
        //                continue;
        //            }

        //            // Add the parameter to the command
        //            // Add the parameter to the command
        //            if (control is TextBox)
        //            {
        //                selectedDictionary[control.Name] = Convert.ToInt32(control.Text);
        //            }
        //            else if (control is DateTimePicker)
        //            {
        //                selectedDictionary[control.Name] = ((DateTimePicker)control).Value;
        //            }
        //            else if (control is ComboBox)
        //            {
        //                selectedDictionary[control.Name] = ((ComboBox)control).SelectedItem;
        //            }
        //            else if (control is RadioButton)
        //            {
        //                if(((RadioButton)control).Checked == true)
        //                selectedDictionary[control.Name]= ((RadioButton)control).Text;
        //            }
        //            else if (control is CheckBox)
        //            {
        //                if(((CheckBox)control).Checked == true)
        //                    selectedDictionary[control.Name]=((CheckBox)control).Text;
        //            }
        //        }
        //    }
        //}

        private void IterateControls(Control parentControl)
        {
            foreach (Control control in parentControl.Controls)
            {
                if (control is PanelControl)
                {
                    continue;
                }
                if(control is Panel)
                {
                    foreach(Control child in control.Controls)
                    {
                        if(child is RadioButton)
                        {
                            if(((RadioButton)child).Checked)
                            selectedDictionary[control.Name] = ((RadioButton)child).Text;
                        }
                    }
                }
                 
                // Check if the control is a TextBox, DateTimePicker or ComboBox
                if (control is TextBox || control is KryptonTextBox|| control is DateTimePicker || control is ComboBox || control is RadioButton || control is CheckBox || control is Label)
                {
                    // Get the parameter name from the dictionary
                    object parameterName;
                    if (!selectedDictionary.TryGetValue(control.Name, out parameterName))
                    {
                        // If the control name is not in the dictionary, skip this control
                        continue;
                    }

                    // Add the parameter to the command
                    
                    if (control is TextBox || control is KryptonTextBox)
                    {
                        if(control.Name.Contains("Id"))
                            selectedDictionary[control.Name] = Convert.ToInt32(control.Text);
                        else
                        selectedDictionary[control.Name] = control.Text;
                    }
                    else if(control is Label)
                    {
                        selectedDictionary[control.Name]= control.Text;
                    }
                    else if (control is DateTimePicker)
                    {
                        DateTime dt = ((DateTimePicker)control).Value.Date;
                        selectedDictionary[control.Name] =dt.ToString("dd-MM-yyyy");
                    }
                    else if (control is ComboBox)
                    {
                        if (((ComboBox)control).SelectedIndex == 0)
                        {
                            selectedDictionary[control.Name] = "None";
                        }
                        selectedDictionary[control.Name] = ((ComboBox)control).SelectedItem;
                    }
                    else if (control is RadioButton)
                    {
                        if (((RadioButton)control).Checked)
                            selectedDictionary[control.Name] = ((RadioButton)control).Text;
                    }
                    else if (control is CheckBox)
                    {
                        if (((CheckBox)control).Checked)
                            selectedDictionary[control.Name] = ((CheckBox)control).Text;
                    }
                    else
                    {
                        selectedDictionary[control.Name] = "";
                    }
                }

                // Recursively iterate over child controls
                if (control.HasChildren)
                {
                    IterateControls(control);
                }
            }
        }
        public bool InsertData(string tablename, Form parentform)
        {
            //method to select data dictionary to insert
            SelectDictionary(tablename);

            // Iterate over all controls in the form hierarchy
            IterateControls(parentform);

            // Execute the command
            return db.InsertRow(tablename, selectedDictionary);
        }

       
    }
}
