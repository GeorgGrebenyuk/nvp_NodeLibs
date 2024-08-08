using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Strings container
///</summary>
namespace nanoCAD.Arguments 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Arguments_Constructor : INode 
	{
		public nanoCAD.IArguments _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.IArguments;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Arguments_ConstructorCast : INode 
	{
		public nanoCAD.IArguments _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.IArguments;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Retrieves the string from container", 
		ViewType = "Data")]
	[NodeInput("Arguments", typeof(object))]
	[NodeInput("idx", typeof(System.Object))]

	///<summary>
	///Retrieves the string from container
	///</summary>
	public class Item : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Item(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Retrieves the string from container", 
		ViewType = "Modifier")]
	[NodeInput("Arguments", typeof(object))]
	[NodeInput("idx", typeof(System.Object))]
	[NodeInput("str", typeof(System.String))]

	///<summary>
	///Retrieves the string from container
	///</summary>
	public class Set_Item : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Item[inputs[1]] = inputs[2];
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Gets the number of commands in assembly", 
		ViewType = "Data")]
	[NodeInput("Arguments", typeof(object))]

	///<summary>
	///Gets the number of commands in assembly
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
		ViewType = "Modifier")]
	[NodeInput("Arguments", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Append : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Append();
			return null;
		}
	}
}
