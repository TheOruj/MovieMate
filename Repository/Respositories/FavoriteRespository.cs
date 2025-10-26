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
    public class FavoriteRespository : GenericRepository<Favorite> , IFavoriteRespository
    {
        public FavoriteRespository(AppDbContext context) : base(context) { }
    }
}
