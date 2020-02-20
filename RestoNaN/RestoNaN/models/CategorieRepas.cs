using System;
namespace RestoNaN.models
{
    public class CategorieRepas
    {
        public int id { get; set; }
        public string nom { get; set; }
        public DateTime date_add { get; set; }
        public DateTime date_upd { get; set; }
        public bool status { get; set; }
    }
}
