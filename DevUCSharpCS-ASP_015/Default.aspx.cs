using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevUCSharpCS_ASP_015
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Days.Hour.Minutes:Seconds.Milliseconds
            // http://is.gd/timespan
            //TimeSpan myTimeSpan = TimeSpan.Parse("7.7.7:7.7");

            //show elapsed time between a given date and DateTime.Now
            //DateTime myBirthday = DateTime.Parse("12/7/1969");
            //TimeSpan myAge = DateTime.Now.Subtract(myBirthday);

            //resultLabel.Text = myAge.TotalDays.ToString();

            DateTime myDate = DateTime.Parse("1/1/0001");
            TimeSpan myTime = DateTime.Now.Subtract(myDate);

            resultLabel.Text = "There have been " + myTime.TotalDays.ToString() + " days since Jan 1, 0001.";
        }
    }
}