using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Assembly loader
///</summary>
namespace nanoCAD.ALoader 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ALoader_Constructor : INode 
	{
		public nanoCAD.IALoader _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.IALoader;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ALoader_ConstructorCast : INode 
	{
		public nanoCAD.IALoader _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.IALoader;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Retrieves the command item from assembly", 
		ViewType = "Data")]
	[NodeInput("ALoader", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Retrieves the command item from assembly
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
		Text = "Gets the number of commands in assembly", 
		ViewType = "Data")]
	[NodeInput("ALoader", typeof(object))]

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
		Text = "Loads the assembly", 
		ViewType = "Modifier")]
	[NodeInput("ALoader", typeof(object))]
	[NodeInput("Path", typeof(System.String))]

	///<summary>
	///Loads the assembly
	///</summary>
	public class Load : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Load(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "unLoads the assembly", 
		ViewType = "Modifier")]
	[NodeInput("ALoader", typeof(object))]

	///<summary>
	///unLoads the assembly
	///</summary>
	public class Unload : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Unload();
			return null;
		}
	}
}
