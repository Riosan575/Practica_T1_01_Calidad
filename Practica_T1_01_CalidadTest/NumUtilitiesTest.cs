using NUnit.Framework;
using Practica_T1_01_Calidad;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_T1_01_CalidadTest
{
    public class NumUtilitiesTest
    {
        [Test]
        public void NumPositivoCaso01()
        {
            var utils = new NumUtilities();
            int[] num = new int[] { 1, 2, 3, 4 };
            var result = utils.ValorConsecutivo(num);
            Assert.IsTrue(result);
        }
    }
}
