using Application.Cqrs.IndicatorType.Commands;
using Application.Cqrs.IndicatorType.Querys;
using Application.Cqrs.Sales.Querys;
using Application.Cqrs.Sales.Commands;
using BaseBackProjects.Api.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace Exalt.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class SalesController : ApiControllerBase
    {
        /// <summary>
        /// Obtain all Store
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet("By/Estatus/ReportDate")]
        public async Task<IActionResult> GetSales([FromQuery] SalesGetIndicatorTypeQuery query)
        {
            return Ok(await Mediator.Send(query));
        }

        /// <summary>
        /// Obtain all Store by Id 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetSalesById(Guid Id)
        {
            return Ok(await Mediator.Send(new SalesGetIndicatorTypeByIdQuery() { Id = Id }));
        }






        [HttpGet("All")]
        public async Task<IActionResult> GetSales()
        {
            return Ok(await Mediator.Send(new SalesGetAllIndicatorTypeQuery()));
        }



        /// <summary>
        /// Post Store
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> PostSales([FromBody] SalesPostIndicatorTypeCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        ///// <summary>
        ///// modify a Store by the id
        ///// </summary>
        ///// <param name="command"></param>
        ///// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> PutSales([FromBody] SalesPutIndicatorTypeCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        /// <summary>
        /// Delete a Store by the id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteSales(Guid Id)
        {
            return Ok(await Mediator.Send(new SalesDeleteIndicatorTypeCommand() { Id = Id }));
        }

    }
}
