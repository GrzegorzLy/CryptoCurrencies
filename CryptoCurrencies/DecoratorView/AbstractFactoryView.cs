using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencies.DecoratorView
{
    abstract class AbstractFactoryView
    {
        public abstract IConsoleView GetView(Market.MarketAbstract marketAbstract, User user);
        public static AbstractFactoryView getFactory(Enum.ViewEnum viewEnum)
        {
            switch (viewEnum)
            {
                case Enum.ViewEnum.MainWindow:
                    return new AbstractFactoryMainWindow();
                case Enum.ViewEnum.Menu:
                    return new AbstractFactoryMenu();
                default:
                    return null;
            }
        }
    }
}
