using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Diagnostics;
using System.Globalization;
using System.Numerics;

namespace UnitTestProject.PrimitiveTypes
{
    [TestClass]
    public class IntTest
    {
        [TestMethod]
        public void GenerateSequenceOfNumbers()
        {
            var list = Enumerable.Range(1, 12).ToList(); //better then use for 

            foreach(var item in list)
                Debug.WriteLine(item);      
        }

        private (int tamanho, string nome) GetNome()
        {
            return (10, "Gláucio");
        }

        [TestMethod]
        public void ThreePartFormat()
        {
            var format = "Boa Avaliação #;Avaliação Ruim -#;Novo Item";

            var avaliacoes = new int[] {-10, 5, 0, 15 };

            foreach (var avaliacao in avaliacoes)
                Debug.WriteLine($"Nota: {avaliacao} Avaliação: {avaliacao.ToString(format)}");
        }


        [TestMethod]
        public void StringToBigInteger()
        {
            var input = "1091203912038109238109238109231092831092312313";
            var bigInt = BigInteger.Parse(input);
            
            var result = BigInteger.Add(bigInt, 1);

            Debug.WriteLine(result);

        }

        [TestMethod]
        public void CustomFormatUsage()
        {
            var avaliacoes = new int[] { -10, 5, 0, 15 };

            foreach (var avaliacao in avaliacoes)
                Debug.WriteLine(string.Format(new ProdutividadeFormatProvider(),"{0}", avaliacao));
        }

        [TestMethod]
        public void StringToInt()
        {
            var avaliacoes = new string[] { "   -10  ", "-5 ", "0","(100)", "10", "15" };

            foreach (var avaliacao in avaliacoes)
                Debug.WriteLine(int.Parse(avaliacao, NumberStyles.Integer | NumberStyles.AllowParentheses));
        }

        [TestMethod]
        public void StringToIntWithCustomFormatProvider()
        {
            var avaliacoes = new int[] { -10, 5, 0, 15 };

            foreach (var avaliacao in avaliacoes)
                Debug.WriteLine(string.Format(new ProdutividadeFormatProvider(),"{0}", avaliacao));
        }
    }

    class ProdutividadeFormatProvider : IFormatProvider, ICustomFormatter
    {
        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            int rating = (int)arg;

            if (rating > 10)
                return $"Nota: {rating}, Excelente!!";
            else if (rating > 4)
                return $"Nota: {rating}, Bom Trabalho.";
            else if (rating > 1)
                return $"Nota: {rating}. Continue tentando!";
            else
                return $"Nota: {rating}. Procure ajuda.";
        }

        public object GetFormat(Type formatType)
        {
            return this;
        }
    }


}
