using Sustainsys.Saml2.Saml2P;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Metadata;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Web;

/// <summary>
/// Summary description for LogoutModel
/// </summary>
public class LogoutModel
{
    
        public LogoutModel()
        {
            //SessionIndex = AssertionModel.DefaultSessionIndex;
        }

        [Required]
    [DisplayName("SP Single Logout Url")]
    public Uri DestinationUrl { get; set; }

    [Required]
    [DisplayName("Session index")]
    public string SessionIndex { get; set; }

    [Required]
    [DisplayName("Subject NameID")]
    public string NameId { get; set; }

    public string Issuer { get; set; }
    public Saml2LogoutRequest ToLogoutRequest()
    {
        return new Saml2LogoutRequest()
        {
            DestinationUrl = DestinationUrl,
            SigningCertificate = CertificateHelper.SigningCertificate,
            SigningAlgorithm = "http://www.w3.org/2001/04/xmldsig-more#rsa-sha256",
            Issuer = new EntityId(Issuer),
            NameId = new Saml2NameIdentifier(NameId),
            SessionIndex = SessionIndex,
        };
    }

}