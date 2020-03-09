using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZKTecoFingerPrintScanner_Implementation.Helpers
{
    public class PersonModel
    {
        public int CEDULA { get; set; }
        public string NOMBRE { get; set; }
        public string HUELLA { get; set; }
        public int STATUS { get; set; }
        public string FECHA_INSC { get; set; }
        public string TIPO_INSC { get; set; } //SI ES PARA EL GYM O PARA EL KICKBOXING
    }
}
