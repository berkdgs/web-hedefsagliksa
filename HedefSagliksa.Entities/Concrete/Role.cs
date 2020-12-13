using HedefSagliksa.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedefSagliksa.Entities.Concrete
{
    public class Role : IEntity
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }

        public virtual ICollection<Identity> Identities { get; set; }

    }
}
