using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1_1_hur_manga_versaler
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Click(object sender, EventArgs e)
        {
            if (TextBox.Enabled)
            {
                Result.Text = String.Format("There's {0} uppercase letters in the text", TextAnalyzer.GetNumberOfCapitals(TextBox.Text));
                TextBox.Enabled = false;
                Button.Text = "Reset";
            }
            else
            {
                TextBox.Text = "";
                TextBox.Enabled = true;
                Result.Text = "";
                Button.Text = "Count uppercase letters";
            }
        }

    }
}