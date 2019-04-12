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
    public class FeaturesController : ControllerBase
    {
        private readonly VegaDbContext _context;

        public IMapper _mapper { get; }

        public FeaturesController(VegaDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<FeatureResource>> GetFeatures()
        {
            var features = await _context.Features.ToListAsync();

            return _mapper.Map<List<Feature>, List<FeatureResource>>(features);
        }
    }
}