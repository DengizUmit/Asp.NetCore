using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Controllers
{
    public class FolderController : Controller
    {
        public IActionResult List()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot"));
            var folders = directoryInfo.GetDirectories();

            return View(folders);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string folderName)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", folderName));
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }

            return RedirectToAction("List");
        }

        public IActionResult Delete(string folderName)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", folderName));
            if (directoryInfo.Exists)
            {
                directoryInfo.Delete(true);
            }

            return RedirectToAction("List");
        }
    }
}
