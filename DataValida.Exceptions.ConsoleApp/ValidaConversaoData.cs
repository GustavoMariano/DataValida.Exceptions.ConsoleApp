using System;

namespace DataValida.Exceptions.ConsoleApp
{
    public class ValidaConversaoData
    {
        /// <summary> 
        /// Verifica se é possivel realizar a conversão de Int para DateTime.
        /// </summary>
        /// <param name="dia">Int no seguinte formato: dd</param>
        /// <param name="mes">Int no seguinte formato: MM</param>
        /// <param name="ano">Int no seguinte formato: yyyy</param>
        /// <returns>Retorna exceção caso não seja possivel realizar a conversão</returns>
        public void IntToDate(int dia, int mes, int ano)
        {
            DateTime dataConvertida;

            if (ano >= 1 && ano < 3000)
            {
                if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                {
                    if (dia < 1 || dia > 31)
                        throw new ArgumentException("Dia informado é inválido!!");
                    else
                        dataConvertida = new DateTime(ano, mes, dia);
                }
                else if (mes == 2)
                {
                    bool ehAnoBissexto = DateTime.IsLeapYear(ano);
                    if (ehAnoBissexto == false)
                    {
                        if (dia < 1 || dia > 28)
                            throw new ArgumentException("O ano informado não é bissexto, portanto fevereiro possui 28 dias!!");
                        else
                            dataConvertida = new DateTime(ano, mes, dia);
                    }
                    else
                    {
                        if (dia < 1 || dia > 29)
                            throw new ArgumentException("O ano informado é bissexto, porém o dia informado, não é válido!!");
                        else
                            dataConvertida = new DateTime(ano, mes, dia);
                    }
                }
                else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                {
                    if (dia < 1 || dia > 30)
                        throw new ArgumentException("Dia informado é inválido!!");
                    else
                        dataConvertida = new DateTime(ano, mes, dia);
                }
                else
                    throw new ArgumentException("O mês informado é inválido!!");
            }
            else
                throw new ArgumentException("Ano informado está fora do escopo de validação (0001 ~ 3000)");
        }
        /// <summary> 
        /// Verifica se é possivel realizar a conversão de String para DateTime.
        /// </summary>
        /// <param name="dia">String no seguinte formato: "dd"</param>
        /// <param name="mes">String no seguinte formato: "MM"</param>
        /// <param name="ano">String no seguinte formato: "yyyy"</param>
        /// <returns>Retorna exceção caso não seja possivel realizar a conversão</returns>
        /// <exception cref=""></exception>
        public void StringToDate(string dia, string mes, string ano)
        {
            int intDia = Convert.ToInt32(dia);
            int intMes = Convert.ToInt32(mes);
            int intAno = Convert.ToInt32(ano);

            DateTime dataConvertida;

            if (intAno >= 1 && intAno < 3000)
            {
                if (intMes == 1 || intMes == 3 || intMes == 5 || intMes == 7 || intMes == 8 || intMes == 10 || intMes == 12)
                {
                    if (intDia < 1 || intDia > 31)
                        throw new ArgumentException("Dia informado é inválido!!");
                    else
                        dataConvertida = new DateTime(intAno, intMes, intDia);
                }
                else if (intMes == 2)
                {
                    bool ehAnoBissexto = DateTime.IsLeapYear(intAno);
                    if (ehAnoBissexto == false)
                    {
                        if (intDia < 1 || intDia > 28)
                            throw new ArgumentException("O ano informado não é bissexto, portanto fevereiro possui 28 dias!!");
                        else
                            dataConvertida = new DateTime(intAno, intMes, intDia);
                    }
                }
                else if (intMes == 4 || intMes == 6 || intMes == 9 || intMes == 11)
                {
                    if (intDia < 1 || intDia > 30)
                        throw new ArgumentException("Dia informado é inválido!!");
                    else
                        dataConvertida = new DateTime(intAno, intMes, intDia);
                }
                else
                    throw new ArgumentException("O mês informado é inválido!!");
            }
            else
                throw new ArgumentException("Ano informado está fora do escopo de validação (0001 ~ 3000)");
        }
    }
}
