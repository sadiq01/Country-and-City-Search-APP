using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryCityWebApp.DAL.DAO
{
    public class City
    {
        public int Serial { get; set; }
        //public int Id { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public int DwelerNo { get; set; }
        public string Location { get; set; }
        public string Weather { get; set; }
        public int countryId;
        public string CountryName { get; set; }
        public string CountryAbout { get; set; }

    }
}