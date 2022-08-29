﻿using ConsumerMicroservice.Model;
using ConsumerMicroservice.Repo.IRepo;
using Microsoft.EntityFrameworkCore;

namespace ConsumerMicroservice.Repo
{
    public class BuisnessPropertyRepo :IBusinessPropertyRepo
    {
            private readonly ConsumerDbcontext _dbContext;

            public BuisnessPropertyRepo(ConsumerDbcontext dbContext)
            {
                _dbContext = dbContext;
            }
            //-------------------Property Methods----------------------------
            public IEnumerable<Property> GetProperty()
            {
                //Use Inculde to add businessMaster in Get Api Display
                return _dbContext.Property.Include(c => c.PropertyMaster).ToList();
            }

            // GEt property by Id
            public Property GetProperties(int PropertyId)
            {
                return _dbContext.Property.FirstOrDefault(x => x.PropertyId == PropertyId);
            }

            // Create Property 
            public bool CreateProperty(Property? property)
            {
                _dbContext.Property.Add(property);
                return Save();
            }

            // Udpate property
            public bool UpdateProperty(int PropertyId, Property property)
            {
                _dbContext.Property.Update(property);
                return Save();
            }

            // Delete Property
            public bool DeleteProperty(int PropertyId)
            {
                Property property = _dbContext.Property.FirstOrDefault(x => x.PropertyId == PropertyId);
                if (property != null)
                {
                    _dbContext.Property.Remove(property);
                }
                return Save();
            }

            // return true if there is a insertion into database else false
            public bool PropertyExists(int PropertyId)
            {
                return _dbContext.Property.Any(a => a.PropertyId == PropertyId);
            }

            public bool Save()
            {
                return _dbContext.SaveChanges() >= 0 ? true : false;
            }
        
    }
}
