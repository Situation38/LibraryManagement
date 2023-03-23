using SimpleAPI.BusinessLogic.IServices;
using SimpleAPI.DAL.DAO.IDaos;
using SimpleAPI.DAL.Entities;
using SimpleAPI.Dtos;
using SimpleAPI.Dtos.VBM;
using SimpleAPI.Dtos.VM;
using SimpleAPI.Helpers;

namespace SimpleAPI.BusinessLogic.Services
{
    public class LibraryService:BaseService,ILibraryService
    {
       private readonly ILibraryDao _libraryDao;

        public LibraryService(ILibraryDao libraryDao)
        {
            _libraryDao = libraryDao;
        }

        /// <summary>
        ///     Service for create library
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<Response<LibraryVM>> CreateLibraryAsync(LibraryBM model)
        {

            Library library = new();
            LibraryVM libraryVM = new();
            string message = MsgUtils.OK;

            try
            {

                
                library.CopyTOEntity(model);
                library.BaseCreate("",true);
                await _libraryDao.InsertAsync(library);

                if (library != null)
                {
                    libraryVM = library.CopyTOModel();
                }

            }


            catch (Exception e)
            {
                message =MsgUtils.INTERNAL_SERVER_ERROR;
                if (e.InnerException != null)
                {
                    message = message + ' ' + e.InnerException.Message;
                }

                return new Response<LibraryVM> { Message = message, Total = 0, HttpStatus = MsgUtils.HTTP_500 };
            }

            var response = new Response<LibraryVM>
            {
                Message = message,
                Total = 1,
                Data = libraryVM,
                HttpStatus = MsgUtils.HTTP_200,
                Success = true
            };
            return response;
        }



        // <summary>
        ///     Service for get libraries
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<Response<List<LibraryVM>>> GetAllLibraryAsync()
        {
            string message = MsgUtils.OK;
            List<LibraryVM> libraryVm = new();
            int total = 0;

            try
            {
                var libraries = await _libraryDao.GetAllAsync();;

                if (libraries.Equals(null))
                {
                    return new Response<List<LibraryVM>>
                    {
                        Message = MsgUtils.NOT_FOUND,
                        Success = false,
                        HttpStatus = MsgUtils.HTTP_404
                    };

                }

                total = libraries.Count;

               
                foreach (var library in libraries)
                {
                    if (!library.IsActive)
                    {
                        continue;
                    }
                    LibraryVM _libraryVm = new();
                    _libraryVm = library.CopyTOModel();
                    libraryVm.Add(_libraryVm);
                }
            }
            catch (Exception e)
            {
                message = MsgUtils.INTERNAL_SERVER_ERROR;
                if (e.InnerException != null)
                {
                    message = message + ' ' + e.InnerException.Message;
                }

                return new Response<List<LibraryVM>> { Message = message, Total = 0, HttpStatus = MsgUtils.HTTP_500, };
            }

            var response = new Response<List<LibraryVM>>
            {
                Message = message,
                Total = total,
                Data = libraryVm,
                HttpStatus = MsgUtils.HTTP_200,
                Success = true
                
            };

            return response;
        }

        /// <summary>
        ///     sercice  for get a specific Library
        /// </summary>
        /// <param name="LibraryId"></param>
        /// <returns></returns>
        public async Task<Response<LibraryVM>> GetLibraryByIdAsync(int LibraryId)
        {
            string message = MsgUtils.OK;
            LibraryVM libraryVM = new();

            try
            {
                var library = await _libraryDao.GetByIdAsync(LibraryId);

                if (library == null || !library.IsActive)
                {
                    return new Response<LibraryVM> { Message = MsgUtils.NOT_FOUND, Total = 0 ,HttpStatus = MsgUtils.HTTP_500};
                }
                libraryVM = library.CopyTOModel();

            }
            catch (Exception e)
            {
                message = MsgUtils.INTERNAL_SERVER_ERROR;
                if (e.InnerException != null)
                {
                    message = message + ' ' + e.InnerException.Message;
                }

                return new Response<LibraryVM> { Message = message, Total = 0 , HttpStatus = MsgUtils.HTTP_500 };
            }

            var response = new Response<LibraryVM>
            {
                Message = message,
                Total = 1,
                Data = libraryVM,
                HttpStatus = MsgUtils.HTTP_200,
                Success = true
            };

            return response;
        }

    }
}
