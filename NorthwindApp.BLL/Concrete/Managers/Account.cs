using NorthwindApp.BLL.Abstract;
using NorthwindApp.Entities.DTO;
using NorthwindApp.Helpers.Utilities.Encryption;
using NorthwindApp.Helpers.Utilities.Mapper;
using NorthwindApp.Helpers.Utilities.Search;
using NorthwindApp.Interfaces;

namespace NorthwindApp.BLL.Concrete.Managers
{
    public class Account
        : NorthwindApp.Entities.CORE.Kullanici, IAccountService
    {
        IAccountDal _accountDal;
        public Account(IAccountDal accountDal)
        {
            _accountDal = accountDal;
        }

        Kullanici IAccountService.Login(Login login)
        {
            QueryParam[] parametreler = new QueryParam[]
            {
                new QueryParam{ParamName="UserName",ParamValue=login.UserName},
                new QueryParam{ParamName="Password",ParamValue=login.Password}
        };
            var result = _accountDal.Get(NorthwindApp.StoredProcedures.Account.Login, parametreler);
            NorthwindApp.Entities.DTO.Kullanici kullaniciDTO = new Kullanici();
            if (result != null)
            {
                SimpleMapper.PropertyMap(result, kullaniciDTO);
                kullaniciDTO.KullaniciId = Encryptor.Encrypt(kullaniciDTO.KullaniciId);
            }

            return kullaniciDTO;
        }
    }
}
