using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Alpinismo.BD;
using HOST_PRUEBA;
using System.Data;

namespace HOST_PRUEBA
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AlpinismoServices" in code, svc and config file together.
    public class AlpinismoServices : IAlpinismoServices
    {
        public void DoWork()
        {
        }

        AlpinismoDAO hbdo = new AlpinismoDAO();
        public string insertar(AlpinismoBE hboe)
        {

            int cant = hbdo.validaHobie(hboe.Deporte);


            if (cant > 0)
            {
                throw new System.ArgumentException("El Hobbie fue ingresado , Desea registrar otro Hobbie", "original");


            }
            else
            {
                hbdo.insertHobie(hboe);
                return "La Grabacion fue Exitosa";
            }

        }

        public System.Data.DataSet listar()
        {
            return hbdo.gethobies();

        }
    }
}
