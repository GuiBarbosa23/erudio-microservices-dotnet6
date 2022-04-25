using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Services.Interfaces
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person Update(Person person);
        Person FindById(long id);
        void Delete(long id);
        List<Person> FindAll();
    }
}
