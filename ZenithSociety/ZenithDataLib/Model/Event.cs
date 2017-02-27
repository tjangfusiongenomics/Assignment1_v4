using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenithDataLib.Model
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }
        [Display(Name = "Start Time")]
        public DateTime EventFromDateAndTime { get; set; }
        [Display(Name = "End Time")]
        public DateTime EventToDateAndTime { get; set; }
        public string EnteredByUserName { get; set; }
        [Display(Name = "Creation Date")]
        public DateTime CreationDate { get; set; }
        public bool IsActive { get; set; }


        public List<Activity> Activities { get; set; }
    }
}
