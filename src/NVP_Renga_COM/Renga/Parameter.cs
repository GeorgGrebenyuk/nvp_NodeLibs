using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace NVP_Renga_COM._Renga.Parameter 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Parameter_Constructor : INode 
	{
		public Renga.IParameter _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IParameter;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Parameter_ConstructorCast : INode 
	{
		public Renga.IParameter _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IParameter;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Parameter", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ValueType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ValueType);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Parameter", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Definition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Definition);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Parameter", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetBoolValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBoolValue);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("Parameter", typeof(object))]
	[NodeInput("value", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class SetBoolValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetBoolValue(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Parameter", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetIntValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetIntValue);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("Parameter", typeof(object))]
	[NodeInput("value", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class SetIntValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetIntValue(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Parameter", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetDoubleValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetDoubleValue);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("Parameter", typeof(object))]
	[NodeInput("value", typeof(System.Double))]

	///<summary>
	///
	///</summary>
	public class SetDoubleValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetDoubleValue(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Parameter", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetStringValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetStringValue);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("Parameter", typeof(object))]
	[NodeInput("value", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class SetStringValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetStringValue(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Parameter", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Id : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Id);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Parameter", typeof(object))]

	///<summary>
	///
	///</summary>
	public class IdS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IdS);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Parameter", typeof(object))]

	///<summary>
	///
	///</summary>
	public class HasValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasValue);

		}
	}
}
