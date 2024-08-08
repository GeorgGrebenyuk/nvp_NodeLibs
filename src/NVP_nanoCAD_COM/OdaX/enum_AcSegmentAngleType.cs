using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcSegmentAngleType 
{


	[NVP_Manifest(
		Id = "8696880E-5F9C-4E38-BE3C-29AD2DDABA10", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcSegmentAngleType.enum_acDegreesAny", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcSegmentAngleType", 
		NodeName = "enum_acDegreesAny", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDegreesAny : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcSegmentAngleType.acDegreesAny);

		}
	}


	[NVP_Manifest(
		Id = "79570563-69CB-4BDF-8441-A4CD2644FF5E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcSegmentAngleType.enum_acDegrees15", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcSegmentAngleType", 
		NodeName = "enum_acDegrees15", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDegrees15 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcSegmentAngleType.acDegrees15);

		}
	}


	[NVP_Manifest(
		Id = "367999DF-541B-4531-BB46-0A56D32C8644", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcSegmentAngleType.enum_acDegrees30", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcSegmentAngleType", 
		NodeName = "enum_acDegrees30", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDegrees30 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcSegmentAngleType.acDegrees30);

		}
	}


	[NVP_Manifest(
		Id = "5E0BF914-9AB2-4527-B6F6-0E186C4FFB09", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcSegmentAngleType.enum_acDegrees45", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcSegmentAngleType", 
		NodeName = "enum_acDegrees45", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDegrees45 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcSegmentAngleType.acDegrees45);

		}
	}


	[NVP_Manifest(
		Id = "698CD9B5-B667-420B-A178-B72FF8A7ECCB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcSegmentAngleType.enum_acDegrees60", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcSegmentAngleType", 
		NodeName = "enum_acDegrees60", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDegrees60 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcSegmentAngleType.acDegrees60);

		}
	}


	[NVP_Manifest(
		Id = "60466408-7ED3-4654-BD65-84AF590CFB8B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcSegmentAngleType.enum_acDegrees90", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcSegmentAngleType", 
		NodeName = "enum_acDegrees90", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDegrees90 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcSegmentAngleType.acDegrees90);

		}
	}


	[NVP_Manifest(
		Id = "6C3014F1-38AF-4ED7-8F98-CD19B038AF9A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcSegmentAngleType.enum_acDegreesHorz", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcSegmentAngleType", 
		NodeName = "enum_acDegreesHorz", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDegreesHorz : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcSegmentAngleType.acDegreesHorz);

		}
	}
}
