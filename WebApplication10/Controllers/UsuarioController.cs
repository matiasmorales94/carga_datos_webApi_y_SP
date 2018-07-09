using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using WebApplication10.Models;

namespace WebApplication10.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }

        // GET: Usuario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuario/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuario/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Usuario/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Usuario/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //Obtener Usuarios JSON

        [HttpGet]
        public Boolean ObtenerDatos() {

            try
            {

                string strgUrlRequest = "http://jsonplaceholder.typicode.com/posts";

                var json = new WebClient().DownloadString(strgUrlRequest);

                JavaScriptSerializer ser = new JavaScriptSerializer();


                var list = JsonConvert.DeserializeObject<List<Usuario>>(json);


                foreach (var us in list) {

                    Usuario user = new Usuario();
                    user.userId = us.userId;
                    user.id = us.id;
                    user.title = us.title;
                    user.body = us.body;


                    user.guardarUsuario(user);
                    

                       
                    }

                return true;
            


            }

            catch (Exception ex) {

                Console.WriteLine("Error :"+ ex.Message);

                return false;
            }


           
        }
    }
}
