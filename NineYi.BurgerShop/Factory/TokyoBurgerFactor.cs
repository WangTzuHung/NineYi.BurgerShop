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
    public class TokyoBurgerFactor : DefaultBurgerFactory
    {
        public TokyoBurgerFactor()
        {
            this._bread = new GrainBread();
            this._veggie = new Cabbage();
            this._chickenMeat = new JapanChicken();
            this._porkMeat = new WagyuPork();
        }

        public override Burger MakeChickenBurger()
        {
            Burger burger = new Burger();
            burger.Name = " Tokyo Chicken Burger";
            burger.Bread = this._bread;
            burger.Meat = this._chickenMeat;
            burger.Veggie = this._veggie;

            return burger;
        }

        public override Burger MakePorkBurger()
        {
            Burger burger = new Burger();
            burger.Name = " Tokyo Pork Burger";
            burger.Bread = this._bread;
            burger.Meat = this._porkMeat;
            burger.Veggie = this._veggie;

            return burger;
        }
    }
}
