using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcDimUnits 
{


	[NVP_Manifest(
		Id = "BDAC77D4-4E59-4024-8AEB-8A6C185A8CF0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimUnits.enum_acDimScientific", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimUnits", 
		NodeName = "enum_acDimScientific", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDimScientific : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimUnits.acDimScientific);

		}
	}


	[NVP_Manifest(
		Id = "D701EBDA-BCD8-4C89-993A-B209B2A6F1DF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimUnits.enum_acDimDecimal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimUnits", 
		NodeName = "enum_acDimDecimal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDimDecimal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimUnits.acDimDecimal);

		}
	}


	[NVP_Manifest(
		Id = "F33A164D-55F6-41F8-AA38-1C8A00CD4CFF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimUnits.enum_acDimEngineering", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimUnits", 
		NodeName = "enum_acDimEngineering", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDimEngineering : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimUnits.acDimEngineering);

		}
	}


	[NVP_Manifest(
		Id = "2C339C2F-115A-4CEE-8BEA-4FC409EE28B7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimUnits.enum_acDimArchitecturalStacked", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimUnits", 
		NodeName = "enum_acDimArchitecturalStacked", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDimArchitecturalStacked : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimUnits.acDimArchitecturalStacked);

		}
	}


	[NVP_Manifest(
		Id = "35A6EFC1-DDF7-4F97-AD6F-FD0138C4D907", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimUnits.enum_acDimFractionalStacked", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimUnits", 
		NodeName = "enum_acDimFractionalStacked", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDimFractionalStacked : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimUnits.acDimFractionalStacked);

		}
	}


	[NVP_Manifest(
		Id = "38D156A5-5943-4E3F-92DA-2B1DDB16BC94", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimUnits.enum_acDimArchitectural", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimUnits", 
		NodeName = "enum_acDimArchitectural", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDimArchitectural : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimUnits.acDimArchitectural);

		}
	}


	[NVP_Manifest(
		Id = "57CE8483-726F-4FF9-81BF-9F50A76D45BF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimUnits.enum_acDimFractional", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimUnits", 
		NodeName = "enum_acDimFractional", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDimFractional : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimUnits.acDimFractional);

		}
	}


	[NVP_Manifest(
		Id = "9BA064ED-58C7-4303-B6B7-37E2B756A477", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimUnits.enum_acDimWindowsDesktop", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimUnits", 
		NodeName = "enum_acDimWindowsDesktop", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDimWindowsDesktop : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimUnits.acDimWindowsDesktop);

		}
	}
}
