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
    public class FlatsController : ControllerBase
    {
        private IService _servce;

        public FlatsController(IService service)
        {
            _servce = service ?? throw new ArgumentNullException(nameof(service));
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_servce.GetFlats());
        }
    }
}
