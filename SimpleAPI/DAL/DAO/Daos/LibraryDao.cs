using SimpleAPI.DAL.DAO.IDaos;
using SimpleAPI.DAL.Entities;
using SimpleAPI.Data.Repository;

namespace SimpleAPI.DAL.DAO.Daos
{
    public class LibraryDao : RepositoryAsync<Library>, ILibraryDao
    {
        public LibraryDao() : base(Ctx)
        {
        }
        
    }
}
