using Feedback.DAL.Models;
using Feedback.Services.Services.Interface;
using Feedback2._0.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Feedback.Services.Services.Repository
{
    public class FeedbackRepository : IFeedback
    {
        private readonly Feedback2_0Context _usersDbContext;
        public FeedbackRepository(Feedback2_0Context context)
        {
            _usersDbContext = context;
        }
        public void AddFeedback(FeedbackRating feedback)
        {
            _usersDbContext.Feedbacks.Add(entity: feedback);
            _usersDbContext.SaveChanges();
        }

        public bool Any(int? Id)
        {
            if (_usersDbContext.Feedbacks.Any(x => x.Id == Id))
            {
                return true;
            }
            return false;
        }

        public void DeleteFeedbackById(int? id)
        {
            FeedbackRating temp=_usersDbContext.Feedbacks.Find(id);
            _usersDbContext.Feedbacks.Remove(temp);
            _usersDbContext.SaveChanges();

        }

        public IEnumerable<FeedbackRating> GetAllFeedbacks()
        {
            
            return _usersDbContext.Feedbacks.ToList();
        }

        public IEnumerable<FeedbackRating> GetAllFeedbackById(int? id)
        {
            if (id is null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            return _usersDbContext.Feedbacks.Where(x=> x.UserEmail.Equals(id)).ToList();
            
        }

        public void UpdateFeedback(FeedbackRating feedback)
        {
            _usersDbContext.Entry(feedback).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _usersDbContext.SaveChanges();
        }

        public FeedbackRating GetFeedbackById(int? id)
        {
            return _usersDbContext.Feedbacks.Find(id);
        }
    }
}
