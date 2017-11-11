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
    public class TaipeiBurgerFactory : DefaultBurgerFactory
    {
        public TaipeiBurgerFactory()
        {
            this._bread = new WhiteBread();
            this._veggie = new Tomato();
            this._chickenMeat = new TaiwanChicken();
            this._porkMeat = new Tenderloin();
        }
        
        public override Burger MakeChickenBurger()
        {
            Burger burger = new Burger();
            burger.Name = "Taipei Chicken Burger";
            burger.Bread = this._bread;
            burger.Meat = this._chickenMeat;
            burger.Veggie = this._veggie;

            return burger;
        }

        public override Burger MakePorkBurger()
        {
            Burger burger = new Burger();
            burger.Name = "Taipei Pork Burger";
            burger.Bread = this._bread;
            burger.Meat = this._porkMeat;
            burger.Veggie = this._veggie;

            return burger;
        }
    }
}
