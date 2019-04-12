using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Hamedani.Controllers.Resources;
using Hamedani.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hamedani.Controllers
{
    [Route("api/[controller]")]
	[ApiController]
    public class MakesController : ControllerBase
    {
        private readonly VegaDbContext _context;

        public IMapper _mapper { get; }

        public MakesController(VegaDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
            var makes = await _context.Makes.Include(m => m.Models).ToListAsync();

            return _mapper.Map<List<Make>, List<MakeResource>>(makes);
        }
    }
}