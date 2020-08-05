using System;
using System.Collections.Generic;
using System.IdentityModel.Protocols.WSTrust;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DALI;
using Microsoft.EntityFrameworkCore;


namespace WebApiiPloomes.Controllers {
    public class ContatoController : ApiController {
        // GET: api/Contato
        public IEnumerable<Contato> Get() {
            using (TESTEntities db = new TESTEntities()) {
                return db.Contatoes.ToList();
            }
        }

        // GET: api/Contato/5
        public string Get(int id) {
            return "";
        }

        // POST: api/Contato
        public HttpResponseMessage post([FromBody] Contato contato) {
            int resp = 0;
            HttpResponseMessage msg = null;
            try {
                using (TESTEntities entities = new TESTEntities()) {
                    entities.Entry(contato).State = (System.Data.Entity.EntityState)EntityState.Added;
                    resp = entities.SaveChanges();
                    msg = Request.CreateResponse(HttpStatusCode.OK, resp);
                }
            } catch (Exception ex) {
                msg = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
            return msg;

        }

        // PUT: api/Contato/5
        //public HttpResponseMessage Put([FromBody] Contato contato) {
        //    int resp = 0;
        //    HttpResponseMessage msg = null;
        //    try {
        //        using (TESTEntities entities = new TESTEntities()) {
        //            entities.Entry(contato).State = (System.Data.Entity.EntityState)EntityState.Modified;
        //            resp = entities.SaveChanges();
        //            msg = Request.CreateResponse(HttpStatusCode.OK, resp);
        //        }
        //    } catch (Exception ex) {
        //        msg = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
        //    }
        //    return msg;
        //}


        // DELETE: api/Contato/5
//        public HttpResponseMessage Delete([FromBody] Contato contato) {

//            int resp = 0;
//            HttpResponseMessage msg = null;

//            try {
//                using (TESTEntities entities = new TESTEntities()) {
//                    entities.Entry(contato).State = (System.Data.Entity.EntityState)EntityState.Deleted;
//                    resp = entities.SaveChanges();
//                    msg = Request.CreateResponse(HttpStatusCode.OK, resp); 
//                }
//            } catch (Exception ex) {
                
//                msg = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);

//            }
//            return msg;
        }
    }
//}

