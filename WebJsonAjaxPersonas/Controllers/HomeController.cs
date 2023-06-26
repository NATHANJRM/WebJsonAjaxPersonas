using BussPersonas;
using EntityPersonas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebJsonAjaxPersonas.Controllers
{
    public class HomeController : Controller
    {
        BPersonas bus = new BPersonas();
        EPersonas per = new EPersonas();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Obtener()
        {
            try
            {
                List<EPersonas> list = bus.Obtener();
                return Json(new { mensaje = "ok", ls = list }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new {mensaje = ex.Message }, JsonRequestBehavior.AllowGet);                
            }
        }

        public JsonResult Agregar(EPersonas p)
        {
            try
            {
                bus.Agregar(p);
                return Json(new { mensaje = "ok" }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

                return Json(new { mensaje = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult Obtenerid(int id)
        {
            try
            {
               EPersonas pid = bus.Obtenerid(id);
                return Json(new { mensaje = "ok", pid = pid }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { mensaje = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult Eliminar(int id)
        {
            try
            {
                bus.Eliminar(id);
                return Json(new { mensaje = "ok" }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

                return Json(new { mensaje = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult Editar(EPersonas p)
        {
            try
            {
                bus.Editar(p);
                return Json(new { mensaje = "ok" }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

                return Json(new { mensaje = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult Buscar(string valor)
        {
            try
            {
                List<EPersonas> busca = bus.Buscar(valor);
                return Json(new { mensaje = "ok", sear = busca }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

                return Json(new { mensaje = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}