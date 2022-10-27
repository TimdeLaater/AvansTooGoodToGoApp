using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Models.Enum;

namespace DomainModel.Models
{
    public class Canteen
    {

        public Canteen(int canteenId, string name, City city, bool servesHot)
        {
            this.canteenId = canteenId;
            Name = name;
            this.city = city;
            ServesHot = servesHot;
        }

        public int canteenId { get; set; }  
        public string Name  { get; set; }
        public City city { get; set; }    
        public Boolean ServesHot { get; set; }  

    }
}
