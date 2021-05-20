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

            if (ano >= 1 && ano <= 3000)
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
            bool validacao;
            int intDia; 
            
            validacao = Int32.TryParse(dia, out intDia);
             if(validacao == false)
                throw new ArgumentException("O dia informado é inválido!!");

            int intMes = Convert.ToInt32(mes);
            validacao = Int32.TryParse(mes, out intMes);
            if (validacao == false)
                throw new ArgumentException("O mês informado é inválido!!");

            int intAno = Convert.ToInt32(ano);
            validacao = Int32.TryParse(ano, out intAno);
            if (validacao == false)
                throw new ArgumentException("O ano informado é inválido!!");

            DateTime dataConvertida;

            IntToDate(intDia, intMes, intAno);        
        }
    }
}
