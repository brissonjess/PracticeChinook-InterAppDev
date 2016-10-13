using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional namespaces
using Microsoft.AspNet.Identity.EntityFramework;//for IdentityDbContext 
#endregion

namespace ChinookSystem.Security
{
    //pass the connection string to the DbContext using :base()
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
    }
}
