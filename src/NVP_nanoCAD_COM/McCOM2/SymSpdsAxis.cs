using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Construction axis interface
///</summary>
namespace McCOM2.SymSpdsAxis 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsAxis_Constructor : INode 
	{
		public McCOM2.ISymSpdsAxis _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymSpdsAxis;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsAxis_ConstructorCast : INode 
	{
		public McCOM2.ISymSpdsAxis _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymSpdsAxis;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x00000604", 
		ViewType = "Data")]
	[NodeInput("SymSpdsAxis", typeof(object))]

	///<summary>
	///0x00000604
	///</summary>
	public class Index : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Index);

		}
	}


	[NVP_Manifest(
		Text = "0x00000604", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsAxis", typeof(object))]
	[NodeInput("pbstrValue", typeof(System.String))]

	///<summary>
	///0x00000604
	///</summary>
	public class Set_Index : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Index = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000605", 
		ViewType = "Data")]
	[NodeInput("SymSpdsAxis", typeof(object))]

	///<summary>
	///0x00000605
	///</summary>
	public class TextPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextPosition);

		}
	}


	[NVP_Manifest(
		Text = "0x00000605", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsAxis", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000605
	///</summary>
	public class Set_TextPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextPosition = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000606", 
		ViewType = "Data")]
	[NodeInput("SymSpdsAxis", typeof(object))]

	///<summary>
	///0x00000606
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
		Text = "0x00000606", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsAxis", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000606
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
}
