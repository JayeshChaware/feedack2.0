using System.ComponentModel.DataAnnotations;

namespace Feedback.DAL.Models
{
    public class Address
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(150)]
        public string AddressLineOne { get; set; }
        [MaxLength(150)]
        public string AddressLineTwo { get; set; }
        [Required]
        [MaxLength(30)]
        public string City { get; set; }
        [Required]
        [MaxLength(30)]
        public string State { get; set; }
        [Required]
        [MaxLength(30)]
        public string Country { get; set; }
        [Required]
        [MaxLength(12)]
        public string Pincode { get; set; }
        public FeedbackUser User { get; set; }
    }
}
