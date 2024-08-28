using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Single position of ISymBOMLeader mark
///</summary>
namespace NVP_nanoCAD_COM._McCOM2.BOMLeaderPosition 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class BOMLeaderPosition_Constructor : INode 
	{
		public McCOM2.IBOMLeaderPosition _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.IBOMLeaderPosition;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class BOMLeaderPosition_ConstructorCast : INode 
	{
		public McCOM2.IBOMLeaderPosition _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.IBOMLeaderPosition;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x000005d2", 
		ViewType = "Data")]
	[NodeInput("BOMLeaderPosition", typeof(object))]

	///<summary>
	///0x000005d2
	///</summary>
	public class Owner : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Owner);

		}
	}


	[NVP_Manifest(
		Text = "0x000005d3", 
		ViewType = "Data")]
	[NodeInput("BOMLeaderPosition", typeof(object))]

	///<summary>
	///0x000005d3
	///</summary>
	public class Record : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Record);

		}
	}


	[NVP_Manifest(
		Text = "0x000005d3", 
		ViewType = "Modifier")]
	[NodeInput("BOMLeaderPosition", typeof(object))]
	[NodeInput("ppValue", typeof(System.Object))]

	///<summary>
	///0x000005d3
	///</summary>
	public class Set_Record : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Record = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000005d4", 
		ViewType = "Data")]
	[NodeInput("BOMLeaderPosition", typeof(object))]

	///<summary>
	///0x000005d4
	///</summary>
	public class Object : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Object);

		}
	}


	[NVP_Manifest(
		Text = "0x000005d4", 
		ViewType = "Modifier")]
	[NodeInput("BOMLeaderPosition", typeof(object))]
	[NodeInput("ppValue", typeof(System.Object))]

	///<summary>
	///0x000005d4
	///</summary>
	public class Set_Object : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Object = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000005d5", 
		ViewType = "Data")]
	[NodeInput("BOMLeaderPosition", typeof(object))]

	///<summary>
	///0x000005d5
	///</summary>
	public class BOM : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BOM);

		}
	}
}
