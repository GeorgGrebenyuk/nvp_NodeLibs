using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///ILeadersCollection interface
///</summary>
namespace McCOM2.LeadersCollection 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class LeadersCollection_Constructor : INode 
	{
		public McCOM2.ILeadersCollection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ILeadersCollection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class LeadersCollection_ConstructorCast : INode 
	{
		public McCOM2.ILeadersCollection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ILeadersCollection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x00000086", 
		ViewType = "Data")]
	[NodeInput("LeadersCollection", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///0x00000086
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
		Text = "0x00000085", 
		ViewType = "Data")]
	[NodeInput("LeadersCollection", typeof(object))]

	///<summary>
	///0x00000085
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
		Text = "0x00000083", 
		ViewType = "Modifier")]
	[NodeInput("LeadersCollection", typeof(object))]
	[NodeInput("vPoint", typeof(System.Object))]
	[NodeInput("McCOM2.ArrowType", typeof(System.Object))]
	[NodeInput("rArrowSize", typeof(System.Double))]

	///<summary>
	///0x00000083
	///</summary>
	public class Add : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Add(inputs[1].Value,((McCOM2.ArrowType)inputs[2].Value),inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000084", 
		ViewType = "Modifier")]
	[NodeInput("LeadersCollection", typeof(object))]
	[NodeInput("Item", typeof(System.Object))]

	///<summary>
	///0x00000084
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
		Text = "0x00000087", 
		ViewType = "Data")]
	[NodeInput("LeadersCollection", typeof(object))]

	///<summary>
	///0x00000087
	///</summary>
	public class Object : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Object);

		}
	}
}
