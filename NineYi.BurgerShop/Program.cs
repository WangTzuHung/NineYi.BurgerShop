using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NineYi.BurgerShop.Burgers;
using NineYi.BurgerShop.Breads;
using NineYi.BurgerShop.Veggies;
using NineYi.BurgerShop.Meats;
using NineYi.BurgerShop.Factory;
using NineYi.BurgerShop.Enum;

namespace NineYi.BurgerShop
{
    class Program
    {
        private static ShopFactory shopCreator = new ShopFactory();
        static void Main(string[] args)
        {

            //// 1. 使用者點餐
            var shop = shopCreator.ChoiceShop();
            //// 2. 準備漢堡 
            //// 3. 烹飪漢堡
            shop.ChoiceBurger();
            

            Console.ReadLine();
        }
    }
}
