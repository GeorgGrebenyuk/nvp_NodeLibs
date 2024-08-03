using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace nanoCAD.enum_AcProxyImage 
{


	[NVP_Manifest(
		Id = "4C24C73A-CA3F-472E-BA30-9473A66216F6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcProxyImage.enum_acProxyNotShow", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcProxyImage", 
		NodeName = "enum_acProxyNotShow", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acProxyNotShow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcProxyImage.acProxyNotShow);

		}
	}


	[NVP_Manifest(
		Id = "48B8BE64-620C-4D4E-937C-859D6A42EF7B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcProxyImage.enum_acProxyShow", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcProxyImage", 
		NodeName = "enum_acProxyShow", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acProxyShow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcProxyImage.acProxyShow);

		}
	}


	[NVP_Manifest(
		Id = "0B877D59-0C04-42EE-B951-D0C13FAB05CB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcProxyImage.enum_acProxyBoundingBox", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcProxyImage", 
		NodeName = "enum_acProxyBoundingBox", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acProxyBoundingBox : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcProxyImage.acProxyBoundingBox);

		}
	}
}
