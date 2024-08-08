using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Note mark
///</summary>
namespace McCOM2.SymNote 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymNote_Constructor : INode 
	{
		public McCOM2.ISymNote _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymNote;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymNote_ConstructorCast : INode 
	{
		public McCOM2.ISymNote _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymNote;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x00000298", 
		ViewType = "Data")]
	[NodeInput("SymNote", typeof(object))]

	///<summary>
	///0x00000298
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
		Text = "0x00000298", 
		ViewType = "Modifier")]
	[NodeInput("SymNote", typeof(object))]
	[NodeInput("pbstrText", typeof(System.String))]

	///<summary>
	///0x00000298
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
		Text = "0x0000028f", 
		ViewType = "Data")]
	[NodeInput("SymNote", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///0x0000028f
	///</summary>
	public class Lines : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Lines(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "0x0000028f", 
		ViewType = "Modifier")]
	[NodeInput("SymNote", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]
	[NodeInput("vbstrResult", typeof(System.String))]

	///<summary>
	///0x0000028f
	///</summary>
	public class Set_Lines : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Lines[inputs[1]] = inputs[2];
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000290", 
		ViewType = "Data")]
	[NodeInput("SymNote", typeof(object))]

	///<summary>
	///0x00000290
	///</summary>
	public class LinesCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LinesCount);

		}
	}


	[NVP_Manifest(
		Text = "0x00000290", 
		ViewType = "Modifier")]
	[NodeInput("SymNote", typeof(object))]
	[NodeInput("pnResult", typeof(System.Object))]

	///<summary>
	///0x00000290
	///</summary>
	public class Set_LinesCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LinesCount = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000286", 
		ViewType = "Data")]
	[NodeInput("SymNote", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///0x00000286
	///</summary>
	public class Align : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Align(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "0x00000286", 
		ViewType = "Modifier")]
	[NodeInput("SymNote", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]
	[NodeInput("McCOM2.TextAlignment", typeof(System.Object))]

	///<summary>
	///0x00000286
	///</summary>
	public class Set_Align : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Align[inputs[1]] = inputs[2];
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000299", 
		ViewType = "Data")]
	[NodeInput("SymNote", typeof(object))]

	///<summary>
	///0x00000299
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
		Text = "0x00000299", 
		ViewType = "Modifier")]
	[NodeInput("SymNote", typeof(object))]
	[NodeInput("pvResult", typeof(System.Object))]

	///<summary>
	///0x00000299
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
		Text = "0x0000028b", 
		ViewType = "Data")]
	[NodeInput("SymNote", typeof(object))]

	///<summary>
	///0x0000028b
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
		Text = "0x0000028b", 
		ViewType = "Modifier")]
	[NodeInput("SymNote", typeof(object))]
	[NodeInput("prResult", typeof(System.Double))]

	///<summary>
	///0x0000028b
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
		Text = "0x00000294", 
		ViewType = "Data")]
	[NodeInput("SymNote", typeof(object))]

	///<summary>
	///0x00000294
	///</summary>
	public class Multiline : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Multiline);

		}
	}


	[NVP_Manifest(
		Text = "0x00000294", 
		ViewType = "Modifier")]
	[NodeInput("SymNote", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x00000294
	///</summary>
	public class Set_Multiline : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Multiline = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000028e", 
		ViewType = "Data")]
	[NodeInput("SymNote", typeof(object))]

	///<summary>
	///0x0000028e
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
