using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcRotationAngle 
{


	[NVP_Manifest(
		Id = "6F8824E1-488C-4279-9341-D7EA5AED4389", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcRotationAngle.enum_acDegreesUnknown", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcRotationAngle", 
		NodeName = "enum_acDegreesUnknown", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDegreesUnknown : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcRotationAngle.acDegreesUnknown);

		}
	}


	[NVP_Manifest(
		Id = "7BE61A9D-645D-43D7-901D-0BB85106190A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcRotationAngle.enum_acDegrees000", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcRotationAngle", 
		NodeName = "enum_acDegrees000", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDegrees000 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcRotationAngle.acDegrees000);

		}
	}


	[NVP_Manifest(
		Id = "FA43F543-EA1F-455E-BF41-FC0BD4681D3A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcRotationAngle.enum_acDegrees090", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcRotationAngle", 
		NodeName = "enum_acDegrees090", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDegrees090 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcRotationAngle.acDegrees090);

		}
	}


	[NVP_Manifest(
		Id = "567DE473-9D44-4D34-BC56-22F715B3F4A9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcRotationAngle.enum_acDegrees180", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcRotationAngle", 
		NodeName = "enum_acDegrees180", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDegrees180 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcRotationAngle.acDegrees180);

		}
	}


	[NVP_Manifest(
		Id = "57B13B03-0688-4FC9-B6AE-D17E8836C48E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcRotationAngle.enum_acDegrees270", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcRotationAngle", 
		NodeName = "enum_acDegrees270", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDegrees270 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcRotationAngle.acDegrees270);

		}
	}
}
