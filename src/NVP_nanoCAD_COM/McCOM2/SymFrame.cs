using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Drawing bound interface
///</summary>
namespace McCOM2.SymFrame 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymFrame_Constructor : INode 
	{
		public McCOM2.ISymFrame _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymFrame;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymFrame_ConstructorCast : INode 
	{
		public McCOM2.ISymFrame _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymFrame;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x0000022e", 
		ViewType = "Modifier")]
	[NodeInput("SymFrame", typeof(object))]
	[NodeInput("rBounds", typeof(System.Object))]

	///<summary>
	///0x0000022e
	///</summary>
	public class SelectFor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SelectFor(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000230", 
		ViewType = "Data")]
	[NodeInput("SymFrame", typeof(object))]
	[NodeInput("vPoint", typeof(System.Object))]

	///<summary>
	///0x00000230
	///</summary>
	public class ZoneAtPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ZoneAtPoint(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "0x0000023d", 
		ViewType = "Data")]
	[NodeInput("SymFrame", typeof(object))]

	///<summary>
	///0x0000023d
	///</summary>
	public class Prev : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Prev);

		}
	}


	[NVP_Manifest(
		Text = "0x0000023c", 
		ViewType = "Data")]
	[NodeInput("SymFrame", typeof(object))]

	///<summary>
	///0x0000023c
	///</summary>
	public class Next : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Next);

		}
	}


	[NVP_Manifest(
		Text = "0x0000023f", 
		ViewType = "Modifier")]
	[NodeInput("SymFrame", typeof(object))]
	[NodeInput("ppSymbol", typeof(System.Object))]

	///<summary>
	///0x0000023f
	///</summary>
	public class Set_Roughness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Roughness = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000023f", 
		ViewType = "Data")]
	[NodeInput("SymFrame", typeof(object))]

	///<summary>
	///0x0000023f
	///</summary>
	public class Roughness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Roughness);

		}
	}


	[NVP_Manifest(
		Text = "0x00000240", 
		ViewType = "Data")]
	[NodeInput("SymFrame", typeof(object))]

	///<summary>
	///0x00000240
	///</summary>
	public class Text : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Text);

		}
	}
}
