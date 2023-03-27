using System.ComponentModel.DataAnnotations;

namespace GovBright.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstLine { get; set; }

       
        public string SecondLine { get; set; }

        [Required]
        public string Town { get; set; }

       
        public string County { get; set; }

        [Required]
        public string Postcode { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}