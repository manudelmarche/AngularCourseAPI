using Microsoft.AspNetCore.Mvc;

namespace BootCampApi.Controllers
{

    // GET api/values
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {

        // GET api/values
        [HttpGet]
        public ActionResult Get()
        {
            return new JsonResult(Singleton.Instance.items);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return new JsonResult(Singleton.Instance.items.Find(item => item.Id == id));
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] EventItem value)
        {
            var count = Singleton.Instance.items.Count;
            value.Id = count + 1;
            Singleton.Instance.items.Add(value);
            return Ok(value.Id);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] EventItem value)
        {
            var item = Singleton.Instance.items.Find(v => v.Id == id);
            item = value;
            return Ok();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = Singleton.Instance.items.Find(item => item.Id == id);
            Singleton.Instance.items.Remove(result);
            return Ok();
        }
    }
}

