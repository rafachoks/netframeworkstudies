using Blinks.Project.Domain;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blinks.Project.Service
{
    public interface IBaseService<TEntity> where TEntity : BaseEntity
    {
        TEntity Add<TValidator>(TEntity entity) where TValidator : AbstractValidator<TEntity>;

        void Update<TValidator>(TEntity entity) where TValidator : AbstractValidator<TEntity>;

        IList<TEntity> GetAll();

        TEntity Get(int id);

        void Delete(int id);
    }
}
