using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.AcadDwfUnderlay 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadDwfUnderlay_Constructor : INode 
	{
		public OdaX.IAcadDwfUnderlay _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadDwfUnderlay;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadDwfUnderlay_ConstructorCast : INode 
	{
		public OdaX.IAcadDwfUnderlay _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadDwfUnderlay;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Specifies the format of DWF file", 
		ViewType = "Data")]
	[NodeInput("AcadDwfUnderlay", typeof(object))]

	///<summary>
	///Specifies the format of DWF file
	///</summary>
	public class DWFFormat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DWFFormat);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the format of DWF file", 
		ViewType = "Modifier")]
	[NodeInput("AcadDwfUnderlay", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Specifies the format of DWF file
	///</summary>
	public class Set_DWFFormat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DWFFormat = inputs[1].Value;
			return null;
		}
	}
}
