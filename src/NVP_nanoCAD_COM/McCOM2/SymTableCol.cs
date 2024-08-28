using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Table column
///</summary>
namespace NVP_nanoCAD_COM._McCOM2.SymTableCol 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymTableCol_Constructor : INode 
	{
		public McCOM2.ISymTableCol _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymTableCol;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymTableCol_ConstructorCast : INode 
	{
		public McCOM2.ISymTableCol _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymTableCol;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x0000050f", 
		ViewType = "Data")]
	[NodeInput("SymTableCol", typeof(object))]
	[NodeInput("nIndex", typeof(System.Object))]

	///<summary>
	///0x0000050f
	///</summary>
	public class Cell : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Cell(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "0x00000510", 
		ViewType = "Data")]
	[NodeInput("SymTableCol", typeof(object))]

	///<summary>
	///0x00000510
	///</summary>
	public class Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Count);

		}
	}


	[NVP_Manifest(
		Text = "0x00000517", 
		ViewType = "Data")]
	[NodeInput("SymTableCol", typeof(object))]

	///<summary>
	///0x00000517
	///</summary>
	public class Width : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Width);

		}
	}


	[NVP_Manifest(
		Text = "0x00000517", 
		ViewType = "Modifier")]
	[NodeInput("SymTableCol", typeof(object))]
	[NodeInput("prValue", typeof(System.Double))]

	///<summary>
	///0x00000517
	///</summary>
	public class Set_Width : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Width = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000512", 
		ViewType = "Data")]
	[NodeInput("SymTableCol", typeof(object))]

	///<summary>
	///0x00000512
	///</summary>
	public class Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Height);

		}
	}


	[NVP_Manifest(
		Text = "0x0000050e", 
		ViewType = "Data")]
	[NodeInput("SymTableCol", typeof(object))]

	///<summary>
	///0x0000050e
	///</summary>
	public class Bounds : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Bounds);

		}
	}


	[NVP_Manifest(
		Text = "0x00000513", 
		ViewType = "Data")]
	[NodeInput("SymTableCol", typeof(object))]

	///<summary>
	///0x00000513
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
		Text = "0x00000515", 
		ViewType = "Data")]
	[NodeInput("SymTableCol", typeof(object))]

	///<summary>
	///0x00000515
	///</summary>
	public class Table : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Table);

		}
	}


	[NVP_Manifest(
		Text = "0x00000514", 
		ViewType = "Data")]
	[NodeInput("SymTableCol", typeof(object))]

	///<summary>
	///0x00000514
	///</summary>
	public class Range : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Range);

		}
	}


	[NVP_Manifest(
		Text = "0x00000511", 
		ViewType = "Data")]
	[NodeInput("SymTableCol", typeof(object))]

	///<summary>
	///0x00000511
	///</summary>
	public class Format : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Format);

		}
	}


	[NVP_Manifest(
		Text = "0x0000050b", 
		ViewType = "Modifier")]
	[NodeInput("SymTableCol", typeof(object))]
	[NodeInput("nIdxAfter", typeof(System.Object))]
	[NodeInput("vbWithFormat", typeof(System.Object))]
	[NodeInput("vbWithContent", typeof(System.Object))]

	///<summary>
	///0x0000050b
	///</summary>
	public class Copy : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Copy(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000050c", 
		ViewType = "Modifier")]
	[NodeInput("SymTableCol", typeof(object))]

	///<summary>
	///0x0000050c
	///</summary>
	public class Delete : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Delete();
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000050d", 
		ViewType = "Modifier")]
	[NodeInput("SymTableCol", typeof(object))]
	[NodeInput("vWidthsArray", typeof(System.Object))]

	///<summary>
	///0x0000050d
	///</summary>
	public class Split : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Split(inputs[1].Value);
			return null;
		}
	}
}
