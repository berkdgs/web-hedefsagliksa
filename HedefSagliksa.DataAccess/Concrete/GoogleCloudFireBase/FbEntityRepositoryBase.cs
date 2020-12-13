using Google.Cloud.Firestore;
using HedefSagliksa.DataAccess.Abstract;
using HedefSagliksa.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HedefSagliksa.DataAccess.Concrete.GoogleCloudFireBase
{
    public class FbEntityRepositoryBase<TEntity> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
    {
        FirestoreDb _db;
        public FbEntityRepositoryBase()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"Credentials\hedefsagliksa.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            _db = FirestoreDb.Create("hedefsagliksa-ccf1a");
        }

        public void Add(TEntity entity)
        {
            CollectionReference collection = _db.Collection(typeof(TEntity).Name.ToLower());
            collection.AddAsync(entity);
        }

        public void Delete(TEntity entity)
        {
            DocumentReference documentReference = _db.Collection(typeof(TEntity).Name.ToLower())
                                                     .Document(entity.GetType().GetProperty("Id").GetValue(entity).ToString());
            documentReference.DeleteAsync();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            Query query = _db.Collection(typeof(TEntity).Name.ToLower());
            QuerySnapshot documentSnapshots = query.GetSnapshotAsync().Result;
            List<TEntity> entities = new List<TEntity>();
            foreach (var item in documentSnapshots)
            {
                if (item.Exists)
                {
                    TEntity entity = item.ConvertTo<TEntity>();
                    entities.Add(entity);
                }
            }
            return entities;
        }

        public TEntity GetById(string id)
        {
            DocumentReference documentReference = _db.Collection(typeof(TEntity).Name.ToLower()).Document(id);
            return documentReference.GetSnapshotAsync().Result.ConvertTo<TEntity>();
        }

        public void Update(TEntity entity)
        {
            DocumentReference documentReference = _db.Collection(typeof(TEntity).Name.ToLower())
                                                    .Document(entity.GetType().GetProperty("Id").GetValue(entity).ToString());
            documentReference.SetAsync(entity);
        }
    }
}
