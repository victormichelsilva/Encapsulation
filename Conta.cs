﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento1
{
    class Conta
    {
        private decimal saldo;

        public decimal Saldo 
        {
            get { return saldo; }

            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("O saldo não pode ser negativo");
                }
                else 
                {
                    saldo = value;
                }
            }
        }
    }
}
