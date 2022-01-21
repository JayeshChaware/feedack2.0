using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Feedback.DAL.Models
{
    public class FeedbackUser :IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string FirstName { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }
        public int? AddressId { get; set; }


        [ForeignKey("AddressId")]
        public virtual Address Address { get; set; }//fot 1-1

        public List<FeedbackRating> Feedbacks = new List<FeedbackRating>();
        public List<Product> Productss = new List<Product>();
    }
}
