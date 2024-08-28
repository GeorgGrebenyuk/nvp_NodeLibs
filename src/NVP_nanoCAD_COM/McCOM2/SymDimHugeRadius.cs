using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Huge radius dimension
///</summary>
namespace NVP_nanoCAD_COM._McCOM2.SymDimHugeRadius 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymDimHugeRadius_Constructor : INode 
	{
		public McCOM2.ISymDimHugeRadius _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymDimHugeRadius;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymDimHugeRadius_ConstructorCast : INode 
	{
		public McCOM2.ISymDimHugeRadius _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymDimHugeRadius;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x00000180", 
		ViewType = "Data")]
	[NodeInput("SymDimHugeRadius", typeof(object))]

	///<summary>
	///0x00000180
	///</summary>
	public class MeanCenter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MeanCenter);

		}
	}


	[NVP_Manifest(
		Text = "0x00000180", 
		ViewType = "Modifier")]
	[NodeInput("SymDimHugeRadius", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000180
	///</summary>
	public class Set_MeanCenter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MeanCenter = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000172", 
		ViewType = "Data")]
	[NodeInput("SymDimHugeRadius", typeof(object))]

	///<summary>
	///0x00000172
	///</summary>
	public class BreakPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BreakPosition);

		}
	}


	[NVP_Manifest(
		Text = "0x00000172", 
		ViewType = "Modifier")]
	[NodeInput("SymDimHugeRadius", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000172
	///</summary>
	public class Set_BreakPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BreakPosition = inputs[1].Value;
			return null;
		}
	}
}
