using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityPersonas
{
    public class EPersonas
    {
        public int id { get; set; }

        public string Nombre { get; set; }

        public string Paterno { get; set; }

        public string Materno { get; set; }

        public int Edad { get; set; }

        public DateTime Fechaalta { get; set; }

        private string fechaformato;

        public string fecha
        {
            get {
                fechaformato = Fechaalta.ToString("dd/MM/yyyy");
                return fechaformato; }
            
        }

    }
}
