using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GestaoComercial.Web.Models;
using GestaoComercial.Web.ViewModels.Produtos;

namespace GestaoComercial.Web.Controllers
{
    [Authorize]
    [RoutePrefix("produtos")]
    public class ProdutosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Produtos
        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            if (!this.Request.IsAjaxRequest())
                return Redirect("~/");

            return PartialView("Index", new ProdutosViewModel()
            {
                Titulo = "Título veio do controller",
                Produtos = db.Produtos.ToList()
            });
        }

        // GET: Produtos/Details/5
        [HttpGet]
        [Route("detalhes/{id:guid}")]
        public ActionResult Details(Guid? id)
        {
            if (!this.Request.IsAjaxRequest())
                return Redirect("~/");

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Produto produto = db.Produtos.Find(id);

            if (produto == null)
            {
                return HttpNotFound();
            }

            return PartialView(produto);
        }

        // GET: Produtos/Create
        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {
            if (!this.Request.IsAjaxRequest())
                return Redirect("~/");

            return PartialView();
        }

        // POST: Produtos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Route("create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Descricao,Valor")] Produto produto)
        {
            if (!this.Request.IsAjaxRequest())
                return Redirect("~/");

            if (ModelState.IsValid)
            {
                produto.Id = Guid.NewGuid();
                db.Produtos.Add(produto);
                db.SaveChanges();

                return Index();
            }

            return PartialView(produto);
        }

        [HttpGet]
        [Route("editar/{id:guid}")]
        public ActionResult Edit(Guid? id)
        {
            if (!this.Request.IsAjaxRequest())
                return Redirect("~/");

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto produto = db.Produtos.Find(id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            return PartialView(produto);
        }

        // POST: Produtos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Route("editar/{id:guid}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Descricao,Valor")] Produto produto)
        {
            if (!this.Request.IsAjaxRequest())
                return Redirect("~/");

            if (ModelState.IsValid)
            {
                db.Entry(produto).State = EntityState.Modified;
                db.SaveChanges();

                return Index();
            }

            return PartialView(produto);
        }

        // GET: Produtos/Delete/5
        [Route("excluir/{id:guid}")]
        public ActionResult Delete(Guid? id)
        {
            if (!this.Request.IsAjaxRequest())
                return Redirect("~/");

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto produto = db.Produtos.Find(id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            return PartialView(produto);
        }

        // POST: Produtos/Delete/5
        [HttpPost, ActionName("Delete")]
        [Route("excluir/{id:guid}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            if (!this.Request.IsAjaxRequest())
                return Redirect("~/");

            Produto produto = db.Produtos.Find(id);
            db.Produtos.Remove(produto);
            db.SaveChanges();

            return Index();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
