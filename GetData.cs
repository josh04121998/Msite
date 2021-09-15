using Msite.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msite
{
    public class GetData
    {
        private List<DepartmentDTO> ListOfDepartment;
        private List<PersonDTO> ListOfPeople;

        public GetData(
            List<DepartmentDTO> listOfDepartment,
            List<PersonDTO> listOfPeople)
        {
            ListOfDepartment = listOfDepartment;
            ListOfPeople = listOfPeople;
        }

        public List<string> GetSurnamesOfPeopleInTheDepartment(string departmentName)
        {
            var department = ListOfDepartment.Where(x => x.Name.ToLower() == departmentName.ToLower());
            var people = department.FirstOrDefault().Members;
            List<string> surnames = new();
            foreach(PersonDTO person in people)
            {
                surnames.Add(person.Surname);
            }
            return surnames;
        }

        public List<string> GetDepartmentPersonIsIn(string forename, string surname)
        {
            List<string> departmentNames = new();
            foreach (DepartmentDTO department in ListOfDepartment)
            {
                foreach (PersonDTO personDTO in department.Members)
                {
                    if (personDTO.Forename == forename && personDTO.Surname == surname)
                    {
                        departmentNames.Add(department.Name);
                    }
                }
            }
            return departmentNames;
        }
    }
}
