using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfServiceLastSample
{
    public class TestClientServiceExample
    {
        public void Test()
        {
            try
            {   
              /*  EndpointAddress ep = new EndpointAddress(new Uri(
                    "https://localhost:44392/Service1.svc"));
                WSHttpBinding bind = new WSHttpBinding();
                bind.Security.Mode = SecurityMode.TransportWithMessageCredential;
                bind.Security.Message.ClientCredentialType =
                    MessageCredentialType.UserName;


                Service1Client client = new Service1Client(bind, ep);
                //      client.ClientCredentials.ClientCertificate.SetCertificate(StoreLocation.CurrentUser, StoreName.My, X509FindType.FindByIssuerName, "<issuername>");

                client.ClientCredentials.UserName.UserName = "test";
                client.ClientCredentials.UserName.Password = "test";
                Console.WriteLine(client.GetData(1) + "  ");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadLine();
                throw;
            }        */
        }
    }
}