using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Linear dimension
///</summary>
namespace NVP_nanoCAD_COM._McCOM2.SymDimLinear 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymDimLinear_Constructor : INode 
	{
		public McCOM2.ISymDimLinear _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymDimLinear;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymDimLinear_ConstructorCast : INode 
	{
		public McCOM2.ISymDimLinear _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymDimLinear;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x000001ae", 
		ViewType = "Data")]
	[NodeInput("SymDimLinear", typeof(object))]

	///<summary>
	///0x000001ae
	///</summary>
	public class Position1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Position1);

		}
	}


	[NVP_Manifest(
		Text = "0x000001ae", 
		ViewType = "Modifier")]
	[NodeInput("SymDimLinear", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x000001ae
	///</summary>
	public class Set_Position1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Position1 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000001af", 
		ViewType = "Data")]
	[NodeInput("SymDimLinear", typeof(object))]

	///<summary>
	///0x000001af
	///</summary>
	public class Position2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Position2);

		}
	}


	[NVP_Manifest(
		Text = "0x000001af", 
		ViewType = "Modifier")]
	[NodeInput("SymDimLinear", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x000001af
	///</summary>
	public class Set_Position2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Position2 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000019a", 
		ViewType = "Data")]
	[NodeInput("SymDimLinear", typeof(object))]

	///<summary>
	///0x0000019a
	///</summary>
	public class Arrow1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Arrow1);

		}
	}


	[NVP_Manifest(
		Text = "0x0000019a", 
		ViewType = "Modifier")]
	[NodeInput("SymDimLinear", typeof(object))]
	[NodeInput("McCOM2.ArrowType", typeof(System.Object))]

	///<summary>
	///0x0000019a
	///</summary>
	public class Set_Arrow1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Arrow1 = ((McCOM2.ArrowType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000019b", 
		ViewType = "Data")]
	[NodeInput("SymDimLinear", typeof(object))]

	///<summary>
	///0x0000019b
	///</summary>
	public class Arrow2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Arrow2);

		}
	}


	[NVP_Manifest(
		Text = "0x0000019b", 
		ViewType = "Modifier")]
	[NodeInput("SymDimLinear", typeof(object))]
	[NodeInput("McCOM2.ArrowType", typeof(System.Object))]

	///<summary>
	///0x0000019b
	///</summary>
	public class Set_Arrow2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Arrow2 = ((McCOM2.ArrowType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000001a7", 
		ViewType = "Data")]
	[NodeInput("SymDimLinear", typeof(object))]

	///<summary>
	///0x000001a7
	///</summary>
	public class LinePosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LinePosition);

		}
	}


	[NVP_Manifest(
		Text = "0x000001a7", 
		ViewType = "Modifier")]
	[NodeInput("SymDimLinear", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x000001a7
	///</summary>
	public class Set_LinePosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LinePosition = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000001a1", 
		ViewType = "Data")]
	[NodeInput("SymDimLinear", typeof(object))]

	///<summary>
	///0x000001a1
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
		Text = "0x000001a1", 
		ViewType = "Modifier")]
	[NodeInput("SymDimLinear", typeof(object))]
	[NodeInput("pvVector", typeof(System.Object))]

	///<summary>
	///0x000001a1
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
		Text = "0x00000163", 
		ViewType = "Data")]
	[NodeInput("SymDimLinear", typeof(object))]

	///<summary>
	///0x00000163
	///</summary>
	public class Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Type);

		}
	}


	[NVP_Manifest(
		Text = "0x00000163", 
		ViewType = "Modifier")]
	[NodeInput("SymDimLinear", typeof(object))]
	[NodeInput("McCOM2.SymDimensionType", typeof(System.Object))]

	///<summary>
	///0x00000163
	///</summary>
	public class Set_Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Type = ((McCOM2.SymDimensionType)inputs[1].Value);
			return null;
		}
	}
}
