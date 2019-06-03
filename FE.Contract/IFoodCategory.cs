using FE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FE.Contract
{
    public interface IFoodCategory
    {
        void Add(FoodCategory fc);
        void Update(int ID, FoodCategory fc);
        void Delete(int ID);

        FoodCategory Find(int ID);

        List<FoodCategory> GetFoodCategory();        

    }
}
