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
        public string Name { get; set; }
        [Key]
        public string Email { get; set; }
        [Key]
        public string WorkerNr { get; set; }  
        public Canteen Canteen { get; set; }    
    }
}
