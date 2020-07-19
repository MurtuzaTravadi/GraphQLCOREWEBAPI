using GraphQL.Types;
using GraphQLWEBAPI.Model.GraphQL;
using GraphQLWEBAPI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLWEBAPI.Model.GraphQLQuery
{
    public class ToDoQuery : ObjectGraphType
    {
        public ToDoQuery(ToDoService toDoService)
        {
            int id = 0;
            //Field<ListGraphType<TodoGraphType>>(
            //name: "todos", resolve: context =>
            //{
            //    return toDoService.GetAllTodos();
            //});
            //Field<TodoGraphType>(
            //    name: "todo",
            //    arguments: new QueryArguments(new
            //    QueryArgument<IntGraphType>
            //    { Name = "id" }),
            //    resolve: context =>
            //    {
            //        id = context.GetArgument<int>("id");
            //        return toDoService.GetTdoById(id);
            //    }
            //);
        }
    }
}
