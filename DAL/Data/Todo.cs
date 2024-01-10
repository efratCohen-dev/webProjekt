using DAL.Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data
{
    internal class Todo : ITodo
    {
        public Task<TodoItem> delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TodoItem> get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TodoItem> getAll()
        {
            throw new NotImplementedException();
        }

        public Task<TodoItem> newToDo(TodoItem t)
        {
            throw new NotImplementedException();
        }

        public Task<TodoItem> update(TodoItem t)
        {
            throw new NotImplementedException();
        }
    }
}
