using ExamenVueling.Domain.Models;
using ExamenVueling.Infrastructure.Repository.Contracts;
using ExamenVueling.Infrastructure.Repository.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenVueling.Infrastructure.Repository.Repository
{
    public class AlumnoRepository : IRepository<AlumnoEntity>
    {
        public AlumnoEntity Add(AlumnoEntity model)
        {
            // Aqui se haria el automapper para pasar a objeto 
            throw new NotImplementedException();
        }

        public List<AlumnoEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public AlumnoEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Remove(int id)
        {
            throw new NotImplementedException();
        }

        public AlumnoEntity Update(AlumnoEntity model)
        {
            throw new NotImplementedException();
        }
    }
}
