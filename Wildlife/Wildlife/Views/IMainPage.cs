using System.Threading.Tasks;

namespace Wildlife.Views
{
    public interface IMainPage
    {
        Task NavigateFromMenu(int id);
    }
}