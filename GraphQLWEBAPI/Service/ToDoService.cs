using GraphQLWEBAPI.Model;
using GraphQLWEBAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLWEBAPI.Service
{
    public class ToDoService
    {
        private readonly TodoRepository _ToDoRepository;
        public ToDoService(TodoRepository
               ToDoRepository)
        {
            _ToDoRepository = ToDoRepository;
        }
        public List<TodoItem> GetAllTodos()
        {
            return _ToDoRepository.GetAllTodos();
        }
        public TodoItem GetTdoById(int id)
        {
            return _ToDoRepository.GetTdoById(id);
        }
    }
}
