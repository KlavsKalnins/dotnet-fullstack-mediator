using DataStore.Person.Models;

namespace DataStore.Person.Data
{
    public interface IPersonAccess
    {
        List<PersonModel> GetPerson();
        PersonModel InsertPerson(string name);
        PersonModel DeletePerson(int id);
    }
}