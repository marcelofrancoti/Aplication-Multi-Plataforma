using GTIEntity;
using MVCWEB.Services;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWEB.Controllers
{

    [Route("{action=listar}")]
    public class CadClienteController : Controller
    {
              ActionResult Index()
        {
            return View();
        }

        // GET: CadCliente
        [Route("listar")]
        public ActionResult Index(string buscar, int pageNumber = 1)
        {
            int PageSize = 500;
            ConsumoAPICliente consumoAPICliente = new ConsumoAPICliente();

            var paged = consumoAPICliente.GetClientes(buscar, PageSize, pageNumber);
            ViewBag.TotalCount = Math.Ceiling((double)paged.Count / PageSize);
            ViewBag.PageNumber = pageNumber;
            ViewBag.SearchData = buscar;

            return View(paged.List);
        }



        // GET: CadCliente/Details/5
        public ActionResult Details(int id)
        {
            ConsumoAPICliente consumoAPICliente = new ConsumoAPICliente();

            var cliente = consumoAPICliente.GetClientePorId(id);

            return View(cliente);

        }

        // GET: CadCliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CadCliente/Create
        [HttpPost]
        public ActionResult Create(Cliente model)
        {
            try
            {
                ConsumoAPICliente consumoAPICliente = new ConsumoAPICliente();
                consumoAPICliente.InserirCliente(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CadCliente/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CadCliente/Edit/5
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

        // GET: CadCliente/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CadCliente/Delete/5
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
    }
}
