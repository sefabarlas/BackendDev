using AutoMapper;
using Contracts;
using Entities.Dtos;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SomeFeatureEntitiesController : ControllerBase
    {
        private ILoggerManager _logger;
        private IRepositoryWrapper _repository;
        private IMapper _mapper;

        public SomeFeatureEntitiesController(ILoggerManager logger, IRepositoryWrapper repository, IMapper mapper)
        {
            _logger = logger;
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var someFeatureEntities = _repository.SomeFeatureEntity.GetAll();
                var mappedSomeFeatureEntities = _mapper.Map<IEnumerable<SomeFeatureEntityDto>>(someFeatureEntities);

                _logger.LogInfo($"Returned all some feature entities from database");
                return Ok(mappedSomeFeatureEntities);
            }
            catch (Exception e)
            {
                _logger.LogError($"Something went wrong inside GetAll action: {e.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("{id}", Name = "SomeFeatureEntityById")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                var someFeatureEntity = _repository.SomeFeatureEntity.GetByGuidId(id);
                if (someFeatureEntity is null)
                {
                    _logger.LogError($"Some feature entity with id: {id}, hasn't been found in database");
                    return NotFound();
                }

                var mappedSomeFeatureEntity = _mapper.Map<SomeFeatureEntityDto>(someFeatureEntity);
                _logger.LogInfo($"Returned some feature entity with id: {id}");
                return Ok(mappedSomeFeatureEntity);
            }
            catch (Exception e)
            {
                _logger.LogError($"Something went wrong inside GetById action: {e.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("{id}/someFeatureEntityDetail")]
        public IActionResult GetByIdWithDetails(Guid id)
        {
            try
            {
                var someFeatureEntity = _repository.SomeFeatureEntity.GetSomeFeatureEntityWithDetails(id);
                if (someFeatureEntity is null)
                {
                    _logger.LogError($"Some feature entity with id: {id}, hasn't been found in database");
                    return NotFound();
                }

                var mappedSomeFeatureEntity = _mapper.Map<SomeFeatureEntityDto>(someFeatureEntity);
                _logger.LogInfo($"Returned some feature entity with id: {id}");
                return Ok(mappedSomeFeatureEntity);
            }
            catch (Exception e)
            {
                _logger.LogError($"Something went wrong inside GetById action: {e.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost]
        public IActionResult Create([FromBody] SomeFeatureEntityForCreationDto data)
        {
            try
            {
                if (data is null)
                {
                    _logger.LogError("Some feature entity object sent from client is null.");
                    return BadRequest("Some feature entity object is null");
                }

                if (!ModelState.IsValid)
                {
                    _logger.LogError("Invalid some feature entity object sent from client.");
                    return BadRequest("Invalid some feature entity object");
                }

                SomeFeatureEntity mappedSomeFeatureEntity = _mapper.Map<SomeFeatureEntity>(data);
                _repository.SomeFeatureEntity.Create(mappedSomeFeatureEntity);
                _repository.Save();

                SomeFeatureEntityDto createdSomeFeatureEntity = _mapper.Map<SomeFeatureEntityDto>(mappedSomeFeatureEntity);
                return CreatedAtRoute("SomeFeatureEntityById", new { id = createdSomeFeatureEntity.Id }, createdSomeFeatureEntity);
            }
            catch (Exception e)
            {
                _logger.LogError($"Something went wrong inside Create action: {e.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}