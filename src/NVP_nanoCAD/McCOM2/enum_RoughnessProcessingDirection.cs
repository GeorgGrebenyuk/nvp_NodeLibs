using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace McCOM2.enum_RoughnessProcessingDirection 
{


	[NVP_Manifest(
		Id = "168899F7-F7B2-4A88-8F54-435DC115EB2C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_RoughnessProcessingDirection.enum_mcProcessingDirNone", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_RoughnessProcessingDirection", 
		NodeName = "enum_mcProcessingDirNone", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcProcessingDirNone : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.RoughnessProcessingDirection.mcProcessingDirNone);

		}
	}


	[NVP_Manifest(
		Id = "D99C237C-CA37-4674-9253-63408D3B1B66", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_RoughnessProcessingDirection.enum_mcProcessingDirParallel", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_RoughnessProcessingDirection", 
		NodeName = "enum_mcProcessingDirParallel", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcProcessingDirParallel : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.RoughnessProcessingDirection.mcProcessingDirParallel);

		}
	}


	[NVP_Manifest(
		Id = "D451578F-73E9-427B-92ED-98C6D79CE57E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_RoughnessProcessingDirection.enum_mcProcessingDirPerpendicular", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_RoughnessProcessingDirection", 
		NodeName = "enum_mcProcessingDirPerpendicular", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcProcessingDirPerpendicular : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.RoughnessProcessingDirection.mcProcessingDirPerpendicular);

		}
	}


	[NVP_Manifest(
		Id = "E361B699-ADE0-4A19-9D3D-053FFEAD5B8A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_RoughnessProcessingDirection.enum_mcProcessingDirCrossing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_RoughnessProcessingDirection", 
		NodeName = "enum_mcProcessingDirCrossing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcProcessingDirCrossing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.RoughnessProcessingDirection.mcProcessingDirCrossing);

		}
	}


	[NVP_Manifest(
		Id = "C59BBB56-3669-4C88-BBC9-8C0943C1B47B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_RoughnessProcessingDirection.enum_mcProcessingDirRadial", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_RoughnessProcessingDirection", 
		NodeName = "enum_mcProcessingDirRadial", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcProcessingDirRadial : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.RoughnessProcessingDirection.mcProcessingDirRadial);

		}
	}


	[NVP_Manifest(
		Id = "2B2513FD-FB3B-46E2-8C53-5C64A163BEF2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_RoughnessProcessingDirection.enum_mcProcessingDirCircular", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_RoughnessProcessingDirection", 
		NodeName = "enum_mcProcessingDirCircular", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcProcessingDirCircular : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.RoughnessProcessingDirection.mcProcessingDirCircular);

		}
	}


	[NVP_Manifest(
		Id = "9F643C71-D689-437B-8A05-9B8523ED27BD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_RoughnessProcessingDirection.enum_mcProcessingDirFree", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_RoughnessProcessingDirection", 
		NodeName = "enum_mcProcessingDirFree", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcProcessingDirFree : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.RoughnessProcessingDirection.mcProcessingDirFree);

		}
	}


	[NVP_Manifest(
		Id = "6C569132-2094-4846-8AB1-E15DA50F3E05", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_RoughnessProcessingDirection.enum_mcProcessingDirPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_RoughnessProcessingDirection", 
		NodeName = "enum_mcProcessingDirPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcProcessingDirPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.RoughnessProcessingDirection.mcProcessingDirPoint);

		}
	}
}
