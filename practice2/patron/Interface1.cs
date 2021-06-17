using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice2.patron
{
  abstract  class clase_abstracta
    {
        public abstract string preparar_html();
        public abstract void _enviar_correo(string html);

        public void enviar_correo()
        {
            _enviar_correo(preparar_html());
        }
    }
}
