using HedefSagliksa.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedefSagliksa.DataAccess.Concrete.EntityFramework.Mapping
{
    public class CommentMap : EntityTypeConfiguration<Comment>
    {
        public CommentMap()
        {
            ToTable(@"Comments", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.Title).IsRequired().HasMaxLength(150);
            Property(x => x.CommentContent).IsRequired().HasMaxLength(500);
            Property(x => x.NickName).IsRequired().HasMaxLength(50);
            Property(x => x.CommentDate).IsRequired();
            Property(x => x.ArticleId).IsRequired();
    }
    }
}
