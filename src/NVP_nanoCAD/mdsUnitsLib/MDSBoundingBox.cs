using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrBoundingBox Interface
///</summary>
namespace mdsUnitsLib.MDSBoundingBox 
{

	[NVP_Manifest(
		Id = "63275A64-70AC-48ED-9B75-7F14D4952186", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSBoundingBox.MDSBoundingBox_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSBoundingBox", 
		NodeName = "_MDSBoundingBox_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSBoundingBox_Constructor : INode 
	{
		public mdsUnitsLib.IMDSBoundingBox _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsUnitsLib.IMDSBoundingBox;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "822CEE98-E63F-4AA6-9CD3-0D8153E723DA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSBoundingBox.MDSBoundingBox_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSBoundingBox", 
		NodeName = "_MDSBoundingBox_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSBoundingBox_ConstructorCast : INode 
	{
		public mdsUnitsLib.IMDSBoundingBox _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsUnitsLib.IMDSBoundingBox;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
}
