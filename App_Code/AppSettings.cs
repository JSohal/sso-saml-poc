using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for AppSettings
/// </summary>
public class AppSettings
{   
    //http://localhost:52484/Default.aspx
    public string assertionConsumerServiceUrl = "http://pwssobroker.azurewebsites.net/Consume.aspx";
  
    public string issuer = "http://www.okta.com/exkftlr7hw9Hkh7Rp0h7";
}
