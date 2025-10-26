using Domain.Entities;
using Infrastructure.Persistence;
using Repository.Respositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Respositories
{
    public class ActorRepository : GenericRepository<Actor>, IActorRepository
    {
        public ActorRepository(AppDbContext context) : base(context) { }
    }
}
