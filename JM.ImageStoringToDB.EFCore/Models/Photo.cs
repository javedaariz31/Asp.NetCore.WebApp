using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JM.ImageStoringToDB.EFCore.Data.Models
{
    public class Photo
    {
        [Key]
        public int Id { get; set; }

        public string PhotoName { get; set; }

        public byte[] PhotoBinary { get; set; }

        public string Ocassion { get; set; }

    }
}
