using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace StoreApi.Controllers
{
    [ApiController]
    [Route("stores")]

    public class StoreControllers : ControllerBase
    {
        private static List<Store> StaticStores()
        {
            List<Store> storesList = new List<Store>
            {
                new Store(26754, "Teste De Carga 0543" ,"2bf783d7-8ebe-430c-801f-a5501b3b4f92"),
                new Store(26755, "Teste De Carga 0544" ,"7f4df5f7-285e-4f61-9835-6c346c1004a2"),
                new Store(26756, "Teste De Carga 0545" ,"5915bc76-2e88-4404-8514-37627a8944c1"),
                new Store(26757, "Teste De Carga 0546" ,"604111ff-d8df-4305-88f3-b5c606486a1e"),
                new Store(26758, "Teste De Carga 0547" ,"5d97ea6b-c207-4e1f-8734-9eca136af5c1"),
                new Store(26759, "Teste De Carga 0548" ,"89601dbb-d29a-4cee-8902-85decf56b501"),
                new Store(26760, "Teste De Carga 0549" ,"c55f22d9-b1e5-4439-8a3f-c36fe4c97627"),
                new Store(26761, "Teste De Carga 0550" ,"64143cfd-cb69-4c8c-99df-72d20c748e79"),
                new Store(26762, "Teste De Carga 0551" ,"42c39266-db47-4405-ae19-256458931c92"),
                new Store(26763, "Teste De Carga 0552" ,"e1fba75f-ee09-4963-a0e2-29b9481384f1")
            };
            return storesList;
        }


        [HttpGet]
        //TODO: arrumar summary do swagger
        //[SwaggerOperation(Summary = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA")]
        [ProducesResponseType(typeof(IList<Store>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetStores()
        {
            return Ok(StaticStores());
        }

        [Route("{storeId}"), HttpGet]
        [ProducesResponseType(typeof(Store), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetStoreById(string storeId)
        {
            if (storeId == null)
                return BadRequest();

            List<Store> storesList = StaticStores();

            for(int i = 0;i < storesList.Count; i++)
            {
                if (storesList[i].StoreIdGuid == storeId)
                    return Ok(storesList[i]);
            }

            return NotFound();
        }

        //TODO: criar endpoint pra pegar loja por id
    }
}