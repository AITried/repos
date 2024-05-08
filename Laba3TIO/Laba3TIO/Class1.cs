using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Laba3TIO;

namespace Tests
{
    public class IsbelongTests
    {
        Isbelong equivalence = new Isbelong();

        [Test]
        public void Test1()
        {
            double result = equivalence.TestPoints(0.2, -0.2);
            Assert.That(2, Is.EqualTo(result));
        }
        [Test]
        public void Test2()
        {
            double result = equivalence.TestPoints(-0.2, 0.2);
            Assert.That(4, Is.EqualTo(result));
        }
        [Test]
        public void Test3()
        {
            double result = equivalence.TestPoints(0.58, -0.58);
            Assert.That(2, Is.EqualTo(result));
        }
        [Test]
        public void Test4()
        {
            double result = equivalence.TestPoints(-0.58, 0.58);
            Assert.That(4, Is.EqualTo(result));
        }
        [Test]
        public void Test5()
        {
            double result = equivalence.TestPoints(0.59, -0.59);
            Assert.That(0, Is.EqualTo(result));
        }
        [Test]
        public void Test6()
        {
            double result = equivalence.TestPoints(-0.59, 0.59);
            Assert.That(0, Is.EqualTo(result));
        }
        [Test]
        public void Test7()
        {
            double result = equivalence.TestPoints(0, 0);
            Assert.That(0, Is.EqualTo(result));
        }
    }
}
