using ConsumerMicroservice.Model;
using ConsumerMicroservice.Repo.IRepo;
using Microsoft.EntityFrameworkCore;


namespace ConsumerMicroservice.Repo
{
    public class ConsumerBuisnessRepo :IConsumerBusinessRepo
    {
        private readonly ConsumerDbcontext _dbContext;

        public ConsumerBuisnessRepo(ConsumerDbcontext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Business> GetBuisness()
        {
            return _dbContext.Business.Include(c => c.BusinessMaster).ToList();
        }

        // Get Business by Id
        public Business GetBuisnesss(int BuisnessId)
        {
            return _dbContext.Business.FirstOrDefault(x => x.BusinessId == BuisnessId);
        }

        // Create Business 
        public bool CreateBuisness(Business? buisness)
        {
            _dbContext.Business.Add(buisness);
            return Save();
        }

        // Update business
        public bool UpdateBuisness(int ConsumerId, Business buisness)
        {
            _dbContext.Business.Update(buisness);
            return Save();
        }

        // delete business
        public bool DeleteBuisness(int BuisnessId)
        {
            Business buisness = _dbContext.Business.FirstOrDefault(x => x.BusinessId == BuisnessId);
            if (buisness != null)
            {
                _dbContext.Business.Remove(buisness);
            }
            return Save();
        }

        // check if Business Id exicts
        public bool BuisnessExists(int BusinessId)
        {
            return _dbContext.Business.Any(a => a.BusinessId == BusinessId);
        }

        // return true if there is a insertion into database else false
        public bool Save()
        {
            return _dbContext.SaveChanges() >= 0 ? true : false;
        }
    }
}
