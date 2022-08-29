using ConsumerMicroservice.Model;
using ConsumerMicroservice.Repo.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace ConsumerMicroservice.Service
{
    public class ConsumerService :IConsumerService
    {
        private readonly IConsumerRepo _consumerRepo;
        private readonly IConsumerBusinessRepo _consumerBuisnessRepo;
        private readonly IBusinessPropertyRepo _businessPropertyRepo;
        public ConsumerService(IConsumerRepo consumerRepo, IConsumerBusinessRepo consumerBuisnessRepo,
            IBusinessPropertyRepo businessPropertyRepo)
        {
            _consumerRepo = consumerRepo;
            _consumerBuisnessRepo = consumerBuisnessRepo;
            _businessPropertyRepo = businessPropertyRepo;
        }

        public bool BuisnessExists(int BusinessId)
        {
            return _consumerBuisnessRepo.BuisnessExists(BusinessId);
        }

        public bool ConsumerExists(int ConsumerId)
        {
            return _consumerRepo.ConsumerExists(ConsumerId);
        }

        public bool CreateBuisness(Business business)
        {
            return _consumerBuisnessRepo.CreateBuisness(business);
        }

        public bool CreateConsumer(Consumer consumer)
        {
            return _consumerRepo.CreateConsumer(consumer);
        }

        public bool CreateProperty(Property property)
        {
            return _businessPropertyRepo.CreateProperty(property);
        }

        public bool DeleteBuisness(int BusinessId)
        {
            return _consumerBuisnessRepo.DeleteBuisness(BusinessId);
        }

        public bool DeleteConsumer(int ConsumerId)
        {
            return _consumerRepo.DeleteConsumer(ConsumerId);
        }

        public bool DeleteProperty(int PropertyId)
        {
            return _businessPropertyRepo.DeleteProperty(PropertyId);
        }

        public IEnumerable<BusinessMaster> GetBuisnessMaster()
        {
            return _consumerRepo.GetBusienssMaster();
        }

        public IEnumerable<Business> GetBuisness()
        {
            return _consumerBuisnessRepo.GetBuisness();
        }

        public Business GetBuisnesss(int BusinessId)
        {
            return _consumerBuisnessRepo.GetBuisnesss(BusinessId);
        }

        public Consumer GetConsumer(int ConsumerId)
        {
            return _consumerRepo.GetConsumer(ConsumerId);
        }

        public IEnumerable<Consumer> GetConsumers()
        {
            return _consumerRepo.GetConsumers();
        }

        public Property GetProperties(int PropertyId)
        {
            return _businessPropertyRepo.GetProperties(PropertyId);
        }

        public IEnumerable<Property> GetProperty()
        {
            return _businessPropertyRepo.GetProperty();
        }

        public IEnumerable<PropertyMaster> GetPropertyMaster()
        {
            return _consumerRepo.GetPropertyMaster();
        }

        public bool PropertyExists(int PropertyId)
        {
            return _businessPropertyRepo.PropertyExists(PropertyId);
        }

        public bool Save()
        {
            return _consumerRepo.Save();
        }

        public bool UpdateBuisness(int ConsumerId, Business business)
        {
            return _consumerBuisnessRepo.UpdateBuisness(ConsumerId, business);
        }

        public bool UpdateConsumer(int ConsumerId, Consumer consumer)
        {
            return _consumerRepo.UpdateConsumer(ConsumerId, consumer);
        }

        public bool UpdateProperty(int PropertyId, Property property)
        {
            return _businessPropertyRepo.UpdateProperty(PropertyId, property);
        }
    }
}
