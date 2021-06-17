using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice2.patron
{
    class gmail : clase_abstracta
    {
        public override string preparar_html()
        {
            string html = string.Format(@"
            Hola querido {0}
            enviado desde gmail
            ", "nombre");
            return html;
        }

        public override void _enviar_correo(string html)
        {
            MessageBox.Show("mensage enviado"+html);
        }
    }
}
