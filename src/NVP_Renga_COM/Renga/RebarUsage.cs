using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace NVP_Renga_COM._Renga.RebarUsage 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class RebarUsage_Constructor : INode 
	{
		public Renga.IRebarUsage _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IRebarUsage;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class RebarUsage_ConstructorCast : INode 
	{
		public Renga.IRebarUsage _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IRebarUsage;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("RebarUsage", typeof(object))]

	///<summary>
	///
	///</summary>
	public class StyleId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StyleId);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("RebarUsage", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetQuantities : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetQuantities);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("RebarUsage", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetRebarGeometry : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetRebarGeometry);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("RebarUsage", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetPlacements : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPlacements);

		}
	}
}
