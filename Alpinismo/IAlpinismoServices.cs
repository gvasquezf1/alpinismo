using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using Alpinismo.BD;

namespace Alpinismo
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IAlpinismoServices" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IAlpinismoServices
    {

        [OperationContract]
        string insertar(AlpinismoBE hboe);

        [OperationContract]
        DataSet listar();

    }
}
