using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Radius dimension
///</summary>
namespace McCOM2.SymDimRadius 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymDimRadius_Constructor : INode 
	{
		public McCOM2.ISymDimRadius _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymDimRadius;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymDimRadius_ConstructorCast : INode 
	{
		public McCOM2.ISymDimRadius _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymDimRadius;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x000001f5", 
		ViewType = "Data")]
	[NodeInput("SymDimRadius", typeof(object))]

	///<summary>
	///0x000001f5
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
		Text = "0x000001f5", 
		ViewType = "Modifier")]
	[NodeInput("SymDimRadius", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x000001f5
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
		Text = "0x000001e6", 
		ViewType = "Data")]
	[NodeInput("SymDimRadius", typeof(object))]

	///<summary>
	///0x000001e6
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
		Text = "0x000001e6", 
		ViewType = "Modifier")]
	[NodeInput("SymDimRadius", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x000001e6
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
		Text = "0x000001e3", 
		ViewType = "Data")]
	[NodeInput("SymDimRadius", typeof(object))]

	///<summary>
	///0x000001e3
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
		Text = "0x000001e3", 
		ViewType = "Modifier")]
	[NodeInput("SymDimRadius", typeof(object))]
	[NodeInput("McCOM2.ArrowType", typeof(System.Object))]

	///<summary>
	///0x000001e3
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
}
