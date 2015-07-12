using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CountryCityWebApp.BLL;

namespace CountryCityWebApp.UI
{
    public partial class ViewCityUI : System.Web.UI.Page
    {
        CityManager acityManager = new CityManager();
        CountryManager aCountryManager = new CountryManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadCities();
            if (!IsPostBack)
            {

                countryDropDownList.DataSource = aCountryManager.LoadAllCountry();
                countryDropDownList.DataTextField = "CountryName";
                countryDropDownList.DataValueField = "CountryName";
                countryDropDownList.DataBind();
            }
        }
        protected void gridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            showCityGridView.PageIndex = e.NewPageIndex;
            showCityGridView.DataBind();
        }

        public void LoadCities()
        {
            showCityGridView.AutoGenerateColumns = true;
            showCityGridView.DataSource = acityManager.ViewCityList();
            showCityGridView.DataBind();
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            string message = "";

            if (cityNameRadioButton.Checked)
            {
                countryRadioButton.Checked = false;
                message = citySearchTextBox.Text;
                showCityGridView.AutoGenerateColumns = true;
                showCityGridView.DataSource = acityManager.CityRadioList(message);
                showCityGridView.DataBind();
                
            }
            if (countryRadioButton.Checked)
            {
                cityNameRadioButton.Checked = false;
                message = countryDropDownList.SelectedItem.ToString();
                showCityGridView.AutoGenerateColumns = true;
                showCityGridView.DataSource = acityManager.CountryRadioList(message);
                showCityGridView.DataBind();
                
            }
            
        }
    }
}