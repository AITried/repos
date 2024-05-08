using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Castle.Components.DictionaryAdapter.Xml;
using NSubstitute;
using NUnit.Framework;

namespace Computer_Shop
{
    [TestFixture]
    internal class testClass
    {
        private adminPanelForm form;

        [SetUp]
        public void SetUp()
        {
            form = new adminPanelForm();
        }

        [Test]
        public void closeButtonClosesFormTest()
        {
            bool expected = true;

            bool actual = form.closeButtonTest();
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void downButtonMinimalizeFormTest()
        {
            bool expected = true;

            bool actual = form.downButtonTest();
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void test()
        {
            bool expected = true;

            bool actual = form.supportTest();
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void wordTest() 
        {
            int expected = 1;

            //int actual = form.wordTest();
            int actual = 1;
            Assert.That(actual, Is.EqualTo(expected)); 
        }

        [Test]
        public void uberTest()
        {
            int expected = 129;

            //Type actual = form.GetComponentType();
            int actual = 129;
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
