using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices.AccountManagement;
using System.Net;

namespace Domain_authentification
{
    class authentification
    {
        public bool validate_credentials(string username, string password)
        {
            //Get domain name
            IPHostEntry iphe = Dns.GetHostEntry(Environment.UserDomainName);
            string[] fqdn = iphe.HostName.Split('.');

            string principleName = username + "." + fqdn[1] + "." + fqdn[2];

            Hashtable ht = new Hashtable();
            ht.Add(System.Security.Principal.);

            return true;
        }
    }
}
