using CleanArchitecture.Common;

namespace CleanArchitecture.Domain
{
    public class Phone : BaseEntity
    {
        private Phone()
        {
        }

        public Phone(string number, string ext, ContactItemStatus status, PhoneType type, Person person)
        {
            Person = person;
            PhoneNumber = number;
            PhoneExtension = ext;
            Status = status;
            PhoneType = type;
        }

        public int PersonId { get; private set; }
        public string PhoneNumber { get; private set; }
        public string PhoneExtension { get; private set; }
        public ContactItemStatus Status { get; private set; }
        public PhoneType PhoneType { get; private set; }
        public virtual Person Person { get; private set; }
    }
}