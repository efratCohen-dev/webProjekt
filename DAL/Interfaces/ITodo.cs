using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.Interfaces
{
    public interface ITodo
    {
        Task<TodoItem> getAll();
        Task<TodoItem> get(int id);
        Task<TodoItem> newToDo(TodoItem t);
        Task<TodoItem> delete(int id);
        Task<TodoItem> update(TodoItem t);
    }
}
