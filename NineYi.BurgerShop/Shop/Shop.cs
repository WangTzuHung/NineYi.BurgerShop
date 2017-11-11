using NineYi.BurgerShop.Burgers;
using NineYi.BurgerShop.Enum;
using NineYi.BurgerShop.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineYi.BurgerShop
{
    /// <summary>
    /// 漢堡店
    /// </summary>
    public class Shop
    {
        /// <summary>
        /// 漢堡工廠
        /// </summary>
        private IBurgerFactory _burgers;

        public Shop(IBurgerFactory Burgers)
        {
            this._burgers = Burgers;
        }

        /// <summary>
        /// 地點
        /// </summary>
        public string location { get; set; }

        public void ChoiceBurger()
        {
            Console.Write("What burger would you like? (1)Chicken (2)Pork: ");
            MakeBurger(int.Parse(Console.ReadLine()));
        }

        private void MakeBurger(int burgerEnum)
        {
            switch (burgerEnum)
            {
                case (int)BurgerEnum.Chicken:
                    this._burgers.MakeChickenBurger().Cook();
                    break;
                case (int)BurgerEnum.Pork:
                    this._burgers.MakePorkBurger().Cook();
                    break;
                default:
                    this._burgers.MakeChickenBurger().Cook();
                    break;
            }

        }
    }
}
