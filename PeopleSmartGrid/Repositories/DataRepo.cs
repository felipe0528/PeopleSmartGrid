using PeopleSmartGrid.Interfaces;
using PeopleSmartGrid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleSmartGrid.Repositories
{
    public class DataRepo : IDataContext
    {
        public List<Person> People { get; set; }
        public List<PersonType> PersonTypes { get; set; }

        public DataRepo()
        {
            People = new List<Person>();
            PersonTypes = new List<PersonType>();
        }

        public Person AddPerson(Person person)
        {
            person.Id = People.Count > 0 ? People.Max(x => x.Id) + 1 : 1;
            People.Add(person);
            return person;
        }

        public bool RemovePerson(int id)
        {
            Person person = People.FirstOrDefault(x => x.Id == id);
            if (person != null)
            {
                People.Remove(person);
                return true;
            }
            return false;
        }

        public Person EditPerson(Person newPerson)
        {
            Person person = People.FirstOrDefault(x => x.Id == newPerson.Id);
            if (person != null)
            {
                person.Age = newPerson.Age;
                person.Name = newPerson.Name;
                person.Type = newPerson.Type;
                return person;
            }
            return newPerson;
        }

        public Person GetPerson(int id)
        {
            return People.FirstOrDefault(x => x.Id == id);
        }

        public PersonType AddType(PersonType type)
        {
            type.TypeId = PersonTypes.Count > 0 ? PersonTypes.Max(x => x.TypeId) + 1 : 1;
            PersonTypes.Add(type);
            return type;
        }

        public List<Person> GetPeople()
        {
            return People;
        }

        public List<PersonType> GetPersonTypes()
        {
            return PersonTypes;
        }

        public bool DeletePerson(int id)
        {
            Person person = People.FirstOrDefault(x => x.Id == id);
            if (person != null)
            {
                People.Remove(person);
                return true;
            }
            return false;
        }
    }
}
