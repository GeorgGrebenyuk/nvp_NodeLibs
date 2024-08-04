using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMDSAxisDlg Interface
///</summary>
namespace mdsURSLib.MDSAxisDlg 
{

	[NVP_Manifest(
		Id = "8BAA1F4F-6957-48CB-BA67-E431B94872FA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSAxisDlg.MDSAxisDlg_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSAxisDlg", 
		NodeName = "_MDSAxisDlg_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSAxisDlg_Constructor : INode 
	{
		public mdsURSLib.IMDSAxisDlg _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsURSLib.IMDSAxisDlg;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "E1364CF3-C784-4DDC-8C23-BC98643AC806", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSAxisDlg.MDSAxisDlg_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSAxisDlg", 
		NodeName = "_MDSAxisDlg_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSAxisDlg_ConstructorCast : INode 
	{
		public mdsURSLib.IMDSAxisDlg _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsURSLib.IMDSAxisDlg;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
}
