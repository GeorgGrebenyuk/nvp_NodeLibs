using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

namespace Common.LibraryService
{
    [NVP_Manifest(
        Text = "Инициализирует подключение к Библиотеке компонентов для начала работы",
        ViewType = "Data")]
    public class LibraryService_Constructor : INode
    {
        public BIMStructureMgd.Common.LibraryService _o;
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            _o = BIMStructureMgd.Common.LibraryService.GetLibraryService();
            return new NodeResult(this);
        }
    }

    [NVP_Manifest(
        Text = "Добавляет объект в Библиотеку и возвращает его идентификатор в Библиотеке",
        ViewType = "Modifier")]
    [NodeInput("LibraryService", typeof(object))]
    [NodeInput("Teigha.Entity", typeof(object))]
    public class AddObject : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            dynamic _input0 = inputs[0].Value;
            BIMStructureMgd.Common.LibraryService _service = (BIMStructureMgd.Common.LibraryService)_input0._o;

            dynamic _input1_object = inputs[1].Value;
            int response = _service.AddObject(_input1_object._o);

            return new NodeResult(response);
        }
    }
}
