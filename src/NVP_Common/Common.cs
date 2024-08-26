using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;


namespace Common
{
    [NVP_Manifest(
            Text = "Возвращает значение null",
            ViewType = "Data")]
    public class Null : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(null);
        }
    }

    [NVP_Manifest(
            Text = "Проверяет объект на null (true if null)",
            ViewType = "Data")]
    [NodeInput("Object", typeof(object))]
    public class IsNull : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            var obj = inputs[0].Value;
            return new NodeResult(obj ?? null);
        }
    }
}
