using HedefSagliksa.DataAccess.Concrete.EntityFramework.FirstSampleDatas;
using HedefSagliksa.DataAccess.Concrete.EntityFramework.Mapping;
using HedefSagliksa.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedefSagliksa.DataAccess.Concrete.EntityFramework.Context
{
    public class HSContext : DbContext
    {
        public HSContext()
        {
            Database.SetInitializer(new BlogInitializer());
        }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Commnets { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Identity> Identities { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ArticleMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new CommentMap());
            modelBuilder.Configurations.Add(new RoleMap());
            modelBuilder.Configurations.Add(new IdentityMap());
        }
    }
}
