using Feedback.DAL.Models;
using System;

namespace Feedback.Services.Services.Interface
{
    public interface IAddress : IDisposable
    {
        public void AddAddress(Address address);
        public Address GetAddressByID(int? id);
        public void DeleteAddressByID(int? id);
        void UpdateAddress(Address address);
        bool Any(int? Id);
    }
}
