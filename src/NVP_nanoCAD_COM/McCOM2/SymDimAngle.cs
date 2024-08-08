using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Angle dimension
///</summary>
namespace McCOM2.SymDimAngle 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymDimAngle_Constructor : INode 
	{
		public McCOM2.ISymDimAngle _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymDimAngle;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymDimAngle_ConstructorCast : INode 
	{
		public McCOM2.ISymDimAngle _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymDimAngle;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x00000582", 
		ViewType = "Data")]
	[NodeInput("SymDimAngle", typeof(object))]

	///<summary>
	///0x00000582
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
		Text = "0x00000582", 
		ViewType = "Modifier")]
	[NodeInput("SymDimAngle", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000582
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
		Text = "0x00000583", 
		ViewType = "Data")]
	[NodeInput("SymDimAngle", typeof(object))]

	///<summary>
	///0x00000583
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
		Text = "0x00000583", 
		ViewType = "Modifier")]
	[NodeInput("SymDimAngle", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000583
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
		Text = "0x00000584", 
		ViewType = "Data")]
	[NodeInput("SymDimAngle", typeof(object))]

	///<summary>
	///0x00000584
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
		Text = "0x00000584", 
		ViewType = "Modifier")]
	[NodeInput("SymDimAngle", typeof(object))]
	[NodeInput("McCOM2.ArrowType", typeof(System.Object))]

	///<summary>
	///0x00000584
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
		Text = "0x00000585", 
		ViewType = "Data")]
	[NodeInput("SymDimAngle", typeof(object))]

	///<summary>
	///0x00000585
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
		Text = "0x00000585", 
		ViewType = "Modifier")]
	[NodeInput("SymDimAngle", typeof(object))]
	[NodeInput("McCOM2.ArrowType", typeof(System.Object))]

	///<summary>
	///0x00000585
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
		Text = "0x00000586", 
		ViewType = "Data")]
	[NodeInput("SymDimAngle", typeof(object))]

	///<summary>
	///0x00000586
	///</summary>
	public class Center : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Center);

		}
	}


	[NVP_Manifest(
		Text = "0x00000586", 
		ViewType = "Modifier")]
	[NodeInput("SymDimAngle", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000586
	///</summary>
	public class Set_Center : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Center = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000587", 
		ViewType = "Data")]
	[NodeInput("SymDimAngle", typeof(object))]

	///<summary>
	///0x00000587
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
		Text = "0x00000587", 
		ViewType = "Modifier")]
	[NodeInput("SymDimAngle", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000587
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
}
