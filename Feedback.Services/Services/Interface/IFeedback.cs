using Feedback.DAL.Models;
using System.Collections.Generic;

namespace Feedback.Services.Services.Interface
{
    public interface IFeedback
    {
        public void AddFeedback(FeedbackRating feedback);
        public IEnumerable<FeedbackRating> GetAllFeedbacks();
        public FeedbackRating GetFeedbackById(int? id);
        public IEnumerable<FeedbackRating> GetAllFeedbackById(int? id);
        void DeleteFeedbackById(int? id);
        void UpdateFeedback(FeedbackRating feedback);
        bool Any(int? Id);

    }
}
