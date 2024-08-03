using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace nanoCAD.enum_AcARXDemandLoad 
{


	[NVP_Manifest(
		Id = "7BE1FDC4-D336-4A8C-A32F-1E16C813F1F9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcARXDemandLoad.enum_acDemanLoadDisable", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcARXDemandLoad", 
		NodeName = "enum_acDemanLoadDisable", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDemanLoadDisable : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcARXDemandLoad.acDemanLoadDisable);

		}
	}


	[NVP_Manifest(
		Id = "EAD769E9-F844-45F4-A114-FF751B398D7E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcARXDemandLoad.enum_acDemandLoadOnObjectDetect", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcARXDemandLoad", 
		NodeName = "enum_acDemandLoadOnObjectDetect", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDemandLoadOnObjectDetect : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcARXDemandLoad.acDemandLoadOnObjectDetect);

		}
	}


	[NVP_Manifest(
		Id = "F7C89F41-B0BB-4409-B71D-9775EAB06959", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcARXDemandLoad.enum_acDemandLoadCmdInvoke", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcARXDemandLoad", 
		NodeName = "enum_acDemandLoadCmdInvoke", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDemandLoadCmdInvoke : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcARXDemandLoad.acDemandLoadCmdInvoke);

		}
	}
}
