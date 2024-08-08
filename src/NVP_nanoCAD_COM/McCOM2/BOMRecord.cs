using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Single line of BOM table
///</summary>
namespace McCOM2.BOMRecord 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class BOMRecord_Constructor : INode 
	{
		public McCOM2.IBOMRecord _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.IBOMRecord;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class BOMRecord_ConstructorCast : INode 
	{
		public McCOM2.IBOMRecord _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.IBOMRecord;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x000005c5", 
		ViewType = "Data")]
	[NodeInput("BOMRecord", typeof(object))]

	///<summary>
	///0x000005c5
	///</summary>
	public class Properties : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Properties);

		}
	}


	[NVP_Manifest(
		Text = "0x000005c6", 
		ViewType = "Modifier")]
	[NodeInput("BOMRecord", typeof(object))]

	///<summary>
	///0x000005c6
	///</summary>
	public class Remove : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Remove();
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000005d6", 
		ViewType = "Data")]
	[NodeInput("BOMRecord", typeof(object))]

	///<summary>
	///0x000005d6
	///</summary>
	public class Order : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Order);

		}
	}


	[NVP_Manifest(
		Text = "0x000005d6", 
		ViewType = "Modifier")]
	[NodeInput("BOMRecord", typeof(object))]
	[NodeInput("pnValue", typeof(System.Object))]

	///<summary>
	///0x000005d6
	///</summary>
	public class Set_Order : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Order = inputs[1].Value;
			return null;
		}
	}
}
