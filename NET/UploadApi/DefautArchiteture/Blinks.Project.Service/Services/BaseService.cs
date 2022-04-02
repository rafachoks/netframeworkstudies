using Blinks.Project.Data;
using Blinks.Project.Domain;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blinks.Project.Service.Services
{
    internal class BaseService<TEntity> : IBaseService<TEntity> where TEntity : BaseEntity
    {
        private readonly IBaseRepository<TEntity> _baseRepository;

        public BaseService(IBaseRepository<TEntity> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public TEntity Add<TValidator>(TEntity entity) where TValidator : AbstractValidator<TEntity>
        {
            BaseService<TEntity>.Validate(entity, Activator.CreateInstance<TValidator>());
            _baseRepository.Add(entity);
            return entity;
         }

        public void Delete(int id)
        {
            _baseRepository.Delete(id);
        }

        public TEntity Get(int id)
        {
            return _baseRepository.Get(id);
        }

        public IList<TEntity> GetAll()
        {
           return _baseRepository.GetAll();
        }

        public void Update<TValidator>(TEntity entity) where TValidator : AbstractValidator<TEntity>
        {
            BaseService<TEntity>.Validate(entity, Activator.CreateInstance<TValidator>());
            _baseRepository.Update(entity);
        }

        private static void Validate<TValidator>(TEntity entity, TValidator validator) where TValidator : AbstractValidator<TEntity>
        {
            if(entity == null)
                throw new ArgumentNullException(nameof(entity));

            validator.ValidateAndThrow(entity);
        }
    }
}
