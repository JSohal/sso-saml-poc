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
/// AccountSettings
/// 
/// Replace this class with an interface to your own applications account settings. 
/// 
/// Each account should as a minimum have the following:
///  - A URL pointing to the identity provider for sending Auth Requests
///  - A X.509 certificate for validating the SAML Responses from the identity provider
/// 
/// These should be retrieved from the account store/database on each request in the authentication flow.
/// </summary>
public class AccountSettings
{
    public string certificate = @"-----BEGIN CERTIFICATE-----
MIIDpDCCAoygAwIBAgIGAWQChUwkMA0GCSqGSIb3DQEBCwUAMIGSMQswCQYDVQQGEwJVUzETMBEG
A1UECAwKQ2FsaWZvcm5pYTEWMBQGA1UEBwwNU2FuIEZyYW5jaXNjbzENMAsGA1UECgwET2t0YTEU
MBIGA1UECwwLU1NPUHJvdmlkZXIxEzARBgNVBAMMCmRldi0yMjc5NDkxHDAaBgkqhkiG9w0BCQEW
DWluZm9Ab2t0YS5jb20wHhcNMTgwNjE1MDgxNjI3WhcNMjgwNjE1MDgxNzI3WjCBkjELMAkGA1UE
BhMCVVMxEzARBgNVBAgMCkNhbGlmb3JuaWExFjAUBgNVBAcMDVNhbiBGcmFuY2lzY28xDTALBgNV
BAoMBE9rdGExFDASBgNVBAsMC1NTT1Byb3ZpZGVyMRMwEQYDVQQDDApkZXYtMjI3OTQ5MRwwGgYJ
KoZIhvcNAQkBFg1pbmZvQG9rdGEuY29tMIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEA
xe63qvaaOq8X/bdo6jTlnFTPCy6dtwIZ9/8JgceT6wNyOXblLwWmflxLhx8KeMyjRO5Z6vc+z3WS
pwS0NEVzkinVbzIFqskIBJyG93JUtq5PdMbTGNrLq0niEdLUvuusGOA/USuPGBft7BE0uxsqDy4G
Ht/TjbiY7XLi/7kSzrFwt3JySU5nacltYcJ/aakz6Jr43qrXneewtLuw5DOub0kI1G6njM87pakK
qORKMt1JHJOTVhPncy/Cf9oZN49yqw9A1MFP0gRHFyFSfGutTj8YErekkNZO3zobHTXGMBO6NDI/
vtCdhyT6ftMW+9n2AzTQqYSI2//8+Mgb6XzDzwIDAQABMA0GCSqGSIb3DQEBCwUAA4IBAQC4HpKK
GUaot6B+VjOk5fncbA+QRFRWylc0LFxeyLXcfa84YLEtstIM6o7r/VywyT52k8fUGzfoPARdb2u0
hPY1r2dfFtBTA7yldBaPF90Q71a4KwefRsVsbJ1URo7cgh6tEi1gaUdm8r0zi320aSL2uFp465Zo
teftbw2deHfbXuVS1StQa6mfDTNumyeVIfcqAr2HRrPyNTacjp3HpUPM1D5kW6sC2opbpexuZf3k
XVWJGYEDtUA5YL/SjbmN8P3aZn7lgRNIABVleorJ9RwSNx+KyjhnxrxTmTGXjZv58Qn0WqBcDqU2
GJ2NYTdf8ysZwNN1dVm5WhBizDBZKxkg
-----END CERTIFICATE-----";


    public string idp_sso_target_url = "https://dev-227949.oktapreview.com/app/persistentdev227949_esissamlapp_1/exkftlr7hw9Hkh7Rp0h7/sso/saml";
    public string idp_slo_url = "https://dev-227949.oktapreview.com/app/persistentdev227949_esissamlapp_1/exkftlr7hw9Hkh7Rp0h7/slo/saml";
    public string sloIssuerUrl = "http://pwssobroker.azurewebsites.net/Default.aspx";
}


