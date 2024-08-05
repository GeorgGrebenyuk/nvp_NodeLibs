using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMDSFilterDlgWrapper Interface
///</summary>
namespace mdsUnitsLib.MDSFilterDlgWrapper 
{

	[NVP_Manifest(
		Id = "26C3B74C-E543-4EF8-A60F-14AC45B330CB", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSFilterDlgWrapper.MDSFilterDlgWrapper_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSFilterDlgWrapper", 
		NodeName = "_MDSFilterDlgWrapper_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSFilterDlgWrapper_Constructor : INode 
	{
		public mdsUnitsLib.IMDSFilterDlgWrapper _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsUnitsLib.IMDSFilterDlgWrapper;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "3123F56B-C6AE-46AF-B442-B34FA04CB4E7", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSFilterDlgWrapper.MDSFilterDlgWrapper_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSFilterDlgWrapper", 
		NodeName = "_MDSFilterDlgWrapper_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSFilterDlgWrapper_ConstructorCast : INode 
	{
		public mdsUnitsLib.IMDSFilterDlgWrapper _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsUnitsLib.IMDSFilterDlgWrapper;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
}
