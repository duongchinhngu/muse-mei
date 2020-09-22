
using AutoMapper;
using MuseMeiV2.Models;
using MuseMeiV2.UnitOfWorks;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MuseMeiV2.Services.OrderServices
{
    public class OrderService : IOrderService, IBaseService<Order>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public OrderService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        Task IBaseService<Order>.Add(Order dto)
        {
            throw new System.NotImplementedException();
        }

        Task IBaseService<Order>.Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        Task<Order> IBaseService<Order>.Get(int id)
        {
            throw new System.NotImplementedException();
        }

        Task<IEnumerable<Order>> IBaseService<Order>.GetAll()
        {
            throw new System.NotImplementedException();
        }

        Task IBaseService<Order>.Update(Order dto)
        {
            throw new System.NotImplementedException();
        }
    }
}
