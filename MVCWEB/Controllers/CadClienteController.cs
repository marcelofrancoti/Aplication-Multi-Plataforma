using GTIEntity;
using MVCWEB.Models;
using MVCWEB.Services;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace MVCWEB.Controllers
{

    [Route("{action=listar}")]
    public class CadClienteController : Controller
    {
        CadastroClienteViewModel _cadastroClienteViewModel;

        ConsumoAPIClienteEndereco _consumoAPIClienteEndereco;
        ConsumoAPICliente _consumoAPICliente;

        public CadClienteController()
        {
            _consumoAPIClienteEndereco = new ConsumoAPIClienteEndereco();
            _consumoAPICliente = new ConsumoAPICliente();
        }

        ActionResult Index()
        {
            return View();
        }

        // GET: CadCliente
        [Route("listar")]
        public ActionResult Index(string buscar, int pageNumber = 1)
        {
            List<CadastroClienteViewModel> _cadastroClienteViewModels = new List<CadastroClienteViewModel>();

            var listCliente = _consumoAPICliente.Get();

            if (listCliente != null && listCliente.Count() > 0)
            {
                foreach (var item in listCliente)
                {
                    _cadastroClienteViewModel = new CadastroClienteViewModel();
                    _cadastroClienteViewModel = item;

                    IEnumerable<ClienteEndereco> listClienteEndereco = _consumoAPIClienteEndereco.GetPorId(item.ClienteId);

                    _cadastroClienteViewModel.listaEndere = new List<ClienteEndereco>();
                    _cadastroClienteViewModel.listaEndere = listClienteEndereco;

                    _cadastroClienteViewModels.Add(_cadastroClienteViewModel);
                }
            }

            return View(_cadastroClienteViewModels);

        }



        // GET: CadCliente/Details/5
        public ActionResult Details(int id)
        {
            CadastroClienteViewModel cadastroClienteViewModel = new CadastroClienteViewModel();
            ConsumoAPICliente consumoAPICliente = new ConsumoAPICliente();

            cadastroClienteViewModel = consumoAPICliente.GetPorId(id);

            return View(cadastroClienteViewModel);

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
                consumoAPICliente.Inserir(model);

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
            CadastroClienteViewModel cadastroClienteViewModel = new CadastroClienteViewModel();

            ConsumoAPICliente consumoAPICliente = new ConsumoAPICliente();

            cadastroClienteViewModel = consumoAPICliente.GetPorId(id);

            return View(cadastroClienteViewModel);
        }

        // POST: CadCliente/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Cliente model)
        {
            try
            {
                ConsumoAPICliente consumoAPICliente = new ConsumoAPICliente();

                consumoAPICliente.Alterar(model);

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
            ConsumoAPICliente consumoAPICliente = new ConsumoAPICliente();
        
            return View(consumoAPICliente.GetPorId(id));
        }

        // POST: CadCliente/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {

                ConsumoAPICliente consumoAPICliente = new ConsumoAPICliente();

                consumoAPICliente.Excluir(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
