using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCOREMVC.Models
{
    public class HomeModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public List<HomeModel> Getall()
        {
            HomeModel item;

            List<HomeModel> Lista = new List<HomeModel>();

            item = new HomeModel();
            item.Id = 1;
            item.Nome = "luis";
            Lista.Add(item);

            item = new HomeModel();
            item.Id = 2;
            item.Nome = "Mauricio";
            Lista.Add(item);

            return Lista;
        }
    }
}
