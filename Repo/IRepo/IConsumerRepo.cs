using ConsumerMicroservice.Model;

namespace ConsumerMicroservice.Repo.IRepo
{
    public interface IConsumerRepo
    {
        IEnumerable<Consumer> GetConsumers();
        Consumer GetConsumer(int ConsumerId);
        bool CreateConsumer(Consumer consumer);
        bool UpdateConsumer(int ConsumerId, Consumer consumer);
        bool DeleteConsumer(int ConsumerId);
        bool ConsumerExists(int ConsumerId);
        IEnumerable<BusinessMaster> GetBusienssMaster();
        IEnumerable<PropertyMaster> GetPropertyMaster();
        bool Save();
    }
}
