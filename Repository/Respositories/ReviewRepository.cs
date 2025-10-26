using Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Respositories
{
    public class ReviewRepository : GenericRepository<Domain.Entities.Review>, Interfaces.IReviewRepository
    {
        public ReviewRepository(AppDbContext context) : base(context) { }
    }
}
