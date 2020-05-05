using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnirAsistentModel.Models;

namespace TurnirAsistentModel.DataAccess
{
    public class TextConnector : IDataConnection
    {
        public NagradaModel NapraviNagradu(NagradaModel model)
        {
            model.ID = 1;
            return model;
        }
    }
}
