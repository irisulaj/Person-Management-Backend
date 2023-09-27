using Microsoft.Extensions.Hosting;

namespace PersonManagement.Models
{
    public interface IPersonRepository 
    {
        IEnumerable<Pm01Person> person { get; }
        Pm01Person? GetPersonById(int? Id);
        void AddPerson(Pm01Person person);

        void UpdatePerson(int id, Pm01Person person);

        void DeletePerson(Pm01Person person);
    }
}
