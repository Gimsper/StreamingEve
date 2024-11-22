using Eve.Core.Models.Entities;
using Eve.Core.ViewModel;
using Eve.Infraestructure.Base;
using Eve.Infraestructure.Repositories.Interfaces;
using Eve.Infraestructure.Services.Interfaces;
using Eve.Shared.Utils;

namespace Eve.Infraestructure.Services
{
    public class UserService : _Service<UserLogin>, IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public ResultOperationStruct<bool> CheckCredentials(UserDataViewModel request)
        {
            ResultOperationStruct<bool> rst = new();
            try
            {
                rst.Result = _repository.CheckCredentials(request);
            }
            catch (Exception ex)
            {
                rst.StateOperation = false;
                rst.Result = false;
                rst.MessageError = ex.Message;
            }

            return rst;
        }
    }
}
