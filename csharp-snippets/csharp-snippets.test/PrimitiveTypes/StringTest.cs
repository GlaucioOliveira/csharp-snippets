using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;

namespace UnitTestProject.PrimitiveTypes
{
    [TestClass]
    public class StringTest
    {

        [TestMethod]
        public void JoinArray()
        {
            var profissoes = new string[] { "Dentista", "Desenvolvedor", "Motorista" };

            Debug.Print(string.Join(", ", profissoes));
        }

        [TestMethod]
        public void StringBuilder()
        {
            StringBuilder sb = new StringBuilder();
            var profissoes = new string[] { "Dentista", "Desenvolvedor", "Motorista" };

            foreach (var profissao in profissoes) sb.Append(profissao);

            Debug.Print(sb.ToString() + " ");
        }


        [TestMethod]
        public void IsEmpty()
        {
            var input = "   ";
            var condition = string.IsNullOrWhiteSpace(input) == true;

            Assert.IsTrue(condition);
        }



        [TestMethod]
        public void StringInterpolation()
        {
            var nome = "Gláucio Oliveira";
            var profissao = "Desenvolvedor";

            var input = $"Olá, meu nome é {nome}";

            var inputAlignedLeft = $"Nome: {nome,-50} Profissão: {profissao,-50}";
            var inputAlignedRight = $"Nome: {nome,50} Profissão: {profissao,50}";

            Debug.WriteLine(inputAlignedLeft);
            Debug.WriteLine(inputAlignedRight);

            var condition = input == "Olá, meu nome é Gláucio Oliveira";

            Assert.IsTrue(condition);
        }

        [TestMethod]
        public void IsValidUnicode()
        {
            var input = "º";
            char inputCode = (char)32;// input.First();

            UnicodeCategory ucCategory = char.GetUnicodeCategory(inputCode);

            var condition = ucCategory != UnicodeCategory.OtherNotAssigned;

            Assert.IsTrue(condition);
        }
    }
}
