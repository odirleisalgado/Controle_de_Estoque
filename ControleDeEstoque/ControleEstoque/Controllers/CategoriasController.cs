using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleEstoque.Models.Contexto;
using ControleEstoque.Models.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace ControleEstoque.Controllers
{
    public class CategoriasController : Controller
    {
        //Construtor da classe
        private readonly Contexto _contexto;
        public CategoriasController(Contexto contexto)
        {
            _contexto = contexto;
        }

        //Listar dados
        public IActionResult Index()
        {
            var lista = _contexto.Categoria.ToList();
            return View(lista);
        }

        //Instância do Objeto Categoria
        [HttpGet]
        public IActionResult Create()
        {
            var categoria = new Categoria();
            return View(categoria);
        }

        //Criação de uma nova Categoria
        [HttpPost]
        public IActionResult Create(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                _contexto.Categoria.Add(categoria);
                _contexto.SaveChanges();

                return RedirectToAction("Index");

            }
            return View(categoria); 
        }

        //Mostrar Categoria a ser editada
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var categoria = _contexto.Categoria.Find(Id);
            if (categoria != null)
            {
                return View(categoria);
            }
            return View(categoria);           
        }

        //Editar Categoria
        [HttpPost]
        public IActionResult Edit(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                _contexto.Categoria.Update(categoria);
                _contexto.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View(categoria);
              
            }
        }

        //Mostrar Categoria a ser deletada
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var categoria = _contexto.Categoria.Find(Id);
            return View(categoria);

        }

        //Deletar Categoria
        [HttpPost]
        public IActionResult Delete(Categoria _categoria)
        {
            var categoria = _contexto.Categoria.Find(_categoria.Id);
            if (categoria != null)
            {
                _contexto.Categoria.Remove(categoria);
                _contexto.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(categoria);
        }
        //Detalhes da Categoria
        [HttpGet]
        public IActionResult Details(int Id)
        {
            var categoria = _contexto.Categoria.Find(Id);
            return View(categoria);

        }


    }
}