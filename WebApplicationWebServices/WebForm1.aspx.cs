using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationWebServices
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient ob1 = new ServiceReference1.WebService1SoapClient();

            Label3.Text =( ob1.add(int.Parse(TextBox1.Text), int.Parse(TextBox2.Text))).ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient ob1 = new ServiceReference1.WebService1SoapClient();

            Label3.Text = (ob1.prod(int.Parse(TextBox1.Text), int.Parse(TextBox2.Text))).ToString(); 
        }
    }
}