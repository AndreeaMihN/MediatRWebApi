using MediatR;

namespace MediatRWebApi.Commands
{
    public record AddProductCommand(Product Product) : IRequest<Product>;
}