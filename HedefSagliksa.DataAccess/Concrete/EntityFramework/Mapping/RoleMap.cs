using HedefSagliksa.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedefSagliksa.DataAccess.Concrete.EntityFramework.Mapping
{
    public class RoleMap : EntityTypeConfiguration<Role>
    {
        public RoleMap()
        {
            ToTable(@"Roles", @"dbo");
            HasKey(x => x.Id);
            HasMany(x => x.Identities);

            Property(x => x.RoleName).IsRequired().HasMaxLength(50);
            Property(x => x.RoleDescription).IsOptional().HasMaxLength(200);
        }
    }
}
