using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

namespace Wait
{
    [NVP_Manifest(
        Text = "Задержка для двух значений",
        ViewType = "Default")]
    [NodeInput("Объект 1", typeof(object))]
    [NodeInput("Объект 2", typeof(object))]
    public class Wait_2 : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(new object[] { inputs[0].Value, inputs[1].Value });
        }
    }

    [NVP_Manifest(
        Text = "Задержка для трех значений",
        ViewType = "Default")]
    [NodeInput("Объект 1", typeof(object))]
    [NodeInput("Объект 2", typeof(object))]
    [NodeInput("Объект 3", typeof(object))]
    public class Wait_3 : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(new object[] { inputs[0].Value, inputs[1].Value, inputs[2].Value });
        }
    }

    [NVP_Manifest(
        Text = "Задержка для четырех значений",
        ViewType = "Default")]
    [NodeInput("Объект 1", typeof(object))]
    [NodeInput("Объект 2", typeof(object))]
    [NodeInput("Объект 3", typeof(object))]
    [NodeInput("Объект 4", typeof(object))]
    public class Wait_4 : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(new object[] { inputs[0].Value, inputs[1].Value, inputs[2].Value, inputs[3].Value });
        }
    }

    [NVP_Manifest(
        Text = "Задержка для пяти значений",
        ViewType = "Default")]
    [NodeInput("Объект 1", typeof(object))]
    [NodeInput("Объект 2", typeof(object))]
    [NodeInput("Объект 3", typeof(object))]
    [NodeInput("Объект 4", typeof(object))]
    [NodeInput("Объект 5", typeof(object))]
    public class Wait_5 : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(new object[] { inputs[0].Value, inputs[1].Value, inputs[2].Value, inputs[3].Value, inputs[4].Value });
        }
    }

    [NVP_Manifest(
        Text = "Задержка для шести значений",
        ViewType = "Default")]
    [NodeInput("Объект 1", typeof(object))]
    [NodeInput("Объект 2", typeof(object))]
    [NodeInput("Объект 3", typeof(object))]
    [NodeInput("Объект 4", typeof(object))]
    [NodeInput("Объект 5", typeof(object))]
    [NodeInput("Объект 6", typeof(object))]
    public class Wait_6 : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(new object[] { inputs[0].Value, inputs[1].Value, inputs[2].Value, inputs[3].Value, inputs[4].Value, inputs[5].Value });
        }
    }

    [NVP_Manifest(
        Text = "Задержка для семи значений",
        ViewType = "Default")]
    [NodeInput("Объект 1", typeof(object))]
    [NodeInput("Объект 2", typeof(object))]
    [NodeInput("Объект 3", typeof(object))]
    [NodeInput("Объект 4", typeof(object))]
    [NodeInput("Объект 5", typeof(object))]
    [NodeInput("Объект 6", typeof(object))]
    [NodeInput("Объект 7", typeof(object))]
    public class Wait_7 : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(new object[] { inputs[0].Value, inputs[1].Value, inputs[2].Value, inputs[3].Value, inputs[4].Value, inputs[5].Value, inputs[6].Value });
        }
    }
}
