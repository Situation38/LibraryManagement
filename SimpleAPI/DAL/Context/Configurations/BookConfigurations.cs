using SimpleAPI.DAL.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SimpleAPI.DAL.Context.Configurations
{
    public class BookConfigurations : EntityTypeConfiguration<Book>
    {
        public BookConfigurations()
        {
            Map(m =>
            {
                m.MapInheritedProperties();
            });
        }
    }
}
