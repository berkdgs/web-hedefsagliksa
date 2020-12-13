using HedefSagliksa.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedefSagliksa.Entities.Concrete
{
    public class Article : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ArticleContent { get; set; }
        public long LikesCount { get; set; }
        public long ViewsCount { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Tag { get; set; }
        public string Image { get; set; }
        public bool HomePage { get; set; }
        public bool Active { get; set; }

        public int IdentityId { get; set; }
        public virtual Identity Identity { get; set; }
        public string CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
