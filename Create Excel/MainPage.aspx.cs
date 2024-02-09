using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Syncfusion.XlsIO;
using System.Drawing;

namespace Create_Excel
{
    public partial class MainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            if (UserName.Text.Length == 0)
            {
                userInput.Text = "Please fill the User name properly";
            }
            else if (Password.Text.Length == 0)
            {
                userInput.Text = "Please fill the password properly";
            }
            else if (!Password.Text.Contains("@"))
            {
                userInput.Text = "Please enter the strong possword with @ symbol";
            }
            else if (Password.Text.Length < 8)
            {
                userInput.Text = "Please enter the strong possword with atleast 8 characters";
            }
            else
            {
                userInput.Text = "Wellcome.. \n Usser name: " + UserName.Text + " Password: " + Password.Text;
            }
        }
    }
}