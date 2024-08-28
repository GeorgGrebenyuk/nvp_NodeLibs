using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IParameters Interface
///</summary>
namespace NVP_ModelStudio_COM._mdsUnitsLib.Parameters 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Parameters_Constructor : INode 
	{
		public mdsUnitsLib.IParameters _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsUnitsLib.IParameters;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Parameters_ConstructorCast : INode 
	{
		public mdsUnitsLib.IParameters _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsUnitsLib.IParameters;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "method Item", 
		ViewType = "Data")]
	[NodeInput("Parameters", typeof(object))]

	///<summary>
	///method Item
	///</summary>
	public class Item : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Item);

		}
	}


	[NVP_Manifest(
		Text = "property Count", 
		ViewType = "Data")]
	[NodeInput("Parameters", typeof(object))]

	///<summary>
	///property Count
	///</summary>
	public class Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Count);

		}
	}


	[NVP_Manifest(
		Text = "method SetParameter", 
		ViewType = "Modifier")]
	[NodeInput("Parameters", typeof(object))]
	[NodeInput("Name", typeof(System.String))]
	[NodeInput("Value", typeof(System.String))]
	[NodeInput("Comment", typeof(System.Object))]
	[NodeInput("ValueComment", typeof(System.Object))]

	///<summary>
	///method SetParameter
	///</summary>
	public class SetParameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetParameter(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "method DeleteParameter", 
		ViewType = "Modifier")]
	[NodeInput("Parameters", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///method DeleteParameter
	///</summary>
	public class DeleteParameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DeleteParameter(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "method DeleteAll", 
		ViewType = "Modifier")]
	[NodeInput("Parameters", typeof(object))]

	///<summary>
	///method DeleteAll
	///</summary>
	public class DeleteAll : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DeleteAll();
			return null;
		}
	}


	[NVP_Manifest(
		Text = "method Has", 
		ViewType = "Data")]
	[NodeInput("Parameters", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///method Has
	///</summary>
	public class Has : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Has(inputs[1].Value));

		}
	}
}
