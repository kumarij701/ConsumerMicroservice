using ConsumerMicroservice.Model;

namespace ConsumerMicroservice.Repo.IRepo
{
    public interface IConsumerBusinessRepo
    {
        IEnumerable<Business> GetBuisness();
        Business GetBuisnesss(int BusinessId);
        bool CreateBuisness(Business business);
        bool UpdateBuisness(int ConsumerId, Business business);
        bool DeleteBuisness(int BusinessId);
        bool BuisnessExists(int BusinessId);
        bool Save();
    }
}
