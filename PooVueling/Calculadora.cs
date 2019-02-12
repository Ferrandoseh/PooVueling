using System;

namespace PooVueling
{
    public class Calculadora : ICalculadora, ICloneable
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(
            System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /* Same as the code above - just for Calculadora class
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(
            typeof(Calculadora));*/ 

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
            catch(DivideByZeroException e)
            {
                log.Error(e.Message);
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
