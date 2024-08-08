using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Break designation
///</summary>
namespace McCOM2.SymBreak 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymBreak_Constructor : INode 
	{
		public McCOM2.ISymBreak _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymBreak;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymBreak_ConstructorCast : INode 
	{
		public McCOM2.ISymBreak _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymBreak;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x000000e6", 
		ViewType = "Data")]
	[NodeInput("SymBreak", typeof(object))]

	///<summary>
	///0x000000e6
	///</summary>
	public class PositionTop : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PositionTop);

		}
	}


	[NVP_Manifest(
		Text = "0x000000e6", 
		ViewType = "Modifier")]
	[NodeInput("SymBreak", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x000000e6
	///</summary>
	public class Set_PositionTop : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PositionTop = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000000e4", 
		ViewType = "Data")]
	[NodeInput("SymBreak", typeof(object))]

	///<summary>
	///0x000000e4
	///</summary>
	public class PositionBottom : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PositionBottom);

		}
	}


	[NVP_Manifest(
		Text = "0x000000e4", 
		ViewType = "Modifier")]
	[NodeInput("SymBreak", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x000000e4
	///</summary>
	public class Set_PositionBottom : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PositionBottom = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000000e5", 
		ViewType = "Data")]
	[NodeInput("SymBreak", typeof(object))]

	///<summary>
	///0x000000e5
	///</summary>
	public class PositionRight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PositionRight);

		}
	}


	[NVP_Manifest(
		Text = "0x000000e5", 
		ViewType = "Modifier")]
	[NodeInput("SymBreak", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x000000e5
	///</summary>
	public class Set_PositionRight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PositionRight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000000e8", 
		ViewType = "Data")]
	[NodeInput("SymBreak", typeof(object))]

	///<summary>
	///0x000000e8
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
		Text = "0x000000e8", 
		ViewType = "Modifier")]
	[NodeInput("SymBreak", typeof(object))]
	[NodeInput("McCOM2.SymBreakType", typeof(System.Object))]

	///<summary>
	///0x000000e8
	///</summary>
	public class Set_Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Type = ((McCOM2.SymBreakType)inputs[1].Value);
			return null;
		}
	}
}
