using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Common;
using System.Linq;

namespace CleanArchitecture.Domain
{
    public class Person : BaseEntity
    {
        private Person()
        {
        }

        public Person(string firstName, string lastName, string photo, PersonType personType)
        {
            FirstName = firstName;
            LastName = lastName;
            ProfilePhoto = photo;
            PersonType = personType;
        }

        private HashSet<Phone> _phones;
        private HashSet<Address> _addresses;
        private HashSet<EmailAddress> _emailAddresses;

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string ProfilePhoto { get; private set; }
        public PersonType PersonType { get; private set; }
        public IEnumerable<EmailAddress> EmailAddresses => _emailAddresses?.ToList();
        public IEnumerable<Address> Addresses => _addresses?.ToList();
        public IEnumerable<Phone> Phones => _phones?.ToList();

        // handling aggreagates
        public void AddEmail(string email, ContactItemStatus status, Person person)
        {
            if (_emailAddresses != null)
            {
                _emailAddresses.Add(new EmailAddress(email, status, person));
            }
        }

        public void RemoveEmail(EmailAddress email)
        {
            _emailAddresses.Remove(email);
        }

        public void AddAddress(string address1, string address2, string city, string zipcode4, string zipcode5, string state, string coords, ContactItemStatus status, AddressType addressType, Person person)
        {
            if (_addresses != null)
            {
                _addresses.Add(new Address(address1, address2, city, zipcode4, zipcode5, state, coords, status, addressType, person));
            }
        }

        public void RemoveAddress(Address address)
        {
            _addresses.Remove(address);
        }

        public void AddPhone(string number, string ext, ContactItemStatus status, PhoneType type, Person person)
        {
            if (_phones != null)
            {
                _phones.Add(new Phone(number, ext, status, type, person));
            }
        }

        public void RemovePhone(Phone phone)
        {
            _phones.Remove(phone);
        }
    }
}