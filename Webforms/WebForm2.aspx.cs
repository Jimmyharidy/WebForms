using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webforms
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buton1_Click(object sender, EventArgs e)
        {
            buton1.Text = "Du clickade på knappen";
            buton1.ForeColor = Color.Yellow;
            textbox1.Text = "Du Klickade på knappen, bra gjort";
            label1.ForeColor = Color.Aqua;
            link1.Text = "Du har ändrat mig!";
        }

        protected void textbox1_TextChanged(object sender, EventArgs e)
        {
            textbox1.Text = "Test test";
        }
    }
}