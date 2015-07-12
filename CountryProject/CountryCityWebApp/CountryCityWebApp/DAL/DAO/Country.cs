using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace CountryCityWebApp.DAL.DAO
{
    public class Country
    {
        public int Serial { get; set; }
        public int Id { get; set; }
        public string CountryName { get; set; }
        public string CountryAbout { get; set; }
        public int City_Number { get; set; }
        public int Dweller_Number { get; set; }

    }
}