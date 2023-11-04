using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripExpenceManager.Data
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public enum TripStatus
    { 
    
    }

    public class Trip
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public string CategoryImage { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime AddedOn { get; set; }
        public DateTime? ModificationOn { get; set; }
    }
}
