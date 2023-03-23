using SimpleAPI.DAL.Entities;
using SimpleAPI.Dtos.VM;
using System.ComponentModel.DataAnnotations;

namespace SimpleAPI.Dtos.VBM
{
    public class LibraryBM
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }

    public static class LibraryCopyData
    {

        /// <summary>
        ///     Use To construct an object with the binding model data
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public static Library CopyTOEntity(this Library entity, LibraryBM model)
        {

            entity.Name = model.Name;

            return entity;
        }

        // <summary>
        ///      Use To construct the View Model object which will be return to the UI
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static LibraryVM CopyTOModel(this Library entity)
        {
            LibraryVM model = new()
            {
                Name = entity.Name,
            };

            return model;

        }
    }
}
