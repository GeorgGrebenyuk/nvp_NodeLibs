using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrAECPlate Interface
///</summary>
namespace ironObjComLib.WrAECPlate 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrAECPlate_Constructor : INode 
	{
		public ironObjComLib.IWrAECPlate _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as ironObjComLib.IWrAECPlate;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrAECPlate_ConstructorCast : INode 
	{
		public ironObjComLib.IWrAECPlate _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as ironObjComLib.IWrAECPlate;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "property AEC_PART_THICKNESS", 
		ViewType = "Data")]
	[NodeInput("WrAECPlate", typeof(object))]

	///<summary>
	///property AEC_PART_THICKNESS
	///</summary>
	public class Thick : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Thick);

		}
	}


	[NVP_Manifest(
		Text = "property AEC_PART_THICKNESS", 
		ViewType = "Modifier")]
	[NodeInput("WrAECPlate", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property AEC_PART_THICKNESS
	///</summary>
	public class Set_Thick : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Thick = inputs[1].Value;
			return null;
		}
	}
}
