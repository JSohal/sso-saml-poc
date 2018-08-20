using OneLogin.Saml;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Logout : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // replace with an instance of the users account.
        AccountSettings accountSettings = new AccountSettings();

        OneLogin.Saml.Response samlResponse = new Response(accountSettings);        
        samlResponse.LoadXmlFromBase64(Request.Form["SAMLResponse"]);
        
        if (samlResponse.IsValid())
            Response.Write(samlResponse.GetStatus());

    }
}