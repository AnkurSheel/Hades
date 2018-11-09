using System.Threading.Tasks;

namespace Hades.Core.GraphQl
{
    public interface IGraphQlService
    {
        Task<T> ExecuteQuery<T>(GraphQlRequest request);
    }
}