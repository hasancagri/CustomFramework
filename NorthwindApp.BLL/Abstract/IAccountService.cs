using System.ServiceModel;

namespace NorthwindApp.BLL.Abstract
{
    [ServiceContract]
    public interface IAccountService
    {
        [OperationContract]
        NorthwindApp.Entities.DTO.Kullanici Login(Entities.DTO.Login login);
    }
}
