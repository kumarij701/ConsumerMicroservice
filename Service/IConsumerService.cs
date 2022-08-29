using ConsumerMicroservice.Model;

namespace ConsumerMicroservice.Service
{
    public interface IConsumerService
    {
        IEnumerable<Consumer> GetConsumers();
        Consumer GetConsumer(int ConsumerId);
        bool CreateConsumer(Consumer consumer);
        bool UpdateConsumer(int ConsumerId, Consumer consumer);
        bool DeleteConsumer(int ConsumerId);
        bool ConsumerExists(int ConsumerId);

        // For Business
        IEnumerable<Business> GetBuisness();
        Business GetBuisnesss(int BuisnessId);
        bool CreateBuisness(Business buisness);
        bool UpdateBuisness(int ConsumerId, Business buisness);
        bool DeleteBuisness(int BuisnessId);
        bool BuisnessExists(int BuisnessId);

        // For PRoperty
        IEnumerable<Property> GetProperty();
        Property GetProperties(int PropertyId);
        bool CreateProperty(Property property);
        bool UpdateProperty(int PropertyId, Property property);
        bool DeleteProperty(int PropertyId);
        bool PropertyExists(int PropertyId);

        // Business Master and Property Master
        IEnumerable<BusinessMaster> GetBuisnessMaster();
        IEnumerable<PropertyMaster> GetPropertyMaster();
        bool Save();
    }
}


/**< connectionStrings >

        < add name = "ConsumerDbContext"  connectionString = "Data Source=BYODHSQ5DX2\\MSSQLSERVERNEW;Initial Catalog=Policy;Integrated Security=True" providerName = "System.Data.SqlClient" />
     
         </ connectionStrings >**/