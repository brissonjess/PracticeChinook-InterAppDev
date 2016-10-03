using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#endregion

namespace ChinookSystem.Data.Entities
{
    //point to the SQL table that this file maps
    //there is no need to put in the schema, if you wanted to it is "DBO"
    [Table("Albums")]
    public class Album
    {
        //Key notation is optional if the SQL Pkey ends in ID or Id
        //required if default of entity is NOT Identity or if Pkey is compound 

        //properties can be fully implemented or auto implemented
        //property names should use SQL attribute name
        //properties should be listed in the same order as SQL table attributes
        //this is for ease of maintenance 

        [Key]
        public int AlbumId { get; set; }
        public string Title { get; set; }
        public int ArtistId { get; set; }
        public int ReleaseYear { get; set; }
        public string ReleaseLabel { get; set; }


        //Navigation properties for use by LINQ
        //these properties will be of type virtual (the system knows not to map as a regular field)
        //  you are giving the system the capability of doing the navigation

        //there is two types of navigation properties:
        //1. properties to point to children use ICollection<Type>
        //2. properties that point to parent ParentName as the data type

        public virtual ICollection<Track> Tracks { get; set; }

        public virtual Artist Artist { get; set; }

    }
}
