using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Drawing dimension
///</summary>
namespace NVP_nanoCAD_COM._McCOM2.SymDimension 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymDimension_Constructor : INode 
	{
		public McCOM2.ISymDimension _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymDimension;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymDimension_ConstructorCast : INode 
	{
		public McCOM2.ISymDimension _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymDimension;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x00000161", 
		ViewType = "Data")]
	[NodeInput("SymDimension", typeof(object))]

	///<summary>
	///0x00000161
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
		Text = "0x00000161", 
		ViewType = "Modifier")]
	[NodeInput("SymDimension", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000161
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
		Text = "0x00000165", 
		ViewType = "Data")]
	[NodeInput("SymDimension", typeof(object))]

	///<summary>
	///0x00000165
	///</summary>
	public class Value : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Value);

		}
	}


	[NVP_Manifest(
		Text = "0x00000164", 
		ViewType = "Data")]
	[NodeInput("SymDimension", typeof(object))]

	///<summary>
	///0x00000164
	///</summary>
	public class Upper : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Upper);

		}
	}


	[NVP_Manifest(
		Text = "0x00000164", 
		ViewType = "Modifier")]
	[NodeInput("SymDimension", typeof(object))]
	[NodeInput("pvResult", typeof(System.Object))]

	///<summary>
	///0x00000164
	///</summary>
	public class Set_Upper : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Upper = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000156", 
		ViewType = "Data")]
	[NodeInput("SymDimension", typeof(object))]

	///<summary>
	///0x00000156
	///</summary>
	public class Lower : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Lower);

		}
	}


	[NVP_Manifest(
		Text = "0x00000156", 
		ViewType = "Modifier")]
	[NodeInput("SymDimension", typeof(object))]
	[NodeInput("pvResult", typeof(System.Object))]

	///<summary>
	///0x00000156
	///</summary>
	public class Set_Lower : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Lower = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000015c", 
		ViewType = "Data")]
	[NodeInput("SymDimension", typeof(object))]

	///<summary>
	///0x0000015c
	///</summary>
	public class Quality : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Quality);

		}
	}


	[NVP_Manifest(
		Text = "0x0000015c", 
		ViewType = "Modifier")]
	[NodeInput("SymDimension", typeof(object))]
	[NodeInput("pnResult", typeof(System.Object))]

	///<summary>
	///0x0000015c
	///</summary>
	public class Set_Quality : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Quality = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000014e", 
		ViewType = "Data")]
	[NodeInput("SymDimension", typeof(object))]

	///<summary>
	///0x0000014e
	///</summary>
	public class Field : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Field);

		}
	}


	[NVP_Manifest(
		Text = "0x0000014e", 
		ViewType = "Modifier")]
	[NodeInput("SymDimension", typeof(object))]
	[NodeInput("pbstrResult", typeof(System.String))]

	///<summary>
	///0x0000014e
	///</summary>
	public class Set_Field : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Field = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000162", 
		ViewType = "Data")]
	[NodeInput("SymDimension", typeof(object))]

	///<summary>
	///0x00000162
	///</summary>
	public class TolView : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TolView);

		}
	}


	[NVP_Manifest(
		Text = "0x00000162", 
		ViewType = "Modifier")]
	[NodeInput("SymDimension", typeof(object))]
	[NodeInput("McCOM2.SymDimensionTolView", typeof(System.Object))]

	///<summary>
	///0x00000162
	///</summary>
	public class Set_TolView : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TolView = ((McCOM2.SymDimensionTolView)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000014a", 
		ViewType = "Data")]
	[NodeInput("SymDimension", typeof(object))]

	///<summary>
	///0x0000014a
	///</summary>
	public class Brackets : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Brackets);

		}
	}


	[NVP_Manifest(
		Text = "0x0000014a", 
		ViewType = "Modifier")]
	[NodeInput("SymDimension", typeof(object))]
	[NodeInput("McCOM2.SymDimensionBracket", typeof(System.Object))]

	///<summary>
	///0x0000014a
	///</summary>
	public class Set_Brackets : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Brackets = ((McCOM2.SymDimensionBracket)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000015e", 
		ViewType = "Data")]
	[NodeInput("SymDimension", typeof(object))]

	///<summary>
	///0x0000015e
	///</summary>
	public class Rect : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Rect);

		}
	}


	[NVP_Manifest(
		Text = "0x0000015e", 
		ViewType = "Modifier")]
	[NodeInput("SymDimension", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x0000015e
	///</summary>
	public class Set_Rect : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Rect = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000152", 
		ViewType = "Data")]
	[NodeInput("SymDimension", typeof(object))]

	///<summary>
	///0x00000152
	///</summary>
	public class Leader : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Leader);

		}
	}


	[NVP_Manifest(
		Text = "0x00000152", 
		ViewType = "Modifier")]
	[NodeInput("SymDimension", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x00000152
	///</summary>
	public class Set_Leader : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Leader = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000015d", 
		ViewType = "Data")]
	[NodeInput("SymDimension", typeof(object))]

	///<summary>
	///0x0000015d
	///</summary>
	public class Real : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Real);

		}
	}


	[NVP_Manifest(
		Text = "0x0000015d", 
		ViewType = "Modifier")]
	[NodeInput("SymDimension", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x0000015d
	///</summary>
	public class Set_Real : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Real = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000160", 
		ViewType = "Data")]
	[NodeInput("SymDimension", typeof(object))]

	///<summary>
	///0x00000160
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
		Text = "0x00000160", 
		ViewType = "Modifier")]
	[NodeInput("SymDimension", typeof(object))]
	[NodeInput("pbstrText", typeof(System.String))]

	///<summary>
	///0x00000160
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
		Text = "0x0000015a", 
		ViewType = "Data")]
	[NodeInput("SymDimension", typeof(object))]

	///<summary>
	///0x0000015a
	///</summary>
	public class Prefix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Prefix);

		}
	}


	[NVP_Manifest(
		Text = "0x0000015a", 
		ViewType = "Modifier")]
	[NodeInput("SymDimension", typeof(object))]
	[NodeInput("pbstrText", typeof(System.String))]

	///<summary>
	///0x0000015a
	///</summary>
	public class Set_Prefix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Prefix = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000015f", 
		ViewType = "Data")]
	[NodeInput("SymDimension", typeof(object))]

	///<summary>
	///0x0000015f
	///</summary>
	public class Suffix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Suffix);

		}
	}


	[NVP_Manifest(
		Text = "0x0000015f", 
		ViewType = "Modifier")]
	[NodeInput("SymDimension", typeof(object))]
	[NodeInput("pbstrText", typeof(System.String))]

	///<summary>
	///0x0000015f
	///</summary>
	public class Set_Suffix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Suffix = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000159", 
		ViewType = "Data")]
	[NodeInput("SymDimension", typeof(object))]

	///<summary>
	///0x00000159
	///</summary>
	public class Postfix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Postfix);

		}
	}


	[NVP_Manifest(
		Text = "0x00000159", 
		ViewType = "Modifier")]
	[NodeInput("SymDimension", typeof(object))]
	[NodeInput("pbstrText", typeof(System.String))]

	///<summary>
	///0x00000159
	///</summary>
	public class Set_Postfix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Postfix = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000014f", 
		ViewType = "Data")]
	[NodeInput("SymDimension", typeof(object))]

	///<summary>
	///0x0000014f
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
		Text = "0x0000014f", 
		ViewType = "Modifier")]
	[NodeInput("SymDimension", typeof(object))]
	[NodeInput("pbstrText", typeof(System.String))]

	///<summary>
	///0x0000014f
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
		Text = "0x00000588", 
		ViewType = "Data")]
	[NodeInput("SymDimension", typeof(object))]

	///<summary>
	///0x00000588
	///</summary>
	public class Symbol : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Symbol);

		}
	}


	[NVP_Manifest(
		Text = "0x00000588", 
		ViewType = "Modifier")]
	[NodeInput("SymDimension", typeof(object))]
	[NodeInput("McCOM2.SymDimensionSymbol", typeof(System.Object))]

	///<summary>
	///0x00000588
	///</summary>
	public class Set_Symbol : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Symbol = ((McCOM2.SymDimensionSymbol)inputs[1].Value);
			return null;
		}
	}
}
