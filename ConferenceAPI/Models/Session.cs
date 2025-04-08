using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ConferenceAPI.Models
{
    public class Session
    {
        [Key]

        public int SessionID { get; set; }

        
        [Required]
        [StringLength(100)] //Maximum 100 characters for SessionTitle

        public string SessionTitle { get; set; }

        [Required]
       

        public DateTime SessionDateTime { get; set; }

        [StringLength(100)]


        public string Speaker { get; set; }

        //navigation property for related Registrations
        public ICollection<Registration> Registrations { get; set; }
    }
}