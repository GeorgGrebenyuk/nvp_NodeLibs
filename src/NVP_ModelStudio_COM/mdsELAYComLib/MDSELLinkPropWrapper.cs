using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMDSELLinkPropWrapper Interface
///</summary>
namespace mdsELAYComLib.MDSELLinkPropWrapper 
{

	[NVP_Manifest(
		Id = "D7B9C952-DCEB-4D8D-9FC1-17F9A1196F44", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLinkPropWrapper.MDSELLinkPropWrapper_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLinkPropWrapper", 
		NodeName = "_MDSELLinkPropWrapper_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSELLinkPropWrapper_Constructor : INode 
	{
		public mdsELAYComLib.IMDSELLinkPropWrapper _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsELAYComLib.IMDSELLinkPropWrapper;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "E18AACA8-014D-4A21-8FA8-60C5DB1BEB92", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLinkPropWrapper.MDSELLinkPropWrapper_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLinkPropWrapper", 
		NodeName = "_MDSELLinkPropWrapper_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSELLinkPropWrapper_ConstructorCast : INode 
	{
		public mdsELAYComLib.IMDSELLinkPropWrapper _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsELAYComLib.IMDSELLinkPropWrapper;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
}
