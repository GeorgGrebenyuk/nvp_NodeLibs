using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcSectionType 
{


	[NVP_Manifest(
		Id = "DB782DD6-0EFA-4A92-BCA0-4B295C0FF6B6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcSectionType.enum_acSectionTypeLiveSection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcSectionType", 
		NodeName = "enum_acSectionTypeLiveSection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acSectionTypeLiveSection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcSectionType.acSectionTypeLiveSection);

		}
	}


	[NVP_Manifest(
		Id = "CB11692A-A5FA-4438-8C9E-45B54789D7A3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcSectionType.enum_acSectionType2dSection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcSectionType", 
		NodeName = "enum_acSectionType2dSection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acSectionType2dSection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcSectionType.acSectionType2dSection);

		}
	}


	[NVP_Manifest(
		Id = "D325D0AE-9A98-482C-BC5A-5E3280DACB20", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcSectionType.enum_acSectionType3dSection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcSectionType", 
		NodeName = "enum_acSectionType3dSection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acSectionType3dSection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcSectionType.acSectionType3dSection);

		}
	}
}
