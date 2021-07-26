using System;
using System.Collections.Generic;

namespace DEV_6
{
   public class CountAllCommand:ICommand
    {
        CountAllReceiver receiver;
        List<Car> list;

        public CountAllCommand(CountAllReceiver receiver, List<Car> list)
        {
            this.receiver = receiver;
            this.list = list;
        }

        public void Execute()
        {
            receiver.PrintCountAll(list);
        }

    }
}
