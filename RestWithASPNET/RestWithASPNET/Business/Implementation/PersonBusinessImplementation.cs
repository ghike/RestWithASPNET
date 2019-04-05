using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using RestWithASPNET.Model;
using RestWithASPNET.Model.Context;
using RestWithASPNET.Repository;

namespace RestWithASPNET.Business.Implementation
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        private IPersonRepository _repository;
        public PersonBusinessImplementation(IPersonRepository repository)
        {
            _repository = repository;
        }

        private int count;

        public Person Create(Person person)
        {
            return _repository.Create(person);
        }

        public Person Update(Person person)
        {
            return _repository.Update(person);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public Person FindById(long id)
        {
            return _repository.FindById(id);
        }

        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }

        private long IndrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
