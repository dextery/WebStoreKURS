using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStoreKURS.Data.Interfaces;
using WebStoreKURS.Data.Models;

namespace WebStoreKURS.Data.Mocks
{
    public class MockCategory : IPartsCategory
    {
        public IEnumerable<Categories> AllCategories 
        { 
            get
            {
                return new List<Categories>
                {
                    new Categories { categoryname = "Графическая карта", catedesc = "Позволяет отображать графические ресурсы" },
                    new Categories { categoryname = "Процессор", catedesc = "Главный мозг компьютера" },
                    new Categories { categoryname = "Оперативная память", catedesc = "Обеспечивает безперебойную работу компьютера"},
                };
            }
        }
    }
}
