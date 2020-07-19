using GraphQL.Types;
using GraphQLWEBAPI.Model.GraphQL;
using GraphQLWEBAPI.Service;

namespace GraphQLWEBAPI.Model.GraphQLQuery
{
    public class AuthorQuery : ObjectGraphType
    {
        public AuthorQuery(AuthorService authorService, ToDoService toDoService)
        {
            int id = 0;
            Field<ListGraphType<AuthorType>>(
            name: "authors", resolve: context =>
            {
                return authorService.GetAllAuthors();
            });
            Field<AuthorType>(
                name: "author",
                arguments: new QueryArguments(new
                QueryArgument<IntGraphType>
                { Name = "id" }),
                resolve: context =>
                {
                    id = context.GetArgument<int>("id");
                    return authorService.GetAuthorById(id);
                }
            );
            Field<ListGraphType<BlogPostType>>(
                name: "blogs",
                arguments: new QueryArguments(new
                QueryArgument<IntGraphType>
                { Name = "id" }),
                resolve: context =>
                {
                    return authorService.GetPostsByAuthor(id);
                }
            );
            Field<ListGraphType<TodoGraphType>>(
           name: "todos", resolve: context =>
           {
               return toDoService.GetAllTodos();
           });
            Field<TodoGraphType>(
                name: "todo",
                arguments: new QueryArguments(new
                QueryArgument<IntGraphType>
                { Name = "id" }),
                resolve: context =>
                {
                    id = context.GetArgument<int>("id");
                    return toDoService.GetTdoById(id);
                }
            );
        }
    }
}
