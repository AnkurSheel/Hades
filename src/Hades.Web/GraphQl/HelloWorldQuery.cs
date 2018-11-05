
using GraphQL.Types;

namespace Hades.Web.GraphQl
{
    public class HelloWorldQuery : ObjectGraphType
    {
        public HelloWorldQuery()
        {
            Field<StringGraphType>("hello", resolve: context => "world");
        }
    }
}
