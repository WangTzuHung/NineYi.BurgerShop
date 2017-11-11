using NineYi.BurgerShop.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineYi.BurgerShop.Factory
{
    public class ShopFactory : IShopFactory
    {
        public Shop ChoiceShop()
        {
            Console.Write("Which shop do you like? (1)Taipei (2)NewYork (3)Tokyo: ");
            var shop = CreateShop(int.Parse(Console.ReadLine()));

            return shop;
        }

        private Shop CreateShop(int shopEnum)
        {
            Shop newShop;
            switch (shopEnum)
            {
                case (int)ShopNameEnum.Taipei:
                    newShop = new Shop(new TaipeiBurgerFactory());
                    newShop.location = ShopNameEnum.Taipei.ToString();
                    break;
                case (int)ShopNameEnum.NewYork:
                    newShop = new Shop(new NewYorkBurgerFactory());
                    newShop.location = ShopNameEnum.NewYork.ToString();
                    break;
                case (int)ShopNameEnum.Tokyo:
                    newShop = new Shop(new TokyoBurgerFactor());
                    newShop.location = ShopNameEnum.Tokyo.ToString();
                    break;
                default:
                    newShop = new Shop(new TaipeiBurgerFactory());
                    newShop.location = ShopNameEnum.Taipei.ToString();
                    break;
            }

            return newShop;
        }
        
    }
}
