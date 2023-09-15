using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppErrorHandling
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnDivision_Click(object sender, EventArgs e)
        {
            try
            {
                int dividend = int.Parse(TxtNum1.Text);
                int divisor = int.Parse(TxtNum2.Text);
                int result = dividend / divisor;
                LblErrorMessage.Text = "Result After Division " + result.ToString();
                if (result > 5)
                {
                    throw new Exception("Result is Greater than 5");
                }
            }
            catch(DivideByZeroException ex)
            {
                Session["Error"] = LblErrorMessage.Text = "Devided by Zero Error Occured"+ex.Message;
                Response.Redirect("Error.aspx");
            }
            catch (Exception ex) {
                Session["Error"]=LblErrorMessage.Text="An Error occured"+ex.Message;
                Response.Redirect("Error.aspx");
            }
        }

        protected void BtnRedirect_Click(object sender, EventArgs e)
        {
            Response.Redirect("DataBinding.aspx");
        }
    }
}