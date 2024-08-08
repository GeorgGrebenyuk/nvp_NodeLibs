using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///ISymSpdsNoteComb interface
///</summary>
namespace McCOM2.SymSpdsNoteComb 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsNoteComb_Constructor : INode 
	{
		public McCOM2.ISymSpdsNoteComb _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymSpdsNoteComb;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsNoteComb_ConstructorCast : INode 
	{
		public McCOM2.ISymSpdsNoteComb _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymSpdsNoteComb;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x000003e6", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteComb", typeof(object))]

	///<summary>
	///0x000003e6
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
		Text = "0x000003e6", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteComb", typeof(object))]
	[NodeInput("vbstrResult", typeof(System.String))]

	///<summary>
	///0x000003e6
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
		Text = "0x000003db", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteComb", typeof(object))]

	///<summary>
	///0x000003db
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
		Text = "0x000003db", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteComb", typeof(object))]
	[NodeInput("vbstrResult", typeof(System.String))]

	///<summary>
	///0x000003db
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
		Text = "0x000003d4", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteComb", typeof(object))]

	///<summary>
	///0x000003d4
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
		Text = "0x000003d4", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteComb", typeof(object))]
	[NodeInput("McCOM2.TextAlignment", typeof(System.Object))]

	///<summary>
	///0x000003d4
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
		Text = "0x000003e5", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteComb", typeof(object))]

	///<summary>
	///0x000003e5
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
		Text = "0x000003e5", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteComb", typeof(object))]
	[NodeInput("pvResult", typeof(System.Object))]

	///<summary>
	///0x000003e5
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
		Text = "0x000003da", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteComb", typeof(object))]

	///<summary>
	///0x000003da
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
		Text = "0x000003da", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteComb", typeof(object))]
	[NodeInput("pvResult", typeof(System.Object))]

	///<summary>
	///0x000003da
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
		Text = "0x000003d9", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteComb", typeof(object))]

	///<summary>
	///0x000003d9
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
		Text = "0x000003d9", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteComb", typeof(object))]
	[NodeInput("prResult", typeof(System.Double))]

	///<summary>
	///0x000003d9
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
		Text = "0x000003de", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteComb", typeof(object))]

	///<summary>
	///0x000003de
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
