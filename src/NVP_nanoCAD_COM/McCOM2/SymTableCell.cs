using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Table cell object
///</summary>
namespace NVP_nanoCAD_COM._McCOM2.SymTableCell 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymTableCell_Constructor : INode 
	{
		public McCOM2.ISymTableCell _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymTableCell;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymTableCell_ConstructorCast : INode 
	{
		public McCOM2.ISymTableCell _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymTableCell;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x000004ef", 
		ViewType = "Data")]
	[NodeInput("SymTableCell", typeof(object))]

	///<summary>
	///0x000004ef
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
		Text = "0x000004ef", 
		ViewType = "Modifier")]
	[NodeInput("SymTableCell", typeof(object))]
	[NodeInput("pbstrResult", typeof(System.String))]

	///<summary>
	///0x000004ef
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
		Text = "0x000005f2", 
		ViewType = "Data")]
	[NodeInput("SymTableCell", typeof(object))]

	///<summary>
	///0x000005f2
	///</summary>
	public class DisplayText : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DisplayText);

		}
	}


	[NVP_Manifest(
		Text = "0x000004ed", 
		ViewType = "Data")]
	[NodeInput("SymTableCell", typeof(object))]

	///<summary>
	///0x000004ed
	///</summary>
	public class Source : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Source);

		}
	}


	[NVP_Manifest(
		Text = "0x000004ed", 
		ViewType = "Modifier")]
	[NodeInput("SymTableCell", typeof(object))]
	[NodeInput("ppResult", typeof(System.Object))]

	///<summary>
	///0x000004ed
	///</summary>
	public class Set_Source : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Source = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000004f0", 
		ViewType = "Data")]
	[NodeInput("SymTableCell", typeof(object))]

	///<summary>
	///0x000004f0
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
		Text = "0x000004f0", 
		ViewType = "Data")]
	[NodeInput("SymTableCell", typeof(object))]

	///<summary>
	///0x000004f0
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
		Text = "0x000004e7", 
		ViewType = "Data")]
	[NodeInput("SymTableCell", typeof(object))]

	///<summary>
	///0x000004e7
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
		Text = "0x000004ec", 
		ViewType = "Data")]
	[NodeInput("SymTableCell", typeof(object))]

	///<summary>
	///0x000004ec
	///</summary>
	public class Row : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Row);

		}
	}


	[NVP_Manifest(
		Text = "0x000004e8", 
		ViewType = "Data")]
	[NodeInput("SymTableCell", typeof(object))]

	///<summary>
	///0x000004e8
	///</summary>
	public class Col : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Col);

		}
	}


	[NVP_Manifest(
		Text = "0x000004ee", 
		ViewType = "Data")]
	[NodeInput("SymTableCell", typeof(object))]

	///<summary>
	///0x000004ee
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
		Text = "0x000004eb", 
		ViewType = "Data")]
	[NodeInput("SymTableCell", typeof(object))]

	///<summary>
	///0x000004eb
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
		Text = "0x000004e9", 
		ViewType = "Data")]
	[NodeInput("SymTableCell", typeof(object))]

	///<summary>
	///0x000004e9
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
		Text = "0x000004e6", 
		ViewType = "Modifier")]
	[NodeInput("SymTableCell", typeof(object))]
	[NodeInput("vWidthsArray", typeof(System.Object))]
	[NodeInput("vHeightsArray", typeof(System.Object))]

	///<summary>
	///0x000004e6
	///</summary>
	public class Split : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Split(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}
}
