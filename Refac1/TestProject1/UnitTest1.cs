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
            var expectedFooter = "����� ����� ���������� 0\n�� ���������� 0 �������� �����";
            Assert.That(result.Contains(expectedFooter));
        }
        [Test]
        public void Test2()
        {
            bill.addGoods(new Item(new Goods("����� 1", Goods.REGULAR), 1, 100));
            var result = bill.statement();
            Assert.That(result.Contains("����� ����� ���������� 100\n"));
            Assert.That(result.Contains("�� ���������� 5 �������� �����"));
        }
        [Test]
        public void Test3()
        {
            bill.addGoods(new Item(new Goods("����� 2", Goods.SPECIAL_OFFER), 11, 50));
            var result = bill.statement();
            Assert.That(result.Contains("����� ����� ���������� 540"));
            Assert.That(result.Contains("�� ���������� 0 �������� �����"));
        }
        [Test]
        public void Test4()
        {
            bill.addGoods(new Item(new Goods("����� �� �������", Goods.SALE), 11, 200));
            var result = bill.statement();
            Assert.That(result.Contains("����� ����� ���������� 2178"));
            Assert.That(result.Contains("�� ���������� 22 �������� �����"));
        }
        [Test]
        public void Test5()
        {
            bill.addGoods(new Item(new Goods("����� 2", Goods.SPECIAL_OFFER), 5, 50));
            var result = bill.statement();
            Assert.That(result.Contains("����� ����� ���������� 240"));
            Assert.That(result.Contains("�� ���������� 0 �������� �����"));

        }
        [Test]
        public void Test6()
        {
            bill.addGoods(new Item(new Goods("����� �� �������", Goods.SALE), 2, 200));
            var result = bill.statement();
            Assert.That(result.Contains("����� ����� ���������� 400"));
            Assert.That(result.Contains("�� ���������� 4 �������� �����"));
        }
        [Test]
        public void Test7()
        {
            bill.addGoods(new Item(new Goods("����� 1", Goods.REGULAR), 3, 100));
            var result = bill.statement();
            Assert.That(result.Contains("����� ����� ���������� 291\n"));
            Assert.That(result.Contains("�� ���������� 15 �������� �����"));
        }
        [Test]
        public void Test8()
        {
            bill.addGoods(new Item(new Goods("����� 1", Goods.REGULAR), 2, 100));
            var result = bill.statement();
            Assert.That(result.Contains("����� ����� ���������� 200\n"));
            Assert.That(result.Contains("�� ���������� 10 �������� �����"));
        }
        [Test]
        public void Test9()
        {
            bill.addGoods(new Item(new Goods("����� 1", Goods.REGULAR), 0   , 100));
            var result = bill.statement();
            Assert.That(result.Contains("����� ����� ���������� 0\n"));
            Assert.That(result.Contains("�� ���������� 0 �������� �����"));
        }
        [Test]
        public void Test10()
        {
            bill.addGoods(new Item(new Goods("����� 1", Goods.REGULAR), 6, 100));
            bill.addGoods(new Item(new Goods("����� 2", Goods.SPECIAL_OFFER), 15, 50));
            bill.addGoods(new Item(new Goods("����� �� �������", Goods.SALE), 11, 200));
            var result = bill.statement();
            Assert.That(result.Contains("����� ����� ���������� 3500\n"));
            Assert.That(result.Contains("�� ���������� 52 �������� �����"));
        }

    }
}