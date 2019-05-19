using SaintNicholas.Post;

namespace SaintNicholas.Mediator
{
    public interface IMediator
    {
        void Send(IProduct postProduct, Colleague colleague);
    }
}
