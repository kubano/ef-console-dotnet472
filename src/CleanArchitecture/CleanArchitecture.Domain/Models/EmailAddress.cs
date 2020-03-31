using CleanArchitecture.Common;

namespace CleanArchitecture.Domain
{
    public class EmailAddress : BaseEntity
    {
        private EmailAddress()
        {
        }

        public EmailAddress(string email, ContactItemStatus status, Person person)
        {
            Person = person;
            Email = email;
            Status = status;
        }

        public int PersonId { get; private set; }
        public string Email { get; private set; }
        public ContactItemStatus Status { get; private set; }
        public Person Person { get; set; }
    }
}