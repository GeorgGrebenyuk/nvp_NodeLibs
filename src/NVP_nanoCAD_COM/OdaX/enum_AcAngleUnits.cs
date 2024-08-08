using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcAngleUnits 
{


	[NVP_Manifest(
		Id = "418044F9-F838-4CA8-A72E-3BBBF91F23C6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcAngleUnits.enum_acDegrees", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcAngleUnits", 
		NodeName = "enum_acDegrees", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDegrees : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcAngleUnits.acDegrees);

		}
	}


	[NVP_Manifest(
		Id = "AB676EBF-E75F-40F0-BC63-692F24B584AE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcAngleUnits.enum_acDegreeMinuteSeconds", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcAngleUnits", 
		NodeName = "enum_acDegreeMinuteSeconds", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDegreeMinuteSeconds : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcAngleUnits.acDegreeMinuteSeconds);

		}
	}


	[NVP_Manifest(
		Id = "F17F75B7-1772-41DC-BEC5-31E7333E2090", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcAngleUnits.enum_acGrads", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcAngleUnits", 
		NodeName = "enum_acGrads", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acGrads : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcAngleUnits.acGrads);

		}
	}


	[NVP_Manifest(
		Id = "B494A47C-FD36-480D-9430-CAF376929835", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcAngleUnits.enum_acRadians", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcAngleUnits", 
		NodeName = "enum_acRadians", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acRadians : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcAngleUnits.acRadians);

		}
	}


	[NVP_Manifest(
		Id = "C912AAB3-4AD9-45DA-8F22-B3465731C2E6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcAngleUnits.enum_acSurveyors", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcAngleUnits", 
		NodeName = "enum_acSurveyors", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acSurveyors : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcAngleUnits.acSurveyors);

		}
	}
}
