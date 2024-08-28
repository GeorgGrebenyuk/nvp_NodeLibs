using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;


namespace NVP_Common.Common
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

    [NVP_Manifest(
        Text = "Преобразует строку в число с плавающей точкой",
        ViewType = "Modifier")]
    [NodeInput("String", typeof(object))]
    public class StringToNumber_Double : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            string obj = (string)inputs[0].Value;
            return new NodeResult(Convert.ToDouble(obj));
        }
    }

    [NVP_Manifest(
        Text = "Преобразует строку в целое число",
        ViewType = "Modifier")]
    [NodeInput("String", typeof(object))]
    public class StringToNumber_Int64 : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            string obj = (string)inputs[0].Value;
            return new NodeResult(Convert.ToInt64(obj));
        }
    }

    [NVP_Manifest(
        Text = "Преобразует объект в строку",
        ViewType = "Modifier")]
    [NodeInput("Object", typeof(object))]
    public class ToString : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            var obj =  inputs[0].Value;
            if (obj != null) return new NodeResult(obj.ToString());
            else return new NodeResult(null);
        }
    }
}
