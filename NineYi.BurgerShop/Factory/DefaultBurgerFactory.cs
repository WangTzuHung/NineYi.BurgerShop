using NineYi.BurgerShop.Breads;
using NineYi.BurgerShop.Burgers;
using NineYi.BurgerShop.Meats;
using NineYi.BurgerShop.Veggies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineYi.BurgerShop.Factory
{
    public abstract class DefaultBurgerFactory : IBurgerFactory
    {
        protected Bread _bread;
        protected Veggie _veggie;
        protected Meat _chickenMeat;
        protected Meat _porkMeat;
        public abstract Burger MakeChickenBurger();

        public abstract Burger MakePorkBurger();

    }
    
}
