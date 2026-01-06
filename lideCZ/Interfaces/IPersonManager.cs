using lideCZ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lideCZ.Interfaces
{
    public interface IPersonManager
    {
        public Person GetById(int? id);
        public List<Person> GetAll();

        public void Add(Person person);
        public void Update(Person person);
        public void Delete(int? id);
    }
}
