using HedefSagliksa.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedefSagliksa.DataAccess.Concrete.EntityFramework.Mapping
{
    public class IdentityMap : EntityTypeConfiguration<Identity>
    {
        public IdentityMap()
        {
            ToTable(@"Identities", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.Name).IsRequired().HasMaxLength(100);
            Property(x => x.Surname).IsOptional().HasMaxLength(100);
            Property(x => x.UserName).IsRequired().HasMaxLength(50);
            Property(x => x.Password).IsRequired().HasMaxLength(16);
            Property(x => x.EMail).IsRequired();
            Property(x => x.RoleId).IsRequired();
        }
    }
}
