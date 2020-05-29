using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Controle_Acesso.Models;

namespace Controle_Acesso.Controllers
{
    public class TB_ALUNO_TURMAController : Controller
    {
        private DB_CONTROLEACESSOEntities db = new DB_CONTROLEACESSOEntities();

        // GET: TB_ALUNO_TURMA
        public ActionResult Index()
        {
            var tB_ALUNO_TURMA = db.TB_ALUNO_TURMA.Include(t => t.TB_ALUNO).Include(t => t.TB_TURMA);
            return View(tB_ALUNO_TURMA.ToList());
        }

        // GET: TB_ALUNO_TURMA/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TB_ALUNO_TURMA tB_ALUNO_TURMA = db.TB_ALUNO_TURMA.Find(id);
            if (tB_ALUNO_TURMA == null)
            {
                return HttpNotFound();
            }
            return View(tB_ALUNO_TURMA);
        }

        // GET: TB_ALUNO_TURMA/Create
        public ActionResult Create()
        {
            ViewBag.COD_ALUNO = new SelectList(db.TB_ALUNO, "COD_ALUNO", "NOME");
            ViewBag.COD_TURMA = new SelectList(db.TB_TURMA, "COD_TURMA", "SERIE");
            return View();
        }

        // POST: TB_ALUNO_TURMA/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "COD_ALUNO,COD_TURMA,ANO,SEMESTRE")] TB_ALUNO_TURMA tB_ALUNO_TURMA)
        {
            if (ModelState.IsValid)
            {
                db.TB_ALUNO_TURMA.Add(tB_ALUNO_TURMA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.COD_ALUNO = new SelectList(db.TB_ALUNO, "COD_ALUNO", "NOME", tB_ALUNO_TURMA.COD_ALUNO);
            ViewBag.COD_TURMA = new SelectList(db.TB_TURMA, "COD_TURMA", "SERIE", tB_ALUNO_TURMA.COD_TURMA);
            return View(tB_ALUNO_TURMA);
        }

        // GET: TB_ALUNO_TURMA/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TB_ALUNO_TURMA tB_ALUNO_TURMA = db.TB_ALUNO_TURMA.Find(id);
            if (tB_ALUNO_TURMA == null)
            {
                return HttpNotFound();
            }
            ViewBag.COD_ALUNO = new SelectList(db.TB_ALUNO, "COD_ALUNO", "NOME", tB_ALUNO_TURMA.COD_ALUNO);
            ViewBag.COD_TURMA = new SelectList(db.TB_TURMA, "COD_TURMA", "SERIE", tB_ALUNO_TURMA.COD_TURMA);
            return View(tB_ALUNO_TURMA);
        }

        // POST: TB_ALUNO_TURMA/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "COD_ALUNO,COD_TURMA,ANO,SEMESTRE")] TB_ALUNO_TURMA tB_ALUNO_TURMA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tB_ALUNO_TURMA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.COD_ALUNO = new SelectList(db.TB_ALUNO, "COD_ALUNO", "NOME", tB_ALUNO_TURMA.COD_ALUNO);
            ViewBag.COD_TURMA = new SelectList(db.TB_TURMA, "COD_TURMA", "SERIE", tB_ALUNO_TURMA.COD_TURMA);
            return View(tB_ALUNO_TURMA);
        }

        // GET: TB_ALUNO_TURMA/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TB_ALUNO_TURMA tB_ALUNO_TURMA = db.TB_ALUNO_TURMA.Find(id);
            if (tB_ALUNO_TURMA == null)
            {
                return HttpNotFound();
            }
            return View(tB_ALUNO_TURMA);
        }

        // POST: TB_ALUNO_TURMA/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TB_ALUNO_TURMA tB_ALUNO_TURMA = db.TB_ALUNO_TURMA.Find(id);
            db.TB_ALUNO_TURMA.Remove(tB_ALUNO_TURMA);
            db.SaveChanges();
            return RedirectToAction("Index");
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
