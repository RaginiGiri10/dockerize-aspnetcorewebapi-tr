using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PlatformService.Models;
using PlatformService.Repository;
using PlatformService.ViewModels;

namespace PlatformService.Controllers
{
     [Route("api/[controller]")]
     [ApiController]
    public class PlatformController:ControllerBase
    {
        private readonly IPlatformRepository _platformRepository;
        private readonly IMapper _mapper;

        public PlatformController(IPlatformRepository platformRepository,IMapper mapper)
        {
            _platformRepository = platformRepository;
            _mapper = mapper;
        }

        public IActionResult GetPlatforms()
        {
            var platforms = _platformRepository.GetPlatforms();
            if(!platforms.Any()){
                return NotFound();
            }
            return Ok(platforms);

        } 


        [HttpGet("{id}")]
        public IActionResult GetPlaform(int id)
        {
            var platform = _platformRepository.GetPlatformById(id);
            if(platform==null){
                return NotFound($"Platform with id = {id} is not found");
            }

            return Ok(platform);
        }


       [HttpPost]
       public IActionResult Create([FromBody] CreatePlatformViewModel createPlatformViewModel)
       {
            var platform = _mapper.Map<Platform>(createPlatformViewModel);
            _platformRepository.CreatePlatform(platform);
            return Ok(platform);
        }

    }
}