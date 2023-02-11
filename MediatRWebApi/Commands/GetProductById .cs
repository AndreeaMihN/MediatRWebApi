using MediatR;

namespace MediatRWebApi.Commands
{
    public record GetProductByIdQuery(int Id) : IRequest<Product>;
}
