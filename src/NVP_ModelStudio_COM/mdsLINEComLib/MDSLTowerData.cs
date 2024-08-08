using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TowerData Interface
///</summary>
namespace mdsLINEComLib.MDSLTowerData 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLTowerData_Constructor : INode 
	{
		public mdsLINEComLib.IMDSLTowerData _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsLINEComLib.IMDSLTowerData;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLTowerData_ConstructorCast : INode 
	{
		public mdsLINEComLib.IMDSLTowerData _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsLINEComLib.IMDSLTowerData;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "property TowerName", 
		ViewType = "Data")]
	[NodeInput("MDSLTowerData", typeof(object))]

	///<summary>
	///property TowerName
	///</summary>
	public class TowerName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TowerName);

		}
	}


	[NVP_Manifest(
		Text = "property DataRoot", 
		ViewType = "Data")]
	[NodeInput("MDSLTowerData", typeof(object))]

	///<summary>
	///property DataRoot
	///</summary>
	public class DataRoot : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DataRoot);

		}
	}


	[NVP_Manifest(
		Text = "method LinkData", 
		ViewType = "Data")]
	[NodeInput("MDSLTowerData", typeof(object))]
	[NodeInput("phaseName", typeof(System.String))]
	[NodeInput("bLeft", typeof(System.Object))]

	///<summary>
	///method LinkData
	///</summary>
	public class LinkData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LinkData(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Text = "method ClimateData", 
		ViewType = "Data")]
	[NodeInput("MDSLTowerData", typeof(object))]

	///<summary>
	///method ClimateData
	///</summary>
	public class climateData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.climateData);

		}
	}
}
