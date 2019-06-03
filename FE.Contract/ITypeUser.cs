using FE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FE.Contract
{
    public interface ITypeUser
    {
        void Add(TypeUser student);
        void Update(int ID, TypeUser student);
        void Delete(int ID);

        TypeUser Find(int ID);

        List<TypeUser> GetTypeUser();
    }
}
