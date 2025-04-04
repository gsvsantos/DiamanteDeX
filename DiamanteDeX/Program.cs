﻿using DiamanteDeX.Entities;
using DiamanteDeX.Entities.Utils;

namespace DiamanteDeX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                ViewWrite.Header();
                Diamond.QuantityOfX = ViewUtils.GetNumber();
                Validators.OddOrEven();
                ViewWrite.NumberChose();

                Diamond.Draw();

                ViewUtils.PressEnter("USAR-NOVAMENTE");
            }while (true);
        }
    }
}
