using Microsoft.AspNetCore.Mvc;
using MyConcept.Data;
using MyConcept.Data.Entities;

namespace MyConcept.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController(MyConceptContext DbContext) : ControllerBase
    {
        [HttpGet("AddShoes")]
        public async Task AddShoes()
        {
            var shoe = new ShoeEntity { Colour = "white", Name = "Sneakers", Size = "38", CreatedDate = DateTime.UtcNow };
            await DbContext.AddAsync(shoe);

            var shoe2 = new ShoeEntity { Colour = "purple", Name = "Pumps", Size = "41", CreatedDate = DateTime.UtcNow };
            await DbContext.AddAsync(shoe2);

            await DbContext.SaveChangesAsync();
        }
    }
}
