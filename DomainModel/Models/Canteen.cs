using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
    internal class Canteen
    {
        public int canteenId { get; set; }  
        public string location  { get; set; }
        public City city { get; set; }    
        public Boolean servesHot { get; set; }  

    }
}
