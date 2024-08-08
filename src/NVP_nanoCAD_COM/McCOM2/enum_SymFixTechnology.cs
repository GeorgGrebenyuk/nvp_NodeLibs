using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace McCOM2.enum_SymFixTechnology 
{


	[NVP_Manifest(
		Id = "F410122F-23C9-4298-AF47-6A58A83D949A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymFixTechnology.enum_mcFixTechnologyWelded", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymFixTechnology", 
		NodeName = "enum_mcFixTechnologyWelded", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcFixTechnologyWelded : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymFixTechnology.mcFixTechnologyWelded);

		}
	}


	[NVP_Manifest(
		Id = "83BE3B1F-4CBD-4AF1-9593-B869297C8DB6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymFixTechnology.enum_mcFixTechnologySoldered", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymFixTechnology", 
		NodeName = "enum_mcFixTechnologySoldered", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcFixTechnologySoldered : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymFixTechnology.mcFixTechnologySoldered);

		}
	}


	[NVP_Manifest(
		Id = "7875BE57-D4BD-4E23-8897-917F02B409D0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymFixTechnology.enum_mcFixTechnologyGlued", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymFixTechnology", 
		NodeName = "enum_mcFixTechnologyGlued", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcFixTechnologyGlued : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymFixTechnology.mcFixTechnologyGlued);

		}
	}


	[NVP_Manifest(
		Id = "A57B4E17-4910-4DAD-9601-36B937EFA3C9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymFixTechnology.enum_mcFixTechnologyAngularClamp", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymFixTechnology", 
		NodeName = "enum_mcFixTechnologyAngularClamp", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcFixTechnologyAngularClamp : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymFixTechnology.mcFixTechnologyAngularClamp);

		}
	}


	[NVP_Manifest(
		Id = "16CD6744-A622-4526-B81A-8472C609BD17", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymFixTechnology.enum_mcFixTechnologyOverlapClamp", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymFixTechnology", 
		NodeName = "enum_mcFixTechnologyOverlapClamp", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcFixTechnologyOverlapClamp : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymFixTechnology.mcFixTechnologyOverlapClamp);

		}
	}


	[NVP_Manifest(
		Id = "5680E30A-F1A8-4CD7-B38B-72835332E76C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymFixTechnology.enum_mcFixTechnologyCrossLinked", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymFixTechnology", 
		NodeName = "enum_mcFixTechnologyCrossLinked", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcFixTechnologyCrossLinked : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymFixTechnology.mcFixTechnologyCrossLinked);

		}
	}
}
