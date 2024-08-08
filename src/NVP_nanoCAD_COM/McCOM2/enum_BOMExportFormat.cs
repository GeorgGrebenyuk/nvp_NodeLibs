using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace McCOM2.enum_BOMExportFormat 
{


	[NVP_Manifest(
		Id = "EA84208D-FBB6-43FB-BC45-FF2ADCEE68DC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_BOMExportFormat.enum_mcExportDrawing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_BOMExportFormat", 
		NodeName = "enum_mcExportDrawing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcExportDrawing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.BOMExportFormat.mcExportDrawing);

		}
	}


	[NVP_Manifest(
		Id = "EC1F9877-0BAB-4965-896B-57DACBA79ECF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_BOMExportFormat.enum_mcExportExcel", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_BOMExportFormat", 
		NodeName = "enum_mcExportExcel", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcExportExcel : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.BOMExportFormat.mcExportExcel);

		}
	}


	[NVP_Manifest(
		Id = "667DE08A-DF53-4544-8ACC-A2A7AA85DEB1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_BOMExportFormat.enum_mcExportTechnologiCS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_BOMExportFormat", 
		NodeName = "enum_mcExportTechnologiCS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcExportTechnologiCS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.BOMExportFormat.mcExportTechnologiCS);

		}
	}


	[NVP_Manifest(
		Id = "7B6C09DA-89F1-459B-8951-A8020B58DC82", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_BOMExportFormat.enum_mcExportDBF", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_BOMExportFormat", 
		NodeName = "enum_mcExportDBF", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcExportDBF : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.BOMExportFormat.mcExportDBF);

		}
	}
}
