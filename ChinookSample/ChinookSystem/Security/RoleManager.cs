using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using Microsoft.AspNet.Identity;                    //RoleManager
using Microsoft.AspNet.Identity.EntityFramework;    //IdentityRole & RoleStore

#endregion


namespace ChinookSystem.Security
{
    public class RoleManager:RoleManager<IdentityRole>
    {
        public RoleManager():
            base (new RoleStore<IdentityRole>(new ApplicationDbContext()))
        {
                
        }
        //this method will be executed with the application starts up under Internet Information Services (IIS)
        /*
         *  During the Startup Process
         *  The 1st time the website is started, a file called Global.aspx is executed
         *  In this file we will call the method RoleManager to AddStartupRoles()
         *  
         *  If you needed to create a new role then you can add it in the SecurityRoles class...
         */
        public void AddStartupRoles()
        {
            foreach(string roleName in SecurityRoles.StartupSecurityRoles)
            {
                //for each item in the StartupSecurityRoles List 
                //  check if the role already exists in the Secuirty Tables located in the database
                if(!Roles.Any(r => r.Name.Equals(roleName)))
                {
                    //role is not currently on the database
                    this.Create(new IdentityRole(roleName));
                }
            }
        }
    }
}
