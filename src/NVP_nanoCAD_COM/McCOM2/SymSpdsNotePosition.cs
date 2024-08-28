using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///ISymSpdsNotePosition interface
///</summary>
namespace NVP_nanoCAD_COM._McCOM2.SymSpdsNotePosition 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsNotePosition_Constructor : INode 
	{
		public McCOM2.ISymSpdsNotePosition _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymSpdsNotePosition;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsNotePosition_ConstructorCast : INode 
	{
		public McCOM2.ISymSpdsNotePosition _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymSpdsNotePosition;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x0000043e", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNotePosition", typeof(object))]

	///<summary>
	///0x0000043e
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
		Text = "0x0000043e", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNotePosition", typeof(object))]
	[NodeInput("vbstrResult", typeof(System.String))]

	///<summary>
	///0x0000043e
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
		Text = "0x00000434", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNotePosition", typeof(object))]

	///<summary>
	///0x00000434
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
		Text = "0x00000434", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNotePosition", typeof(object))]
	[NodeInput("vbstrResult", typeof(System.String))]

	///<summary>
	///0x00000434
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
		Text = "0x0000042e", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNotePosition", typeof(object))]

	///<summary>
	///0x0000042e
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
		Text = "0x0000042e", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNotePosition", typeof(object))]
	[NodeInput("McCOM2.TextAlignment", typeof(System.Object))]

	///<summary>
	///0x0000042e
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
		Text = "0x0000043f", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNotePosition", typeof(object))]

	///<summary>
	///0x0000043f
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
		Text = "0x0000043f", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNotePosition", typeof(object))]
	[NodeInput("pvResult", typeof(System.Object))]

	///<summary>
	///0x0000043f
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
		Text = "0x00000433", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNotePosition", typeof(object))]

	///<summary>
	///0x00000433
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
		Text = "0x00000433", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNotePosition", typeof(object))]
	[NodeInput("prResult", typeof(System.Double))]

	///<summary>
	///0x00000433
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
		Text = "0x00000437", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNotePosition", typeof(object))]

	///<summary>
	///0x00000437
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
