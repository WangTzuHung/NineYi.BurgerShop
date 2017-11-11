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
    public class NewYorkBurgerFactory : DefaultBurgerFactory
    {
        public NewYorkBurgerFactory()
        {
            this._bread = new WheatBread();
            this._veggie = new Onion();
            this._chickenMeat = new Turkey();
            this._porkMeat = new Bacon();
        }

        public override Burger MakeChickenBurger()
        {
            Burger burger = new Burger();
            burger.Name = "NewYork Chicken Burger";
            burger.Bread = this._bread;
            burger.Meat = this._chickenMeat;
            burger.Veggie = this._veggie;

            return burger;
        }

        public override Burger MakePorkBurger()
        {
            Burger burger = new Burger();
            burger.Name = "NewYork Pork Burger";
            burger.Bread = this._bread;
            burger.Meat = this._porkMeat;
            burger.Veggie = this._veggie;

            return burger;
        }
    }
}
