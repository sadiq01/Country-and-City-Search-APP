using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Caching;
using CountryCityWebApp.DAL.DAO;

namespace CountryCityWebApp.DAL.Gateway
{
    public class Citygateway
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["CountryConnectionStrings"].ConnectionString;
        public int Save(City aCity)
        {
            //1. Connect to database
            SqlConnection connection = new SqlConnection(connectionString);
            //2. Write query
            string query = "insert into tbl_City values('"+aCity.Name+"','"+aCity.About+"','"+aCity.DwelerNo+"','"+aCity.Location+"','"+aCity.Weather+"','"+aCity.countryId+"')";
            //3. Execute query
            SqlCommand command = new SqlCommand(query,connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

        public List<City> CityCountryList()
        {

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select tbl_City.CityName, tbl_City.DwellerNumber, tbl_Country.Name from tbl_City INNER JOIN tbl_Country ON tbl_Country.ID = tbl_City.CountryID ORDER BY tbl_City.CityName";
            SqlCommand command = new SqlCommand(query,connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<City>cityCountryList = new List<City>();
            string message = "";
            /*
            while (reader.Read())
            {
                //City aCity = new City();
                //Country aCountry = new Country();
                string Name = reader["CityName"].ToString();
                int DwelerNo = int.Parse(reader["DwelerNumber"].ToString());
                string CountryName = reader["Name"].ToString();
                message = Name + "        " + DwelerNo + "        " + CountryName + "\n";
                //cityCountryList.Add(Name);
                //cityCountryList.Add(DwelerNo.ToString());
                //cityCountryList.Add(CountryName);
                cityCountryList.Add(message);
            }*/
            int serial = 1;
            while (reader.Read())
            {
                City aCity = new City();
                aCity.Serial = serial;
                aCity.Name = reader["CityName"].ToString();
                aCity.DwelerNo = int.Parse(reader["DwellerNumber"].ToString());
                aCity.CountryName = reader["Name"].ToString();
                cityCountryList.Add(aCity);
                serial++;
            }
            reader.Close();
            connection.Close();

            return cityCountryList;
        }
        public List<City> ViewCityList()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select tbl_City.CityName, tbl_City.CityAbout, tbl_City.DwellerNumber, tbl_City.Location, tbl_City.Weather, tbl_Country.Name, tbl_Country.About from tbl_City INNER JOIN tbl_Country ON tbl_Country.ID = tbl_City.CountryID ORDER BY tbl_City.CityName";
            SqlCommand command = new SqlCommand(query,connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<City> viewCityList = new List<City>();
            int serial = 1;
            while (reader.Read())
            {
                City aCity = new City();
                aCity.Serial = serial;
                aCity.Name = reader["CityName"].ToString();
                aCity.About = reader["CityAbout"].ToString();
                aCity.DwelerNo = int.Parse(reader["DwellerNumber"].ToString());
                aCity.Location = reader["Location"].ToString();
                aCity.Weather = reader["Weather"].ToString();
                aCity.CountryName = reader["Name"].ToString();
                aCity.CountryAbout = reader["About"].ToString();
                viewCityList.Add(aCity);
                serial++;
            }
            reader.Close();
            connection.Close();
            return viewCityList;
        }

        public List<City> CountryRadioList(string message)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select tbl_City.CityName, tbl_City.CityAbout, tbl_City.DwellerNumber, tbl_City.Location, tbl_City.Weather, tbl_Country.Name, tbl_Country.About from tbl_City INNER JOIN tbl_Country ON tbl_Country.ID = tbl_City.CountryID where tbl_Country.Name like'%"+message+"%' ORDER BY tbl_City.CityName";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<City> viewCityList = new List<City>();
            int serial = 1;
            while (reader.Read())
            {
                City aCity = new City();
                aCity.Serial = serial;
                aCity.Name = reader["CityName"].ToString();
                aCity.About = reader["CityAbout"].ToString();
                aCity.DwelerNo = int.Parse(reader["DwellerNumber"].ToString());
                aCity.Location = reader["Location"].ToString();
                aCity.Weather = reader["Weather"].ToString();
                aCity.CountryName = reader["Name"].ToString();
                aCity.CountryAbout = reader["About"].ToString();
                viewCityList.Add(aCity);
                serial++;
            }
            reader.Close();
            connection.Close();
            return viewCityList;
        }
        public List<City> CityRadioList(string message)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select tbl_City.CityName, tbl_City.CityAbout, tbl_City.DwellerNumber, tbl_City.Location, tbl_City.Weather, tbl_Country.Name, tbl_Country.About from tbl_City INNER JOIN tbl_Country ON tbl_Country.ID = tbl_City.CountryID where tbl_City.CityName like'%" + message + "%' ORDER BY tbl_City.CityName";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<City> viewCityList = new List<City>();
            int serial = 1;
            while (reader.Read())
            {
                City aCity = new City();
                aCity.Serial = serial;
                aCity.Name = reader["CityName"].ToString();
                aCity.About = reader["CityAbout"].ToString();
                aCity.DwelerNo = int.Parse(reader["DwellerNumber"].ToString());
                aCity.Location = reader["Location"].ToString();
                aCity.Weather = reader["Weather"].ToString();
                aCity.CountryName = reader["Name"].ToString();
                aCity.CountryAbout = reader["About"].ToString();
                viewCityList.Add(aCity);
                serial++;
            }
            reader.Close();
            connection.Close();
            return viewCityList;
        }
    }
}