using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Table object
///</summary>
namespace McCOM2.SymTable 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymTable_Constructor : INode 
	{
		public McCOM2.ISymTable _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymTable;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymTable_ConstructorCast : INode 
	{
		public McCOM2.ISymTable _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymTable;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x000004ce", 
		ViewType = "Data")]
	[NodeInput("SymTable", typeof(object))]
	[NodeInput("nRow", typeof(System.Object))]
	[NodeInput("nCol", typeof(System.Object))]

	///<summary>
	///0x000004ce
	///</summary>
	public class Cell : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Cell(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Text = "0x000004d5", 
		ViewType = "Data")]
	[NodeInput("SymTable", typeof(object))]

	///<summary>
	///0x000004d5
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
		Text = "0x000004e1", 
		ViewType = "Data")]
	[NodeInput("SymTable", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///0x000004e1
	///</summary>
	public class Rows : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Rows(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "0x000004d3", 
		ViewType = "Data")]
	[NodeInput("SymTable", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///0x000004d3
	///</summary>
	public class Cols : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Cols(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "0x000004e0", 
		ViewType = "Data")]
	[NodeInput("SymTable", typeof(object))]

	///<summary>
	///0x000004e0
	///</summary>
	public class RowCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RowCount);

		}
	}


	[NVP_Manifest(
		Text = "0x000004e0", 
		ViewType = "Modifier")]
	[NodeInput("SymTable", typeof(object))]
	[NodeInput("pnValue", typeof(System.Object))]

	///<summary>
	///0x000004e0
	///</summary>
	public class Set_RowCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RowCount = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000004d1", 
		ViewType = "Data")]
	[NodeInput("SymTable", typeof(object))]

	///<summary>
	///0x000004d1
	///</summary>
	public class ColCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ColCount);

		}
	}


	[NVP_Manifest(
		Text = "0x000004d1", 
		ViewType = "Modifier")]
	[NodeInput("SymTable", typeof(object))]
	[NodeInput("pnValue", typeof(System.Object))]

	///<summary>
	///0x000004d1
	///</summary>
	public class Set_ColCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ColCount = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000004ca", 
		ViewType = "Modifier")]
	[NodeInput("SymTable", typeof(object))]
	[NodeInput("vDestination", typeof(System.Object))]

	///<summary>
	///0x000004ca
	///</summary>
	public class Save : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Save(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000004c8", 
		ViewType = "Modifier")]
	[NodeInput("SymTable", typeof(object))]
	[NodeInput("vSource", typeof(System.Object))]

	///<summary>
	///0x000004c8
	///</summary>
	public class Load : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Load(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000004de", 
		ViewType = "Data")]
	[NodeInput("SymTable", typeof(object))]

	///<summary>
	///0x000004de
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
		Text = "0x000004de", 
		ViewType = "Modifier")]
	[NodeInput("SymTable", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x000004de
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
		Text = "0x000004cf", 
		ViewType = "Data")]
	[NodeInput("SymTable", typeof(object))]
	[NodeInput("vPoint", typeof(System.Object))]

	///<summary>
	///0x000004cf
	///</summary>
	public class CellFromPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CellFromPoint(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "0x000004e4", 
		ViewType = "Data")]
	[NodeInput("SymTable", typeof(object))]

	///<summary>
	///0x000004e4
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
		Text = "0x000004d6", 
		ViewType = "Data")]
	[NodeInput("SymTable", typeof(object))]

	///<summary>
	///0x000004d6
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
		Text = "0x000004c6", 
		ViewType = "Modifier")]
	[NodeInput("SymTable", typeof(object))]
	[NodeInput("iRow", typeof(System.Object))]
	[NodeInput("iCol", typeof(System.Object))]
	[NodeInput("iRowCount", typeof(System.Object))]
	[NodeInput("iColCount", typeof(System.Object))]

	///<summary>
	///0x000004c6
	///</summary>
	public class Group : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Group(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000004cc", 
		ViewType = "Modifier")]
	[NodeInput("SymTable", typeof(object))]
	[NodeInput("iRow", typeof(System.Object))]
	[NodeInput("iCol", typeof(System.Object))]
	[NodeInput("iRowCount", typeof(System.Object))]
	[NodeInput("iColCount", typeof(System.Object))]

	///<summary>
	///0x000004cc
	///</summary>
	public class Ungroup : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Ungroup(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000610", 
		ViewType = "Modifier")]
	[NodeInput("SymTable", typeof(object))]
	[NodeInput("pSubtable", typeof(System.Object))]
	[NodeInput("iRowFrom", typeof(System.Object))]
	[NodeInput("iColFrom", typeof(System.Object))]
	[NodeInput("McCOM2.SymSubtableMode", typeof(System.Object))]

	///<summary>
	///0x00000610
	///</summary>
	public class Insert : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Insert(inputs[1].Value,inputs[2].Value,inputs[3].Value,((McCOM2.SymSubtableMode)inputs[4].Value));
			return null;
		}
	}
}
