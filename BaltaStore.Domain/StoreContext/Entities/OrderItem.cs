

using BaltaStore.Shared.Entities;
using FluentValidator;
using System;

namespace BaltaStore.Domain.StoreContext.Entities
{
    public class OrderItem : Entity
    {
        public OrderItem(Product product, decimal quantity)
        {
            Product = product;
            Quantity = quantity;
            Price = product.Price;

            if ((product.QuatityOnHand < quantity))
            {
                AddNotification("quantity", "Produto fora de estoque");
            }
        }
        public Product Product { get; private set; }
        public decimal Quantity { get; private set; }
        public decimal Price { get; private set; }
    }
}
