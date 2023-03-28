using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AuthenticationExample
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(System.Security.Principal.WindowsIdentity.GetCurrent().Name);
            Response.Write("Is Authenticated? "+User.Identity.IsAuthenticated.ToString());
            Response.Write($"Authentication type : {User.Identity.AuthenticationType}");
            Response.Write($"User Name: {User.Identity.Name}");
        }
    }
}