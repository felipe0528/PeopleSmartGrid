using PeopleSmartGrid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleSmartGrid.Interfaces
{
    public interface IDataContext
    {
        Person AddPerson(Person person);
        bool RemovePerson(int id);
        Person EditPerson(Person person);
        Person GetPerson(int id);
        PersonType AddType(PersonType type);
        List<Person> GetPeople();
        List<PersonType> GetPersonTypes();
        bool DeletePerson(int id);
    }
}
