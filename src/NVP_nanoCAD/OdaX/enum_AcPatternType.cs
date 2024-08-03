using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcPatternType 
{


	[NVP_Manifest(
		Id = "56762DF0-65E6-4043-B74A-325F1A37F400", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcPatternType.enum_acHatchPatternTypeUserDefined", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcPatternType", 
		NodeName = "enum_acHatchPatternTypeUserDefined", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHatchPatternTypeUserDefined : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcPatternType.acHatchPatternTypeUserDefined);

		}
	}


	[NVP_Manifest(
		Id = "BF6E0698-AF34-4CF0-8CAC-4A86A3D04D6F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcPatternType.enum_acHatchPatternTypePreDefined", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcPatternType", 
		NodeName = "enum_acHatchPatternTypePreDefined", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHatchPatternTypePreDefined : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcPatternType.acHatchPatternTypePreDefined);

		}
	}


	[NVP_Manifest(
		Id = "AF48EEEB-E7A3-43A8-8EEC-7AD1FA90DBCF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcPatternType.enum_acHatchPatternTypeCustomDefined", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcPatternType", 
		NodeName = "enum_acHatchPatternTypeCustomDefined", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHatchPatternTypeCustomDefined : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcPatternType.acHatchPatternTypeCustomDefined);

		}
	}
}
