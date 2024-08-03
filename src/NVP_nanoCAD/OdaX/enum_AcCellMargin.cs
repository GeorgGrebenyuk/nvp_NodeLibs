using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcCellMargin 
{


	[NVP_Manifest(
		Id = "5C0FCAFA-66E4-4BCB-955F-8BB15E2F923D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcCellMargin.enum_acCellMarginTop", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcCellMargin", 
		NodeName = "enum_acCellMarginTop", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acCellMarginTop : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcCellMargin.acCellMarginTop);

		}
	}


	[NVP_Manifest(
		Id = "825A1CC3-FA30-4084-BC76-D500A446B4AC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcCellMargin.enum_acCellMarginLeft", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcCellMargin", 
		NodeName = "enum_acCellMarginLeft", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acCellMarginLeft : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcCellMargin.acCellMarginLeft);

		}
	}


	[NVP_Manifest(
		Id = "B2103CDC-5F93-42E1-BF7A-32A467691215", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcCellMargin.enum_acCellMarginBottom", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcCellMargin", 
		NodeName = "enum_acCellMarginBottom", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acCellMarginBottom : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcCellMargin.acCellMarginBottom);

		}
	}


	[NVP_Manifest(
		Id = "5AA785FA-EBE9-4862-B6F9-EB46376EB285", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcCellMargin.enum_acCellMarginRight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcCellMargin", 
		NodeName = "enum_acCellMarginRight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acCellMarginRight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcCellMargin.acCellMarginRight);

		}
	}


	[NVP_Manifest(
		Id = "DB3AF7B0-7B60-4611-A381-211F8CC12B09", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcCellMargin.enum_acCellMarginHorzSpacing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcCellMargin", 
		NodeName = "enum_acCellMarginHorzSpacing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acCellMarginHorzSpacing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcCellMargin.acCellMarginHorzSpacing);

		}
	}


	[NVP_Manifest(
		Id = "F2022D5A-EBBB-4A34-AB61-3659A09B4ECC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcCellMargin.enum_acCellMarginVertSpacing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcCellMargin", 
		NodeName = "enum_acCellMarginVertSpacing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acCellMarginVertSpacing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcCellMargin.acCellMarginVertSpacing);

		}
	}
}
