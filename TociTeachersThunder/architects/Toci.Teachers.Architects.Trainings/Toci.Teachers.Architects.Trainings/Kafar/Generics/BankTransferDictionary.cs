﻿using System.Collections.Generic;

namespace Toci.Architects.Training.Kafar.Generics
{
    public class BankTransferDictionary
    {
        public void Example()
        {
            Dictionary<string, BankTransferKafar> transferDictionary = new Dictionary<string, BankTransferKafar>();

            transferDictionary.Add("1060", new BankTransferKafar());
        }
    }
}