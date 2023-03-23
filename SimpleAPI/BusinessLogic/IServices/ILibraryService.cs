using SimpleAPI.Dtos.VBM;
using SimpleAPI.Dtos.VM;
using SimpleAPI.Dtos;

namespace SimpleAPI.BusinessLogic.IServices
{
    public interface ILibraryService:IBaseService
    {
        public Task<Response<LibraryVM>> CreateLibraryAsync(LibraryBM model);
        public Task<Response<List<LibraryVM>>> GetAllLibraryAsync();

        public Task<Response<LibraryVM>> GetLibraryByIdAsync(int LibraryId);
    }
}
