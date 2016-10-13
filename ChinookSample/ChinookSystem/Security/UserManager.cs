using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Additional namespaces
using Microsoft.AspNet.Identity.EntityFramework;    //gets UserStore, which is the second item 
using Microsoft.AspNet.Identity;                    //gets UserManager
#endregion
namespace ChinookSystem.Security
{
    public class UserManager : UserManager<ApplicationUser>
    {
        public UserManager()
            : base(new UserStore<ApplicationUser>(new ApplicationDbContext()))
        {
        }
    }
}
