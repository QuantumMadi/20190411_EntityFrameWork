using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIgrations
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new UsersContext())
            {
                context.Users.ToList();
            }
        }
    }
}
