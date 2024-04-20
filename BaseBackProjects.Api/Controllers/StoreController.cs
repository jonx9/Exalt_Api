using Application.Cqrs.IndicatorType.Commands;
using Application.Cqrs.IndicatorType.Querys;
using Application.Cqrs.Store.Querys;
using Application.Cqrs.User.Commands;
using BaseBackProjects.Api.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace Exalt.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class StoreController : ApiControllerBase
    {
        /// <summary>
        /// Obtain all Store
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet("By/Estatus/ReportDate")]
        public async Task<IActionResult> GetStore([FromQuery] GetIndicatorTypeQuery query)
        {
            return Ok(await Mediator.Send(query));
        }

        /// <summary>
        /// Obtain all Store by Id 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetStoreById(Guid Id)
        {
            return Ok(await Mediator.Send(new GetIndicatorTypeByIdQuery() { Id = Id }));
        }

        [HttpGet("All")]
        public async Task<IActionResult> GetStore()
        {
            return Ok(await Mediator.Send(new GetAllIndicatorTypeQuery()));
        }



        /// <summary>
        /// Post Store
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> PostStore([FromBody] PostIndicatorTypeCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        /// <summary>
        /// modify a Store by the id
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> PutStore([FromBody] PutIndicatorTypeCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        /// <summary>
        /// Delete a Store by the id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteStore(Guid Id)
        {
            return Ok(await Mediator.Send(new DeleteIndicatorTypeCommand() { Id = Id }));
        }

    }
}
