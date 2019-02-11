﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVueling
{

    public class Calculadora : ICalculadora, ICloneable
    {
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public object Clone()
        {
            throw new NotImplementedException("The method is not implemented yet");
        }

        public int Division(int num1, int num2)
        {
            try
            {
                return num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                log.Warn(e.Message);
                throw;
            }
        }

        public int Multiplicacion(int num1, int num2)
        {
                return num1 * num2;
           
        }

        public int Resta(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Suma(int num1, int num2)
        {
            return num1 + num2;
        }


    }
}
