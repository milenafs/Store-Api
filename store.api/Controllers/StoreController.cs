using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections;

namespace Store.Api.Controllers
{
    [ApiController]
    [Route("stores")]

    public class StoreControllers : ControllerBase
    {
        private static List<Store> StaticStores()
        {
            List<Store> storesList = new List<Store>
            {
                new Store(26754, "Teste De Carga 0543" ,new Guid("2bf783d7-8ebe-430c-801f-a5501b3b4f92")),
                new Store(26755, "Teste De Carga 0544" ,new Guid("7f4df5f7-285e-4f61-9835-6c346c1004a2")),
                new Store(26756, "Teste De Carga 0545" ,new Guid("5915bc76-2e88-4404-8514-37627a8944c1")),
                new Store(26757, "Teste De Carga 0546" ,new Guid("604111ff-d8df-4305-88f3-b5c606486a1e")),
                new Store(26758, "Teste De Carga 0547" ,new Guid("5d97ea6b-c207-4e1f-8734-9eca136af5c1")),
                new Store(26759, "Teste De Carga 0548" ,new Guid("89601dbb-d29a-4cee-8902-85decf56b501")),
                new Store(26760, "Teste De Carga 0549" ,new Guid("c55f22d9-b1e5-4439-8a3f-c36fe4c97627")),
                new Store(26761, "Teste De Carga 0550" ,new Guid("64143cfd-cb69-4c8c-99df-72d20c748e79")),
                new Store(26762, "Teste De Carga 0551" ,new Guid("42c39266-db47-4405-ae19-256458931c92")),
                new Store(26763, "Teste De Carga 0552" ,new Guid("e1fba75f-ee09-4963-a0e2-29b9481384f1"))
            };
            return storesList;
        }


        [HttpGet]
        [SwaggerOperation(Summary = "Return all the stores")]
        [ProducesResponseType(typeof(IList<Store>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetStores()
        {
            return Ok(StaticStores());
        }

        [Route("{storeIdGuid}"), HttpGet]
        [SwaggerOperation(Summary = "Return a specific store by its IdGuid")]
        [ProducesResponseType(typeof(Store), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetStoreByIdGuid(Guid storeIdGuid)
        {
            if (storeIdGuid == null)
                return BadRequest();

            var Store = StaticStores().FirstOrDefault(s => s.StoreIdGuid.Equals(storeIdGuid));

            if(Store == null)
                return NotFound();

            return Ok(Store);
        }

        [Route("exist/{storeIdGuid}"), HttpGet]
        [SwaggerOperation(Summary = "Return true if the store exists")]
        public async Task<Boolean> StoreExist(Guid storeIdGuid)
        {
            if (storeIdGuid == null) return false;

            var Store = StaticStores().FirstOrDefault(s => s.StoreIdGuid.Equals(storeIdGuid));

            if (Store == null) return false;

            return true;
        }

    }
}