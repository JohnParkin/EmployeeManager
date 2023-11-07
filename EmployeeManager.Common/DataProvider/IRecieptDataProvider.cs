using EmployeeManager.Common.Model;
using System.Collections.Generic;

namespace EmployeeManager.Common.DataProvider
{
    public interface IRecieptDataProvider
    {
        IEnumerable<Reciept> LoadReciepts();
        IEnumerable<Category> LoadCategories();
        void SaveReciept(Reciept reciept);
    }
}
