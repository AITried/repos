using Refac1;
namespace TestProject1
 
{
    public class Tests
    {
        Customer customer;
        Bill bill;
        [SetUp]
        public void Setup()
        {
            customer = new Customer("Test", 10);
            bill = new Bill(customer);
        }

        [Test]
        public void Test1()
        {
            var result = bill.statement();
            var expectedFooter = "Сумма счета составляет 0\nВы заработали 0 бонусных балов";
            Assert.That(result.Contains(expectedFooter));
        }
        [Test]
        public void Test2()
        {
            bill.addGoods(new Item(new Goods("Товар 1", Goods.REGULAR), 1, 100));
            var result = bill.statement();
            Assert.That(result.Contains("Сумма счета составляет 100\n"));
            Assert.That(result.Contains("Вы заработали 5 бонусных балов"));
        }
        [Test]
        public void Test3()
        {
            bill.addGoods(new Item(new Goods("Товар 2", Goods.SPECIAL_OFFER), 11, 50));
            var result = bill.statement();
            Assert.That(result.Contains("Сумма счета составляет 540"));
            Assert.That(result.Contains("Вы заработали 0 бонусных балов"));
        }
        [Test]
        public void Test4()
        {
            bill.addGoods(new Item(new Goods("Товар со скидкой", Goods.SALE), 11, 200));
            var result = bill.statement();
            Assert.That(result.Contains("Сумма счета составляет 2178"));
            Assert.That(result.Contains("Вы заработали 22 бонусных балов"));
        }
        [Test]
        public void Test5()
        {
            bill.addGoods(new Item(new Goods("Товар 2", Goods.SPECIAL_OFFER), 5, 50));
            var result = bill.statement();
            Assert.That(result.Contains("Сумма счета составляет 240"));
            Assert.That(result.Contains("Вы заработали 0 бонусных балов"));

        }
        [Test]
        public void Test6()
        {
            bill.addGoods(new Item(new Goods("Товар со скидкой", Goods.SALE), 2, 200));
            var result = bill.statement();
            Assert.That(result.Contains("Сумма счета составляет 400"));
            Assert.That(result.Contains("Вы заработали 4 бонусных балов"));
        }
        [Test]
        public void Test7()
        {
            bill.addGoods(new Item(new Goods("Товар 1", Goods.REGULAR), 3, 100));
            var result = bill.statement();
            Assert.That(result.Contains("Сумма счета составляет 291\n"));
            Assert.That(result.Contains("Вы заработали 15 бонусных балов"));
        }
        [Test]
        public void Test8()
        {
            bill.addGoods(new Item(new Goods("Товар 1", Goods.REGULAR), 2, 100));
            var result = bill.statement();
            Assert.That(result.Contains("Сумма счета составляет 200\n"));
            Assert.That(result.Contains("Вы заработали 10 бонусных балов"));
        }
        [Test]
        public void Test9()
        {
            bill.addGoods(new Item(new Goods("Товар 1", Goods.REGULAR), 0   , 100));
            var result = bill.statement();
            Assert.That(result.Contains("Сумма счета составляет 0\n"));
            Assert.That(result.Contains("Вы заработали 0 бонусных балов"));
        }
        [Test]
        public void Test10()
        {
            bill.addGoods(new Item(new Goods("Товар 1", Goods.REGULAR), 6, 100));
            bill.addGoods(new Item(new Goods("Товар 2", Goods.SPECIAL_OFFER), 15, 50));
            bill.addGoods(new Item(new Goods("Товар со скидкой", Goods.SALE), 11, 200));
            var result = bill.statement();
            Assert.That(result.Contains("Сумма счета составляет 3500\n"));
            Assert.That(result.Contains("Вы заработали 52 бонусных балов"));
        }

    }
}