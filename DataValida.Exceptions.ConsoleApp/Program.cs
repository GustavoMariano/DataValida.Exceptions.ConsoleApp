using System;

namespace DataValida.Exceptions.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string strDia = "29", strMes = "02", strAno = "2021";
            int intDia = 29, intMes = 02, intAno = 2021;           

            try
            {
                ValidaConversaoData validaConversaoData = new ValidaConversaoData();

                validaConversaoData.IntToDate(intDia, intMes, intAno);
                //validaConversaoData.StringToDate(strDia, strMes, strAno);
                Console.WriteLine("Sucesso!!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }    
}
