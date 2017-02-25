using grupoelcomercio.com.api.Commands;
using System.Threading.Tasks;

namespace grupoelcomercio.com.api.CommandHandler
{
    public interface ICommandHandler<T> where T : ICommand
    {
        Task Handle(T command);
    }
}
