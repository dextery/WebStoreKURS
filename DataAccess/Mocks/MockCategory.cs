using DataAccess.Entities;
using DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Mocks
{
	public class MockCategory : IPartsCategory
    {
        public IEnumerable<Categories> AllCategories
        {
            get
            {
                return new List<Categories>
                {
                    new Categories { Categoryname = "Графическая карта", catedesc = "Позволяет отображать графические ресурсы" },
                    new Categories { Categoryname = "Процессор", catedesc = "Главный мозг компьютера" },
                    new Categories { Categoryname = "Оперативная память", catedesc = "Обеспечивает безперебойную работу компьютера"},
                };
            }
        }
    }
}
