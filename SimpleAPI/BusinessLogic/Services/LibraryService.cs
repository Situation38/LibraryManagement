﻿using SimpleAPI.BusinessLogic.IServices;
using SimpleAPI.DAL.DAO.IDaos;
using SimpleAPI.DAL.Entities;
using SimpleAPI.Dtos;
using SimpleAPI.Dtos.VBM;
using SimpleAPI.Dtos.VM;

namespace SimpleAPI.BusinessLogic.Services
{
    public class LibraryService:BaseService,ILibraryService
    {
       private readonly ILibraryDao _libraryDao;

        public LibraryService(ILibraryDao libraryDao)
        {
            _libraryDao = libraryDao;
        }

        public async Task<Response<LibraryVM>> CreateLibraryAsync(LibraryBM model)
        {

            Library library = new();
            LibraryVM libraryVM = new();
            string message = "OK";

            try
            {

                
                library = library.CopyTOEntity(model);
                library.BaseCreate("",true);
              // _libraryDao.InsertAsync(library);
                
               
            }


            catch (Exception e)
            {
                message = "INTERNAL_SERVER_ERROR";
                if (e.InnerException != null)
                {
                    message = message + ' ' + e.InnerException.Message;
                }

                return new Response<LibraryVM> { Message = message, Total = 0 };
            }

            var response = new Response<LibraryVM>
            {
                Message = message,
                Total = 1,
                Data = libraryVM
            };
            return response;
        }

    }
}