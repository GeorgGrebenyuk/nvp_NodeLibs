using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Diameter dimension
///</summary>
namespace McCOM2.SymDimDiameter 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymDimDiameter_Constructor : INode 
	{
		public McCOM2.ISymDimDiameter _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymDimDiameter;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymDimDiameter_ConstructorCast : INode 
	{
		public McCOM2.ISymDimDiameter _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymDimDiameter;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x00000131", 
		ViewType = "Data")]
	[NodeInput("SymDimDiameter", typeof(object))]

	///<summary>
	///0x00000131
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
		Text = "0x00000131", 
		ViewType = "Modifier")]
	[NodeInput("SymDimDiameter", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000131
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
		Text = "0x00000132", 
		ViewType = "Data")]
	[NodeInput("SymDimDiameter", typeof(object))]

	///<summary>
	///0x00000132
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
		Text = "0x00000132", 
		ViewType = "Modifier")]
	[NodeInput("SymDimDiameter", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000132
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
		Text = "0x0000011e", 
		ViewType = "Data")]
	[NodeInput("SymDimDiameter", typeof(object))]

	///<summary>
	///0x0000011e
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
		Text = "0x0000011e", 
		ViewType = "Modifier")]
	[NodeInput("SymDimDiameter", typeof(object))]
	[NodeInput("McCOM2.ArrowType", typeof(System.Object))]

	///<summary>
	///0x0000011e
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
		Text = "0x0000011f", 
		ViewType = "Data")]
	[NodeInput("SymDimDiameter", typeof(object))]

	///<summary>
	///0x0000011f
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
		Text = "0x0000011f", 
		ViewType = "Modifier")]
	[NodeInput("SymDimDiameter", typeof(object))]
	[NodeInput("McCOM2.ArrowType", typeof(System.Object))]

	///<summary>
	///0x0000011f
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
		Text = "0x00000122", 
		ViewType = "Data")]
	[NodeInput("SymDimDiameter", typeof(object))]

	///<summary>
	///0x00000122
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
		Text = "0x00000122", 
		ViewType = "Modifier")]
	[NodeInput("SymDimDiameter", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000122
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
}
