using BaltaStore.Domain.StoreContext.Entities;
using BaltaStore.Domain.StoreContext.ValuesObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaltaStore.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Recupera os produtos do banco
            var name = new Name("André", "Baltieri");
            var document = new Document("46718115533");
            var email = new Email("hello@balta.io");
            var c = new Customer(name, document, email, "4234234234");

            var mouse = new Product("Mouse Gamer", "Mouse Gamer", "mouse.jpg", 100M, 10);
            var keyboard = new Product("Teclado Gamer", "Teclado Gamer", "Teclado.jpg", 100M, 10);
            var chair = new Product("Cadeira Gamer", "Cadeira Gamer", "Cadeira.jpg", 100M, 10);
            var monitor = new Product("Monitor Gamer", "Monitor Gamer", "Monitor.jpg", 100M, 10);

            var order = new Order(c);
            order.AddItem(new OrderItem(mouse, 5));
            order.AddItem(new OrderItem(keyboard, 5));
            order.AddItem(new OrderItem(chair, 5));
            order.AddItem(new OrderItem(monitor, 5));

            order.Place();

            order.Pay();

            order.Ship();

            order.Cancel();


        }
    }
}
