
using BaltaStore.Domain.StoreContext.ValuesObjects;
using System.Collections.Generic;
using System.Linq;

namespace BaltaStore.Domain.StoreContext.Entities
{

    public class Customer
    {
        private readonly IList<Address> _addresses;
        public Customer(Name name,
            Document document,
            Email email,
            string phone)
        {

            Document = document;
            Email = email;
            Phone = phone;
            _addresses = new List<Address>();
        }
        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public string Phone { get; private set; }
        public Address address { get; private set; }

        public IReadOnlyCollection<Address> Address => _addresses.ToArray();

        public void AddAddress(Address address)
        {
            _addresses.Add(address);
        }

        public override string ToString()
        {
            return Name.ToString();
        }

    }
}