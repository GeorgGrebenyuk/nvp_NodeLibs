using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;
using Renga.Parameter;

///<summary>
///
///</summary>
namespace Renga.ParameterContainer 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ParameterContainer_Constructor : INode 
	{
		public Renga.IParameterContainer _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IParameterContainer;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ParameterContainer_ConstructorCast : INode 
	{
		public Renga.IParameterContainer _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IParameterContainer;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("ParameterContainer", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetIds : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetIds);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("ParameterContainer", typeof(object))]
	[NodeInput("Id", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Contains : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Contains(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("ParameterContainer", typeof(object))]
	[NodeInput("Id", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Get : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Get(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("ParameterContainer", typeof(object))]
	[NodeInput("Id", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class ContainsS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ContainsS(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("ParameterContainer", typeof(object))]
	[NodeInput("Id", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class GetS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetS(inputs[1].Value));

		}
	}

    [NVP_Manifest(
        Text = "Возвращает все параметры в виде Renga.Parameter",
        ViewType = "Data")]
    [NodeInput("ParameterContainer", typeof(object))]

    public class GetAll_Parameters : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            var _input0 = ((dynamic)inputs[0].Value)._i as Renga.IParameterContainer;
            var guids = _input0.GetIds();
            List<Parameter_Constructor> items = new List<Parameter_Constructor>();
            for (int item_counter = 0; item_counter < guids.Count; item_counter++)
            {
                Guid id = guids.Get(item_counter);
                Parameter_Constructor item = new Parameter_Constructor();
                item._i = _input0.Get(id);
                items.Add(item);
            }
            return new NodeResult(items);
        }
    }

    [NVP_Manifest(
        Text = "Возвращает все параметры в виде словаря",
        ViewType = "Data")]
    [NodeInput("ParameterContainer", typeof(object))]

    public class GetAll_Parameters2 : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            var _input0 = ((dynamic)inputs[0].Value)._i as Renga.IParameterContainer;
            var guids = _input0.GetIds();
            Dictionary<string, object> items = new Dictionary<string, object>();
            for (int item_counter = 0; item_counter < guids.Count; item_counter++)
            {
                Guid id = guids.Get(item_counter);
                Renga.IParameter param = _input0.Get(id);

				object param_value = null;
				switch (param.ValueType)
				{
					case ParameterValueType.ParameterValueType_Bool:
						param_value = param.GetBoolValue(); break;
                    case ParameterValueType.ParameterValueType_Int:
						param_value = param.GetIntValue();break;
					case ParameterValueType.ParameterValueType_Double:
						param_value = param.GetDoubleValue(); break;
					case ParameterValueType.ParameterValueType_String:
						param_value = param.GetStringValue(); break;

                }
				if (!items.ContainsKey(param.Definition.Name)) items.Add(param.Definition.Name, param_value);
				else items[param.Definition.Name] = param_value;
            }
            return new NodeResult(items);
        }
    }
}
