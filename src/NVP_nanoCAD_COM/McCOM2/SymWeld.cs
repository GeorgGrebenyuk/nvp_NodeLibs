using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///ISymWeld interface
///</summary>
namespace McCOM2.SymWeld 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymWeld_Constructor : INode 
	{
		public McCOM2.ISymWeld _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymWeld;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymWeld_ConstructorCast : INode 
	{
		public McCOM2.ISymWeld _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymWeld;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x00000565", 
		ViewType = "Data")]
	[NodeInput("SymWeld", typeof(object))]

	///<summary>
	///0x00000565
	///</summary>
	public class Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Type);

		}
	}


	[NVP_Manifest(
		Text = "0x00000565", 
		ViewType = "Modifier")]
	[NodeInput("SymWeld", typeof(object))]
	[NodeInput("McCOM2.SymWeldType", typeof(System.Object))]

	///<summary>
	///0x00000565
	///</summary>
	public class Set_Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Type = ((McCOM2.SymWeldType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000055b", 
		ViewType = "Data")]
	[NodeInput("SymWeld", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///0x0000055b
	///</summary>
	public class Direction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Direction(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "0x0000055b", 
		ViewType = "Modifier")]
	[NodeInput("SymWeld", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]
	[NodeInput("pnValue", typeof(System.Object))]

	///<summary>
	///0x0000055b
	///</summary>
	public class Set_Direction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Direction[inputs[1]] = inputs[2];
			return null;
		}
	}
}
