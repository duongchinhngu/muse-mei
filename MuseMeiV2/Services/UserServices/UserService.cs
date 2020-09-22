
using AutoMapper;
using MuseMeiV2.Models;
using MuseMeiV2.UnitOfWorks;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MuseMeiV2.Services.UserServices
{
    public class UserService : IUserService, IBaseService<User>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        Task IBaseService<User>.Add(User dto)
        {
            throw new System.NotImplementedException();
        }

        Task IBaseService<User>.Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        Task<User> IBaseService<User>.Get(int id)
        {
            throw new System.NotImplementedException();
        }

        Task<IEnumerable<User>> IBaseService<User>.GetAll()
        {
            throw new System.NotImplementedException();
        }

        Task IBaseService<User>.Update(User dto)
        {
            throw new System.NotImplementedException();
        }
    }
}
