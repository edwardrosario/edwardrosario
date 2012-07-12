using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNET_Test
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["test2"] = "Hello World";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = Session["test2"].ToString();
        }
    }
}
