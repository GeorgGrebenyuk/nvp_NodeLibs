using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace mdsUnitsLib.MDSUnitsFactory 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSUnitsFactory_Constructor : INode 
	{
		public mdsUnitsLib.IMDSUnitsFactory _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsUnitsLib.IMDSUnitsFactory;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSUnitsFactory_ConstructorCast : INode 
	{
		public mdsUnitsLib.IMDSUnitsFactory _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsUnitsLib.IMDSUnitsFactory;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Создание компонента оборудования", 
		ViewType = "Data")]
	[NodeInput("MDSUnitsFactory", typeof(object))]
	[NodeInput("BS_StringXPG", typeof(System.String))]
	[NodeInput("ptPosvar", typeof(System.Object))]
	[NodeInput("varvecX", typeof(System.Object))]
	[NodeInput("varvecY", typeof(System.Object))]
	[NodeInput("varvecZ", typeof(System.Object))]

	///<summary>
	///Создание компонента оборудования
	///</summary>
	public class CreateUnit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateUnit(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value,inputs[5].Value));

		}
	}
}
