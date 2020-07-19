using GraphQL;
using GraphQL.Types;
using GraphQLWEBAPI.Model.GraphQLQuery;

namespace GraphQLWEBAPI.Interface
{
    public class GraphQLDemoSchema : Schema, ISchema
    {
        public GraphQLDemoSchema(IDependencyResolver
        resolver) : base(resolver)
        {
            Query = resolver.Resolve<AuthorQuery>();
            //Query = resolver.Resolve<ToDoQuery>();
        }
    }
}
