using Feedback.DAL.Models;
using Feedback.Services.Services.Interface;
using Feedback2._0.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Feedback.Services.Services.Repository
{
    public class UserRepository : IUser
    {
        private readonly Feedback2_0Context _usersDbContext;
        public UserRepository(Feedback2_0Context context)
        {
            _usersDbContext = context;
        }
        public string AddUser(FeedbackUser user)
        {
            _usersDbContext.Users.Add(user);
            _usersDbContext.SaveChanges();
            return user.Email;
        }


        public bool Any(string Id)
        {
            if (_usersDbContext.Users.Any(x => x.Email .Equals(Id)))
            {
                return true;
            }
            return false;
        }

        public void DeleteUserByID(string id)
        {
            FeedbackUser temp = _usersDbContext.Users.Find(id);    
            _usersDbContext.Users.Remove(temp);
            _usersDbContext.SaveChanges();
        }

        public void Dispose()
        {
            _usersDbContext.Dispose();
            GC.SuppressFinalize(this);
        }

        public IEnumerable<FeedbackUser> GetAllUser()
        {
            return _usersDbContext.Users.ToList();
        }

        public FeedbackUser GetUserByID(string id)
        {
           // if (id.HasValue)
            //{
               // List<User> temp = new List<User>();
                //temp.Add(_usersDbContext.Users.FirstOrDefault(u => u.ID == id));
                return _usersDbContext.Users.FirstOrDefault(u => u.Email.Equals( id));
            //}
            //else
            //{
             //   return _usersDbContext.Users.ToList();
            //}
        }

        public void UpdateUser(FeedbackUser user)
        {
            _usersDbContext.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _usersDbContext.SaveChanges();
        }
    }
}
