﻿using ConsultasMVC.Entities;
using EnerSave.Views.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ConsultasMVC.Controllers
{
    //[Authorize]
    public class TgastosAguaController : Controller
    {
        private readonly ITgastosAguaStore _model;

        public TgastosAguaController(ITgastosAguaStore model)
        {
            _model = model;
        }

        // GET: TgastosAgua
        public async Task<IActionResult> Index()
        {
            return View(await _model.GetAll());
        }

        // GET: TgastosAgua/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tgastosAgua = await _model.GetById(id);
            if (tgastosAgua == null)
            {
                return NotFound();
            }

            return View(tgastosAgua);
        }

        // GET: TgastosAgua/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TgastosAgua/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MetrosCubicos,Periodo,UsuarioId")] GastosAguaViewModel tgastosAgua)
        {
            if (ModelState.IsValid)
            {
                await _model.Post(tgastosAgua);
                return RedirectToAction(nameof(Index));
            }
            return View(tgastosAgua);
        }

        // GET: TgastosAgua/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tgastosAgua = await _model.GetById(id);
            if (tgastosAgua == null)
            {
                return NotFound();
            }
            return View(tgastosAgua);
        }

        // POST: TgastosAgua/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MetrosCubicos,Periodo,UsuarioId")] GastosAguaEntity tgastosAgua)
        {
            if (id != tgastosAgua.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _model.Update(tgastosAgua);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TgastosAguaExists(tgastosAgua.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(tgastosAgua);
        }

        // GET: TgastosAgua/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tgastosAgua = await _model.GetById(id);
            if (tgastosAgua == null)
            {
                return NotFound();
            }

            return View(tgastosAgua);
        }

        // POST: TgastosAgua/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _model.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        private bool TgastosAguaExists(int id)
        {
            return _model.Exists(id);
        }
    }
}
