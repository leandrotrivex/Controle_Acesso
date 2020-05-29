﻿using System;
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
    public class TB_ALUNOController : Controller
    {
        private DB_CONTROLEACESSOEntities db = new DB_CONTROLEACESSOEntities();

        // GET: TB_ALUNO
        public ActionResult Index()
        {
            return View(db.TB_ALUNO.ToList());
        }

        // GET: TB_ALUNO/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TB_ALUNO tB_ALUNO = db.TB_ALUNO.Find(id);
            if (tB_ALUNO == null)
            {
                return HttpNotFound();
            }
            return View(tB_ALUNO);
        }

        // GET: TB_ALUNO/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TB_ALUNO/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "COD_ALUNO,NOME,RM,DATA_NASCIENTO,SEXO")] TB_ALUNO tB_ALUNO)
        {
            if (ModelState.IsValid)
            {
                db.TB_ALUNO.Add(tB_ALUNO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tB_ALUNO);
        }

        // GET: TB_ALUNO/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TB_ALUNO tB_ALUNO = db.TB_ALUNO.Find(id);
            if (tB_ALUNO == null)
            {
                return HttpNotFound();
            }
            return View(tB_ALUNO);
        }

        // POST: TB_ALUNO/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "COD_ALUNO,NOME,RM,DATA_NASCIENTO,SEXO")] TB_ALUNO tB_ALUNO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tB_ALUNO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tB_ALUNO);
        }

        // GET: TB_ALUNO/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TB_ALUNO tB_ALUNO = db.TB_ALUNO.Find(id);
            if (tB_ALUNO == null)
            {
                return HttpNotFound();
            }
            return View(tB_ALUNO);
        }

        // POST: TB_ALUNO/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TB_ALUNO tB_ALUNO = db.TB_ALUNO.Find(id);
            db.TB_ALUNO.Remove(tB_ALUNO);
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
