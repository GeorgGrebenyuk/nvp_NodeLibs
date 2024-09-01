using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teigha.DatabaseServices;

namespace NVP_nanoCAD_Platform_NET
{
    /// <summary>
    /// Вспомогательный интерфейс для создания классов, реализующих получение\изменение объектов модели nanoCAD по ObjectId
    /// </summary>
    public interface IEditAction
    {
#if NET48

#endif
        object GetData(ObjectId id, object modeRaw);
        void SetData(ObjectId id, object modeRaw, object data);
    }
}
