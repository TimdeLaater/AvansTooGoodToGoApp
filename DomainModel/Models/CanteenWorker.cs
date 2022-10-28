using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
    public class CanteenWorker
    {
        [Key]
        public int WorkerId { get; set; }
        public string Name { get; set; }
        public string WorkerNr { get; set; }  
        public Canteen Canteen { get; set; }
        [ForeignKey("AppUser")]
        public string AppUserId { get; set; }
        public AppUser User;
    }
}
