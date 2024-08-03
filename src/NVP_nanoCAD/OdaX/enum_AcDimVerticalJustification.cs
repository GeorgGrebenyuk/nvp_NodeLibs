using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcDimVerticalJustification 
{


	[NVP_Manifest(
		Id = "788F2F06-74DA-49EF-ADC1-36A7D448B047", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimVerticalJustification.enum_acVertCentered", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimVerticalJustification", 
		NodeName = "enum_acVertCentered", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acVertCentered : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimVerticalJustification.acVertCentered);

		}
	}


	[NVP_Manifest(
		Id = "311E304E-2FBA-4635-A8D3-759798D09467", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimVerticalJustification.enum_acAbove", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimVerticalJustification", 
		NodeName = "enum_acAbove", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acAbove : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimVerticalJustification.acAbove);

		}
	}


	[NVP_Manifest(
		Id = "9DF940E5-14CC-442D-AA95-4D6EF274CAC0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimVerticalJustification.enum_acOutside", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimVerticalJustification", 
		NodeName = "enum_acOutside", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acOutside : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimVerticalJustification.acOutside);

		}
	}


	[NVP_Manifest(
		Id = "23A880DC-E3D3-47F8-9974-5D4E8C999210", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimVerticalJustification.enum_acJIS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimVerticalJustification", 
		NodeName = "enum_acJIS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acJIS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimVerticalJustification.acJIS);

		}
	}


	[NVP_Manifest(
		Id = "A7D95A10-F6E9-4987-9271-6DA6501F282B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimVerticalJustification.enum_acUnder", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimVerticalJustification", 
		NodeName = "enum_acUnder", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acUnder : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimVerticalJustification.acUnder);

		}
	}
}
