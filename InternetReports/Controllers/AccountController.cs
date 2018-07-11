using InternetReports.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.Owin;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace InternetReports.Controllers
{
    public class AccountController : Controller
    {

        protected AppUserManager _userManager;
        protected IAuthenticationManager _authManager;
        RoleManager<AppRole> _roleManager;
        protected ARCHIVOS_ALT Catalogos = new ARCHIVOS_ALT();

        public AppUserManager UserManager {
            get
            {
                _userManager = _userManager ?? HttpContext.GetOwinContext().Get<AppUserManager>();
                return _userManager;
            }
            private set
            {
                _userManager = value;
            }
        }

        public RoleManager<AppRole> RoleManager
        {
            get
            {
                _roleManager = _roleManager ?? HttpContext.GetOwinContext().Get<RoleManager<AppRole>>();
                return _roleManager;
            }
            private set
            {
                _roleManager = value;
            }
        }

        public IAuthenticationManager AuthManager {
            get
            {
                _authManager = _authManager ?? HttpContext.GetOwinContext().Authentication;
                return _authManager;
            }
            private set
            {
                _authManager = value;
            }
        }

        // GET: Account
        // GET: Account/Login
        public ActionResult Login()
        {
            return View();
        }

        // POST: Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel login)
        {
            if (ModelState.IsValid)
            {
                AppUser user = await UserManager.FindAsync(login.Email, login.Password);
                if(user != null)
                {
                    var ident = await UserManager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);
                    AuthManager.SignIn(new AuthenticationProperties { IsPersistent = false }, ident);
                    return Redirect(login.ReturnUrl ?? Url.Action("Index", "Operaciones",new {area="Reportes" }));
                }
                
            }

            ModelState.AddModelError("Error de autenticación", "El nombre de usuario no existe o la contraseña es inválida. Verifique nuevamente.");
            return View(login);
        }

        // POST: /Account/LogOff
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            AuthManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            return RedirectToAction("Login", "Account");
        }

        //GET: Account/Registrar
        [HttpGet]
        [AllowAnonymous]
        public ActionResult Registrar()
        {
            //Obtenemos clientes para que el usuario se registre a un cliente especifico
            var CatalogoClientes = Catalogos.CatClientes.OrderBy(o => o.Nom1).Select(s => new SelectListItem()
            {
                Text = s.Nom1 + " (" + s.IdCli + ")",
                Value = s.IdCli.ToString()
            }).ToList();

            CatalogoClientes.Insert(0, new SelectListItem() { Text = "D.A. Hinojosa (Admin)", Value = "0" });

            ViewBag.Clientes = CatalogoClientes;

            return View();
        }

        //POST: Account/Registrar
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Registrar(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                int clienteIdNumero = Convert.ToInt32(model.IdCliente);
                var cliente = Catalogos.CatClientes.Where(w => w.IdCli == clienteIdNumero).Take(1).FirstOrDefault();

                var user = new AppUser { UserName = model.Email, Email = model.Email, ClientId=model.IdCliente, NombreCliente= cliente == null? "": cliente.Nom1 };
                var result = await UserManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    if(model.IdCliente == "0")
                    {
                        AppRole adminRole = await RoleManager.FindByNameAsync("Administrador");
                        if(adminRole == null)
                        {
                            adminRole = new AppRole("Administrador");
                            await RoleManager.CreateAsync(adminRole);
                        }
                            await UserManager.AddToRoleAsync(UserManager.FindByName(model.Email).Id , "Administrador");
                    }

                    return RedirectToAction("Login","Account");
                }
                AddErrors(result);
            }

            //Obtenemos clientes para que el usuario se registre a un cliente especifico
            var CatalogoClientes = Catalogos.CatClientes.OrderBy(o => o.Nom1).Select(s => new SelectListItem()
            {
                Text =s.Nom1 + " ("+s.IdCli +")",
                Value = s.IdCli.ToString()
            }).ToList();

            //Agregamos el de Hinojosa para agregar admins
            CatalogoClientes.Insert(0, new SelectListItem() { Text = "D.A. Hinojosa (Admin)", Value = "0" });

            ViewBag.Clientes = CatalogoClientes;

            // Si llegamos a este punto, es que se ha producido un error y volvemos a mostrar el formulario
            return View(model);
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }


        //// GET: Account/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: Account/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Account/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Account/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Account/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Account/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Account/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
