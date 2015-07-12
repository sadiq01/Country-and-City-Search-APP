using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CountryCityWebApp.DAL.DAO;
using CountryCityWebApp.DAL.Gateway;

namespace CountryCityWebApp.BLL
{
    public class CountryManager
    {
        CountryGateway aCountryGateway = new CountryGateway();
        public string Save(Country aCountry)
        {
                if (aCountryGateway.Save(aCountry) > 0)
                {
                    return "Data saved Successfully.";
                }
                else
                {
                    return "Data not saved.";
                }
            
        }

        public bool isCountryExist(string countryName)
        {
            return aCountryGateway.IScountryExist(countryName);
        }

        public List<Country> LoadAllCountry()
        {
            return aCountryGateway.LoadAllCountry();
        }

        public int GetCountryId(string countryName)
        {
            return aCountryGateway.GetCountryID(countryName);
        }

        public List<Country> ViewCountryList()
        {
            return aCountryGateway.ViewCountryList();
        }
        public List<Country> ViewCountryListSearch(string name)
        {
            return aCountryGateway.ViewCountryListSearch(name);
        }

        
        
    }
}