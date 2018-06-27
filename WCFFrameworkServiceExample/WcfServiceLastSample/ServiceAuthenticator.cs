using System;
using System.Collections.Generic;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.Linq;
using System.ServiceModel.Security;
using System.Web;

namespace WcfServiceLastSample
{
    public class ServiceAuthenticator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName))
                throw new ArgumentNullException();
            if (string.IsNullOrEmpty(password))
                throw new ArgumentNullException();
            if(userName!= "test" || password!= "test")
                throw new SecurityTokenException("Şifre veya paralo hatalı");

        }
    }
}