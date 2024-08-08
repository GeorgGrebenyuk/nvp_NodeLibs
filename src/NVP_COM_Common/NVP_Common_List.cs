using NVP.API.Nodes;
using System;
using System.Collections.Generic;
using NVP_Manifest_Creator;

namespace NVP_COM_Common.List
{
    [NVP_Manifest(
    Id = "1D55F6EB-7935-42FC-89CD-1BFCE83070F4",
    PathAssembly = "NVP_COM_Common.dll",
    PathExecuteClass = "NVP_COM_Common.List.NVP_Common_List",
    CoderName = "GeorgGrebenyuk",
    Folder = "NVP_COM_Common.List",
    NodeName = "List_Create",
    NodeType = "Loaded",
    CADType = "None",
    Text = "Create an empty collection",
    ViewType = "Default")]
    [NodeInput("Размер", typeof(int))]
    public class List_Create : INode
    {
        public List<object> _elements;
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            int list_size = (int)inputs[0].Value;
            _elements = new List<object>(list_size);
            return new NodeResult(_elements); ;
        }
    }

    [NVP_Manifest(
    Id = "28E37B1F-3BE7-46C2-819E-4DD36A616B0D",
    PathAssembly = "NVP_COM_Common.dll",
    PathExecuteClass = "NVP_COM_Common.List.NVP_Common_List_Add",
    CoderName = "GeorgGrebenyuk",
    Folder = "NVP_COM_Common.List",
    NodeName = "List_Add",
    NodeType = "Loaded",
    CADType = "None",
    Text = "Add element in collection and return the edited original collection",
    ViewType = "Data")]
    [NodeInput("List", typeof(object))]
    [NodeInput("Any object", typeof(object))]
    public class List_Add : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            List<object> elements = inputs[0].Value as List<object>;
            elements.Add(inputs[1].Value);
            return new NodeResult(elements);
        }
    }

    [NVP_Manifest(
    Id = "8BE6163B-35AC-4F5B-8A9B-13F6E1D0F0D7",
    PathAssembly = "NVP_COM_Common.dll",
    PathExecuteClass = "NVP_COM_Common.List.NVP_Common_List_GetElements",
    CoderName = "GeorgGrebenyuk",
    Folder = "NVP_COM_Common.List",
    NodeName = "List_GetElements",
    NodeType = "Loaded",
    CADType = "None",
    Text = "Get all elements",
    ViewType = "Data")]
    [NodeInput("List", typeof(object))]
    public class List_GetElements : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            //return new NodeResult(((dynamic)inputs[0].Value)._elements);
            List<object> elements = inputs[0].Value as List<object>;
            return new NodeResult(elements);
        }
    }

    [NVP_Manifest(
    Id = "8B4F1AF7-9B3E-4E0B-BC80-8BD253EDC3E9",
    PathAssembly = "NVP_COM_Common.dll",
    PathExecuteClass = "NVP_COM_Common.List.NVP_Common_List_ToArray",
    CoderName = "GeorgGrebenyuk",
    Folder = "NVP_COM_Common.List",
    NodeName = "List_ToArray",
    NodeType = "Loaded",
    CADType = "None",
    Text = "Convert List to Array",
    ViewType = "Modifier")]
    [NodeInput("List", typeof(object))]
    public class List_ToArray : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            List<object> elements = inputs[0].Value as List<object>;
            //return new NodeResult(((dynamic)inputs[0].Value)._elements.ToArray());
            //List<object> elements = inputs[0].Value as List<object>;
            return new NodeResult(elements.ToArray());
        }
    }

}
