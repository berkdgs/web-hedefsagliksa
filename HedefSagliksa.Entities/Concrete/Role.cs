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
        public string RoleId { get; set; }
        public string RoleDescription { get; set; }

        public Identity Identities { get; set; }

    }
}
