using Feedback.DAL.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Feedback.DAL.Models
{
    public class Product
    {
        public Product()
        {
            FeedbackRatings = new HashSet<FeedbackRating>();
        }
        [Key]
        public int Id { get; set; }
      
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
     
        [Required]
        [MaxLength(500)]
        public string Description { get; set; }
        public string UserEmail { get; set; }
        [ForeignKey("UserEmail")]
        public virtual FeedbackUser User { get; set; }
        [InverseProperty("Product")]
        public virtual ICollection<FeedbackRating> FeedbackRatings { get; set; }
    }
}
