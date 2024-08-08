using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace McCOM2.enum_SymSubtableMode 
{


	[NVP_Manifest(
		Id = "F29368EA-70CF-4638-9342-DEDF3E788F24", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymSubtableMode.enum_mcSubtableInSingleCell", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymSubtableMode", 
		NodeName = "enum_mcSubtableInSingleCell", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcSubtableInSingleCell : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymSubtableMode.mcSubtableInSingleCell);

		}
	}


	[NVP_Manifest(
		Id = "F139ED7C-B6C9-4163-B66E-4E5B0FAE7544", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymSubtableMode.enum_mcSubtableCellByCell", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymSubtableMode", 
		NodeName = "enum_mcSubtableCellByCell", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcSubtableCellByCell : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymSubtableMode.mcSubtableCellByCell);

		}
	}


	[NVP_Manifest(
		Id = "551BA57E-67EA-408A-93C5-3FE5C0D434CE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymSubtableMode.enum_mcSubtableOver", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymSubtableMode", 
		NodeName = "enum_mcSubtableOver", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcSubtableOver : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymSubtableMode.mcSubtableOver);

		}
	}
}
