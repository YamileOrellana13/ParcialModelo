using System.Data.Entity;
                        // eliminos las librerias con control + .
namespace MVCParcial.Models
{
    public class DataContext:DbContext                          //DbContex y damos control + . el primero
    {
        public DataContext(): base("DefaultConnection")             // damos ctor tab tab
        {

        }

        public System.Data.Entity.DbSet<MVCParcial.Models.Product> Products { get; set; }
    }
}