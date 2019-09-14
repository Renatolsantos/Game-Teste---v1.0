using Microsoft.AspNetCore.Mvc;

namespace Game_Teste___v1._0___Controller.Process
{

    [Route("api/")]
    [ApiController]
    public class GameCProcess : ControllerBase
    {
        public ActionResult Teste()
        {
            return Ok();
        }
    }
}
