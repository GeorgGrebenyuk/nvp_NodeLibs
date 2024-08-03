using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMDSLAngleDialogWrap Interface
///</summary>
namespace mdsLINEComLib.MDSLAngleDialogWrap 
{

	[NVP_Manifest(
		Id = "F8D40A49-2FCE-4764-995E-91374C7FBC9C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAngleDialogWrap.MDSLAngleDialogWrap_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAngleDialogWrap", 
		NodeName = "_MDSLAngleDialogWrap_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLAngleDialogWrap_Constructor : INode 
	{
		public mdsLINEComLib.IMDSLAngleDialogWrap _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsLINEComLib.IMDSLAngleDialogWrap;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "6C04DEEE-A9C7-4428-BC5E-46E20FBCBD12", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAngleDialogWrap.MDSLAngleDialogWrap_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAngleDialogWrap", 
		NodeName = "_MDSLAngleDialogWrap_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLAngleDialogWrap_ConstructorCast : INode 
	{
		public mdsLINEComLib.IMDSLAngleDialogWrap _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsLINEComLib.IMDSLAngleDialogWrap;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
}
