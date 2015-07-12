using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CountryCityWebApp.DAL.DAO;

namespace CountryCityWebApp.DAL.Gateway
{
    public class CountryGateway
    {
        private bool isCountryExistresult = false;
        Citygateway aCitygateway = new Citygateway();
       
        private string connectionString = ConfigurationManager.ConnectionStrings["CountryConnectionStrings"].ConnectionString;

        public int Save(Country aCountry)
        {
            //1. Connection establish
            SqlConnection connection = new SqlConnection(connectionString);
            //2. Write query.
            string query = "insert into tbl_Country values ('"+aCountry.CountryName+"','"+aCountry.CountryAbout+"')";
            //3. Execute query
            SqlCommand command = new SqlCommand(query,connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

        public List<Country> LoadAllCountry()
        {
            //1. Connection making
            SqlConnection connection = new SqlConnection(connectionString);
            //2. Write query
            string query = "select * from tbl_Country";
            //3. Execute query
            SqlCommand command = new SqlCommand(query,connection);
            connection.Open();

            //4. Show result
            SqlDataReader reader = command.ExecuteReader();
            List<Country> countryList = new List<Country>();
            int serial = 1;
            while (reader.Read())
            {
                Country aCountry = new Country();
                aCountry.Serial = serial;
                aCountry.Id = int.Parse(reader["Id"].ToString());
                aCountry.CountryName = reader["Name"].ToString();
                aCountry.CountryAbout = reader["About"].ToString();
                countryList.Add(aCountry);
                serial++;
            }
            reader.Close();
            connection.Close();
            return countryList;
        }

        public int GetCountryID(string countryName)
        {
            int id = 0;
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select * from tbl_Country where Name = '" + countryName + "'";
            SqlCommand command = new SqlCommand(query,connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                 id = int.Parse(reader["ID"].ToString());
            }
            reader.Close();
            connection.Close();
            return id;
        }

        public List<Country> ViewCountryList()
        {
            //1. Connection making
            SqlConnection connection = new SqlConnection(connectionString);
            //2. Write query
            string query = "select * from tbl_Country";
            //3. Execute query
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            //4. Show result
            SqlDataReader reader = command.ExecuteReader();
            List<Country> countryList = new List<Country>();
            int serial = 1;
            while (reader.Read())
            {
                Country aCountry = new Country();
                aCountry.Serial = serial;
                aCountry.Id = int.Parse(reader["Id"].ToString());
                aCountry.CountryName = reader["Name"].ToString();
                aCountry.CountryAbout = reader["About"].ToString();
                aCountry.City_Number = GetCityNumber(aCountry.Id);
                aCountry.Dweller_Number = GetDwellerNumber(aCountry.Id);
                countryList.Add(aCountry);
                serial++;
            }
            reader.Close();
            connection.Close();
            return countryList;
        }

        public List<Country> ViewCountryListSearch(string countryName)
        {
            //1. Connection making
            SqlConnection connection = new SqlConnection(connectionString);
            //2. Write query
            string query = "select * from tbl_Country where Name like '%"+countryName+"%'";
            //3. Execute query
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            //4. Show result
            SqlDataReader reader = command.ExecuteReader();
            List<Country> countryList = new List<Country>();
            int serial = 1;
            while (reader.Read())
            {
                Country aCountry = new Country();
                aCountry.Serial = serial;
                aCountry.Id = int.Parse(reader["Id"].ToString());
                aCountry.CountryName = reader["Name"].ToString();
                aCountry.CountryAbout = reader["About"].ToString();
                aCountry.City_Number = GetCityNumber(aCountry.Id);
                aCountry.Dweller_Number = GetDwellerNumber(aCountry.Id);
                countryList.Add(aCountry);
                serial++;
            }
            reader.Close();
            connection.Close();
            return countryList;
        }

        public int GetCityNumber(int Id)
        {
            int cityNumber = 0;
            int dwellerNumber = 0;

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select * from tbl_City where CountryID = '" + Id + "'";
            SqlCommand command = new SqlCommand(query,connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                dwellerNumber += int.Parse(reader["DwellerNumber"].ToString());
                cityNumber++;
            }
            reader.Close();
            connection.Close();
            return cityNumber;
        }

        public int GetDwellerNumber(int Id)
        {
            
            int dwellerNumber = 0;

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select * from tbl_City where CountryID = '" + Id + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                dwellerNumber += int.Parse(reader["DwellerNumber"].ToString());
                
            }
            reader.Close();
            connection.Close();
            return dwellerNumber;
        }

        public bool IScountryExist(string countryName)
        {
            bool isCountryExist = false;

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select * from tbl_Country where Name = '" + countryName + "'";
            SqlCommand command = new SqlCommand(query,connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                isCountryExist = true;
            }
            reader.Close();
            connection.Close();
            return isCountryExist;
        }
               
    }

}