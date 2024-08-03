using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcTextAngleType 
{


	[NVP_Manifest(
		Id = "0DDC88E3-AA6A-4FD1-B620-F0ED31A3581F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTextAngleType.enum_acInsertAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTextAngleType", 
		NodeName = "enum_acInsertAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acInsertAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTextAngleType.acInsertAngle);

		}
	}


	[NVP_Manifest(
		Id = "F79AC66F-29F5-4CBE-B2A4-E27B90878CC9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTextAngleType.enum_acHorizontalAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTextAngleType", 
		NodeName = "enum_acHorizontalAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHorizontalAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTextAngleType.acHorizontalAngle);

		}
	}


	[NVP_Manifest(
		Id = "B04E6768-625E-46C3-821E-F167773C307C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTextAngleType.enum_acAlwaysRightReadingAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTextAngleType", 
		NodeName = "enum_acAlwaysRightReadingAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acAlwaysRightReadingAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTextAngleType.acAlwaysRightReadingAngle);

		}
	}
}
