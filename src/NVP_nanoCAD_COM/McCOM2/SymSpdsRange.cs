using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Range mark
///</summary>
namespace NVP_nanoCAD_COM._McCOM2.SymSpdsRange 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsRange_Constructor : INode 
	{
		public McCOM2.ISymSpdsRange _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymSpdsRange;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsRange_ConstructorCast : INode 
	{
		public McCOM2.ISymSpdsRange _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymSpdsRange;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x000004b0", 
		ViewType = "Data")]
	[NodeInput("SymSpdsRange", typeof(object))]

	///<summary>
	///0x000004b0
	///</summary>
	public class BasePosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BasePosition);

		}
	}


	[NVP_Manifest(
		Text = "0x000004b0", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsRange", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x000004b0
	///</summary>
	public class Set_BasePosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BasePosition = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000004b5", 
		ViewType = "Data")]
	[NodeInput("SymSpdsRange", typeof(object))]

	///<summary>
	///0x000004b5
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
		Text = "0x000004b5", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsRange", typeof(object))]
	[NodeInput("pvVector", typeof(System.Object))]

	///<summary>
	///0x000004b5
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


	[NVP_Manifest(
		Text = "0x000004bf", 
		ViewType = "Data")]
	[NodeInput("SymSpdsRange", typeof(object))]

	///<summary>
	///0x000004bf
	///</summary>
	public class Upper : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Upper);

		}
	}


	[NVP_Manifest(
		Text = "0x000004bf", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsRange", typeof(object))]
	[NodeInput("pvValue", typeof(System.Object))]

	///<summary>
	///0x000004bf
	///</summary>
	public class Set_Upper : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Upper = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000004bb", 
		ViewType = "Data")]
	[NodeInput("SymSpdsRange", typeof(object))]

	///<summary>
	///0x000004bb
	///</summary>
	public class Lower : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Lower);

		}
	}


	[NVP_Manifest(
		Text = "0x000004bb", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsRange", typeof(object))]
	[NodeInput("pvValue", typeof(System.Object))]

	///<summary>
	///0x000004bb
	///</summary>
	public class Set_Lower : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Lower = inputs[1].Value;
			return null;
		}
	}
}
