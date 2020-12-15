using System;
using System.Collections.Generic;
using System.Text;

namespace Exe.Core
{
    // “Code” (string), “Name” (string) e “Description” (string), Price (int).
    public class Product
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

    }
}
