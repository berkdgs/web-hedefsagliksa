using HedefSagliksa.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedefSagliksa.DataAccess.Concrete.EntityFramework.Mapping
{
    public class ArticleMap : EntityTypeConfiguration<Article>
    {
        public ArticleMap()
        {
            ToTable(@"Articles", @"dbo");
            HasKey(x => x.Id);
            HasMany(x => x.Comments);

            Property(x => x.Title).IsRequired().HasMaxLength(100);
            Property(x => x.ArticleContent).IsRequired().HasMaxLength(int.MaxValue);
            Property(x => x.Image).IsOptional().HasMaxLength(2083);
            Property(x => x.LikesCount).IsRequired();
            Property(x => x.ViewsCount).IsRequired();
            Property(x => x.Tag).IsOptional();
            Property(x => x.ReleaseDate).IsRequired();
            Property(x => x.Active).IsRequired();
            Property(x => x.HomePage).IsRequired();
            Property(x => x.IdentityId).IsRequired();
            Property(x => x.CategoryId).IsRequired();
            
        }
    }
}
