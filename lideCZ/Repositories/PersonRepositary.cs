using lideCZ.Database;
using lideCZ.Interfaces;
using lideCZ.Models;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lideCZ.Repositories
{
    public class PersonRepositary : IPersonRepository
    {
        private readonly PersonContext _context;

        public PersonRepositary(PersonContext context)
        {
            _context = context;
        }
        public void Add(Person person)
        {
            _context.Persons.Add(person);
            _context.SaveChanges();
        }

        public void Delete(int? id)
        {
            if (id == null)
            {
                return;
            }
            Person? person = _context.Persons.Find(id);
            if (person != null)
            {
                _context.Persons.Remove(person);
                _context.SaveChanges();
            }
            else throw new NotImplementedException("Person Not Found");
        }

        public List<Person> GetAll()
        {
            return _context.Persons.AsNoTracking().ToList();
        }

        public Person GetById(int? id)
        {
            return _context.Persons.Find(id) ?? throw new NotImplementedException("Person Not Found");
        }

        public void Update(Person person)
        {
            _context.Entry(person).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
