using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///ISymSpdsNoteSecant interface
///</summary>
namespace McCOM2.SymSpdsNoteSecant 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsNoteSecant_Constructor : INode 
	{
		public McCOM2.ISymSpdsNoteSecant _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymSpdsNoteSecant;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsNoteSecant_ConstructorCast : INode 
	{
		public McCOM2.ISymSpdsNoteSecant _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymSpdsNoteSecant;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x0000045c", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteSecant", typeof(object))]

	///<summary>
	///0x0000045c
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
		Text = "0x0000045c", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteSecant", typeof(object))]
	[NodeInput("pvResult", typeof(System.Object))]

	///<summary>
	///0x0000045c
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
		Text = "0x00000449", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteSecant", typeof(object))]

	///<summary>
	///0x00000449
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
		Text = "0x00000449", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteSecant", typeof(object))]
	[NodeInput("McCOM2.TextAlignment", typeof(System.Object))]

	///<summary>
	///0x00000449
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
		Text = "0x0000045b", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteSecant", typeof(object))]

	///<summary>
	///0x0000045b
	///</summary>
	public class Start : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Start);

		}
	}


	[NVP_Manifest(
		Text = "0x0000045b", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteSecant", typeof(object))]
	[NodeInput("pvResult", typeof(System.Object))]

	///<summary>
	///0x0000045b
	///</summary>
	public class Set_Start : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Start = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000044f", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteSecant", typeof(object))]

	///<summary>
	///0x0000044f
	///</summary>
	public class End : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.End);

		}
	}


	[NVP_Manifest(
		Text = "0x0000044f", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteSecant", typeof(object))]
	[NodeInput("pvResult", typeof(System.Object))]

	///<summary>
	///0x0000044f
	///</summary>
	public class Set_End : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.End = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000044e", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteSecant", typeof(object))]

	///<summary>
	///0x0000044e
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
		Text = "0x0000044e", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteSecant", typeof(object))]
	[NodeInput("prResult", typeof(System.Double))]

	///<summary>
	///0x0000044e
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
		Text = "0x00000452", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteSecant", typeof(object))]

	///<summary>
	///0x00000452
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
		Text = "0x00000452", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteSecant", typeof(object))]
	[NodeInput("pbstrResult", typeof(System.String))]

	///<summary>
	///0x00000452
	///</summary>
	public class Set_Index : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Index = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000450", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteSecant", typeof(object))]

	///<summary>
	///0x00000450
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
		Text = "0x00000450", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteSecant", typeof(object))]
	[NodeInput("pbstrResult", typeof(System.String))]

	///<summary>
	///0x00000450
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
		Text = "0x0000045a", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteSecant", typeof(object))]

	///<summary>
	///0x0000045a
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
		Text = "0x0000045a", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteSecant", typeof(object))]
	[NodeInput("pbstrResult", typeof(System.String))]

	///<summary>
	///0x0000045a
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
