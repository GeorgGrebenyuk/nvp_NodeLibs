using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcPredefBlockType 
{


	[NVP_Manifest(
		Id = "E2092324-2133-4EC1-AF9A-FE49A0966763", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcPredefBlockType.enum_acBlockImperial", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcPredefBlockType", 
		NodeName = "enum_acBlockImperial", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acBlockImperial : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcPredefBlockType.acBlockImperial);

		}
	}


	[NVP_Manifest(
		Id = "93D94C41-1922-41BB-A79E-49E84B7FE527", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcPredefBlockType.enum_acBlockSlot", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcPredefBlockType", 
		NodeName = "enum_acBlockSlot", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acBlockSlot : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcPredefBlockType.acBlockSlot);

		}
	}


	[NVP_Manifest(
		Id = "C373277A-F94D-4489-A7FE-C8E548AC956D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcPredefBlockType.enum_acBlockCircle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcPredefBlockType", 
		NodeName = "enum_acBlockCircle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acBlockCircle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcPredefBlockType.acBlockCircle);

		}
	}


	[NVP_Manifest(
		Id = "BB771EC0-1FFC-46A6-B758-A73EFD2B0050", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcPredefBlockType.enum_acBlockBox", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcPredefBlockType", 
		NodeName = "enum_acBlockBox", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acBlockBox : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcPredefBlockType.acBlockBox);

		}
	}


	[NVP_Manifest(
		Id = "5EE33210-DB0F-414F-95DC-9634AB9D3C45", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcPredefBlockType.enum_acBlockHexagon", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcPredefBlockType", 
		NodeName = "enum_acBlockHexagon", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acBlockHexagon : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcPredefBlockType.acBlockHexagon);

		}
	}


	[NVP_Manifest(
		Id = "2D12E316-1157-4B87-A6BE-E02AC4D33476", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcPredefBlockType.enum_acBlockTriangle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcPredefBlockType", 
		NodeName = "enum_acBlockTriangle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acBlockTriangle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcPredefBlockType.acBlockTriangle);

		}
	}


	[NVP_Manifest(
		Id = "C9D70892-9B73-4F54-9C3F-33F9B3B69560", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcPredefBlockType.enum_acBlockUserDefined", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcPredefBlockType", 
		NodeName = "enum_acBlockUserDefined", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acBlockUserDefined : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcPredefBlockType.acBlockUserDefined);

		}
	}
}
