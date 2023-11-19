using AutoMapper;
using InnoGotchi.BLL.Interfaces;
using InnoGotchi.DAL.Entities.Base;
using InnoGotchi.DAL.Interfaces;

namespace InnoGotchi.BLL.Services.Base
{
    public sealed class Service<T, D> : IService<T, D> where T : BaseEntity where D : class
    {
        private readonly IRepository<T> _repository;
        private readonly IMapper _mapper;

        public Service(
            IMapper mapper,
            IRepository<T> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public void Create(D entityDTO)
        {
            var entity = _mapper.Map<T>(entityDTO);
            _repository.Insert(entity);
        }

        public void Update(D entityDTO)
        {
            var entity = _mapper.Map<T>(entityDTO);
            _repository.Update(entity);
        }

        public void Delete(int entityId)
        {
            var entity = _repository.Get(entityId);
            _repository.Delete(entity);
        }

        public D Get(int entityId)
        {
            var entity = _mapper.Map<D>(_repository.Get(entityId));

            return entity;
        }

        public List<D> GetAll()
        {
            var entityList = _repository.GetAll().ToList();

            List<D> entityDTOList = new List<D>();

            foreach (var entity in entityList)
            {
                D entityDTO = _mapper.Map<D>(entity);
                entityDTOList.Add(entityDTO);
            }

            return entityDTOList;
        }
    }
}
