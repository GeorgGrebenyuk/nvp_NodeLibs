using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Table item formatter
///</summary>
namespace McCOM2.SymTableFormat2 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymTableFormat2_Constructor : INode 
	{
		public McCOM2.ISymTableFormat2 _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymTableFormat2;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymTableFormat2_ConstructorCast : INode 
	{
		public McCOM2.ISymTableFormat2 _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymTableFormat2;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x0000060a", 
		ViewType = "Data")]
	[NodeInput("SymTableFormat2", typeof(object))]

	///<summary>
	///0x0000060a
	///</summary>
	public class VertFit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VertFit);

		}
	}


	[NVP_Manifest(
		Text = "0x0000060a", 
		ViewType = "Modifier")]
	[NodeInput("SymTableFormat2", typeof(object))]
	[NodeInput("McCOM2.SymTableVertFit", typeof(System.Object))]

	///<summary>
	///0x0000060a
	///</summary>
	public class Set_VertFit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.VertFit = ((McCOM2.SymTableVertFit)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000060b", 
		ViewType = "Data")]
	[NodeInput("SymTableFormat2", typeof(object))]

	///<summary>
	///0x0000060b
	///</summary>
	public class HorzFit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HorzFit);

		}
	}


	[NVP_Manifest(
		Text = "0x0000060b", 
		ViewType = "Modifier")]
	[NodeInput("SymTableFormat2", typeof(object))]
	[NodeInput("McCOM2.SymTableHorzFit", typeof(System.Object))]

	///<summary>
	///0x0000060b
	///</summary>
	public class Set_HorzFit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HorzFit = ((McCOM2.SymTableHorzFit)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000060c", 
		ViewType = "Data")]
	[NodeInput("SymTableFormat2", typeof(object))]

	///<summary>
	///0x0000060c
	///</summary>
	public class FillColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FillColor);

		}
	}


	[NVP_Manifest(
		Text = "0x0000060c", 
		ViewType = "Modifier")]
	[NodeInput("SymTableFormat2", typeof(object))]
	[NodeInput("pnResult", typeof(System.Object))]

	///<summary>
	///0x0000060c
	///</summary>
	public class Set_FillColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FillColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000612", 
		ViewType = "Data")]
	[NodeInput("SymTableFormat2", typeof(object))]

	///<summary>
	///0x00000612
	///</summary>
	public class ReadOnly : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ReadOnly);

		}
	}
}
