using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace diploma.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;database=recipebook;user=root;password= ;");
            MySqlCommand query = conn.CreateCommand();
            query.CommandText = $"select * from users where user_id = {id}";
            try{
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex) {
                return "failure: "+ ex;
            }
            MySqlDataReader fetch_query = query.ExecuteReader();
            while (fetch_query.Read())
            {
                return fetch_query["login"].ToString();
            }
            return "kek";
          
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
