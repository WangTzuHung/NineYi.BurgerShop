using NineYi.BurgerShop.Burgers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineYi.BurgerShop.Factory
{
    public interface IBurgerFactory
    {
        /// <summary>
        /// 香雞堡
        /// </summary>
        /// <returns>漢堡</returns>
        Burger MakeChickenBurger();

        /// <summary>
        /// 豬肉堡
        /// </summary>
        /// <returns>漢堡</returns>
        Burger MakePorkBurger();
    }
}
