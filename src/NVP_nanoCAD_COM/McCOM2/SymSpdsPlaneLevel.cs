using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Plane level mark
///</summary>
namespace McCOM2.SymSpdsPlaneLevel 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsPlaneLevel_Constructor : INode 
	{
		public McCOM2.ISymSpdsPlaneLevel _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymSpdsPlaneLevel;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsPlaneLevel_ConstructorCast : INode 
	{
		public McCOM2.ISymSpdsPlaneLevel _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymSpdsPlaneLevel;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x00000475", 
		ViewType = "Data")]
	[NodeInput("SymSpdsPlaneLevel", typeof(object))]

	///<summary>
	///0x00000475
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
		Text = "0x00000475", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsPlaneLevel", typeof(object))]
	[NodeInput("pvValue", typeof(System.Object))]

	///<summary>
	///0x00000475
	///</summary>
	public class Set_Value : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Value = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000472", 
		ViewType = "Data")]
	[NodeInput("SymSpdsPlaneLevel", typeof(object))]

	///<summary>
	///0x00000472
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
		Text = "0x00000472", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsPlaneLevel", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000472
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
		Text = "0x00000474", 
		ViewType = "Data")]
	[NodeInput("SymSpdsPlaneLevel", typeof(object))]

	///<summary>
	///0x00000474
	///</summary>
	public class Shape : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Shape);

		}
	}


	[NVP_Manifest(
		Text = "0x00000474", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsPlaneLevel", typeof(object))]
	[NodeInput("McCOM2.PlaneLevelShape", typeof(System.Object))]

	///<summary>
	///0x00000474
	///</summary>
	public class Set_Shape : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Shape = ((McCOM2.PlaneLevelShape)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000046c", 
		ViewType = "Data")]
	[NodeInput("SymSpdsPlaneLevel", typeof(object))]

	///<summary>
	///0x0000046c
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
