using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CountryCityWebApp.DAL.DAO;
using CountryCityWebApp.DAL.Gateway;

namespace CountryCityWebApp.BLL
{
    public class CityManager
    {
        Citygateway aCitygateway = new Citygateway();

        public string Save(City aCity)
        {
            if (aCitygateway.Save(aCity) > 0)
            {
                return "Data saved Successfully.";
            }
            else
            {
                return "Data not saved.";

            }
        }

        public List<City> CityCountryList()
        {
            return aCitygateway.CityCountryList();
        }

        public List<City> ViewCityList()
        {
            return aCitygateway.ViewCityList();
        }

        public List<City> CityRadioList(string message)
        {
            return aCitygateway.CityRadioList(message);
        }
        public List<City> CountryRadioList(string message)
        {
            return aCitygateway.CountryRadioList(message);
        }
    }
}