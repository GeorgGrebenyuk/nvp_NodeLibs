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
		Id = "538C34AE-4E64-4C8E-89BA-6BB9F6C46774", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLLinkData.MDSLLinkData_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLLinkData", 
		NodeName = "_MDSLLinkData_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "E979BE65-15B4-4821-8C3F-49DF9C1A9BBB", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLLinkData.MDSLLinkData_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLLinkData", 
		NodeName = "_MDSLLinkData_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "F9A7DD1D-6D2E-4183-9E98-029628D935E4", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLLinkData.DataRoot", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLLinkData", 
		NodeName = "DataRoot", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "3D698436-4EEA-4890-9DE4-B1F101E2F6EA", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLLinkData.WireLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLLinkData", 
		NodeName = "WireLength", 
		NodeType = "Loaded", 
		CADType = "None", 
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
