using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_Ac3DPolylineType 
{


	[NVP_Manifest(
		Id = "1B87501C-A02D-4586-A60E-6BE074C8B260", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_Ac3DPolylineType.enum_acSimple3DPoly", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_Ac3DPolylineType", 
		NodeName = "enum_acSimple3DPoly", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acSimple3DPoly : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.Ac3DPolylineType.acSimple3DPoly);

		}
	}


	[NVP_Manifest(
		Id = "3A79D077-BB42-4B8A-90D1-B906C6D4FFF0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_Ac3DPolylineType.enum_acQuadSpline3DPoly", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_Ac3DPolylineType", 
		NodeName = "enum_acQuadSpline3DPoly", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acQuadSpline3DPoly : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.Ac3DPolylineType.acQuadSpline3DPoly);

		}
	}


	[NVP_Manifest(
		Id = "F2CA382E-C08E-45C4-A4A1-EA243F07E3B3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_Ac3DPolylineType.enum_acCubicSpline3DPoly", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_Ac3DPolylineType", 
		NodeName = "enum_acCubicSpline3DPoly", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acCubicSpline3DPoly : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.Ac3DPolylineType.acCubicSpline3DPoly);

		}
	}
}
