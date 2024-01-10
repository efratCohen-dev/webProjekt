using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUsers
    {
        Task<User> getAll();
        Task<User> get(int id);
        Task<User> newToDo(User u);
        Task<User> delete(int id);
        Task<User> update(User u);
    }
}
