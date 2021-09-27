using System;
using System.Collections.Generic;
using System.Text;

namespace PurchListApp
{
    public class Artikel
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Beschreibung { get; set; } = "";
        public string ImgLink { get; set; } = "default.jpg";

        public int Count { get; set; } = 1;

    }
}
