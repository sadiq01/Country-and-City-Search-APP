using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CountryCityWebApp.BLL;

namespace CountryCityWebApp.UI
{
    public partial class ViewCountryUI : System.Web.UI.Page
    {
        CountryManager aCountryManager = new CountryManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            //string message = searchTextBox.Text;
            ////GridView1.DataSource = aCountryManager.ViewCountryListSearch(message);

            //ObjectDataSource1.TypeName = "CountryCityWebApp.DAL.Gateway.CountryGateway";
            //ObjectDataSource1.SelectMethod = "ViewCountryListSearch";
            

        }
    }
}