﻿using ConsultasMVC.Controllers.abstractions;
using ConsultasMVC.dbenersave;
using EnerSave.Views.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ConsultasMVC.Controllers
{
    public class TgastosEnergiaController : Controller
    {
        private readonly ITgastosEnergiaModel _model;

        public TgastosEnergiaController(ITgastosEnergiaModel model)
        {
            _model = model;
        }

        // GET: TgastosAgua
        public async Task<IActionResult> Index()
        {
            return View(await _model.getAllGastos());
        }

        // GET: TgastosAgua/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tgastosAgua = await _model.getGastosById(id);
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
        public async Task<IActionResult> Create([Bind("Id,MetrosCubicos,Periodo,UsuarioId")] GastosEnergiaViewModel tgastos)
        {
            if (ModelState.IsValid)
            {
                await _model.postGastos(tgastos);
                return RedirectToAction(nameof(Index));
            }
            return View(tgastos);
        }

        // GET: TgastosAgua/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tgastos = await _model.getGastosById(id);
            if (tgastos == null)
            {
                return NotFound();
            }
            return View(tgastos);
        }

        // POST: TgastosAgua/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MetrosCubicos,Periodo,UsuarioId")] TgastosEnergia tgastos)
        {
            if (id != tgastos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _model.updateGastos(tgastos);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TgastosExists(tgastos.Id))
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
            return View(tgastos);
        }

        // GET: TgastosAgua/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tgastosAgua = await _model.getGastosById(id);
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
            await _model.deleteGastos(id);
            return RedirectToAction(nameof(Index));
        }

        private bool TgastosExists(int id)
        {
            return _model.gastosExists(id);
        }


    }
}