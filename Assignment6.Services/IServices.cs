using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment6.Data.Entity_Models;

namespace Assignment6.Services
{
    public interface IServices
    {
        IQueryable<Employee1> GetUsers();
        Employee1 GetUser(long id);
        void InsertUser(Employee1 emp);
        void UpdateUser(Employee1 emp);
        void DeleteUser(Employee1 emp);
    }
}
