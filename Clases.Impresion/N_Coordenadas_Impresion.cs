using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Impresion
{
    public class N_Coordenadas_Impresion
    {
        private string _posicionX;
        private string _posicionY;

        public string PosicionY
        {
            get { return _posicionY; }
            set { _posicionY = value; }
        }

        public string PosicionX
        {
            get { return _posicionX; }
            set { _posicionX = value; }
        }

    }
}
