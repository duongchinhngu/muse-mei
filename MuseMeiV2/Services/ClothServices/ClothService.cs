using AutoMapper;
using MuseMeiV2.DTOs;
using MuseMeiV2.Models;
using MuseMeiV2.Repositories.ClothRepositories;
using MuseMeiV2.UnitOfWorks;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MuseMeiV2.Services.ClothServices
{
    public class ClothService : IClothService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ClothService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        private ClothRepository ClothRepository => _unitOfWork.ClothRepository;

        public async Task Add(ClothDTO dto)
        {
            Cloth entity = _mapper.Map<Cloth>(dto);
            ClothRepository.Insert(entity);
            await _unitOfWork.commitAsync();
        }

        public async Task Delete(int id)
        {
             ClothRepository.Delete(id);
            await _unitOfWork.commitAsync();
        }

        public async Task<ClothDTO> Get(int id)
        {

            Cloth entity =  await ClothRepository.GetById(id);
            return _mapper.Map<ClothDTO>(entity);
        }

        public async Task<IEnumerable<ClothDTO>> GetAll()
        {
            IEnumerable<Cloth> entities = await ClothRepository.GetAll();
            return _mapper.Map<IEnumerable<ClothDTO>>(entities);
        }

        public Task Update(ClothDTO dto)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<ClothDTO>> GetClothesByCategoryId(int id)
        {
            IEnumerable<Cloth> entities =  await ClothRepository.GetClothesByCategoryId(id);
            return _mapper.Map<IEnumerable<ClothDTO>>(entities);
        }
    }
}
