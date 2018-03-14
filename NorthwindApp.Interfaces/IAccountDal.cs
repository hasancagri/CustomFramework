using NorthwindApp.Helpers.ORM.DAPPER.Abtract;

namespace NorthwindApp.Interfaces
{
    public interface IAccountDal
        : IBaseRepository<NorthwindApp.Entities.CORE.Kullanici>
    {
    }
}
