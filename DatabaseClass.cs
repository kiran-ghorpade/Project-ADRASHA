﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace ADRASHA_Main
{
    internal class DatabaseClass
    {
        private static string dbFilePath ="ADRASHA_DB.sqlite"; // file path for Database

        public DatabaseClass() 
        {
            SetupDatabase();
        }

        public void SetupDatabase()
        {
                //create database schema if db file not exist
                if (!File.Exists(dbFilePath))
                {
                    CreateDatabaseSchema();
                }
        }

        public static SqliteConnection GetConnection()
        {
            // Open the connection 
            SqliteConnection connection = new SqliteConnection($"Data Source={dbFilePath}");
           
            connection.Open();
            return connection;
        }

        public static DataTable GetDataTable(string query)
        {
            //return the datatable on basis of query
            DataTable dataTable = new DataTable();

            using (SqliteConnection connection = GetConnection())
            {
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    using (SqliteDataReader dr = command.ExecuteReader())
                    {
                        dataTable.Load(dr);
                    }
                }
            }
            return dataTable;
        }

        public static int GetAutoID(string sql)
        {
            //method to get next id from table
            int i = 1;
            try
            {
                DataTable dt = GetDataTable(sql);
                if (dt.Rows.Count >= 1)
                {
                    i = (int.Parse(dt.Rows[0][0].ToString()) + 1);
                }
                else
                    i = 1;
            }
            catch (Exception)
            {
                return 1;
            }
            return i;
        }

        public static DataRow GetRowById(string tableName,string id_column, int id)
        {
            //to get row by the id
            string query = $"SELECT * FROM {tableName} WHERE {id_column} = {id}";
            using (SqliteConnection conn = GetConnection())
            {
                SqliteCommand cmd = new SqliteCommand(query, conn);
               // cmd.Parameters.AddWithValue("@id", id);
                DataTable dt = new DataTable();
                SqliteDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                return dt.Rows.Count > 0 ? dt.Rows[0] : null;
            }
        }
        
        public bool RowExists(string tableName,string id_column, int id)
        {
            //to check whether row exist in the table or not by the id
            DataTable dt = GetRowById(tableName,id_column, id).Table;
            if (dt.Rows.Count >= 1) { return true; }
            else { return false; }
        }

        public static int ExecuteNonQuery(string query)
        {
            //just execute the sql query
            using (SqliteConnection connection = GetConnection())
            {
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    return command.ExecuteNonQuery();
                }
            }
        }

        public static void BindGridView(DataGridView dataGridView, string query)
        {
            //to bind gridview to database table
            dataGridView.DataSource = GetDataTable(query);
        }

        public static void FillComboBox(ComboBox comboBox, string query, string displayMember, string valueMember)
        {
            //fill combo box
            DataTable dataTable = GetDataTable(query);

            comboBox.DataSource = dataTable;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
        }

        public static bool UpdateRow(string tableName,string column, int id, string updatecolumn, object value)
        {

            ///update an row 
            string query = $"UPDATE {tableName} SET ";

            query += $"{updatecolumn} = '{value}',";
            
            query = query.TrimEnd(',') + $" WHERE {column} = {id}";

            using (SqliteConnection conn = GetConnection())
            {
                SqliteCommand cmd = new SqliteCommand(query, conn);

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }

        public bool InsertRow(string tableName, Dictionary<string, object> data)
        {
            //insert a row in database table
            //i used it many times in this project. thanks to this function
            try
            {
                string query = $"Insert Into {tableName} ( ";
                foreach (KeyValuePair<string, object> item in data)
                {
                    query += $"{item.Key},";
                }
                query = query.TrimEnd(',') + $") Values(";
                foreach (KeyValuePair<string, object> item in data)
                {
                    if (item.Value.GetType() == typeof(int))
                        query += $"{item.Value},";
                    else
                        query += $"'{item.Value}',";
                }
                query = query.TrimEnd(',') + $")";
                using (SqliteConnection conn = GetConnection())
                {
                    SqliteCommand cmd = new SqliteCommand(query, conn);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        private static void CreateDatabaseSchema()
        {
            // create schema from script
            //for future update in database , add updated script in below string -by kiran
            string createTableQuery = @"
                            --
                            -- File generated with SQLiteStudio v3.4.3 on Mon Apr 10 13:11:50 2023
                            --
                            -- Text encoding used: System
                            --
                            PRAGMA foreign_keys = off;
                            BEGIN TRANSACTION;
                            
                            -- Table: asha_details
                            CREATE TABLE IF NOT EXISTS asha_details (
                                Asha_Id          INTEGER PRIMARY KEY,
                                First_Name       TEXT    NOT NULL,
                                Middle_Name      TEXT    NOT NULL,
                                Last_Name        TEXT    NOT NULL,
                                Birth_Date       DATE,
                                Mobile_NO        TEXT,
                                Marital_Status   TEXT,
                                Qualifications   TEXT,
                                Center           TEXT    NOT NULL,
                                Sub_Center       TEXT    NOT NULL,
                                Village          TEXT    NOT NULL,
                                PinCode          TEXT    NOT NULL,
                                Taluka           TEXT    NOT NULL,
                                District         TEXT    NOT NULL,
                                State            TEXT    NOT NULL,
                                Total_Families   INTEGER NOT NULL,
                                Total_Population INTEGER NOT NULL,
                                Village_Type     TEXT,
                                Password         TEXT
                            );
                            
                            
                            -- Table: CBAC_details
                            CREATE TABLE IF NOT EXISTS CBAC_details (
                                CBAC_ID               INTEGER PRIMARY KEY AUTOINCREMENT,
                                Member_id             INTEGER REFERENCES member_details (Member_Id),
                                visit_date            DATE,
                                Age                   TEXT,
                                Gutka                 TEXT,
                                history               TEXT,
                                Exercise              TEXT,
                                waist                 TEXT,
                                alcohol               TEXT,
                                total_score           TEXT,
                                Veginal_foul_smelling TEXT,
                                Intercourse_Bleeding  TEXT,
                                Periods_bleeding      TEXT,
                                Nipple_Blood          TEXT,
                                Voice_Changed         TEXT,
                                Ulcer                 TEXT,
                                Menopause_bleeding    TEXT,
                                Breast_Size_Changed   TEXT,
                                Mouth_Opening         TEXT,
                                Fits                  TEXT,
                                Coughing_2weeks       TEXT,
                                Blood_In_Sputum       TEXT,
                                Breath_shortness      TEXT
                            );
                            
                            
                            -- Table: family_details
                            CREATE TABLE IF NOT EXISTS family_details (
                                Family_Id        INTEGER PRIMARY KEY,
                                Family_Head      INTEGER REFERENCES member_details (Member_Id),
                                Total_Members    INTEGER,
                                House_Type       TEXT,
                                Vehicle          TEXT,
                                Toilet_Type      TEXT,
                                Fuel_Type        TEXT,
                                Poverty_Status   TEXT,
                                Residence_Type   TEXT,
                                Water_Supply     TEXT,
                                Electricity_Type TEXT,
                                Village          TEXT,
                                PinCode          TEXT,
                                Taluka           TEXT,
                                District         TEXT,
                                State            TEXT,
                                Country          TEXT
                            );
                            
                            
                            -- Table: HBNC_Visits
                            CREATE TABLE IF NOT EXISTS HBNC_Visits (
                                HBNC_VISIT_ID       INTEGER PRIMARY KEY AUTOINCREMENT,
                                HBNC_VISIT_DATE     DATE,
                                MEMBER_ID           INTEGER REFERENCES member_details (Member_Id),
                                HBNC_VISIT_NO       INTEGER,
                                Meal                TEXT,
                                kept_warm           TEXT,
                                baby_feed_proparly  TIME,
                                baby_crying         TEXT,
                                TEMPERATURE         REAL,
                                foul_smelling       TEXT,
                                Speaking_abnormally TEXT,
                                No_milk             TEXT,
                                Cracked_Nipples     TEXT,
                                eye_swollen         TEXT,
                                Weight              TEXT,
                                baby_temperature    TEXT,
                                Skin                TEXT,
                                Crack_Redness       TEXT,
                                Yellowness          TEXT
                            );
                            
                            
                            -- Table: health_profile
                            CREATE TABLE IF NOT EXISTS health_profile (
                                health_profile_id  INTEGER   PRIMARY KEY,
                                member_id          INTEGER   NOT NULL,
                                height             REAL,
                                weight             REAL,
                                blood_group        TEXT,
                                medical_conditions TEXT,
                                created_at         TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                                updated_at         TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                                FOREIGN KEY (
                                    member_id
                                )
                                REFERENCES member (member_id) 
                            );
                            
                            
                            -- Table: HomeDelivery_Visit
                            CREATE TABLE IF NOT EXISTS HomeDelivery_Visit (
                                HomeDelivery_Visit_ID INTEGER PRIMARY KEY AUTOINCREMENT,
                                VISIT_DATE            DATE,
                                MEMBER_ID             INTEGER REFERENCES member_details (Member_Id),
                                BIRTH_DATE            DATE,
                                PRETERM_Status        DATE,
                                BIRTH_TIME            DATE,
                                PROBLEM               TEXT,
                                FIRST_FEED            TEXT,
                                BREAST_FEED_TIME      TIME,
                                HOW_FEED              TEXT,
                                TEMPERATURE           REAL,
                                EYES_STATUS           TEXT,
                                UMBILICAL_CORD        TEXT,
                                BABY_WEIGHT           TEXT,
                                Feeding_Status        TEXT,
                                Cry_Status            TEXT,
                                Limbs_Status          TEXT
                            );
                            
                            
                            -- Table: member_details
                            CREATE TABLE IF NOT EXISTS member_details (
                                Member_Id       INTEGER PRIMARY KEY AUTOINCREMENT,
                                Family_Id       INTEGER REFERENCES family_details (Family_Id),
                                First_Name      TEXT    NOT NULL,
                                Middle_Name     TEXT    NOT NULL,
                                Last_Name       TEXT    NOT NULL,
                                Birth_Date      DATE,
                                Birth_Place     TEXT,
                                Gender          TEXT,
                                Adhar_Number    TEXT    UNIQUE,
                                ABHA_Number     TEXT    UNIQUE,
                                Mobile_Number   TEXT,
                                Email           TEXT,
                                Occupation_Name TEXT,
                                Work_Place      TEXT,
                                Work_Type       TEXT,
                                Education       TEXT,
                                Marital_Status  TEXT,
                                Marriage_Date   DATE,
                                Partner_Id      INTEGER,
                                Child_Number    INTEGER,
                                Age             INTEGER,
                                Alive_Status    TEXT    DEFAULT ('Alive') 
                            );
                            
                            
                            -- Table: ncd_details
                            CREATE TABLE IF NOT EXISTS ncd_details (
                                NCD_Id            INTEGER   PRIMARY KEY,
                                MemberId          INTEGER   NOT NULL
                                                            REFERENCES member_details (Member_Id),
                                NCD_Name          TEXT      NOT NULL,
                                Diagnosis_Date    DATE,
                                Screening_Date    DATE,
                                Treatement_Status TEXT,
                                created_at        TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                                updated_at        TIMESTAMP DEFAULT CURRENT_TIMESTAMP
                            );
                            
                            
                            -- Table: pregnancy
                            CREATE TABLE IF NOT EXISTS pregnancy (
                                Pregnancy_Id         INTEGER PRIMARY KEY,
                                Mother_Id            INTEGER REFERENCES member_details (Member_Id),
                                Father_ID            INTEGER REFERENCES member_details (Member_Id),
                                Last_Period          DATE,
                                Expected_Date        DATE,
                                Previous_Pregnancies INTEGER
                            );
                            
                            
                            -- Table: Pregnancy_Visits
                            CREATE TABLE IF NOT EXISTS Pregnancy_Visits (
                                Pregnancy_Visit_id     INTEGER PRIMARY KEY AUTOINCREMENT,
                                Mother_Id              INTEGER REFERENCES member_details (Member_Id),
                                Visit_Date             DATE,
                                Month_of_Pregnancy     INTEGER,
                                Blood_Pressure         REAL,
                                Weight                 REAL,
                                TT_Injection_Status    TEXT,
                                Iron_Tablets_Status    TEXT,
                                Iron_Tablet_Given_Date DATE
                            );
                            
                            
                            -- Table: vaccination
                            CREATE TABLE IF NOT EXISTS vaccination (
                                Vaccination_Id    INTEGER PRIMARY KEY AUTOINCREMENT,
                                Member_Id         INTEGER NOT NULL
                                                          REFERENCES member_details (Member_Id),
                                Vaccine_Name      TEXT    NOT NULL,
                                Given_On          DATE,
                                Given_At          TEXT,
                                next_Vaccine_DATE DATE,
                                next_Vaccine_name TEXT
                            );
                            
                            
                            -- View: All_Data
                            CREATE VIEW IF NOT EXISTS All_Data AS
                                SELECT/* family_details.Family_Id as 'Family Id',
                            member_details.First_Name || ' ' || member_details.Middle_Name || ' ' || member_details.Last_Name as 'Family Head Name',
                            family_details.Total_Members as 'Totol Members',
                            family_details.House_Type as 'House Type',
                            family_details.Toilet_Type as 'Toilet Type',
                            family_details.Fuel_Type as 'Fuel Type',
                            family_details.Poverty_Status as 'Poverty Status',
                            family_details.Residence_Type as 'Residence Type',
                            family_details.Water_Supply as 'Water Supply',
                            family_details.Village ||','|| family_details.Taluka||','|| family_details.District || ','|| family_details.State as 'Address', */ member_details.Member_Id AS [Member Id],
                                       member_details.First_Name || ' ' || member_details.Middle_Name || ' ' || member_details.Last_Name AS [Member Name],
                                       member_details.Birth_Date AS [Birth Date],
                                       member_details.Birth_Place AS [Birth Place],
                                       member_details.Gender AS Gender,
                                       member_details.Adhar_Number AS [Adhar Number],
                                       member_details.ABHA_Number AS [ABHA Number],
                                       member_details.Mobile_Number AS [Mobile Number],
                                       member_details.Work_Type AS [Work Type],
                                       member_details.Education AS Education,
                                       member_details.Marital_Status AS [Marital Status],
                                       member_details.Alive_Status AS [Alive Status]-- ncd_details.NCD_Id as 'NCD Id',
                                  /* ncd_details.NCD_Name as 'NCD Name', */FROM member_details;
                            -- ncd_details.Diagnosis_Date as 'Diagnosis Date',-- vaccination.Vaccination_Id as 'Vaccination Id',-- vaccination.Vaccine_Name as 'Vaccine Name',-- vaccination.Given_On as 'Given Date',-- vaccination.Given_At as 'Given At'-- family_details join-- join vaccination join ncd_details-- where-- member_details.Member_Id=vaccination.Member_Id=ncd_details.MemberId
                            
                            -- View: Child_list
                            CREATE VIEW IF NOT EXISTS Child_list AS
                                SELECT member_id AS personal_id,
                                       family_id,
                                       first_name || ' ' || middle_name || ' ' || last_name AS child_name,
                                       gender,
                                       age,
                                       birth_date
                                  FROM member_details
                                 WHERE age <= 5;
                            
                            
                            -- View: Family_Head_list
                            CREATE VIEW IF NOT EXISTS Family_Head_list AS
                                SELECT family_details.Family_Id,
                                       family_details.Family_Head AS personal_Id,
                                       family_details.Total_Members,
                                       member_details.First_Name || ' ' || member_details.Middle_Name || ' ' || member_details.Last_Name AS Head_Name,
                                       member_details.Age,
                                       member_details.Gender,
                                       member_details.Mobile_Number
                                  FROM family_details
                                       JOIN
                                       member_details
                                 WHERE member_details.Member_Id = family_details.Family_Head;
                            
                            
                            -- View: Header_view
                            CREATE VIEW IF NOT EXISTS Header_view AS
                                SELECT first_name || ' ' || middle_name || ' ' || last_name AS asha_name,
                                       village,
                                       sub_center
                                  FROM asha_details;
                            
                            
                            -- View: Member_list
                            CREATE VIEW IF NOT EXISTS Member_list AS
                                SELECT member_details.member_id AS personal_id,
                                       member_details.family_id,
                                       member_details.first_name || ' ' || member_details.middle_name || ' ' || member_details.last_name AS member_name,
                                       member_details.gender,
                                       member_details.age,
                                       member_details.Mobile_Number
                                  FROM member_details;
                            
                            
                            -- View: NCD_List
                            CREATE VIEW IF NOT EXISTS NCD_List AS
                                SELECT ncd_details.NCD_Id,
                                       ncd_details.NCD_Name,
                                       ncd_details.MemberId AS Personal_id,
                                       member_details.First_Name || ' ' || member_details.Middle_Name || ' ' || member_details.Last_Name AS Member_Name,
                                       member_details.Age,
                                       member_details.Gender
                                  FROM ncd_details
                                       JOIN
                                       member_details
                                 WHERE member_details.Member_Id = ncd_details.MemberId;
                            
                            
                            -- View: Pregnancy_list
                            CREATE VIEW IF NOT EXISTS Pregnancy_list AS
                                SELECT pregnancy.Pregnancy_Id,
                                       pregnancy.Mother_Id,
                                       pregnancy.Last_Period,
                                       pregnancy.Expected_Date,
                                       member_details.First_Name || ' ' || member_details.Middle_Name || ' ' || member_details.Last_Name AS Mother_Name,
                                       member_details.Age
                                  FROM pregnancy
                                       JOIN
                                       member_details
                                 WHERE member_details.Member_Id = pregnancy.Mother_Id;
                            
                            
                            -- View: Vaccination_List
                            CREATE VIEW IF NOT EXISTS Vaccination_List AS
                                SELECT vaccination.Vaccination_Id,
                                       vaccination.Given_On,
                                       vaccination.Vaccine_Name,
                                       vaccination.Given_At,
                                       vaccination.Member_Id AS child_id,
                                       member_details.First_Name || ' ' || member_details.Middle_Name || ' ' || member_details.Last_Name AS Child_Name
                                  FROM vaccination
                                       JOIN
                                       member_details
                                 WHERE member_details.Member_Id = vaccination.Member_Id;
                            
                            
                            COMMIT TRANSACTION;
                            PRAGMA foreign_keys = on;
                            
            ";         
            ExecuteNonQuery(createTableQuery);
        }
    }
}