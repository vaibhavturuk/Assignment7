using Assignment6.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment6.Data.Entity_Models;

namespace Assignment6.Services
{
    public class Services : IServices
    {
        private IRepository<Employee1> empRepository;
        public void DeleteUser(Employee1 emp)
        {
            throw new NotImplementedException();
        }

        public Employee1 GetUser(long id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Employee1> GetUsers()
        {
            throw new NotImplementedException();
        }

        public void InsertUser(Employee1 emp)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(Employee1 emp)
        {
            throw new NotImplementedException();
        }
    }
}
