using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Construction axis interface
///</summary>
namespace McCOM2.SymSpdsGrid 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsGrid_Constructor : INode 
	{
		public McCOM2.ISymSpdsGrid _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymSpdsGrid;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsGrid_ConstructorCast : INode 
	{
		public McCOM2.ISymSpdsGrid _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymSpdsGrid;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x00000600", 
		ViewType = "Data")]
	[NodeInput("SymSpdsGrid", typeof(object))]

	///<summary>
	///0x00000600
	///</summary>
	public class AxesX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AxesX);

		}
	}


	[NVP_Manifest(
		Text = "0x00000601", 
		ViewType = "Data")]
	[NodeInput("SymSpdsGrid", typeof(object))]

	///<summary>
	///0x00000601
	///</summary>
	public class AxesY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AxesY);

		}
	}


	[NVP_Manifest(
		Text = "0x00000602", 
		ViewType = "Data")]
	[NodeInput("SymSpdsGrid", typeof(object))]

	///<summary>
	///0x00000602
	///</summary>
	public class Polar : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Polar);

		}
	}


	[NVP_Manifest(
		Text = "0x00000602", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsGrid", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x00000602
	///</summary>
	public class Set_Polar : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Polar = inputs[1].Value;
			return null;
		}
	}
}
