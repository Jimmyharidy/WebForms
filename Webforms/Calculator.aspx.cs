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
        public static double tal1 = -1;
        public static double tal2 = -1;
        public static bool flag = false;
        public static string operand = string.Empty;
        public static double result = 0;
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
        protected void ButtonMinus_Click(object sender, EventArgs e)
        {
            double.TryParse(TextBox1.Text, out tal1);
            TextBox1.Text = string.Empty;
            flag = true;
            operand = "-";
        }
        protected void ButtonMultiply_Click(object sender, EventArgs e)
        {
            double.TryParse(TextBox1.Text, out tal1);
            TextBox1.Text = string.Empty;
            flag = true;
            operand = "*";
        }
        protected void ButtonDevide_Click(object sender, EventArgs e)
        {
            double.TryParse(TextBox1.Text, out tal1);
            TextBox1.Text = string.Empty;
            flag = true;
            operand = "/";
        }
        protected void ButtonEquals_Click(object sender, EventArgs e)
        {

            double.TryParse(TextBox1.Text, out tal2);
            if (flag && tal2 >= 0)
            {
                switch (operand)
                {
                    case "+":
                        result = (tal1 + tal2);
                        TextBox1.Text = result.ToString();
                        break;
                    case "-":
                        result = (tal1 - tal2);
                        TextBox1.Text = result.ToString();
                        break;
                    case "*":
                        result = (tal1*tal2);
                        TextBox1.Text = result.ToString();
                        break;
                        result = (tal1/tal2);
                        TextBox1.Text = result.ToString();
                    default:
                        TextBox1.Text = "Not a valid input, only numbers is valid!";
                        break;
                }
            }
        }


    }
}