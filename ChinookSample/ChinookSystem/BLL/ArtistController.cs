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
    public class ArtistController
    {
        //first method: dump the entire artist entity 
            //This will use entity framework access
            //Entity classes will be used to define the data

        [DataObjectMethod(DataObjectMethodType.Select,false)]
        public List<Artist> Artist_ListAll()
        {
            //setup transaction area 
            //everything inside the using is a transaction 
            using (var context = new ChinookContext())
            {
                //gets the entire table from the DB
                return context.Artists.ToList();
            }
        }




        //second method: report a dataset containing data from multiple tables(enitities)
            //this will use LINQ to Entity access
            //POCO classes will be used to define the data 
            //

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<ArtistAlbums> Artist_Albums_Get()
        {
            //setup transaction area 
            //everything inside the using is a transaction 
            using (var context = new ChinookContext())
            {
                //need to setup a LINQ command to get our data
                //when you bring your query from LINQ pad to your program
                    //you must change the reference(s) to the data source
                    //in this case your had to change Albums to context.Albums

                //you may also need to change your navigation referencing
                    // used in LINQ pad to the navigation properties you 
                    // stated in the entity class definitions
                    //in this case your had to change Artist to Artists
                var results = from x in context.Albums
                              where x.ReleaseYear == 2008
                              orderby x.Artists.Name, x.Title
                              //the data type that you write here will the 
                                //match the list data type in the public class definition
                              select new ArtistAlbums
                              {
                                  //Name and title are POCO class property names
                                  Name = x.Artists.Name,
                                  Title = x.Title
                              };
                //the following requires the query data in memory which is:
                //.ToList()
                //At this point the query will actually execute
                return results.ToList();
            }
        }
    }
}
