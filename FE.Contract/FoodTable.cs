using FE.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FE.Contract
{
    public interface IFoodTable
    {
        void Add(FoodTable enrollment);
        void Update(int ID, FoodTable enrollment);
        void Delete(int ID);

        FoodTable Find(int ID);

        List<FoodTable> GetFoodTable();
    }
}
