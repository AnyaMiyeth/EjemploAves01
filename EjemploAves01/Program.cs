using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploAves01
{
    class Program
    {
        static void Main(string[] args)
        {
            ImpresoraModelo2000 impresora2000 = new ImpresoraModelo2000();
            ImpresoraModelo2001 impresora2001 = new ImpresoraModelo2001();

            impresora2000.Imprimir();
            impresora2001.();
        }
    }
}
