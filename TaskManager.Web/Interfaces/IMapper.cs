using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Web.Interfaces
{
    public interface IMapper<T, U>
    {
        T Map(U entity);
    }
}
