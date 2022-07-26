using DataStore.Person.Models;

namespace DataStore.Person.Data
{
    // Add you EF core here
    public class PersonAccess : IPersonAccess
    {
        private List<PersonModel> people = new();

        public PersonAccess()
        {
            people.Add(new PersonModel() { Id = 1, Name = "Klavs"});
            people.Add(new PersonModel() { Id = 2, Name = "Klaus" });
        }
        public List<PersonModel> GetPerson()
        {
            return people;
        }

        public PersonModel InsertPerson(string name)
        {
            PersonModel model = new() { Name = name };
            model.Id = people.Max(x => x.Id) + 1;

            people.Add(model);

            return model;
        }
        public PersonModel DeletePerson(int id)
        {
            var model = people.Single(c => c.Id == id);
            people.Remove(model);
            return model;
        }
    }
}