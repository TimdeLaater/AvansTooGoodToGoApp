using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
    public class Canteen
    {
        public int canteenId { get; set; }  
        public string Name  { get; set; }
        public City city { get; set; }    
        public Boolean ServesHot { get; set; }  

    }
}
