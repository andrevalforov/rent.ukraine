using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using RentCourse.Data.EFContext;
using RentCourse.Models;

namespace RentCourse.Services
{
    public class FileService
    {
        EFDbContext _context;
        IHostingEnvironment _appEnvironment;
        
        public async Task AddFile(IFormFile uploadedFile)
        {
            if (uploadedFile != null)
            {
                string id = Guid.NewGuid().ToString();
                string name = id + ".jpg";
                // путь к папке Files
                string path = "/files/" + name;
                // сохраняем файл в папку Files в каталоге wwwroot
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }

                FileModel file = new FileModel { Id = id, Name = name, Path = path };
                _context.Files.Add(file);
                _context.SaveChanges();
            }
        }
    }
}
