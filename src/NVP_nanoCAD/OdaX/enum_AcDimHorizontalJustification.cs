using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcDimHorizontalJustification 
{


	[NVP_Manifest(
		Id = "9D839777-5065-4A55-A789-F9A80E350EA6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimHorizontalJustification.enum_acHorzCentered", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimHorizontalJustification", 
		NodeName = "enum_acHorzCentered", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHorzCentered : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimHorizontalJustification.acHorzCentered);

		}
	}


	[NVP_Manifest(
		Id = "9CC29F92-DE08-443E-9128-FC9FF2D37D33", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimHorizontalJustification.enum_acFirstExtensionLine", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimHorizontalJustification", 
		NodeName = "enum_acFirstExtensionLine", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acFirstExtensionLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimHorizontalJustification.acFirstExtensionLine);

		}
	}


	[NVP_Manifest(
		Id = "82AA3F6F-97B7-4158-AE57-28E682EA62DA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimHorizontalJustification.enum_acSecondExtensionLine", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimHorizontalJustification", 
		NodeName = "enum_acSecondExtensionLine", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acSecondExtensionLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimHorizontalJustification.acSecondExtensionLine);

		}
	}


	[NVP_Manifest(
		Id = "09BAAF96-0D1F-4E7D-94C3-606C51CCCB43", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimHorizontalJustification.enum_acOverFirstExtension", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimHorizontalJustification", 
		NodeName = "enum_acOverFirstExtension", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acOverFirstExtension : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimHorizontalJustification.acOverFirstExtension);

		}
	}


	[NVP_Manifest(
		Id = "2CD693B0-3A60-422D-A11B-D96EF98CC6BB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimHorizontalJustification.enum_acOverSecondExtension", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimHorizontalJustification", 
		NodeName = "enum_acOverSecondExtension", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acOverSecondExtension : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimHorizontalJustification.acOverSecondExtension);

		}
	}
}
