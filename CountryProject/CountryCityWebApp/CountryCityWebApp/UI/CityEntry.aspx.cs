using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CountryCityWebApp.BLL;
using CountryCityWebApp.DAL.DAO;

namespace CountryCityWebApp.UI
{
    public partial class CityEntry : System.Web.UI.Page
    {
        private CountryManager aCountryManager = new CountryManager();
        private CityManager aCityManager = new CityManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Country> countryList = aCountryManager.LoadAllCountry();
                CountryDropDownList.DataSource = countryList;
                CountryDropDownList.DataTextField = "CountryName";
                CountryDropDownList.DataValueField = "CountryName";
                CountryDropDownList.DataBind();
            }
          

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            City aCity = new City();
            aCity.Name = nameCityTextBox.Text;
            aCity.About = aboutCityTextBox.Text;
            aCity.DwelerNo = int.Parse(dwellerTextBox.Text);
            aCity.Location = locationTextBox.Text;
            aCity.Weather = weatherTextBox.Text;
            aCity.countryId = aCountryManager.GetCountryId(CountryDropDownList.SelectedItem.ToString());
            showLabel.Text = aCityManager.Save(aCity);
            nameCityTextBox.Text = "";
            aboutCityTextBox.Text = "";
            dwellerTextBox.Text = "";
            locationTextBox.Text = "";
            weatherTextBox.Text = "";
            Response.Redirect(Request.RawUrl);
        }

       

       
    }
}