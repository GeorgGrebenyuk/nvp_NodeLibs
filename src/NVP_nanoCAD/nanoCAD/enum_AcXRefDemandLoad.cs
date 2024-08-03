using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace nanoCAD.enum_AcXRefDemandLoad 
{


	[NVP_Manifest(
		Id = "413F6713-0365-45D2-9720-E4F49993A208", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcXRefDemandLoad.enum_acDemandLoadDisabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcXRefDemandLoad", 
		NodeName = "enum_acDemandLoadDisabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDemandLoadDisabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcXRefDemandLoad.acDemandLoadDisabled);

		}
	}


	[NVP_Manifest(
		Id = "2BA620E3-F24F-427D-BCBB-C86E4D318740", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcXRefDemandLoad.enum_acDemandLoadEnabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcXRefDemandLoad", 
		NodeName = "enum_acDemandLoadEnabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDemandLoadEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcXRefDemandLoad.acDemandLoadEnabled);

		}
	}


	[NVP_Manifest(
		Id = "537DC9CD-0E48-4FFE-A35C-961C1E829DB4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcXRefDemandLoad.enum_acDemandLoadEnabledWithCopy", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcXRefDemandLoad", 
		NodeName = "enum_acDemandLoadEnabledWithCopy", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDemandLoadEnabledWithCopy : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcXRefDemandLoad.acDemandLoadEnabledWithCopy);

		}
	}
}
