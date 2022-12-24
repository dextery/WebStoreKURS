using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStoreKURS.Data.Models;

namespace WebStoreKURS.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            content.Database.Migrate();

            if (!content.Category.Any())
            {
                content.Category.AddRange(Categoris.Select(c => c.Value));
            }

            if (!content.Part.Any())
            {
                content.AddRange(
                    new Parts
                    {
                        name = "NVIDIA Geforce GTX 1650",
                        shortDesc = "Видеокарта серии GeForce GTX 16",
                        longDesc = "Видеокарта серии GeForce GTX 16. Мощность карты делает её очень выгодной для покупки несмотря на относительно меньший уровень мощности по сравнению с другими картами NVIDIA.",
                        img = "/img/Nvidia-GeForce-GTX-1650-6.jpg",
                        price = 30190,
                        isFavourite = true,
                        isavailable = true,
                        Category = Categoris["Графическая карта"]
                    },
                     new Parts
                     {
                         name = "Intel Core i5-10400F",
                         shortDesc = "Процессор Intel Core серии i5",
                         longDesc = "Процессор Intel Core 5 поколения модель 10400. Ядерная формула 6/12, кэш память третьего уровня объёмом 12 Мбайт и расчитаны на работу в диапазоня от 2,9 ГГц до 4,3 ГГц.",
                         img = "/img/intel-core-i5f-10th.jpg",
                         price = 11990,
                         isFavourite = false,
                         isavailable = true,
                         Category = Categoris["Процессор"]
                     },
                      new Parts
                      {
                          name = "Оперативная память DDR4 8Gb ",
                          shortDesc = "Четвёртое поколение DDR 8Гб памяти",
                          longDesc = "Четвёртое поколение DDR SDRAM. Содержит 8Гб памяти, имеет пониженное рабочее напряжение и высокую плотность памяти по сравнению с DDR3.",
                          img = "/img/1_small.jpg",
                          price = 2190,
                          isFavourite = false,
                          isavailable = true,
                          Category = Categoris["Оперативная память"]
                      },
                      new Parts
                      {
                          name = "Оперативная память DDR4 16Gb ",
                          shortDesc = "Четвёртое поколение DDR 16Гб памяти",
                          longDesc = "Четвёртое поколение DDR SDRAM. Содержит 16Гб памяти, имеет пониженное рабочее напряжение и высокую плотность памяти по сравнению с DDR3.",
                          img = "/img/14800.970.jpg",
                          price = 4835,
                          isFavourite = false,
                          isavailable = false,
                          Category = Categoris["Оперативная память"]
                      },
                       new Parts
                       {
                           name = "NVIDIA Geforce GTX 1050TI",
                           shortDesc = "Видеокарта серии GeForce GTX 10",
                           longDesc = "Видеокарта серии GeForce GTX 10. Огромная мощность для своего времени, способна выводить изображение плоть до 8К и имеет высокий дианамический диапазон (HDR).",
                           img = "/img/GeForce_GTX_1050_Ti_Partner_GALAX_E2AFC8D40E284EC9893ACED4B668269C.jpg",
                           price = 21000,
                           isFavourite = false,
                           isavailable = false,
                           Category = Categoris["Графическая карта"]
                       }
                    );
            }

            content.SaveChanges();
        }
        private static Dictionary<string, Categories> category;
        public static Dictionary<string, Categories> Categoris
        {
            get
            {
                if (category == null)
                {
                    var list = new Categories[]
                    {
                        new Categories { categoryname = "Графическая карта", catedesc = "Позволяет отображать графические ресурсы" },
                        new Categories { categoryname = "Процессор", catedesc = "Главный мозг компьютера" },
                        new Categories { categoryname = "Оперативная память", catedesc = "Обеспечивает безперебойную работу компьютера" },
                    };
                    category = new Dictionary<string, Categories>();
                    foreach(Categories el in list)
                        category.Add(el.categoryname, el);

                }
                return category;
            }
        }
    }
}
