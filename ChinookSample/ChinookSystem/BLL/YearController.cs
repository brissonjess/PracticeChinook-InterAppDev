using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel; //ODS
using ChinookSystem.Data.Entities;
using ChinookSystem.Data.POCOs;
using ChinookSystem.DAL; //get to context class
#endregion

namespace ChinookSystem.BLL
{
    [DataObject]
    public class YearController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<EmployeeNameList>
    }
}
