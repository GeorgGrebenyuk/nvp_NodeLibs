using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Correction mark
///</summary>
namespace McCOM2.SymSpdsCorrection 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsCorrection_Constructor : INode 
	{
		public McCOM2.ISymSpdsCorrection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymSpdsCorrection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsCorrection_ConstructorCast : INode 
	{
		public McCOM2.ISymSpdsCorrection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymSpdsCorrection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x0000035d", 
		ViewType = "Data")]
	[NodeInput("SymSpdsCorrection", typeof(object))]

	///<summary>
	///0x0000035d
	///</summary>
	public class Text : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Text);

		}
	}


	[NVP_Manifest(
		Text = "0x0000035d", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsCorrection", typeof(object))]
	[NodeInput("pbstrResult", typeof(System.String))]

	///<summary>
	///0x0000035d
	///</summary>
	public class Set_Text : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Text = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000353", 
		ViewType = "Data")]
	[NodeInput("SymSpdsCorrection", typeof(object))]

	///<summary>
	///0x00000353
	///</summary>
	public class Footer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Footer);

		}
	}


	[NVP_Manifest(
		Text = "0x00000353", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsCorrection", typeof(object))]
	[NodeInput("pbstrResult", typeof(System.String))]

	///<summary>
	///0x00000353
	///</summary>
	public class Set_Footer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Footer = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000356", 
		ViewType = "Data")]
	[NodeInput("SymSpdsCorrection", typeof(object))]

	///<summary>
	///0x00000356
	///</summary>
	public class Leaders : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Leaders);

		}
	}
}
