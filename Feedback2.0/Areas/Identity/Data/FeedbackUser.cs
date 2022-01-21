using Feedback.DAL.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Feedback2._0.Areas.Identity.Data
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
    }
}
