using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcMeshCreaseType 
{


	[NVP_Manifest(
		Id = "981732CC-944B-495B-9BEB-59B33CFD14A9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcMeshCreaseType.enum_acNoneCrease", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcMeshCreaseType", 
		NodeName = "enum_acNoneCrease", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acNoneCrease : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcMeshCreaseType.acNoneCrease);

		}
	}


	[NVP_Manifest(
		Id = "2163C8BD-2217-4C1F-857A-E5AFCBE81E99", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcMeshCreaseType.enum_acAlwaysCrease", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcMeshCreaseType", 
		NodeName = "enum_acAlwaysCrease", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acAlwaysCrease : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcMeshCreaseType.acAlwaysCrease);

		}
	}


	[NVP_Manifest(
		Id = "C4F430E1-5D53-4F35-B4FC-37CF6EBBCE12", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcMeshCreaseType.enum_acCreaseByLevel", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcMeshCreaseType", 
		NodeName = "enum_acCreaseByLevel", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acCreaseByLevel : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcMeshCreaseType.acCreaseByLevel);

		}
	}
}
