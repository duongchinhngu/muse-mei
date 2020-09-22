using AutoMapper;
using MuseMeiV2.DTOs;
using MuseMeiV2.Models;
using MuseMeiV2.Repositories.CategoryRepositories;
using MuseMeiV2.UnitOfWorks;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MuseMeiV2.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public CategoryRepository CategoryRepository => _unitOfWork.CategoryRepository;

        public async Task Add(CategoryDTO dto)
        {
            Category category = _mapper.Map<Category>(dto);
            CategoryRepository.Insert(category);
            await _unitOfWork.commitAsync();
        }

        public async Task Delete(int id)
        {
            CategoryRepository.Delete(id);
            await _unitOfWork.commitAsync();
        }

        public async Task<CategoryDTO> Get(int id)
        {
            Category category =  await CategoryRepository.GetById(id);
            CategoryDTO dto = _mapper.Map<CategoryDTO>(category);
            return dto;
        }

        public async Task<IEnumerable<CategoryDTO>> GetAll()
        {
            IEnumerable<Category> categories = await CategoryRepository.GetAll();
            IEnumerable<CategoryDTO> dtos = _mapper.Map<IEnumerable<CategoryDTO>>(categories);
            return dtos;
        }

        public async Task Update(CategoryDTO dto)
        {
            Category category = _mapper.Map<Category>(dto);
            CategoryRepository.Update(category);
            await _unitOfWork.commitAsync();
        }
    }
}
