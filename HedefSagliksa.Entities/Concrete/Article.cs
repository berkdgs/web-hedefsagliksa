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
        public DateTime ReleaseDate { get; set; }
        public long CountOfViews { get; set; }
        public long CountOfLikes { get; set; }

        public int IdentityId { get; set; }
        public Identity Identity { get; set; }
        public Comment Comments { get; set;}
        public int CategoryId { get; set; }
        public Category Category { get; set; }


    }
}
