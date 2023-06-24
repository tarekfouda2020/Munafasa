using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using static System.Net.Mime.MediaTypeNames;

namespace Munafasa.Utilities
{
	public class FileHelper
	{
        private readonly IWebHostEnvironment _hostEnvironment;

        public FileHelper(IWebHostEnvironment hostEnvironment)
        {
            _hostEnvironment = hostEnvironment;
        }

        public async Task<string> SaveFile(IFormFile file, string path, string? prevFile = null)
		{
            var rootPath = _hostEnvironment.WebRootPath;
            var localPath = Path.Combine(rootPath, @""+path+"");
            var extension = Path.GetExtension(file.FileName);
            var fileName = Guid.NewGuid().ToString() + extension;
            //check if there is old image to remove the old one
            if (prevFile != null)
            {
                var oldPath = Path.Combine(rootPath, prevFile);
                if (File.Exists(oldPath))
                {
                    File.Delete(oldPath);
                }
            }

            using (var fileStream = new FileStream(Path.Combine(localPath, fileName), FileMode.Create))
            {
               await file.CopyToAsync(fileStream);

            }
            return @"" + path + "" + fileName;
        }

        public void DeleteFiles( List<string> paths)
        {
            var rootPath = _hostEnvironment.WebRootPath;
            //check if there is old image to remove the old one
            foreach (var item in paths)
            {
                var oldPath = Path.Combine(rootPath, item);
                if (File.Exists(oldPath))
                {
                    File.Delete(oldPath);
                }
            }

        }

        public void DeleteFile(string path)
        {
            var rootPath = _hostEnvironment.WebRootPath;
            var oldPath = Path.Combine(rootPath, path);
            if (File.Exists(oldPath))
            {
                File.Delete(oldPath);
            }

        }
    }
}

