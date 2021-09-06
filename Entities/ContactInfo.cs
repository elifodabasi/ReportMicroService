using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Entities
{

    public class ContactInfo :IEntity
    {
        public ContactInfo()
        {
            //Persons = new Collection<Person>();
            //Locations = new Collection<Location>();
        }
        public Guid Id { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Location { get; set; }
        public string InfoContext { get; set; }
        public Guid PersonId { get; set; }
        public virtual Person Person { get; set; }
        //public ICollection<Person> Persons { get; set; }
        //public ICollection<Location> Locations { get; set; }
    }
}
