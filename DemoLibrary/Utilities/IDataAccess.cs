using System.Threading.Tasks;

namespace DemoLibrary.Utilities
{
    public interface IDataAccess
    {
        Task  LoadData();
        Task SaveData(string name);
    }
}