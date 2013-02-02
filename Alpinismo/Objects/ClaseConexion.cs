using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alpinismo.BD
{
    class ClaseConexion
    {
        public static string ObtenerCadenaMINSURBAS()
        {


            string strCnx = "Server=f241ef81-a42d-44bf-b58f-a15700037eb4.sqlserver.sequelizer.com;Database=dbf241ef81a42d44bfb58fa15700037eb4;User ID=hpgjhzlferqsdzht;Password=EYKK6U3ZjWsUPCZtb2eRmZSEVGWJNZxeCT3EF8BiAbtiYxGQ68H3PLdMgfWx7sks;";

            if (object.ReferenceEquals(strCnx, string.Empty))
            {
                return string.Empty;
            }
            else
            {
                return strCnx;
            }



        }



    }
}
