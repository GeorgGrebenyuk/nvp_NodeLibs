using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///ISymSpdsNoteKnot interface
///</summary>
namespace NVP_nanoCAD_COM._McCOM2.SymSpdsNoteKnot 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsNoteKnot_Constructor : INode 
	{
		public McCOM2.ISymSpdsNoteKnot _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymSpdsNoteKnot;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsNoteKnot_ConstructorCast : INode 
	{
		public McCOM2.ISymSpdsNoteKnot _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymSpdsNoteKnot;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x000003fe", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteKnot", typeof(object))]

	///<summary>
	///0x000003fe
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
		Text = "0x000003fe", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteKnot", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x000003fe
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
		Text = "0x00000405", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteKnot", typeof(object))]

	///<summary>
	///0x00000405
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
		Text = "0x00000405", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteKnot", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000405
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
		Text = "0x000003f0", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteKnot", typeof(object))]

	///<summary>
	///0x000003f0
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
		Text = "0x000003f0", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteKnot", typeof(object))]
	[NodeInput("McCOM2.TextAlignment", typeof(System.Object))]

	///<summary>
	///0x000003f0
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
		Text = "0x00000404", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteKnot", typeof(object))]

	///<summary>
	///0x00000404
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
		Text = "0x00000404", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteKnot", typeof(object))]
	[NodeInput("pbstrResult", typeof(System.String))]

	///<summary>
	///0x00000404
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
		Text = "0x000003f5", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteKnot", typeof(object))]

	///<summary>
	///0x000003f5
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
		Text = "0x000003f5", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteKnot", typeof(object))]
	[NodeInput("prResult", typeof(System.Double))]

	///<summary>
	///0x000003f5
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
		Text = "0x000003f6", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteKnot", typeof(object))]

	///<summary>
	///0x000003f6
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
		Text = "0x000003f6", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteKnot", typeof(object))]
	[NodeInput("pbstrResult", typeof(System.String))]

	///<summary>
	///0x000003f6
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
		Text = "0x00000401", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteKnot", typeof(object))]

	///<summary>
	///0x00000401
	///</summary>
	public class RadiusPerp : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RadiusPerp);

		}
	}


	[NVP_Manifest(
		Text = "0x00000401", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteKnot", typeof(object))]
	[NodeInput("prResult", typeof(System.Double))]

	///<summary>
	///0x00000401
	///</summary>
	public class Set_RadiusPerp : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RadiusPerp = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000402", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteKnot", typeof(object))]

	///<summary>
	///0x00000402
	///</summary>
	public class RadiusRef : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RadiusRef);

		}
	}


	[NVP_Manifest(
		Text = "0x00000402", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteKnot", typeof(object))]
	[NodeInput("prResult", typeof(System.Double))]

	///<summary>
	///0x00000402
	///</summary>
	public class Set_RadiusRef : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RadiusRef = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000400", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteKnot", typeof(object))]

	///<summary>
	///0x00000400
	///</summary>
	public class RadiusDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RadiusDirection);

		}
	}


	[NVP_Manifest(
		Text = "0x00000400", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteKnot", typeof(object))]
	[NodeInput("prValue", typeof(System.Double))]

	///<summary>
	///0x00000400
	///</summary>
	public class Set_RadiusDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RadiusDirection = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000403", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteKnot", typeof(object))]

	///<summary>
	///0x00000403
	///</summary>
	public class Sheet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Sheet);

		}
	}


	[NVP_Manifest(
		Text = "0x00000403", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteKnot", typeof(object))]
	[NodeInput("pbstrResult", typeof(System.String))]

	///<summary>
	///0x00000403
	///</summary>
	public class Set_Sheet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Sheet = inputs[1].Value;
			return null;
		}
	}
}
