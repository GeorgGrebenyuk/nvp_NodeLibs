using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Leader points interface
///</summary>
namespace NVP_nanoCAD_COM._McCOM2.Leader 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Leader_Constructor : INode 
	{
		public McCOM2.ILeader _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ILeader;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Leader_ConstructorCast : INode 
	{
		public McCOM2.ILeader _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ILeader;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x00000081", 
		ViewType = "Data")]
	[NodeInput("Leader", typeof(object))]

	///<summary>
	///0x00000081
	///</summary>
	public class Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Position);

		}
	}


	[NVP_Manifest(
		Text = "0x00000081", 
		ViewType = "Modifier")]
	[NodeInput("Leader", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000081
	///</summary>
	public class Set_Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Position = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000007e", 
		ViewType = "Data")]
	[NodeInput("Leader", typeof(object))]

	///<summary>
	///0x0000007e
	///</summary>
	public class Arrow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Arrow);

		}
	}


	[NVP_Manifest(
		Text = "0x0000007e", 
		ViewType = "Modifier")]
	[NodeInput("Leader", typeof(object))]
	[NodeInput("McCOM2.ArrowType", typeof(System.Object))]

	///<summary>
	///0x0000007e
	///</summary>
	public class Set_Arrow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Arrow = ((McCOM2.ArrowType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000007f", 
		ViewType = "Data")]
	[NodeInput("Leader", typeof(object))]

	///<summary>
	///0x0000007f
	///</summary>
	public class ArrowSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrowSize);

		}
	}


	[NVP_Manifest(
		Text = "0x0000007f", 
		ViewType = "Modifier")]
	[NodeInput("Leader", typeof(object))]
	[NodeInput("pnSize", typeof(System.Double))]

	///<summary>
	///0x0000007f
	///</summary>
	public class Set_ArrowSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArrowSize = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000080", 
		ViewType = "Data")]
	[NodeInput("Leader", typeof(object))]

	///<summary>
	///0x00000080
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
