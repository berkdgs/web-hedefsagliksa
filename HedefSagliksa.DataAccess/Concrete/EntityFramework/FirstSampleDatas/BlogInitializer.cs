using HedefSagliksa.DataAccess.Concrete.EntityFramework.Context;
using HedefSagliksa.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedefSagliksa.DataAccess.Concrete.EntityFramework.FirstSampleDatas
{
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<HSContext>
    {
        protected override void Seed(HSContext context)
        {
            List<Category> categories = new List<Category>
            {
                new Category{ Name="Diyet", Description="Zayıflama rejimleri"},
                new Category{ Name="Beslenme", Description="Sağlıklı beslenme"}
            };

            context.Categories.AddRange(categories);
            context.SaveChanges();

            List<Role> roles = new List<Role>
            {
                new Role{ RoleName="Administrators", RoleDescription="Administrators"},
                new Role{ RoleName="Users", RoleDescription="Users"}
            };

            context.Roles.AddRange(roles);
            context.SaveChanges();

            List<Identity> identities = new List<Identity>
            {
                new Identity{ UserName="admin", Password="123456", Name="Berk", Surname="Doğuş", EMail="berk.dogus@gmail.com", RoleId=1},
                new Identity{ UserName="atekes", Password="24680", Name="Aysun", Surname="Tekeş", EMail="aysuntekesyuksel@gmail.com", RoleId=2}
            };

            context.Identities.AddRange(identities);
            context.SaveChanges();


            List<Article> articles = new List<Article>
            {
                new Article{ Title="Her Yönüyle Ketojenik Diyet", ArticleContent="Vücut enerji sağlamak için karbobhidratları direk kullanabilirken yağları kullanamaz. Bu yüzden karaciğerin önce yağları parçalayıp keton adı verilen maddelere çevirmesi gerekmektedir. Bunu sağlamak için vücut “ketozis” denilen bir biyolojik duruma girer. Bu durumda karbonhidrat alımı sınırlı olduğundan kandaki şeker düşmüş, vücut enerji sağlamak için yağların kapısını çalmıştır. Yağlar karaciğerin salgıladığı enzimlerle parçalanıp ketonlar oluşmuş yakıt kaynağı olarak bu oluşan ketonlar kullanılmaya başlanmıştır. Kan şekerinin yükselmemesi insülin salgısını ve şeker düzeyini dengede tutarak ,açlık hissetme süresini uzatmıştır.", Tag="Ketojenik", ReleaseDate = new DateTime(2020, 11,1), Active = true, HomePage=true, LikesCount=0, ViewsCount=0, CategoryId=1, IdentityId=2},
                new Article{ Title="Her Yönüyle Ketojenik Diyet1", ArticleContent="Vücut enerji sağlamak için karbobhidratları direk kullanabilirken yağları kullanamaz. Bu yüzden karaciğerin önce yağları parçalayıp keton adı verilen maddelere çevirmesi gerekmektedir. Bunu sağlamak için vücut “ketozis” denilen bir biyolojik duruma girer. Bu durumda karbonhidrat alımı sınırlı olduğundan kandaki şeker düşmüş, vücut enerji sağlamak için yağların kapısını çalmıştır. Yağlar karaciğerin salgıladığı enzimlerle parçalanıp ketonlar oluşmuş yakıt kaynağı olarak bu oluşan ketonlar kullanılmaya başlanmıştır. Kan şekerinin yükselmemesi insülin salgısını ve şeker düzeyini dengede tutarak ,açlık hissetme süresini uzatmıştır.", Tag="Ketojenik", ReleaseDate = new DateTime(2020, 11,1), Active = true, HomePage=true, LikesCount=0, ViewsCount=0, CategoryId=1, IdentityId=2},
                new Article{ Title="Fermante Gıdaların Önemi", ArticleContent="Fermantasyon (mayalanma), bir maddenin bakteriler, mantarlar ve diğer mikroorganizmalar aracılığıyla, genellikle ısı vererek ve köpürerek kimyasal olarak çürümesi olayıdır. Fermentasyon için gerekli şartların sağlanması çok önemlidir. Bu şartlar; uygun ısı, kaliteli hammadde ve uygun PH değeri yani asitliktir. Fermentasyon sonucu oluşan gıdaya fermente ürün denir. Fermente ürünler, sağlık açısından önemli ve besin değeri bakımından oldukça zengindir. Bir çok dünya mutfağında bulunan fermente gıdaların Türk Mutfağındaki yeride yadsınamaz.", Tag="Fermante, Gıda", ReleaseDate = new DateTime(2020, 12,1), Active = true, HomePage=true, LikesCount=0, ViewsCount=0, CategoryId=2, IdentityId=2}
            };

            context.Articles.AddRange(articles);
            context.SaveChanges();

            List<Comment> comments = new List<Comment>
            {
                new Comment{ CommentDate=new DateTime(2020,12,2), Title="Çok güzel yazı", CommentContent="Güzel bir yazı olmuş devamını bekliyoruz.", NickName="idogus", ArticleId=1},
                new Comment{ CommentDate=new DateTime(2020,12,2), Title="Berbat", CommentContent="Herkes kendini uzman sanıyor.", NickName="bdogus", ArticleId=1},
                new Comment{ CommentDate=new DateTime(2020,12,1), Title="Harika...Tam aradığım yazı", CommentContent="Günümüzde nasıl beslenmemiz gerektiğini bilmeliyiz", NickName="bdogus", ArticleId=2}
            };

            context.Commnets.AddRange(comments);
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
