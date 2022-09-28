using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
    internal class CanteenWorker
    {
        public string name { get; set; }
        [Key]
        public string workerNr { get; set; }  
        public Canteen canteen { get; set; }    
    }
}
