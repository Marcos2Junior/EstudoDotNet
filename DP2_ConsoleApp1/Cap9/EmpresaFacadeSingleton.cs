using System;
using System.Collections.Generic;
using System.Text;

namespace DP2_ConsoleApp1.Cap9
{
    class EmpresaFacadeSingleton
    {
        private static EmpresaFacade instancia = new EmpresaFacade();

        public EmpresaFacade Instancia
        {
            get
            {
                return instancia;
            }
        }
    }
}
