using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcLoftedSurfaceNormalType 
{


	[NVP_Manifest(
		Id = "04E68EF1-9104-43C1-8A42-A36CD0A7FC11", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcLoftedSurfaceNormalType.enum_acRuled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcLoftedSurfaceNormalType", 
		NodeName = "enum_acRuled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acRuled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcLoftedSurfaceNormalType.acRuled);

		}
	}


	[NVP_Manifest(
		Id = "830B3D19-B3B9-4766-8893-EB9A4DACDF82", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcLoftedSurfaceNormalType.enum_acSmooth", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcLoftedSurfaceNormalType", 
		NodeName = "enum_acSmooth", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acSmooth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcLoftedSurfaceNormalType.acSmooth);

		}
	}


	[NVP_Manifest(
		Id = "CBBFFDEE-549B-4AEE-B5F4-A06407503969", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcLoftedSurfaceNormalType.enum_acFirstNormal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcLoftedSurfaceNormalType", 
		NodeName = "enum_acFirstNormal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acFirstNormal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcLoftedSurfaceNormalType.acFirstNormal);

		}
	}


	[NVP_Manifest(
		Id = "F8A282F1-A94C-4463-BE23-A2FCBF12EEC7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcLoftedSurfaceNormalType.enum_acLastNormal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcLoftedSurfaceNormalType", 
		NodeName = "enum_acLastNormal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acLastNormal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcLoftedSurfaceNormalType.acLastNormal);

		}
	}


	[NVP_Manifest(
		Id = "2EE7D461-ECE7-4899-B20A-3C96A8C21E43", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcLoftedSurfaceNormalType.enum_acEndsNormal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcLoftedSurfaceNormalType", 
		NodeName = "enum_acEndsNormal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acEndsNormal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcLoftedSurfaceNormalType.acEndsNormal);

		}
	}


	[NVP_Manifest(
		Id = "B2B23B13-649A-4681-8A18-F97775A1209A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcLoftedSurfaceNormalType.enum_acAllNormal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcLoftedSurfaceNormalType", 
		NodeName = "enum_acAllNormal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acAllNormal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcLoftedSurfaceNormalType.acAllNormal);

		}
	}


	[NVP_Manifest(
		Id = "CCBE9C5E-9CAE-4DED-B4ED-1E39B60F7BA6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcLoftedSurfaceNormalType.enum_acUseDraftAngles", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcLoftedSurfaceNormalType", 
		NodeName = "enum_acUseDraftAngles", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acUseDraftAngles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcLoftedSurfaceNormalType.acUseDraftAngles);

		}
	}
}
