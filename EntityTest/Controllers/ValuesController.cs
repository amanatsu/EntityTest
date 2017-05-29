using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Common;

namespace EntityTest.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            //参考http://turing.hatenablog.com/entry/2016/07/16/170001
            //Modelsの新規作成でクラスからEntity Data Modelをえらび、データベースからCodeFirstを選びました。
            Models.TestDBContext _db;
            _db = new Models.TestDBContext();
            string[] ret = _db.mClerks.Where(a => (a.nDisplayFlagID == 0)).Select(a => a.sDisplayName.ToString()).ToArray();

            //Modelクラスを少し変え、SQLConnectionを動的にセットするようにしました
            Models.ClerkDBContext _clk;
            var connection = DbProviderFactories.GetFactory("System.Data.SqlClient").CreateConnection();
            connection.ConnectionString = "data source=DBSE05;initial catalog=MGWG_HotelData;user id=sa;password=dyn;MultipleActiveResultSets=True;App=EntityFramework";
            _clk = new Models.ClerkDBContext(connection);
            string[] ret2 = _clk.mClerks.Where(a => (a.nDisplayFlagID == 0)).Select(a => a.sDisplayName.ToString()).ToArray();

            return ret2;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
