using Core.DataAccess.EntityFramework;
using Entities;

namespace DataAccess.EntityFramework.ContactInfoDal
{
    public class EfContactInfoDal : EfRepositoryBase<ContactInfo, EfDbContext>, IContactInfoDal
    {
    }
}
