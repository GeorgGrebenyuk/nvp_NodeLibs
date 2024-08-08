using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcHorizontalAlignment 
{


	[NVP_Manifest(
		Id = "13D100EA-BFB5-446A-96A2-13054030A00D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcHorizontalAlignment.enum_acHorizontalAlignmentLeft", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcHorizontalAlignment", 
		NodeName = "enum_acHorizontalAlignmentLeft", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHorizontalAlignmentLeft : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcHorizontalAlignment.acHorizontalAlignmentLeft);

		}
	}


	[NVP_Manifest(
		Id = "99C92F15-3464-4E6E-8A4F-AB0EDC2AF1F6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcHorizontalAlignment.enum_acHorizontalAlignmentCenter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcHorizontalAlignment", 
		NodeName = "enum_acHorizontalAlignmentCenter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHorizontalAlignmentCenter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcHorizontalAlignment.acHorizontalAlignmentCenter);

		}
	}


	[NVP_Manifest(
		Id = "171D8A6F-0609-4DFF-8932-C0DD0D2ECC26", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcHorizontalAlignment.enum_acHorizontalAlignmentRight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcHorizontalAlignment", 
		NodeName = "enum_acHorizontalAlignmentRight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHorizontalAlignmentRight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcHorizontalAlignment.acHorizontalAlignmentRight);

		}
	}


	[NVP_Manifest(
		Id = "D2F471C7-29D2-4D73-BBA9-9C854BAD65B1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcHorizontalAlignment.enum_acHorizontalAlignmentAligned", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcHorizontalAlignment", 
		NodeName = "enum_acHorizontalAlignmentAligned", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHorizontalAlignmentAligned : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcHorizontalAlignment.acHorizontalAlignmentAligned);

		}
	}


	[NVP_Manifest(
		Id = "B96128E4-03EF-47CD-8000-036D71E02DC5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcHorizontalAlignment.enum_acHorizontalAlignmentMiddle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcHorizontalAlignment", 
		NodeName = "enum_acHorizontalAlignmentMiddle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHorizontalAlignmentMiddle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcHorizontalAlignment.acHorizontalAlignmentMiddle);

		}
	}


	[NVP_Manifest(
		Id = "5B46A28A-2891-47CA-A7EA-2932CA1A745F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcHorizontalAlignment.enum_acHorizontalAlignmentFit", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcHorizontalAlignment", 
		NodeName = "enum_acHorizontalAlignmentFit", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHorizontalAlignmentFit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcHorizontalAlignment.acHorizontalAlignmentFit);

		}
	}
}
