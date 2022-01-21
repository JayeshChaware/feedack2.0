﻿using Feedback.DAL.Models;
using Feedback.Services.Services.Interface;
using Feedback2._0.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Feedback.Services.Services.Repository
{
    public class AddressRepository : IAddress
    {
        private readonly Feedback2_0Context _usersDbContext;
        public AddressRepository(Feedback2_0Context context)
        {
            _usersDbContext = context;
        }
        public void AddAddress(Address address)
        {
            _usersDbContext.Addresses.Add(address);
            _usersDbContext.SaveChanges();
        }

        public bool Any(int? Id)
        {
            if (_usersDbContext.Addresses.Any(x => x.ID == Id))
            {
                return true;
            }
            return false;
        }

        public void DeleteAddressByID(int? id)
        {
            Address temp = _usersDbContext.Addresses.Find(id);
            _usersDbContext.Addresses.Remove(temp);
            _usersDbContext.SaveChanges();
        }

        public void Dispose()
        {
            _usersDbContext.Dispose();
            GC.SuppressFinalize(this);
        }

        public Address GetAddressByID(int? id)
        {
            return _usersDbContext.Addresses.Find(id);
        }

        public void UpdateAddress(Address address)
        {
            _usersDbContext.Entry(address).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _usersDbContext.SaveChanges();
        }
    }
}
