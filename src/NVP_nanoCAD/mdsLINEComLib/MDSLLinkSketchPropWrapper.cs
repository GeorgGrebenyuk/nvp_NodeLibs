using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMDSLLinkSketchPropWrapper Interface
///</summary>
namespace mdsLINEComLib.MDSLLinkSketchPropWrapper 
{

	[NVP_Manifest(
		Id = "6BDE977C-A1D4-40BD-8707-A2F25E527393", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLLinkSketchPropWrapper.MDSLLinkSketchPropWrapper_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLLinkSketchPropWrapper", 
		NodeName = "_MDSLLinkSketchPropWrapper_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLLinkSketchPropWrapper_Constructor : INode 
	{
		public mdsLINEComLib.IMDSLLinkSketchPropWrapper _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsLINEComLib.IMDSLLinkSketchPropWrapper;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "C28B74CE-04AF-406D-BC6E-D8C5A34D6C1D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLLinkSketchPropWrapper.MDSLLinkSketchPropWrapper_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLLinkSketchPropWrapper", 
		NodeName = "_MDSLLinkSketchPropWrapper_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLLinkSketchPropWrapper_ConstructorCast : INode 
	{
		public mdsLINEComLib.IMDSLLinkSketchPropWrapper _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsLINEComLib.IMDSLLinkSketchPropWrapper;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
}
