using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcProxyImage 
{


	[NVP_Manifest(
		Id = "3BFA1EFA-C139-4F91-8184-EC8BB06BBB09", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcProxyImage.enum_acProxyNotShow", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcProxyImage", 
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
			return new NodeResult(OdaX.AcProxyImage.acProxyNotShow);

		}
	}


	[NVP_Manifest(
		Id = "B60E59DF-AD3F-4F86-B2B5-617D08DCA1E2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcProxyImage.enum_acProxyShow", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcProxyImage", 
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
			return new NodeResult(OdaX.AcProxyImage.acProxyShow);

		}
	}


	[NVP_Manifest(
		Id = "21878AB6-4F55-418E-9F3B-90BDA8742FB2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcProxyImage.enum_acProxyBoundingBox", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcProxyImage", 
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
			return new NodeResult(OdaX.AcProxyImage.acProxyBoundingBox);

		}
	}
}
