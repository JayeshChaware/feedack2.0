using Feedback.DAL.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Feedback.DAL.Models
{
    public class FeedbackRating
    {
        [Key]
        public int Id { get; set; }
        [Required]

        public int ProductId { get; set; }
        [Required]
        public StarRating Rating { get; set; }
        [MaxLength(500)]
        public string Comment { get; set; }

        public string UserEmail { get; set; }
        [ForeignKey("UserEmail")]
        public virtual FeedbackUser User { get; set; }

        [ForeignKey("ProductId")]
        //[InverseProperty("FeedbackRating")]
        public virtual Product Product { get; set; }

        
    }
}
