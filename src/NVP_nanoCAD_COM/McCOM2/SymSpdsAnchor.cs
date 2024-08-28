using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///ISymSpdsAnchor interface
///</summary>
namespace NVP_nanoCAD_COM._McCOM2.SymSpdsAnchor 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsAnchor_Constructor : INode 
	{
		public McCOM2.ISymSpdsAnchor _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymSpdsAnchor;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsAnchor_ConstructorCast : INode 
	{
		public McCOM2.ISymSpdsAnchor _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymSpdsAnchor;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x00000319", 
		ViewType = "Data")]
	[NodeInput("SymSpdsAnchor", typeof(object))]

	///<summary>
	///0x00000319
	///</summary>
	public class ArrowFirst : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrowFirst);

		}
	}


	[NVP_Manifest(
		Text = "0x00000319", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsAnchor", typeof(object))]
	[NodeInput("McCOM2.SymAnchorType", typeof(System.Object))]

	///<summary>
	///0x00000319
	///</summary>
	public class Set_ArrowFirst : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArrowFirst = ((McCOM2.SymAnchorType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000031a", 
		ViewType = "Data")]
	[NodeInput("SymSpdsAnchor", typeof(object))]

	///<summary>
	///0x0000031a
	///</summary>
	public class ArrowLast : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrowLast);

		}
	}


	[NVP_Manifest(
		Text = "0x0000031a", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsAnchor", typeof(object))]
	[NodeInput("McCOM2.SymAnchorType", typeof(System.Object))]

	///<summary>
	///0x0000031a
	///</summary>
	public class Set_ArrowLast : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArrowLast = ((McCOM2.SymAnchorType)inputs[1].Value);
			return null;
		}
	}
}
