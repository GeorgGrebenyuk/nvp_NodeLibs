using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Interface of property collection
///</summary>
namespace NVP_nanoCAD_COM._McCOM2.PropertiesCollection 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class PropertiesCollection_Constructor : INode 
	{
		public McCOM2.IPropertiesCollection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.IPropertiesCollection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class PropertiesCollection_ConstructorCast : INode 
	{
		public McCOM2.IPropertiesCollection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.IPropertiesCollection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x000000a9", 
		ViewType = "Data")]
	[NodeInput("PropertiesCollection", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///0x000000a9
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
		Text = "0x000000a8", 
		ViewType = "Data")]
	[NodeInput("PropertiesCollection", typeof(object))]

	///<summary>
	///0x000000a8
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
		Text = "0x000000ab", 
		ViewType = "Data")]
	[NodeInput("PropertiesCollection", typeof(object))]

	///<summary>
	///0x000000ab
	///</summary>
	public class Object : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Object);

		}
	}


	[NVP_Manifest(
		Text = "0x000000aa", 
		ViewType = "Data")]
	[NodeInput("PropertiesCollection", typeof(object))]

	///<summary>
	///0x000000aa
	///</summary>
	public class Names : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Names);

		}
	}
}
