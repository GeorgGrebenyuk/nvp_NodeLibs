using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace McCOM2.enum_PlaneLevelShape 
{


	[NVP_Manifest(
		Id = "B90E0307-D872-4490-8705-74238A30C123", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_PlaneLevelShape.enum_mcLevelShapeSimple", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_PlaneLevelShape", 
		NodeName = "enum_mcLevelShapeSimple", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcLevelShapeSimple : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.PlaneLevelShape.mcLevelShapeSimple);

		}
	}


	[NVP_Manifest(
		Id = "A8180107-286F-48A3-84D0-2194816BB62E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_PlaneLevelShape.enum_mcLevelShapeUnderlined", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_PlaneLevelShape", 
		NodeName = "enum_mcLevelShapeUnderlined", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcLevelShapeUnderlined : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.PlaneLevelShape.mcLevelShapeUnderlined);

		}
	}


	[NVP_Manifest(
		Id = "2E02D164-A1A1-43BE-AA5A-235B072388A2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_PlaneLevelShape.enum_mcLevelShapeFramed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_PlaneLevelShape", 
		NodeName = "enum_mcLevelShapeFramed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcLevelShapeFramed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.PlaneLevelShape.mcLevelShapeFramed);

		}
	}
}
