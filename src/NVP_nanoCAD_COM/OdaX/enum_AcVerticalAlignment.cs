using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcVerticalAlignment 
{


	[NVP_Manifest(
		Id = "1D23A22D-DF25-4554-BCAA-43C3128EEB5B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcVerticalAlignment.enum_acVerticalAlignmentBaseline", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcVerticalAlignment", 
		NodeName = "enum_acVerticalAlignmentBaseline", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acVerticalAlignmentBaseline : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcVerticalAlignment.acVerticalAlignmentBaseline);

		}
	}


	[NVP_Manifest(
		Id = "ED92D7D5-5804-4D6E-9E3D-8EF6C2B7FFAB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcVerticalAlignment.enum_acVerticalAlignmentBottom", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcVerticalAlignment", 
		NodeName = "enum_acVerticalAlignmentBottom", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acVerticalAlignmentBottom : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcVerticalAlignment.acVerticalAlignmentBottom);

		}
	}


	[NVP_Manifest(
		Id = "D984A9BA-1142-4652-B46B-D0A4D9EC23D4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcVerticalAlignment.enum_acVerticalAlignmentMiddle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcVerticalAlignment", 
		NodeName = "enum_acVerticalAlignmentMiddle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acVerticalAlignmentMiddle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcVerticalAlignment.acVerticalAlignmentMiddle);

		}
	}


	[NVP_Manifest(
		Id = "E3C8970D-53B8-48C2-8933-915BE2D06704", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcVerticalAlignment.enum_acVerticalAlignmentTop", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcVerticalAlignment", 
		NodeName = "enum_acVerticalAlignmentTop", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acVerticalAlignmentTop : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcVerticalAlignment.acVerticalAlignmentTop);

		}
	}
}
