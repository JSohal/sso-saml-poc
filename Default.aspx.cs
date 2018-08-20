using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;


using OneLogin.Saml;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Form["SAMLResponse"] != null)
        {
            AccountSettings accountSettings = new AccountSettings();

            OneLogin.Saml.Response samlResponse = new Response(accountSettings);
            samlResponse.LoadXmlFromBase64(Request.Form["SAMLResponse"]);

            if (samlResponse.IsValid())
            {
                
                Response.Write("OK!\n");
                Response.Write("Name ID: " + samlResponse.GetNameID() + "\n");
                Session["username"] = samlResponse.GetNameID();
                Session["sessionId"] = samlResponse.GetSessionId();
                Response.Write("Session ID: " + Session["sessionId"]);
                ssoUserId.Value = samlResponse.GetNameID();
            }
            else
            {
                Response.Write("Failed");
            }

        }

        else {
            if (!Page.IsPostBack)
            {
                AccountSettings accountSettings = new AccountSettings();

                OneLogin.Saml.AuthRequest req = new AuthRequest(new AppSettings(), accountSettings);

                Response.Redirect(accountSettings.idp_sso_target_url + "?SAMLRequest=" + Server.UrlEncode(req.GetRequest(AuthRequest.AuthRequestFormat.Base64)));
            }
        }
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        AccountSettings accountSettings = new AccountSettings();

        OneLogin.Saml.AuthRequest req = new AuthRequest(new AppSettings(), accountSettings);
        Response.Redirect(req.BindLogoutRequest(Session["username"].ToString(),Session["sessionId"].ToString()));
       
    }
}
