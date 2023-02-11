using MediatR;

namespace MediatRWebApi.Queries
{
    public record GetProductsQuery : IRequest<IEnumerable<Product>>
    {
    }
}
