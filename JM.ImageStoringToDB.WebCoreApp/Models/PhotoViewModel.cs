using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JM.ImageStoringToDB.WebCoreApp.Models
{
    public class PhotoViewModel
    {
        public string PhotoName { get; set; }

        public IFormFile PhotoBinary { get; set; }
    
        public string Ocassion { get; set; }
    }
}
