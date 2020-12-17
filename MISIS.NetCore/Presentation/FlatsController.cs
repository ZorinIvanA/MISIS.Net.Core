using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISIS.NetCore.Domain;

namespace MISIS.NetCore.Presentation
{
    [Route("api/flats")]
    [ApiController]
    public class FlatsController : MisisControllerBase
    {
        private IService _servce;

        public FlatsController(IService service)
        {
            _servce = service ?? throw new ArgumentNullException(nameof(service));
        }

        [HttpGet]
        public IActionResult Get()
        {
            return ExecuteLogic<Flat[]>();
        }


        protected override IActionResult DoTheLogic<T>()
        {
            return Ok(_servce.GetFlats());
        }
    }
}
