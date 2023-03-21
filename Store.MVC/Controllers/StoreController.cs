using Store.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections;
using StoreModel = Store.MVC.Models.Store;

namespace Store.MVC.Controllers
{
    [ApiController]
    [Route("stores")]

    public class StoreControllers : ControllerBase
    {
        private readonly ApiDbContext _context;

        public StoreControllers(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "Return all the stores")]
        [ProducesResponseType(typeof(IList<StoreModel>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetStores()
        {
            var store = _context.Stores.FirstOrDefault();

            //var store = _context.Stores.Select((s) => new
            //{
            //    IdGuid = s.IdGuid,
            //    Name = s.Name,
            //}).ToList();

            return Ok(store);
        }

        [Route("{storeIdGuid}"), HttpGet]
        [SwaggerOperation(Summary = "Return a specific store by its IdGuid")]
        [ProducesResponseType(typeof(StoreModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetStoreByIdGuid(Guid storeIdGuid)
        {
            if (storeIdGuid == null)
                return BadRequest();

            var Store = _context.Stores.FirstOrDefault(s => s.IdGuid.Equals(storeIdGuid));

            if(Store == null)
                return NotFound();

            return Ok(Store);
        }

        // TODO: Endpoint to insert new store in  mongoDB
        //

    }
}