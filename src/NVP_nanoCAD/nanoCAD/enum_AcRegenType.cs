using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace nanoCAD.enum_AcRegenType 
{


	[NVP_Manifest(
		Id = "C20EA93F-5919-41EC-9467-0FF94F2E7743", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcRegenType.enum_acActiveViewport", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcRegenType", 
		NodeName = "enum_acActiveViewport", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acActiveViewport : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcRegenType.acActiveViewport);

		}
	}


	[NVP_Manifest(
		Id = "E022BBBD-20AC-415C-AC2E-31F653CCE0F7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcRegenType.enum_acAllViewports", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcRegenType", 
		NodeName = "enum_acAllViewports", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acAllViewports : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcRegenType.acAllViewports);

		}
	}
}
