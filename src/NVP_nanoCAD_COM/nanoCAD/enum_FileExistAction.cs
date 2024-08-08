using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace nanoCAD.enum_FileExistAction 
{


	[NVP_Manifest(
		Id = "8F88E8EB-B221-41EE-9944-C6BBE907C0B0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_FileExistAction.enum_eFEA_Attach", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_FileExistAction", 
		NodeName = "enum_eFEA_Attach", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_eFEA_Attach : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.FileExistAction.eFEA_Attach);

		}
	}
}
