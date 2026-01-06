using lideCZ.Interfaces;
using lideCZ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace lideCZ.Managers
{
    public class PersonManager : IPersonManager
    {
        private readonly IPersonRepository _personRepository;
        public PersonManager(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public void Add(Person person)
        {
            _personRepository.Add(person);
        }

        public void Delete(int? id)
        {
            _personRepository.Delete(id);
        }

        public List<Person> GetAll()
        {
            return _personRepository.GetAll();
        }

        public Person GetById(int? id)
        {
            return _personRepository.GetById(id);
        }

        public void Update(Person person)
        {
            _personRepository.Update(person);
        }
    }
}
