using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Alpinismo.BD;

namespace Alpinismo
{   
    public class AlpinismoServices : IAlpinismoServices
    {



        AlpinismoDAO hbdo = new AlpinismoDAO();
        public string insertar(BD.AlpinismoBE hboe)
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
