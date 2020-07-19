using GraphQLWEBAPI.Model;
using System.Collections.Generic;
using System.Linq;

namespace GraphQLWEBAPI.Repository
{
    public class TodoRepository 
    {
        private readonly TODOContext _context;
        public TodoRepository(TODOContext context)
        {
            _context = context;
        }
        public List<TodoItem> GetAllTodos()
        {
            return _context.TodoItems.ToList();
            
        }

        public TodoItem GetTdoById(int Id)
        {
            return _context.TodoItems.FirstOrDefault(x => x.Id == Id);
        }
    }
} 
