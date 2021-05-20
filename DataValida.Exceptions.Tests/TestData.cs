using DataValida.Exceptions.ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DataValida.Exceptions.Tests
{
    [TestClass]
    public class TestData
    {
        ValidaConversaoData validaConversaoData = new ValidaConversaoData();

        #region Validação do Ano
        [TestMethod]
        public void AnoMenorQueUm()
        {
            int dia = 01, mes = 01, ano = 0;

            Assert.ThrowsException<ArgumentException>(() => validaConversaoData.IntToDate(dia, mes, ano));
        }

        [TestMethod]
        public void AnoMaiorQueTresMil()
        {
            int dia = 01, mes = 01, ano = 3001;

            Assert.ThrowsException<ArgumentException>(() => validaConversaoData.IntToDate(dia, mes, ano));
        }
        #endregion

        #region Validação do mês
        [TestMethod]
        public void MesMenorQueUm()
        {
            int dia = 01, mes = 00, ano = 2021;

            Assert.ThrowsException<ArgumentException>(() => validaConversaoData.IntToDate(dia, mes, ano));
        }

        [TestMethod]
        public void MesMaiorQue12()
        {
            int dia = 01, mes = 13, ano = 2021;

            Assert.ThrowsException<ArgumentException>(() => validaConversaoData.IntToDate(dia, mes, ano));
        }
        #endregion

        #region Validação Dia
        [TestMethod]
        public void DiaMenorQueUm()
        {
            int dia = 00, mes = 01, ano = 2021;

            Assert.ThrowsException<ArgumentException>(() => validaConversaoData.IntToDate(dia, mes, ano));
        }

        #region Mes com 31 dias
        [TestMethod]
        public void DiaMaiorQue31EmJaneiro()
        {
            int dia = 32, mes = 01, ano = 2020;

            Assert.ThrowsException<ArgumentException>(() => validaConversaoData.IntToDate(dia, mes, ano));
        }

        [TestMethod]
        public void DiaMaiorQue31EmMarco()
        {
            int dia = 32, mes = 03, ano = 2021;

            Assert.ThrowsException<ArgumentException>(() => validaConversaoData.IntToDate(dia, mes, ano));
        }

        [TestMethod]
        public void DiaMaiorQue31EmMaio()
        {
            int dia = 32, mes = 05, ano = 2021;

            Assert.ThrowsException<ArgumentException>(() => validaConversaoData.IntToDate(dia, mes, ano));
        }

        [TestMethod]
        public void DiaMaiorQue31EmJulho()
        {
            int dia = 32, mes = 07, ano = 2021;

            Assert.ThrowsException<ArgumentException>(() => validaConversaoData.IntToDate(dia, mes, ano));
        }

        [TestMethod]
        public void DiaMaiorQue31EmAgosto()
        {
            int dia = 32, mes = 08, ano = 2021;

            Assert.ThrowsException<ArgumentException>(() => validaConversaoData.IntToDate(dia, mes, ano));
        }

        [TestMethod]
        public void DiaMaiorQue31EmOutubro()
        {
            int dia = 32, mes = 10, ano = 2021;

            Assert.ThrowsException<ArgumentException>(() => validaConversaoData.IntToDate(dia, mes, ano));
        }

        [TestMethod]
        public void DiaMaiorQue31EmDezembro()
        {
            int dia = 32, mes = 12, ano = 2021;

            Assert.ThrowsException<ArgumentException>(() => validaConversaoData.IntToDate(dia, mes, ano));
        }

        #endregion

        #region Mes com 30 dias

        [TestMethod]
        public void DiaMaiorQue30EmAbril()
        {
            int dia = 31, mes = 04, ano = 2021;

            Assert.ThrowsException<ArgumentException>(() => validaConversaoData.IntToDate(dia, mes, ano));
        }

        [TestMethod]
        public void DiaMaiorQue30EmJunho()
        {
            int dia = 31, mes = 06, ano = 2021;

            Assert.ThrowsException<ArgumentException>(() => validaConversaoData.IntToDate(dia, mes, ano));
        }

        [TestMethod]
        public void DiaMaiorQue30EmSetembro()
        {
            int dia = 31, mes = 09, ano = 2021;

            Assert.ThrowsException<ArgumentException>(() => validaConversaoData.IntToDate(dia, mes, ano));
        }
        [TestMethod]
        public void DiaMaiorQue30EmNovembro()
        {
            int dia = 31, mes = 11, ano = 2021;

            Assert.ThrowsException<ArgumentException>(() => validaConversaoData.IntToDate(dia, mes, ano));
        }

        #endregion

        #region Validação Fevereiro
        [TestMethod]
        public void DiaMaiorQue28EmFevereiroEAnoNaoBissexto()
        {
            int dia = 29, mes = 02, ano = 2021;

            Assert.ThrowsException<ArgumentException>(() => validaConversaoData.IntToDate(dia, mes, ano));
        }

        [TestMethod]
        public void DiaMaiorQue29EmFevereiroEAnoBissexto()
        {
            int dia = 30, mes = 02, ano = 2020;

            Assert.ThrowsException<ArgumentException>(() => validaConversaoData.IntToDate(dia, mes, ano));
        }
        #endregion

        #endregion
    }
}
