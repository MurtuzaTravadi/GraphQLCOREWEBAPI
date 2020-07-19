using GraphQL.Types;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLWEBAPI.Model.GraphQL
{
    public class TodoGraphType : ObjectGraphType<TodoItem>
    {
        public TodoGraphType()
        {
            Name = "ToDo";
            Field(_ => _.Id, type:
            typeof(IdGraphType)).Description
           ("The Id Todo app.");
            Field(_ => _.Name).Description
            ("The Todo name.");
            Field(_ => _.IsComplete).Description
            ("Is it completed?");
        }
    }
}
