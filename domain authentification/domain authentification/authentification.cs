using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices.AccountManagement;

namespace Domain_authentification
{
    class authentification
    {
        public bool validate_credentials(string username, string password)
        {
            using (PrincipalContext context = new PrincipalContext(ContextType.Domain))
            {
                return context.ValidateCredentials(username, password);
            }
        }
    }
}
