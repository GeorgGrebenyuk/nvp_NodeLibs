using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace NVP_Renga_COM._Renga.ReinforcementUnitUsage 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ReinforcementUnitUsage_Constructor : INode 
	{
		public Renga.IReinforcementUnitUsage _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IReinforcementUnitUsage;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ReinforcementUnitUsage_ConstructorCast : INode 
	{
		public Renga.IReinforcementUnitUsage _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IReinforcementUnitUsage;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("ReinforcementUnitUsage", typeof(object))]

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
	[NodeInput("ReinforcementUnitUsage", typeof(object))]

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
	[NodeInput("ReinforcementUnitUsage", typeof(object))]

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
