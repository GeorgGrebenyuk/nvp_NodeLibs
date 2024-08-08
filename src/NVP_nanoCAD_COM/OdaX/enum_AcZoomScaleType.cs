using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcZoomScaleType 
{


	[NVP_Manifest(
		Id = "839D6982-0D18-4F6F-8893-016B81B26E92", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcZoomScaleType.enum_acZoomScaledAbsolute", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcZoomScaleType", 
		NodeName = "enum_acZoomScaledAbsolute", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acZoomScaledAbsolute : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcZoomScaleType.acZoomScaledAbsolute);

		}
	}


	[NVP_Manifest(
		Id = "36980E1C-E9A7-4BF1-AB1F-9828331979BB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcZoomScaleType.enum_acZoomScaledRelative", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcZoomScaleType", 
		NodeName = "enum_acZoomScaledRelative", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acZoomScaledRelative : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcZoomScaleType.acZoomScaledRelative);

		}
	}


	[NVP_Manifest(
		Id = "439839B8-138D-49CF-A587-9226ABE00205", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcZoomScaleType.enum_acZoomScaledRelativePSpace", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcZoomScaleType", 
		NodeName = "enum_acZoomScaledRelativePSpace", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acZoomScaledRelativePSpace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcZoomScaleType.acZoomScaledRelativePSpace);

		}
	}
}
