using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.net.core.ejemplo.Models;
using api.net.core.ejemplo.Repository;
using api.net.core.ejemplo.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.net.core.ejemplo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelController : ControllerBase
    {
        private readonly IModelItemRepository _modelRepository;

        public ModelController(IModelItemRepository modelRepository)
        {
            _modelRepository = modelRepository;
        }

        // GET api/model/id
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var entity = await _modelRepository.Get(id);
            return Ok();
        }

        // GET api/model/id
        [HttpGet]
        [Route("where /{id}")]
        public IActionResult GetWhere(int id)
        {
            var entity = _modelRepository.GetWhere(id);
            return Ok();
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ModelRequest request)
        {
            var entity = new ModelItem
            {
                EsCliente = true,
                Nombre = request.Nombre
            };

            await _modelRepository.AddModelItem(entity);

            return Ok();
        }

        // PUT api/model/5
        [HttpPut]
        public void Put([FromBody] ModelItem model)
        {
            _modelRepository.UpdateModelItem(model);
        }

        [HttpPatch]
        public void Patch([FromBody] ModelItem model)
        {
            _modelRepository.UpdateModelItem(model);
        }

        // DELETE api/model/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _modelRepository.Delete(id);
        }
    }
}