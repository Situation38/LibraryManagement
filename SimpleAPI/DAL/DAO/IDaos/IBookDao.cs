using SimpleAPI.DAL.Entities;
using SimpleAPI.DAL.Repository;

namespace SimpleAPI.DAL.DAO.IDaos
{
    public interface IBookDao: IAsyncRepository<Book>
    {
    }
}
