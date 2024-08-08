using NVP.API.Nodes;
using System;
using System.Collections.Generic;
using NVP_Manifest_Creator;

namespace List
{
    [NVP_Manifest(
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
