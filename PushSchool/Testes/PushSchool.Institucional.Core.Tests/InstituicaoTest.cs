using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PushSchool.Institucional.Core.Models;
using PushSchool.Kernel.Core.Models;

namespace PushSchool.Institucional.Core.Tests
{
    [TestClass]
    public class InstituicaoTest
    {
        [TestMethod]
        [TestCategory("Teste de criação de uma nova Instituição")]
        public void Criando_Instancia()
        {
            var inst = new Instituicao("Colégio Progresso", "123123123");

            Assert.IsNotNull(inst);
        }

        [TestMethod]
        [TestCategory("Teste de criação de uma nova Instituição")]
        public void Associando_Responsavel()
        {
            var inst = new Instituicao("Colégio Progresso", "123123123");

            var pessoa = new Pessoa("Elton", "elton.augusto.tamilheiro@hotmail.com", "19981925300");

            inst.AtribuirResponsavel(pessoa);

            Assert.AreEqual(inst.Responsavel, pessoa);
        }
    }
}
