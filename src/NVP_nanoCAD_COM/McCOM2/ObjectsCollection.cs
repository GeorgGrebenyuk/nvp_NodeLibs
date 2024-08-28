using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Interafce of object collection
///</summary>
namespace NVP_nanoCAD_COM._McCOM2.ObjectsCollection 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ObjectsCollection_Constructor : INode 
	{
		public McCOM2.IObjectsCollection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.IObjectsCollection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ObjectsCollection_ConstructorCast : INode 
	{
		public McCOM2.IObjectsCollection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.IObjectsCollection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x000000a6", 
		ViewType = "Data")]
	[NodeInput("ObjectsCollection", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///0x000000a6
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
		Text = "0x000000a5", 
		ViewType = "Data")]
	[NodeInput("ObjectsCollection", typeof(object))]

	///<summary>
	///0x000000a5
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
		Text = "0x0000009e", 
		ViewType = "Modifier")]
	[NodeInput("ObjectsCollection", typeof(object))]
	[NodeInput("pItem", typeof(System.Object))]

	///<summary>
	///0x0000009e
	///</summary>
	public class Add : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Add(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000000a3", 
		ViewType = "Modifier")]
	[NodeInput("ObjectsCollection", typeof(object))]
	[NodeInput("Item", typeof(System.Object))]

	///<summary>
	///0x000000a3
	///</summary>
	public class Remove : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Remove(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000000a0", 
		ViewType = "Data")]
	[NodeInput("ObjectsCollection", typeof(object))]
	[NodeInput("pValue", typeof(System.Object))]

	///<summary>
	///0x000000a0
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
		Text = "0x000000a2", 
		ViewType = "Data")]
	[NodeInput("ObjectsCollection", typeof(object))]
	[NodeInput("vSecond", typeof(System.Object))]

	///<summary>
	///0x000000a2
	///</summary>
	public class Or : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Or(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "0x0000009f", 
		ViewType = "Data")]
	[NodeInput("ObjectsCollection", typeof(object))]
	[NodeInput("vSecond", typeof(System.Object))]

	///<summary>
	///0x0000009f
	///</summary>
	public class And : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.And(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "0x000000a1", 
		ViewType = "Data")]
	[NodeInput("ObjectsCollection", typeof(object))]
	[NodeInput("vSecond", typeof(System.Object))]

	///<summary>
	///0x000000a1
	///</summary>
	public class Not : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Not(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "0x000000a4", 
		ViewType = "Data")]
	[NodeInput("ObjectsCollection", typeof(object))]
	[NodeInput("vSecond", typeof(System.Object))]

	///<summary>
	///0x000000a4
	///</summary>
	public class Xor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Xor(inputs[1].Value));

		}
	}
}
