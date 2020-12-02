using HedefSagliksa.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedefSagliksa.DataAccess.Concrete.EntityFramework.Mapping
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            ToTable(@"Cateogies", @"dbo");
            HasKey(x => x.Id);
            HasMany(x => x.Articles);

            Property(x => x.Name).IsRequired().HasMaxLength(50);
            Property(x => x.Description).IsOptional().HasMaxLength(250);
        }
    }
}
