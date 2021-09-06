using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Seeds
{
    public class PersonSeed : IEntityTypeConfiguration<Person>
    {
        private readonly Guid[] _Ids;
        public PersonSeed(Guid[] Ids)
        {
            _Ids = Ids;

        }
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasData(
                 new Person
                 {
                     Id= _Ids[0],
                     Name="Elif",
                     Surname ="Odabaşıoğlu",
                     Company = "Odabaşı Soft",
                 }
                );
        }
    }
}
