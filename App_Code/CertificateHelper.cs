using System;
using System.Collections.Generic;
using System.IdentityModel.Metadata;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Web;


    public static class CertificateHelper
    {
        public static X509Certificate2 SigningCertificate
        {
            get
            {
               return signingCertificateSustainsys;
            }
        }

        // The X509KeyStorageFlags.MachineKeySet flag is required when loading a
        // certificate from file on a shared hosting solution such as Azure.
        private static readonly X509Certificate2 signingCertificateSustainsys
            = new X509Certificate2(
                HttpContext.Current.Server.MapPath(
                "oktanew.pfx"), "test");

       

        

    }
