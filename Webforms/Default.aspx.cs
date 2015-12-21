using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webforms
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Button1.Text = "Klicka";
            Button1.BackColor = Color.Aqua;
            Button1.BorderColor = Color.Black;
        }
    }
}