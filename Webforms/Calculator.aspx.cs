using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webforms
{
    public partial class Calculator : System.Web.UI.Page
    {
        public double tal1 = -1;
        public double tal2 = -1;
        public bool flag = false;
        public string operand = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text += Button1.Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text += Button2.Text;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox1.Text += Button3.Text;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            TextBox1.Text += Button4.Text;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            TextBox1.Text += Button5.Text;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            TextBox1.Text += Button6.Text;
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            TextBox1.Text += Button7.Text;
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            TextBox1.Text += Button8.Text;
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            TextBox1.Text += Button9.Text;
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            TextBox1.Text += Button.Text;
        }

        protected void ButtonPoint_Click(object sender, EventArgs e)
        {
            TextBox1.Text += ButtonPoint.Text;
        }

        protected void ButtonPlus_Click(object sender, EventArgs e)
        {
           
            double.TryParse(TextBox1.Text, out tal1);            
            TextBox1.Text = string.Empty;
            flag = true;
            operand = "+";
        
        }

        protected void ButtonEquals_Click(object sender, EventArgs e)
        {
           
           double.TryParse(TextBox1.Text, out tal2);
           if(flag && tal2 >= 0)
            { 
                switch (operand)
                {
                    case "+":
                        TextBox1.Text = (tal1 + tal2).ToString();
                        break;
                    default:
                        Label1.Text = "Please enter a valid input.";
                        break;
                }
            }
        }
    }
}