using Feedback.DAL.Models;
using System;
using System.Collections.Generic;

namespace Feedback.Services.Services.Interface
{
    public interface IUser : IDisposable
    {
        public string AddUser(FeedbackUser user);
        public FeedbackUser GetUserByID(string id);
        public void DeleteUserByID(string id);
        IEnumerable<FeedbackUser> GetAllUser();
        void UpdateUser(FeedbackUser user);
        bool Any(string Id);
    }
}
