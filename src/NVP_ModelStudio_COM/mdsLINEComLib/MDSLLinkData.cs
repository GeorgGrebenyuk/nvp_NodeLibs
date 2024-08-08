using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///LinkData Interface
///</summary>
namespace mdsLINEComLib.MDSLLinkData 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLLinkData_Constructor : INode 
	{
		public mdsLINEComLib.IMDSLLinkData _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsLINEComLib.IMDSLLinkData;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLLinkData_ConstructorCast : INode 
	{
		public mdsLINEComLib.IMDSLLinkData _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsLINEComLib.IMDSLLinkData;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "property DataRoot", 
		ViewType = "Data")]
	[NodeInput("MDSLLinkData", typeof(object))]

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
		Text = "property WireLength", 
		ViewType = "Data")]
	[NodeInput("MDSLLinkData", typeof(object))]

	///<summary>
	///property WireLength
	///</summary>
	public class WireLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WireLength);

		}
	}
}
