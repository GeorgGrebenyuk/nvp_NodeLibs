using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMDSLPropertyDialogWrap Interface
///</summary>
namespace mdsLINEComLib.MDSLPropertyDialogWrap 
{

	[NVP_Manifest(
		Id = "521A2AC6-75B3-4F1E-AAF4-0B7A183194C0", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLPropertyDialogWrap.MDSLPropertyDialogWrap_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLPropertyDialogWrap", 
		NodeName = "_MDSLPropertyDialogWrap_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLPropertyDialogWrap_Constructor : INode 
	{
		public mdsLINEComLib.IMDSLPropertyDialogWrap _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsLINEComLib.IMDSLPropertyDialogWrap;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "61E0D900-3358-479C-AD9C-AC7C6CF07040", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLPropertyDialogWrap.MDSLPropertyDialogWrap_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLPropertyDialogWrap", 
		NodeName = "_MDSLPropertyDialogWrap_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLPropertyDialogWrap_ConstructorCast : INode 
	{
		public mdsLINEComLib.IMDSLPropertyDialogWrap _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsLINEComLib.IMDSLPropertyDialogWrap;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
}
