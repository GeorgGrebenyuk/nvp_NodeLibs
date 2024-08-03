using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcAttributeMode 
{


	[NVP_Manifest(
		Id = "4F9B42A9-ED1D-43B5-9398-19FF3E89052C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcAttributeMode.enum_acAttributeModeNormal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcAttributeMode", 
		NodeName = "enum_acAttributeModeNormal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acAttributeModeNormal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcAttributeMode.acAttributeModeNormal);

		}
	}


	[NVP_Manifest(
		Id = "3D13E2EA-4F20-4461-970A-2B6B2A85ED9E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcAttributeMode.enum_acAttributeModeInvisible", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcAttributeMode", 
		NodeName = "enum_acAttributeModeInvisible", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acAttributeModeInvisible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcAttributeMode.acAttributeModeInvisible);

		}
	}


	[NVP_Manifest(
		Id = "522B6CAD-B7C9-4B48-9B77-F2149108FAC3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcAttributeMode.enum_acAttributeModeConstant", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcAttributeMode", 
		NodeName = "enum_acAttributeModeConstant", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acAttributeModeConstant : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcAttributeMode.acAttributeModeConstant);

		}
	}


	[NVP_Manifest(
		Id = "85353773-FCDF-4D5E-B48C-3D9DC41620F5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcAttributeMode.enum_acAttributeModeVerify", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcAttributeMode", 
		NodeName = "enum_acAttributeModeVerify", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acAttributeModeVerify : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcAttributeMode.acAttributeModeVerify);

		}
	}


	[NVP_Manifest(
		Id = "4B17B963-831C-40D2-A156-B4BA1C42C4CF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcAttributeMode.enum_acAttributeModePreset", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcAttributeMode", 
		NodeName = "enum_acAttributeModePreset", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acAttributeModePreset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcAttributeMode.acAttributeModePreset);

		}
	}


	[NVP_Manifest(
		Id = "8EA512E9-1D9F-45D3-A6A5-DF2C9F68CBA6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcAttributeMode.enum_acAttributeModeLockPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcAttributeMode", 
		NodeName = "enum_acAttributeModeLockPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acAttributeModeLockPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcAttributeMode.acAttributeModeLockPosition);

		}
	}


	[NVP_Manifest(
		Id = "21E111C2-9DF5-49D9-BA7B-052BA9EA4839", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcAttributeMode.enum_acAttributeModeMultipleLine", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcAttributeMode", 
		NodeName = "enum_acAttributeModeMultipleLine", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acAttributeModeMultipleLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcAttributeMode.acAttributeModeMultipleLine);

		}
	}
}
