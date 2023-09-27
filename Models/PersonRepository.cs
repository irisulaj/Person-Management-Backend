using Microsoft.Extensions.Hosting;

namespace PersonManagement.Models
{
    public class PersonRepository : IPersonRepository
    {

        private readonly PersonManagementContext _personManagementContext;

        public PersonRepository(PersonManagementContext personManagementContext)
        {
            _personManagementContext = personManagementContext;
        }

        public IEnumerable<Pm01Person> person

        {
            get
            {
                return _personManagementContext.Pm01People;
            }
        }

        public Pm01Person? GetPersonById(int? Id)
        {
            return _personManagementContext.Pm01People.FirstOrDefault(i => i.IdPerson == Id);
        }

        public void AddPerson(Pm01Person person)
        {
            _personManagementContext.Pm01People.Add(person);

            _personManagementContext.SaveChanges();
        }

        public void UpdatePerson(int id, Pm01Person person)
        {
            var personUpdated = _personManagementContext.Pm01People.FirstOrDefault(i => i.IdPerson == id);

            personUpdated.Name = person.Name;
            personUpdated.Surname = person.Surname;
            personUpdated.DateofBirth = person.DateofBirth;
            personUpdated.Phone = person.Phone;
            personUpdated.Gender = person.Gender;
            personUpdated.IsEmployed = person.IsEmployed;
            personUpdated.IdMaritalstatus = person.IdMaritalstatus;
            personUpdated.PlaceofBirth = person.PlaceofBirth;
   
            _personManagementContext.Update(personUpdated);
            _personManagementContext.SaveChanges(true);
        }

        public void DeletePerson(Pm01Person person)
        {
            _personManagementContext.Remove(person);

            _personManagementContext.SaveChanges();
        }
    }
}
