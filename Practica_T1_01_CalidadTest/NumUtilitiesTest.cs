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
            int num = 1;
            var result = utils.RepresentacionRomano(num);
            Assert.AreEqual("I",result);
        }
        [Test]
        public void NumPositivoCaso02()
        {
            var utils = new NumUtilities();
            int num = 2;
            var result = utils.RepresentacionRomano(num);
            Assert.AreEqual("II", result);
        }
        [Test]
        public void NumPositivoCaso03()
        {
            var utils = new NumUtilities();
            int num = 3;
            var result = utils.RepresentacionRomano(num);
            Assert.AreEqual("III", result);
        }
        [Test]
        public void NumPositivoCaso04()
        {
            var utils = new NumUtilities();
            int num = 4;
            var result = utils.RepresentacionRomano(num);
            Assert.AreEqual("IV", result);
        }
        [Test]
        public void NumPositivoCaso05()
        {
            var utils = new NumUtilities();
            int num = 5;
            var result = utils.RepresentacionRomano(num);
            Assert.AreEqual("V", result);
        }
        [Test]
        public void NumPositivoCaso06()
        {
            var utils = new NumUtilities();
            int num = 6;
            var result = utils.RepresentacionRomano(num);
            Assert.AreEqual("VI", result);
        }
        [Test]
        public void NumPositivoCaso07()
        {
            var utils = new NumUtilities();
            int num = 10;
            var result = utils.RepresentacionRomano(num);
            Assert.AreEqual("X", result);
        }
        [Test]
        public void NumPositivoCaso08()
        {
            var utils = new NumUtilities();
            int num = 100;
            var result = utils.RepresentacionRomano(num);
            Assert.AreEqual("C", result);
        }
        [Test]
        public void NumPositivoCaso09()
        {
            var utils = new NumUtilities();
            int num = 200;
            var result = utils.RepresentacionRomano(num);
            Assert.AreEqual("CC", result);
        }
        [Test]
        public void NumPositivoCaso10()
        {
            var utils = new NumUtilities();
            int num = 150;
            var result = utils.RepresentacionRomano(num);
            Assert.AreEqual("CL", result);
        }
        [Test]
        public void NumPositivoCaso11()
        {
            var utils = new NumUtilities();
            int num = 15;
            var result = utils.RepresentacionRomano(num);
            Assert.AreEqual("XV", result);
        }
        [Test]
        public void NumPositivoCaso12()
        {
            var utils = new NumUtilities();
            int num = 35;
            var result = utils.RepresentacionRomano(num);
            Assert.AreEqual("XXXV", result);
        }
        [Test]
        public void NumPositivoCaso13()
        {
            var utils = new NumUtilities();
            int num = 40;
            var result = utils.RepresentacionRomano(num);
            Assert.AreEqual("XL", result);
        }
        [Test]
        public void NumPositivoCaso14()
        {
            var utils = new NumUtilities();
            int num = 1000;
            var result = utils.RepresentacionRomano(num);
            Assert.AreEqual("M", result);
        }
    }
}
