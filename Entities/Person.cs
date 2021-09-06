using Core.Entities.Abstract;
using System;

namespace Entities
{
    public class Person : IEntity
    {
        public Person()
        {
            //ContactInfos = new Collection<ContactInfo>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Company { get; set; }
        //public ICollection<ContactInfo> ContactInfos { get; set; }
    }
}
