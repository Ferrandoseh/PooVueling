namespace PooVueling
{
    public interface ICalculadora
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        /// 
        int FirstNumber { get; set; }
        int SecondNumber { get; set; }

        int Suma(int num1, int num2);
        int Resta(int num1, int num2);
        int Multiplicacion(int num1, int num2);
        int Division(int num1, int num2);
    }
}
