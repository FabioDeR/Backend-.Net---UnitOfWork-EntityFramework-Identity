using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLearn360.Repository
{
    public class CategoryRepository : Repository<Guid, Category>, ICategoryRepository
    {
		private readonly DbSet<Category> _entities;
		private readonly Elearn360DBContext _context;

		public CategoryRepository(Elearn360DBContext context) : base(context)
		{
			_context = context;
			_entities = _context.Set<Category>();
		}
	}
}
