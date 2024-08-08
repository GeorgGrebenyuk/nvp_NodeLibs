using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///ISymSpdsNoteChain interface
///</summary>
namespace McCOM2.SymSpdsNoteChain 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsNoteChain_Constructor : INode 
	{
		public McCOM2.ISymSpdsNoteChain _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymSpdsNoteChain;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsNoteChain_ConstructorCast : INode 
	{
		public McCOM2.ISymSpdsNoteChain _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymSpdsNoteChain;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x000003c9", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteChain", typeof(object))]

	///<summary>
	///0x000003c9
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
		Text = "0x000003c9", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteChain", typeof(object))]
	[NodeInput("vbstrResult", typeof(System.String))]

	///<summary>
	///0x000003c9
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
		Text = "0x000003be", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteChain", typeof(object))]

	///<summary>
	///0x000003be
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
		Text = "0x000003be", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteChain", typeof(object))]
	[NodeInput("vbstrResult", typeof(System.String))]

	///<summary>
	///0x000003be
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
		Text = "0x000003b8", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteChain", typeof(object))]

	///<summary>
	///0x000003b8
	///</summary>
	public class Align : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Align);

		}
	}


	[NVP_Manifest(
		Text = "0x000003b8", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteChain", typeof(object))]
	[NodeInput("McCOM2.TextAlignment", typeof(System.Object))]

	///<summary>
	///0x000003b8
	///</summary>
	public class Set_Align : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Align = ((McCOM2.TextAlignment)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000003ca", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteChain", typeof(object))]

	///<summary>
	///0x000003ca
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
		Text = "0x000003ca", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteChain", typeof(object))]
	[NodeInput("pvResult", typeof(System.Object))]

	///<summary>
	///0x000003ca
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
		Text = "0x000003bd", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteChain", typeof(object))]

	///<summary>
	///0x000003bd
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
		Text = "0x000003bd", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteChain", typeof(object))]
	[NodeInput("prResult", typeof(System.Double))]

	///<summary>
	///0x000003bd
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
		Text = "0x000003c2", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteChain", typeof(object))]

	///<summary>
	///0x000003c2
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
