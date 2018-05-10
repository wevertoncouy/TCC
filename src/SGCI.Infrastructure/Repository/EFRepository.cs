using Microsoft.EntityFrameworkCore;
using SGCI.ApplicationCore.Interfaces.Repository;
using SGCI.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SGCI.Infrastructure.Repository
{
    public class EFRepository<TEmtity> : IRepository<TEmtity> where TEmtity : class
    {


        protected readonly GestaoCarteiraContext _dbContext;

        public EFRepository(GestaoCarteiraContext dbContext)
        {
            _dbContext = dbContext;
        }


        public TEmtity Adicionar(TEmtity entity)
        {
            _dbContext.Set<TEmtity>().Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public void Atualizar(TEmtity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public IEnumerable<TEmtity> Buscar(Expression<Func<TEmtity, bool>> predicado)
        {
            return _dbContext.Set<TEmtity>().Where(predicado).AsEnumerable();
        }

        public TEmtity ObterPorId(int id)
        {
            return _dbContext.Set<TEmtity>().Find(id);
        }

        public IEnumerable<TEmtity> ObterTodos()
        {
            return _dbContext.Set<TEmtity>().AsEnumerable();
        }

        public void Remover(TEmtity entity)
        {
            _dbContext.Set<TEmtity>().Remove(entity);
            _dbContext.SaveChanges();
        }
    }
}
