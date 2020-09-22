using AutoMapper;
using MuseMeiV2.Models;
using MuseMeiV2.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuseMeiV2.Services.RoleServices
{
    public class RoleService : IRoleService, IBaseService<Role>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RoleService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        Task IBaseService<Role>.Add(Role dto)
        {
            throw new NotImplementedException();
        }

        Task IBaseService<Role>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        Task<Role> IBaseService<Role>.Get(int id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Role>> IBaseService<Role>.GetAll()
        {
            throw new NotImplementedException();
        }

        Task IBaseService<Role>.Update(Role dto)
        {
            throw new NotImplementedException();
        }
    }
}
