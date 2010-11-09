using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OpenRasta.Authentication;
using OpenRasta.Authentication.Basic;

namespace OpenRastaAuthSample.Auth
{
    public class MyBasicAuthenticator :IBasicAuthenticator
    {
        public string Realm
        {
            get { return "SecuredDomainRealm"; }
        }

        public AuthenticationResult Authenticate(BasicAuthRequestHeader header)
        {
            return new AuthenticationResult.Success(header.Username);
        }

    }
}