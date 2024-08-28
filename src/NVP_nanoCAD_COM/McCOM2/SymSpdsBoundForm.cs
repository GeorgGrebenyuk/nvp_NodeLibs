using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///ISymSpdsBoundForm interface
///</summary>
namespace NVP_nanoCAD_COM._McCOM2.SymSpdsBoundForm 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsBoundForm_Constructor : INode 
	{
		public McCOM2.ISymSpdsBoundForm _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymSpdsBoundForm;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsBoundForm_ConstructorCast : INode 
	{
		public McCOM2.ISymSpdsBoundForm _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymSpdsBoundForm;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x00000345", 
		ViewType = "Data")]
	[NodeInput("SymSpdsBoundForm", typeof(object))]

	///<summary>
	///0x00000345
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
		Text = "0x00000345", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsBoundForm", typeof(object))]
	[NodeInput("McCOM2.SymBoundFormType", typeof(System.Object))]

	///<summary>
	///0x00000345
	///</summary>
	public class Set_Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Type = ((McCOM2.SymBoundFormType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000033b", 
		ViewType = "Data")]
	[NodeInput("SymSpdsBoundForm", typeof(object))]

	///<summary>
	///0x0000033b
	///</summary>
	public class Direction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Direction);

		}
	}


	[NVP_Manifest(
		Text = "0x0000033b", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsBoundForm", typeof(object))]
	[NodeInput("pnValue", typeof(System.Object))]

	///<summary>
	///0x0000033b
	///</summary>
	public class Set_Direction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Direction = inputs[1].Value;
			return null;
		}
	}
}
