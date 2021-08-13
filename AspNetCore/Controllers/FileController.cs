using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Controllers
{
    public class FileController : Controller
    {
        public IActionResult List()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files"));
            var files = directoryInfo.GetFiles();

            return View(files);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string fileName)
        {
            FileInfo fileInfo = new FileInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files", fileName));
            if (!fileInfo.Exists)
            {
                fileInfo.Create();
            }

            return RedirectToAction("List");
        }

        public IActionResult CreateWithData()
        {
            FileInfo fileInfo = new FileInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files", Guid.NewGuid().ToString() + ".txt"));
            
            StreamWriter writer = fileInfo.CreateText();
            writer.Write(" Zero To One ");
            writer.Close();

            return RedirectToAction("List");
        }

        public IActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Upload(IFormFile formFile)
        {
            //if (formFile.ContentType == / )
            //{

            //}

            var extension = Path.GetExtension(formFile.FileName);

            var path = Directory.GetCurrentDirectory() + "/wwwroot" + "/pdfs/" + Guid.NewGuid() + extension;
            FileStream fileStream = new FileStream(path, FileMode.Create);
            formFile.CopyTo(fileStream);

            return RedirectToAction("List");
        }

        public IActionResult Delete(string fileName)
        {
            FileInfo fileInfo = new FileInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files", fileName));
            if (fileInfo.Exists)
            {
                fileInfo.Delete();
            }

            return RedirectToAction("List");
        }
    }
}