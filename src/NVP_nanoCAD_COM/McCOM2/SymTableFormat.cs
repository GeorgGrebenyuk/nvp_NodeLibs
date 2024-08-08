using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Table item formatter
///</summary>
namespace McCOM2.SymTableFormat 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymTableFormat_Constructor : INode 
	{
		public McCOM2.ISymTableFormat _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymTableFormat;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymTableFormat_ConstructorCast : INode 
	{
		public McCOM2.ISymTableFormat _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymTableFormat;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x00000501", 
		ViewType = "Data")]
	[NodeInput("SymTableFormat", typeof(object))]
	[NodeInput("McCOM2.SymTableBorder", typeof(System.Object))]

	///<summary>
	///0x00000501
	///</summary>
	public class BorderWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BorderWeight(((McCOM2.SymTableBorder)inputs[1].Value)));

		}
	}


	[NVP_Manifest(
		Text = "0x00000501", 
		ViewType = "Modifier")]
	[NodeInput("SymTableFormat", typeof(object))]
	[NodeInput("McCOM2.SymTableBorder", typeof(System.Object))]
	[NodeInput("prValue", typeof(System.Double))]

	///<summary>
	///0x00000501
	///</summary>
	public class Set_BorderWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BorderWeight[inputs[1]] = inputs[2];
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000500", 
		ViewType = "Data")]
	[NodeInput("SymTableFormat", typeof(object))]
	[NodeInput("McCOM2.SymTableBorder", typeof(System.Object))]

	///<summary>
	///0x00000500
	///</summary>
	public class BorderColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BorderColor(((McCOM2.SymTableBorder)inputs[1].Value)));

		}
	}


	[NVP_Manifest(
		Text = "0x00000500", 
		ViewType = "Modifier")]
	[NodeInput("SymTableFormat", typeof(object))]
	[NodeInput("McCOM2.SymTableBorder", typeof(System.Object))]
	[NodeInput("pnValue", typeof(System.Object))]

	///<summary>
	///0x00000500
	///</summary>
	public class Set_BorderColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BorderColor[inputs[1]] = inputs[2];
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000508", 
		ViewType = "Data")]
	[NodeInput("SymTableFormat", typeof(object))]

	///<summary>
	///0x00000508
	///</summary>
	public class TextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextStyle);

		}
	}


	[NVP_Manifest(
		Text = "0x00000508", 
		ViewType = "Modifier")]
	[NodeInput("SymTableFormat", typeof(object))]
	[NodeInput("pbstrResult", typeof(System.String))]

	///<summary>
	///0x00000508
	///</summary>
	public class Set_TextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextStyle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000505", 
		ViewType = "Data")]
	[NodeInput("SymTableFormat", typeof(object))]

	///<summary>
	///0x00000505
	///</summary>
	public class TextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextHeight);

		}
	}


	[NVP_Manifest(
		Text = "0x00000505", 
		ViewType = "Modifier")]
	[NodeInput("SymTableFormat", typeof(object))]
	[NodeInput("prResult", typeof(System.Double))]

	///<summary>
	///0x00000505
	///</summary>
	public class Set_TextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextHeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000503", 
		ViewType = "Data")]
	[NodeInput("SymTableFormat", typeof(object))]

	///<summary>
	///0x00000503
	///</summary>
	public class TextAlign : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextAlign);

		}
	}


	[NVP_Manifest(
		Text = "0x00000503", 
		ViewType = "Modifier")]
	[NodeInput("SymTableFormat", typeof(object))]
	[NodeInput("McCOM2.TextAlignment", typeof(System.Object))]

	///<summary>
	///0x00000503
	///</summary>
	public class Set_TextAlign : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextAlign = ((McCOM2.TextAlignment)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000506", 
		ViewType = "Data")]
	[NodeInput("SymTableFormat", typeof(object))]

	///<summary>
	///0x00000506
	///</summary>
	public class TextMargin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextMargin);

		}
	}


	[NVP_Manifest(
		Text = "0x00000506", 
		ViewType = "Modifier")]
	[NodeInput("SymTableFormat", typeof(object))]
	[NodeInput("prResult", typeof(System.Double))]

	///<summary>
	///0x00000506
	///</summary>
	public class Set_TextMargin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextMargin = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000504", 
		ViewType = "Data")]
	[NodeInput("SymTableFormat", typeof(object))]

	///<summary>
	///0x00000504
	///</summary>
	public class TextAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextAngle);

		}
	}


	[NVP_Manifest(
		Text = "0x00000504", 
		ViewType = "Modifier")]
	[NodeInput("SymTableFormat", typeof(object))]
	[NodeInput("pnAngle", typeof(System.Object))]

	///<summary>
	///0x00000504
	///</summary>
	public class Set_TextAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextAngle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000509", 
		ViewType = "Data")]
	[NodeInput("SymTableFormat", typeof(object))]

	///<summary>
	///0x00000509
	///</summary>
	public class TextWrap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextWrap);

		}
	}


	[NVP_Manifest(
		Text = "0x00000509", 
		ViewType = "Modifier")]
	[NodeInput("SymTableFormat", typeof(object))]
	[NodeInput("pvbResult", typeof(System.Object))]

	///<summary>
	///0x00000509
	///</summary>
	public class Set_TextWrap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextWrap = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000507", 
		ViewType = "Data")]
	[NodeInput("SymTableFormat", typeof(object))]

	///<summary>
	///0x00000507
	///</summary>
	public class TextScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextScale);

		}
	}


	[NVP_Manifest(
		Text = "0x00000507", 
		ViewType = "Modifier")]
	[NodeInput("SymTableFormat", typeof(object))]
	[NodeInput("pvbResult", typeof(System.Object))]

	///<summary>
	///0x00000507
	///</summary>
	public class Set_TextScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000502", 
		ViewType = "Data")]
	[NodeInput("SymTableFormat", typeof(object))]

	///<summary>
	///0x00000502
	///</summary>
	public class Enabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Enabled);

		}
	}


	[NVP_Manifest(
		Text = "0x00000502", 
		ViewType = "Modifier")]
	[NodeInput("SymTableFormat", typeof(object))]
	[NodeInput("pvbResult", typeof(System.Object))]

	///<summary>
	///0x00000502
	///</summary>
	public class Set_Enabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Enabled = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000004ff", 
		ViewType = "Modifier")]
	[NodeInput("SymTableFormat", typeof(object))]
	[NodeInput("pFrom", typeof(System.Object))]

	///<summary>
	///0x000004ff
	///</summary>
	public class CopyFrom : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CopyFrom(inputs[1].Value);
			return null;
		}
	}
}
