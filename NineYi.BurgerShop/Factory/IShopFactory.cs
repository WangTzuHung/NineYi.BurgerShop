using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineYi.BurgerShop.Factory
{
    public interface IShopFactory
    {
        Shop ChoiceShop();
    }
}
