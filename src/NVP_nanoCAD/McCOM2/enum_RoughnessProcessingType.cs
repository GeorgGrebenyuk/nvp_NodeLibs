using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace McCOM2.enum_RoughnessProcessingType 
{


	[NVP_Manifest(
		Id = "C0BBF5C6-41AE-451B-9BEF-F4C690932EF2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_RoughnessProcessingType.enum_mcProcessingTypeDefault", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_RoughnessProcessingType", 
		NodeName = "enum_mcProcessingTypeDefault", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcProcessingTypeDefault : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.RoughnessProcessingType.mcProcessingTypeDefault);

		}
	}


	[NVP_Manifest(
		Id = "47AC1180-453B-46B6-989B-C018EA5790FF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_RoughnessProcessingType.enum_mcProcessingTypeCut", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_RoughnessProcessingType", 
		NodeName = "enum_mcProcessingTypeCut", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcProcessingTypeCut : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.RoughnessProcessingType.mcProcessingTypeCut);

		}
	}


	[NVP_Manifest(
		Id = "891ED0AC-612F-46A0-9BE1-C3C092C6D1FF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_RoughnessProcessingType.enum_mcProcessingTypeNoCut", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_RoughnessProcessingType", 
		NodeName = "enum_mcProcessingTypeNoCut", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcProcessingTypeNoCut : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.RoughnessProcessingType.mcProcessingTypeNoCut);

		}
	}
}
