using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Mark symbol
///</summary>
namespace NVP_nanoCAD_COM._McCOM2.SymMark 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymMark_Constructor : INode 
	{
		public McCOM2.ISymMark _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymMark;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymMark_ConstructorCast : INode 
	{
		public McCOM2.ISymMark _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymMark;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x0000027c", 
		ViewType = "Data")]
	[NodeInput("SymMark", typeof(object))]

	///<summary>
	///0x0000027c
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
		Text = "0x0000027c", 
		ViewType = "Modifier")]
	[NodeInput("SymMark", typeof(object))]
	[NodeInput("pbstrResult", typeof(System.String))]

	///<summary>
	///0x0000027c
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
		Text = "0x00000276", 
		ViewType = "Data")]
	[NodeInput("SymMark", typeof(object))]

	///<summary>
	///0x00000276
	///</summary>
	public class Method : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Method);

		}
	}


	[NVP_Manifest(
		Text = "0x00000276", 
		ViewType = "Modifier")]
	[NodeInput("SymMark", typeof(object))]
	[NodeInput("pbstrResult", typeof(System.String))]

	///<summary>
	///0x00000276
	///</summary>
	public class Set_Method : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Method = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000027b", 
		ViewType = "Data")]
	[NodeInput("SymMark", typeof(object))]

	///<summary>
	///0x0000027b
	///</summary>
	public class Stamp : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Stamp);

		}
	}


	[NVP_Manifest(
		Text = "0x0000027b", 
		ViewType = "Modifier")]
	[NodeInput("SymMark", typeof(object))]
	[NodeInput("pvbResult", typeof(System.Object))]

	///<summary>
	///0x0000027b
	///</summary>
	public class Set_Stamp : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Stamp = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000026f", 
		ViewType = "Data")]
	[NodeInput("SymMark", typeof(object))]

	///<summary>
	///0x0000026f
	///</summary>
	public class Documentation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Documentation);

		}
	}


	[NVP_Manifest(
		Text = "0x0000026f", 
		ViewType = "Modifier")]
	[NodeInput("SymMark", typeof(object))]
	[NodeInput("pnResult", typeof(System.String))]

	///<summary>
	///0x0000026f
	///</summary>
	public class Set_Documentation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Documentation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000279", 
		ViewType = "Data")]
	[NodeInput("SymMark", typeof(object))]

	///<summary>
	///0x00000279
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
		Text = "0x00000279", 
		ViewType = "Modifier")]
	[NodeInput("SymMark", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000279
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


	[NVP_Manifest(
		Text = "0x00000272", 
		ViewType = "Data")]
	[NodeInput("SymMark", typeof(object))]

	///<summary>
	///0x00000272
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
