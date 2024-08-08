using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcPolymeshType 
{


	[NVP_Manifest(
		Id = "C83DF9F9-FFD7-48D2-ACD3-2F04DBE1ACD1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcPolymeshType.enum_acSimpleMesh", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcPolymeshType", 
		NodeName = "enum_acSimpleMesh", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acSimpleMesh : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcPolymeshType.acSimpleMesh);

		}
	}


	[NVP_Manifest(
		Id = "CF5D184B-FBDA-49CD-B25C-C05F758A61F6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcPolymeshType.enum_acQuadSurfaceMesh", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcPolymeshType", 
		NodeName = "enum_acQuadSurfaceMesh", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acQuadSurfaceMesh : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcPolymeshType.acQuadSurfaceMesh);

		}
	}


	[NVP_Manifest(
		Id = "B4D0F0BB-C783-471D-82C1-87DABFE5E318", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcPolymeshType.enum_acCubicSurfaceMesh", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcPolymeshType", 
		NodeName = "enum_acCubicSurfaceMesh", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acCubicSurfaceMesh : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcPolymeshType.acCubicSurfaceMesh);

		}
	}


	[NVP_Manifest(
		Id = "83E030F2-ED00-4A56-B06C-3797252D811D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcPolymeshType.enum_acBezierSurfaceMesh", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcPolymeshType", 
		NodeName = "enum_acBezierSurfaceMesh", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acBezierSurfaceMesh : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcPolymeshType.acBezierSurfaceMesh);

		}
	}
}
