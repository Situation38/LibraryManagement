using SimpleAPI.DAL.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SimpleAPI.DAL.Context.Configurations
{
    public class LibraryConfigurations : EntityTypeConfiguration<Library>
    {
        public LibraryConfigurations()
        {
            Map(m =>
            {
                m.MapInheritedProperties();
            });
        }
    }
}
