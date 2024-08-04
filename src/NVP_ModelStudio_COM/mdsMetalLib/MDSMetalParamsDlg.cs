using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMDSMetalParamsDlg Interface
///</summary>
namespace mdsMetalLib.MDSMetalParamsDlg 
{

	[NVP_Manifest(
		Id = "7F3C087D-7D80-4531-980A-FB0F659BAC13", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsMetalLib.MDSMetalParamsDlg.MDSMetalParamsDlg_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsMetalLib.MDSMetalParamsDlg", 
		NodeName = "_MDSMetalParamsDlg_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSMetalParamsDlg_Constructor : INode 
	{
		public mdsMetalLib.IMDSMetalParamsDlg _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsMetalLib.IMDSMetalParamsDlg;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "A45F91A8-F7FF-4637-9CA9-E0C813C2F244", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsMetalLib.MDSMetalParamsDlg.MDSMetalParamsDlg_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsMetalLib.MDSMetalParamsDlg", 
		NodeName = "_MDSMetalParamsDlg_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSMetalParamsDlg_ConstructorCast : INode 
	{
		public mdsMetalLib.IMDSMetalParamsDlg _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsMetalLib.IMDSMetalParamsDlg;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
}
