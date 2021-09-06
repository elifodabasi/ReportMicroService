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
    public class ContactInfoSeed : IEntityTypeConfiguration<ContactInfo>
    {
        private readonly Guid[] _Ids;
        public ContactInfoSeed(Guid[] Ids)
        {
            _Ids = Ids;

        }
        public void Configure(EntityTypeBuilder<ContactInfo> builder)
        {
            builder.HasData(
          new ContactInfo
          {
             Id=_Ids[0],
             PhoneNumber = "05077217160",
             EmailAddress="elifodabasi14@gmail.com",
             Location = "Ankara",
             InfoContext = "Bilgi",
             PersonId= _Ids[0],
          }
         );

        }
    }
}
