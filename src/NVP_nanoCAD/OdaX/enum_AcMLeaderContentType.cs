using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcMLeaderContentType 
{


	[NVP_Manifest(
		Id = "F3552D03-595F-41EA-952D-B9F67F94B311", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcMLeaderContentType.enum_acNoneContent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcMLeaderContentType", 
		NodeName = "enum_acNoneContent", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acNoneContent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcMLeaderContentType.acNoneContent);

		}
	}


	[NVP_Manifest(
		Id = "AB2BDB6E-DDB7-4AC1-A788-33A882E48F16", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcMLeaderContentType.enum_acBlockContent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcMLeaderContentType", 
		NodeName = "enum_acBlockContent", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acBlockContent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcMLeaderContentType.acBlockContent);

		}
	}


	[NVP_Manifest(
		Id = "71F3FB59-CE1A-4916-A586-26DF2D5524A4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcMLeaderContentType.enum_acMTextContent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcMLeaderContentType", 
		NodeName = "enum_acMTextContent", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acMTextContent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcMLeaderContentType.acMTextContent);

		}
	}
}
