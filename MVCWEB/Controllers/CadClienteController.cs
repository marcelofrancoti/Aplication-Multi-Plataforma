using Entity;
using MVCWEB.Models;
using MVCWEB.Services;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
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

            _cadastroClienteViewModel = _consumoAPICliente.GetPorId(id);
            _cadastroClienteViewModel.ClienteEndereco = _consumoAPIClienteEndereco.GetPorId(id).FirstOrDefault();

            return View(_cadastroClienteViewModel);
        }

        // GET: CadCliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CadCliente/Create
        [HttpPost]
        public async Task<ActionResult> Create(CadastroClienteViewModel model)
        {
            try
            {
                HttpResponseMessage resposta = _consumoAPICliente.InserirHttpResponse(model.ToEntity());

                if (resposta.IsSuccessStatusCode)
                {
                    CadastroClienteViewModel clienteFiltrado = _consumoAPICliente.Get().Where(f => f.CPF.Equals(model.CPF)).Select(f => f).FirstOrDefault();
                    model.ClienteEndereco.ClienteId = clienteFiltrado.ClienteId;

                    HttpResponseMessage respostaEndereco = _consumoAPIClienteEndereco.InserirHttpResponse(model.ClienteEndereco);
                    if (resposta.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        string erro = await resposta.Content.ReadAsStringAsync();
                        return View("Error", new ErrorViewModel { ErrorMessage = erro });
                    }

                }
                else
                {
                    string erro = await resposta.Content.ReadAsStringAsync();
                    return View("Error", new ErrorViewModel { ErrorMessage = erro });
                }
            }
            catch (Exception ex)
            {
                return View("Error", new ErrorViewModel { ErrorMessage = ex.Message });
            }
        }



        // GET: CadCliente/Edit/5
        public ActionResult Edit(int id)
        {
            _cadastroClienteViewModel = _consumoAPICliente.GetPorId(id);
            _cadastroClienteViewModel.ClienteEndereco = _consumoAPIClienteEndereco.GetPorId(id).FirstOrDefault();
            return View(_cadastroClienteViewModel);
        }

        // POST: CadCliente/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, CadastroClienteViewModel model)
        {
            try
            {
                _consumoAPICliente.Alterar(model.ToEntity());
                model.ClienteEndereco.ClienteId = model.ClienteId;


                _consumoAPIClienteEndereco.Alterar(model.ClienteEndereco);

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
            _consumoAPICliente.Excluir(id);

            return RedirectToAction("Index");
        }

        public ActionResult getEndereco(int id)
        {
            IEnumerable<ClienteEndereco> listClienteEndereco = _consumoAPIClienteEndereco.GetPorId(id);
            return Json(listClienteEndereco, JsonRequestBehavior.AllowGet);
        }
    }
}
