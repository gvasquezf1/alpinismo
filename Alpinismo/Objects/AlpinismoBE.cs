using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alpinismo.BD
{
    public class AlpinismoBE
    {
        private  string _Deporte;
        public string Deporte
        {
            get { return _Deporte; }
            set { _Deporte = value; }
        }

        private string _Horario;
        public string Horario
        {
            get { return _Horario; }
            set { _Horario = value; }
        }



        private string _Tipo;
        public string Tipo
        {
            get { return _Tipo; }
            set { _Tipo = value; }
        }


    }
}
