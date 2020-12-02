using HedefSagliksa.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedefSagliksa.Entities.Concrete
{
    public class Comment : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string CommentContent { get; set; }
        public DateTime CommentDate { get; set; }
        public string NickName { get; set; }

        public int ArticleId { get; set; }
        public Article Article { get; set; }
    }
}
