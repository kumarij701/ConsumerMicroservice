using ConsumerMicroservice.Model;

namespace ConsumerMicroservice.Repo.IRepo
{
    public interface IBusinessPropertyRepo
    { 
        // Return a Bool value when opertions are done , this is Property 
    IEnumerable<Property> GetProperty();
    Property GetProperties(int PropertyId);
    bool CreateProperty(Property property);
    bool UpdateProperty(int PropertyId, Property property);
    bool DeleteProperty(int PropertyId);
    bool PropertyExists(int PropertyId);
    bool Save();
}
}
