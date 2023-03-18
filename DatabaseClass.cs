using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        //SqliteConnection conn = GetConnection();             
        //connecting to database and opening connection.
        //connection object
        private static string dbFilePath ="ADRASHA_DB.sqlite"; // file path for Database


        public DatabaseClass() 
        {
            SetupDatabase();
        }

        public void SetupDatabase()
        {
            using (SqliteConnection connection = GetConnection())
            {
                if (!File.Exists(dbFilePath))
                    CreateDatabaseSchema();
            }
        }

        public static SqliteConnection GetConnection()
        {
            // Open the connection 
            SqliteConnection connection = new SqliteConnection($"Data Source={dbFilePath}"); ;
            connection.Open();
            return connection;
        }

        public static DataTable GetDataTable(string query)
        {
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
            catch (Exception e)
            {
                throw e;
            }
            return i;
        }

        public SqliteDataReader GetDataReader(string sql)
        {
            using (SqliteConnection conn = GetConnection())
            {
                SqliteCommand cmd = new SqliteCommand(sql, conn);
                return cmd.ExecuteReader();
            }
        }

        public static DataRow GetRowById(string tableName, int id)
        {
            string query = $"SELECT * FROM {tableName} WHERE Id = @id";
            using (SqliteConnection conn = GetConnection())
            {
                SqliteCommand cmd = new SqliteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                DataTable dt = new DataTable();
                SqliteDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                return dt.Rows.Count > 0 ? dt.Rows[0] : null;
            }
        }
        
        public bool RowExists(string tableName, int id)
        {
            DataTable dt = GetRowById(tableName, id).Table;
            if (dt.Rows.Count >= 1) { return true; }
            else { return false; }
        }

        public static int ExecuteNonQuery(string query)
        {
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
            dataGridView.DataSource = GetDataTable(query);
        }

        public static void FillComboBox(ComboBox comboBox, string query, string displayMember, string valueMember)
        {
            DataTable dataTable = GetDataTable(query);

            comboBox.DataSource = dataTable;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
        }

        public bool UpdateRow(string tableName,string column, int id, Dictionary<string, object> data)
        {
            string query = $"UPDATE {tableName} SET ";
            foreach (KeyValuePair<string, object> item in data)
            {
                query += $"{item.Key} = '{item.Value}',";
            }
            query = query.TrimEnd(',') + $" WHERE @Id = @id";

            using (SqliteConnection conn = GetConnection())
            {
                SqliteCommand cmd = new SqliteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@Id", column);
                //foreach (KeyValuePair<string, object> item in data)
                //{
                //    cmd.Parameters.AddWithValue($"@{item.Key}", item.Value);
                //}

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }

        public bool InsertRow(string tableName, Dictionary<string, object> data)
        {
            string query = $"Insert Into {tableName} ( ";
            foreach (KeyValuePair<string,object> item in data)
            {
                query += $"{item.Key},";
            }
            query = query.TrimEnd(',') + $") Values(";
            foreach (KeyValuePair<string, object> item in data)
            {
                if (item.Value.GetType() == typeof(int))
                    query += $"@{item.Key},";
                else
                    query += $"'@{item.Key}',";
            }
            query = query.TrimEnd(',') + $")";
                using (SqliteConnection conn = GetConnection())
                {
                    SqliteCommand cmd = new SqliteCommand(query, conn);
                foreach (KeyValuePair<string, object> item in data)
                {
                    cmd.Parameters.AddWithValue($"@{item.Key}", item.Value);
                }

                int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
        }

        private static void CreateDatabaseSchema()
        {
            // Put your database creation script here
            string createTableQuery = @"
                           --
            -- File generated with SQLiteStudio v3.4.3 on Thu Mar 16 08:43:51 2023
            --
            -- Text encoding used: System
            --
            PRAGMA foreign_keys = off;
            BEGIN TRANSACTION;

            -- Table: asha_profile
            CREATE TABLE IF NOT EXISTS asha_profile (
                Aasha_Id         INTEGER   PRIMARY KEY,
                First_Name       TEXT      NOT NULL,
                Middle_Name      TEXT      NOT NULL,
                Last_Name        TEXT      NOT NULL,
                Birth_Date       DATE,
                Mobile_NO        TEXT,
                Marital_Status   TEXT,
                Qualifications   TEXT,
                Center           TEXT      NOT NULL,
                Sub_Center       TEXT      NOT NULL,
                Village          TEXT      NOT NULL,
                PinCode          TEXT      NOT NULL,
                Taluka           TEXT      NOT NULL,
                District         TEXT      NOT NULL,
                State            TEXT      NOT NULL,
                Total_Families   INTEGER   NOT NULL,
                Total_Population INTEGER   NOT NULL,
                Village_Type     TEXT,
                created_at       TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                updated_at       TIMESTAMP DEFAULT CURRENT_TIMESTAMP
            );

            -- Table: family_details
            CREATE TABLE IF NOT EXISTS family_details (
                Family_Id        INTEGER   PRIMARY KEY,
                Family_Head      INTEGER   REFERENCES member_details (Member_Id),
                Total_Members    INTEGER,
                House_Type       TEXT,
                Vehicle          TEXT,
                Toilet_Type      TEXT,
                Fuel_Type        TEXT,
                Poverty_Status   TEXT,
                Residence_Type   TEXT,
                Water_Supply     TEXT,
                Electricity_Type TEXT,
                created_at       TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                updated_at       TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                Village          TEXT,
                PinCode          TEXT,
                Taluka           TEXT,
                District         TEXT,
                State            TEXT,
                Country          TEXT
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
                Partner_Id      INTEGER REFERENCES member_details (Member_Id),
                Child_Number    INTEGER
            );

            -- Table: ncd_details
            CREATE TABLE IF NOT EXISTS ncd_details (
                NCD_Id       INTEGER   PRIMARY KEY,
                Member_Id    INTEGER   NOT NULL,
                NCD_Type     TEXT      NOT NULL
                                       REFERENCES ncd_types (NCD_Type_Id),
                Diagnosed_On DATE,
                Medication   TEXT,
                created_at   TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                updated_at   TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                FOREIGN KEY (
                    Member_Id
                )
                REFERENCES member (member_id) 
            );


            -- Table: ncd_types
            CREATE TABLE IF NOT EXISTS ncd_types (
                NCD_Type_Id   INTEGER PRIMARY KEY,
                Disease_Name  TEXT,
                NCD_Type_Name TEXT
            );


            -- Table: pregnancy
            CREATE TABLE IF NOT EXISTS pregnancy (
                Pregnancy_Id           INTEGER   PRIMARY KEY,
                Member_Id              INTEGER   NOT NULL,
                Expected_Delivery_Date DATE,
                created_at             TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                updated_at             TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                FOREIGN KEY (
                    Member_Id
                )
                REFERENCES member (member_id) 
            );


            -- Table: vaccination
            CREATE TABLE IF NOT EXISTS vaccination (
                Vaccination_Id INTEGER   PRIMARY KEY,
                Member_Id      INTEGER   NOT NULL,
                Vaccine_Id     TEXT      NOT NULL
                                         REFERENCES Vaccines (Vaccine_Id),
                Given_On       DATE,
                Next_Due_Date  DATE,
                Given_By       TEXT,
                Given_At       TEXT,
                created_at     TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                updated_at     TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                FOREIGN KEY (
                    Member_Id
                )
                REFERENCES member (member_id) 
            );


            -- Table: Vaccines
            CREATE TABLE IF NOT EXISTS Vaccines (
                Vaccine_Id   INTEGER PRIMARY KEY AUTOINCREMENT,
                Vaccine_Name TEXT,
                Description  TEXT
            );


            COMMIT TRANSACTION;
            PRAGMA foreign_keys = on;



            ";

            
            ExecuteNonQuery(createTableQuery);
        }

    }
}