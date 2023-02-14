using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WalksAPI.Models.Domain;
using WalksAPI.Repository;

namespace WalksAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        private readonly IRegionRepository regionRepository;

        public RegionController(IRegionRepository regionRepository)
        {
            this.regionRepository = regionRepository;
        }
        [HttpGet]
        public IActionResult GetAllRegion()
        {
            #region Static Data List
            //var regions = new List<Region>()
            //{
            //    new Region()
            //    {
            //        Id= Guid.NewGuid(),
            //        Name= "Kolkata",
            //        Code = "Kol",
            //        Area = 600000,
            //        Latitude= 23.6,
            //        Longitude=29.9,
            //        Population=1000000
            //        },
            //    new Region()
            //    {
            //        Id= Guid.NewGuid(),
            //        Name= "Delhi",
            //        Code = "Del",
            //        Area = 600000,
            //        Latitude= 23.6,
            //        Longitude=29.9,
            //        Population=1000000

            //    }
            //};
            #endregion

            var regions=regionRepository.GetAll();

            // Return regions DTO
            var regionsDTO = new List<Models.DTO.Region>();
            regions.ToList().ForEach(region =>
            {
                var regionDTO = new Models.DTO.Region()
                {
                    Id = region.Id,
                    Name = region.Name,
                    Area = region.Area,
                    Code = region.Code,
                    Latitude = region.Latitude,
                    Longitude = region.Longitude,
                    Population = region.Population
                };
                regionsDTO.Add(regionDTO);
            });
            return Ok(regionsDTO);
        }
    }
}
