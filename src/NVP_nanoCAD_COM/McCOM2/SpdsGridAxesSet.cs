using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Set of axes with the same properites
///</summary>
namespace NVP_nanoCAD_COM._McCOM2.SpdsGridAxesSet 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SpdsGridAxesSet_Constructor : INode 
	{
		public McCOM2.ISpdsGridAxesSet _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISpdsGridAxesSet;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SpdsGridAxesSet_ConstructorCast : INode 
	{
		public McCOM2.ISpdsGridAxesSet _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISpdsGridAxesSet;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x000005f4", 
		ViewType = "Data")]
	[NodeInput("SpdsGridAxesSet", typeof(object))]

	///<summary>
	///0x000005f4
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
		Text = "0x000005f4", 
		ViewType = "Modifier")]
	[NodeInput("SpdsGridAxesSet", typeof(object))]
	[NodeInput("pbstrValue", typeof(System.String))]

	///<summary>
	///0x000005f4
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
		Text = "0x000005f5", 
		ViewType = "Data")]
	[NodeInput("SpdsGridAxesSet", typeof(object))]

	///<summary>
	///0x000005f5
	///</summary>
	public class Distance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Distance);

		}
	}


	[NVP_Manifest(
		Text = "0x000005f5", 
		ViewType = "Modifier")]
	[NodeInput("SpdsGridAxesSet", typeof(object))]
	[NodeInput("prValue", typeof(System.Double))]

	///<summary>
	///0x000005f5
	///</summary>
	public class Set_Distance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Distance = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000005f6", 
		ViewType = "Data")]
	[NodeInput("SpdsGridAxesSet", typeof(object))]

	///<summary>
	///0x000005f6
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
		Text = "0x000005f7", 
		ViewType = "Data")]
	[NodeInput("SpdsGridAxesSet", typeof(object))]

	///<summary>
	///0x000005f7
	///</summary>
	public class Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Count);

		}
	}


	[NVP_Manifest(
		Text = "0x000005f7", 
		ViewType = "Modifier")]
	[NodeInput("SpdsGridAxesSet", typeof(object))]
	[NodeInput("pnValue", typeof(System.Object))]

	///<summary>
	///0x000005f7
	///</summary>
	public class Set_Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Count = inputs[1].Value;
			return null;
		}
	}
}
