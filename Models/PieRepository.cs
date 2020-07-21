using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext appDbContext;

        public PieRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IEnumerable<Pie> AllPies => appDbContext.Pies.Include(p=>p.Category);

        public IEnumerable<Pie> PiesOfTheWeek => appDbContext.Pies.Include(p => p.Category).Where(p=>p.IsPieOfTheWeek);

        public Pie GetPieById(int id)
        {
            var result = appDbContext.Pies.Find(id);
            return result;
        }
    }
}
