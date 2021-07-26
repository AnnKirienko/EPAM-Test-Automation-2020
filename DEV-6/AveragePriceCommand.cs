using System;
using System.Collections.Generic;

namespace DEV_6
{
   public class AveragePriceCommand:ICommand
    {
        AveragePriceReceiver receiver;
        List<Car> list;

        public AveragePriceCommand(AveragePriceReceiver receiver, List<Car> list)
        {
            this.receiver = receiver;
            this.list = list;
        }

        public void Execute()
        {
            receiver.PrintAveragePrice(list);
        }
    }
}
