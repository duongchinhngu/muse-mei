using AutoMapper;
using MuseMeiV2.Models;
using MuseMeiV2.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MuseMeiV2.Services.OrderDetailServices
{
    public class OrderDetailService : IOrderDetailService, IBaseService<OrderDetail>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public OrderDetailService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        Task IBaseService<OrderDetail>.Add(OrderDetail dto)
        {
            throw new NotImplementedException();
        }

        Task IBaseService<OrderDetail>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        Task<OrderDetail> IBaseService<OrderDetail>.Get(int id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<OrderDetail>> IBaseService<OrderDetail>.GetAll()
        {
            throw new NotImplementedException();
        }

        Task IBaseService<OrderDetail>.Update(OrderDetail dto)
        {
            throw new NotImplementedException();
        }
    }

}
