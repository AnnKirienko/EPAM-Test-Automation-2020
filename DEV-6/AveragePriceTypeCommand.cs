using System;
using System.Collections.Generic;

namespace DEV_6
{
   public class AveragePriceTypeCommand:ICommand
    {
        AveragePriceTypeReceiver receiver;
        string type;
        List<Car> list;

        public AveragePriceTypeCommand(AveragePriceTypeReceiver receiver, string type, List<Car> list)
        {
            this.receiver = receiver;
            this.type = type;
            this.list = list;
        }

       public void Execute()
        {
            receiver.PrintAveragePriceType(type, list);
        }

    }
}
