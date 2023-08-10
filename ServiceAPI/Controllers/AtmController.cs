using MeasurementsWebAPI.BusinessLogic.Interfaces;
using MeasurementsWebAPI.BusinessLogic.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MeasurementsWebAPI.ServiceAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AtmController : ControllerBase
    {
        private readonly IAtmBusinessManager _atmBusinessManager;
        private readonly ILogger _logger;

        public AtmController(IAtmBusinessManager atmBusinessManager)
        {
            _atmBusinessManager = atmBusinessManager;
            //_logger = logger;
        }

        [HttpGet(),
        ProducesResponseType((int)HttpStatusCode.OK),
        ProducesResponseType((int)HttpStatusCode.BadRequest),
        ProducesResponseType((int)HttpStatusCode.NotFound),
        ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<ActionResult<IEnumerable<Atm>>> Get()
        {
            try
            {
                return Ok(await _atmBusinessManager.GetAll());
            }
            catch (Exception ex)
            {
                var errorMessage = "Failed to retrieve list of ATMs!";
                //_logger.LogError(errorMessage, ex);

                return StatusCode((int) HttpStatusCode.InternalServerError, errorMessage);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Atm?>> Get(int id)
        {
            try
            {
                return Ok( await _atmBusinessManager.SingleOrDefault(x=>x.Id==id));
            }
            catch (Exception ex)
            {
                var errorMessage = $"Failed to retrieve ATM with ID {id}!";
                //_logger.LogError(errorMessage, ex);

                return StatusCode((int)HttpStatusCode.InternalServerError, errorMessage);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Atm atm)
        {
            try
            {
                _atmBusinessManager.Insert(atm);
                return Ok("Success!");
            }
            catch (Exception ex)
            {
                var errorMessage = $"Failed to insert new ATM!";
                //_logger.LogError(errorMessage, ex);

                return StatusCode((int)HttpStatusCode.InternalServerError, errorMessage);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Atm atm)
        {
            try
            {
                _atmBusinessManager.Update(atm);
                return Ok("Success!");
            }
            catch (Exception ex)
            {
                var errorMessage = $"Failed to update ATM with ID {id}!";
                //_logger.LogError(errorMessage, ex);

                return StatusCode((int)HttpStatusCode.InternalServerError, errorMessage);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                _atmBusinessManager.Delete(id);
                return Ok("Success!");
            }
            catch (Exception ex)
            {

                var errorMessage = $"Failed to delete ATM with ID {id}!";
                //_logger.LogError(errorMessage, ex);

                return StatusCode((int)HttpStatusCode.InternalServerError, errorMessage);
            }
        }
    }
}
