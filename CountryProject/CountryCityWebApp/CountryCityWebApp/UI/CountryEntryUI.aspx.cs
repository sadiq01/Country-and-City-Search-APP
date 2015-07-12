using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CountryCityWebApp.BLL;
using CountryCityWebApp.DAL.DAO;

namespace CountryCityWebApp
{
    public partial class CountryEntryUI : System.Web.UI.Page
    {
        Country aCountry = new Country();
        CountryManager aCountryManager = new CountryManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            //LoadAllCountry();
            
        }

       public void saveButton_Click(object sender, EventArgs e)
       {
            aCountry.CountryName = nameCountryTextBox.Text;
            //aCountry.CountryAbout = aboutCountryTextBox.Text;
            aCountry.CountryAbout = Request.Form["write"];
           if (aCountryManager.isCountryExist(aCountry.CountryName))
           {
               showLabel.Text = "Not saved. Country already exist.";
           }
           else
           {
               showLabel.Text = aCountryManager.Save(aCountry);
               LoadAllCountry();
               nameCountryTextBox.Text = "";
               //aboutCountryTextBox.Text = "";
               Response.Redirect(Request.RawUrl);
           }
            
       }

       public void LoadAllCountry()
       {
           
           //gridViewCountry.AutoGenerateColumns = true;
           //gridViewCountry.DataSource = aCountryManager.LoadAllCountry();
           //gridViewCountry.DataBind();

           
       }
    }
}