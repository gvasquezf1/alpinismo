using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using Alpinismo.BD;

namespace HOST_PRUEBA
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAlpinismoServices" in both code and config file together.
    [ServiceContract]
    public interface IAlpinismoServices
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        string insertar(AlpinismoBE hboe);

        [OperationContract]
        DataSet listar();
    }
}
