using PeopleSmartGrid.Interfaces;

namespace PeopleSmartGrid.Models
{
    public class SeedData
    {
        public static void Seed(IDataContext data)
        {
            PersonType newTypeTea = new PersonType
            {
                TypeId = 1,
                Description = "Teacher"
            };

            PersonType newTypeStud = new PersonType
            {
                TypeId = 2,
                Description = "Student"
            };
            data.AddType(newTypeTea);
            data.AddType(newTypeStud);

            Person newPerson = new Person
            {
                Id = 1,
                Name = "Juan Varner",
                Type = 2,
                Age = 31
            };

            data.AddPerson(newPerson);
        }
    }
}
