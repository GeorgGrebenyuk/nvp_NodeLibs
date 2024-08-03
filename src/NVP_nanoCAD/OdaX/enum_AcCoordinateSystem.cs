using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcCoordinateSystem 
{


	[NVP_Manifest(
		Id = "884217C7-C3AD-4ED3-8B82-A8E59BCC0A22", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcCoordinateSystem.enum_acWorld", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcCoordinateSystem", 
		NodeName = "enum_acWorld", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acWorld : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcCoordinateSystem.acWorld);

		}
	}


	[NVP_Manifest(
		Id = "105E2A34-C2FA-466B-B3CD-3BAC92049BFD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcCoordinateSystem.enum_acUCS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcCoordinateSystem", 
		NodeName = "enum_acUCS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acUCS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcCoordinateSystem.acUCS);

		}
	}


	[NVP_Manifest(
		Id = "5C62CD0C-3446-450F-92DF-AC6BA98F6134", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcCoordinateSystem.enum_acDisplayDCS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcCoordinateSystem", 
		NodeName = "enum_acDisplayDCS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDisplayDCS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcCoordinateSystem.acDisplayDCS);

		}
	}


	[NVP_Manifest(
		Id = "14E573BE-6715-4DFA-92F2-4879EA0CB9E4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcCoordinateSystem.enum_acPaperSpaceDCS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcCoordinateSystem", 
		NodeName = "enum_acPaperSpaceDCS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acPaperSpaceDCS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcCoordinateSystem.acPaperSpaceDCS);

		}
	}


	[NVP_Manifest(
		Id = "BB73532A-114F-4E28-A90D-22B3E9230BCF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcCoordinateSystem.enum_acOCS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcCoordinateSystem", 
		NodeName = "enum_acOCS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acOCS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcCoordinateSystem.acOCS);

		}
	}
}
