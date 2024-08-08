using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcPolylineType 
{


	[NVP_Manifest(
		Id = "AE81491B-9DB9-4346-BEBC-3B949D06902B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcPolylineType.enum_acSimplePoly", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcPolylineType", 
		NodeName = "enum_acSimplePoly", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acSimplePoly : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcPolylineType.acSimplePoly);

		}
	}


	[NVP_Manifest(
		Id = "D12A2C41-AAD5-4E26-ACD1-E79368ADFF28", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcPolylineType.enum_acFitCurvePoly", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcPolylineType", 
		NodeName = "enum_acFitCurvePoly", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acFitCurvePoly : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcPolylineType.acFitCurvePoly);

		}
	}


	[NVP_Manifest(
		Id = "B7365113-F9B6-4DAD-961F-5319EFB15DD9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcPolylineType.enum_acQuadSplinePoly", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcPolylineType", 
		NodeName = "enum_acQuadSplinePoly", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acQuadSplinePoly : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcPolylineType.acQuadSplinePoly);

		}
	}


	[NVP_Manifest(
		Id = "3750E959-8257-4B09-BA94-65C94224DCD2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcPolylineType.enum_acCubicSplinePoly", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcPolylineType", 
		NodeName = "enum_acCubicSplinePoly", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acCubicSplinePoly : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcPolylineType.acCubicSplinePoly);

		}
	}
}
