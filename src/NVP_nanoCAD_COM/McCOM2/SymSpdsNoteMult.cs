using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///ISymSpdsNoteMult interface
///</summary>
namespace NVP_nanoCAD_COM._McCOM2.SymSpdsNoteMult 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsNoteMult_Constructor : INode 
	{
		public McCOM2.ISymSpdsNoteMult _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymSpdsNoteMult;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsNoteMult_ConstructorCast : INode 
	{
		public McCOM2.ISymSpdsNoteMult _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymSpdsNoteMult;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x00000421", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteMult", typeof(object))]

	///<summary>
	///0x00000421
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
		Text = "0x00000421", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteMult", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000421
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
		Text = "0x00000424", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteMult", typeof(object))]

	///<summary>
	///0x00000424
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
		Text = "0x00000424", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteMult", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000424
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
		Text = "0x00000410", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteMult", typeof(object))]

	///<summary>
	///0x00000410
	///</summary>
	public class Arrow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Arrow);

		}
	}


	[NVP_Manifest(
		Text = "0x00000410", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteMult", typeof(object))]
	[NodeInput("McCOM2.ArrowType", typeof(System.Object))]

	///<summary>
	///0x00000410
	///</summary>
	public class Set_Arrow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Arrow = ((McCOM2.ArrowType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000423", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteMult", typeof(object))]

	///<summary>
	///0x00000423
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
		Text = "0x00000423", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteMult", typeof(object))]
	[NodeInput("vbstrResult", typeof(System.String))]

	///<summary>
	///0x00000423
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
		Text = "0x0000041a", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteMult", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///0x0000041a
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
		Text = "0x0000041a", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteMult", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]
	[NodeInput("vbstrResult", typeof(System.String))]

	///<summary>
	///0x0000041a
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
		Text = "0x0000041b", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteMult", typeof(object))]

	///<summary>
	///0x0000041b
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
		Text = "0x0000041b", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteMult", typeof(object))]
	[NodeInput("pnResult", typeof(System.Object))]

	///<summary>
	///0x0000041b
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
		Text = "0x0000040f", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteMult", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///0x0000040f
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
		Text = "0x0000040f", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteMult", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]
	[NodeInput("McCOM2.TextAlignment", typeof(System.Object))]

	///<summary>
	///0x0000040f
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
		Text = "0x00000415", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteMult", typeof(object))]

	///<summary>
	///0x00000415
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
		Text = "0x00000415", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteMult", typeof(object))]
	[NodeInput("prResult", typeof(System.Double))]

	///<summary>
	///0x00000415
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
		Text = "0x00000416", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteMult", typeof(object))]

	///<summary>
	///0x00000416
	///</summary>
	public class Grow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Grow);

		}
	}


	[NVP_Manifest(
		Text = "0x00000416", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteMult", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x00000416
	///</summary>
	public class Set_Grow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Grow = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000419", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteMult", typeof(object))]

	///<summary>
	///0x00000419
	///</summary>
	public class Line : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Line);

		}
	}


	[NVP_Manifest(
		Text = "0x00000419", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteMult", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x00000419
	///</summary>
	public class Set_Line : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Line = inputs[1].Value;
			return null;
		}
	}
}
