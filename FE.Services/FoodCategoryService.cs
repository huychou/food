using FE.Contract;
using FE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FE.Services
{
    public class FoodCategoryService : IFoodCategory
    {
        private DB_FOODEntities dbContext = new DB_FOODEntities();
        public void Add(FoodCategory fc)
        {
            try
            {
                dbContext.FoodCategories.Add(fc);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int ID)
        {
            try
            {
                var entity = dbContext.FoodCategories.Where(x => x.id_FC == ID).FirstOrDefault();
                dbContext.FoodCategories.Remove(entity);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public FoodCategory Find(int ID)
        {
            var entity = dbContext.FoodCategories.Where(x => x.id_FC == ID).FirstOrDefault();
            return entity;
        }

        public List<FoodCategory> GetFoodCategory()
        {
           return dbContext.FoodCategories.ToList();
        }

        public void Update(int ID, FoodCategory fc)
        {
            try
            {
                var entity = dbContext.FoodCategories.Where(x => x.id_FC == ID).FirstOrDefault();

                if (entity != null)
                {
                    entity.name_FC = fc.name_FC;
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
