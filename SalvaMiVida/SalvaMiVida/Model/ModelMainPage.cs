using System;
using System.Collections.Generic;
using System.Text;

namespace SalvaMiVida.Model
{


    public class Item
    {
        public int cuenta { get; set; }
    }

    public class Link
    {
        public string rel { get; set; }
        public string href { get; set; }
    }

    public class ModelMainPage
    {
        public List<Item> items { get; set; }
        public bool hasMore { get; set; }
        public int limit { get; set; }
        public int offset { get; set; }
        public int count { get; set; }
        public List<Link> links { get; set; }
    }

}
