using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webforms
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Button1.Text = "Click Me";
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button1.Text = "Hello World";
            Button1.ForeColor = Color.HotPink;
            Label1.Text = "Hello World";
        }
    }
}