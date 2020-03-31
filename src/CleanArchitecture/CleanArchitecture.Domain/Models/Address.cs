using CleanArchitecture.Common;

namespace CleanArchitecture.Domain
{
    public class Address : BaseEntity
    {
        private Address()
        {
        }

        public Address(string address1, string address2, string city, string zipcode4, string zipcode5, string state, string coords, ContactItemStatus status, AddressType addressType, Person person)
        {
            Person = person;
            AddressType = addressType;
            Status = status;
            Address1 = address1;
            Address2 = address2;
            City = city;
            ZipCode4 = zipcode4;
            ZipCode5 = zipcode5;
            State = state;
            Coordinates = coords;
        }

        public int PersonId { get; private set; }

        public string Address1 { get; private set; }
        public string Address2 { get; private set; }
        public string City { get; private set; }
        public string ZipCode4 { get; private set; }
        public string ZipCode5 { get; private set; }

        public string State { get; private set; }
        public string Coordinates { get; private set; }

        public ContactItemStatus Status { get; private set; }
        public AddressType AddressType { get; private set; }

        public virtual Person Person { get; set; }
    }
}