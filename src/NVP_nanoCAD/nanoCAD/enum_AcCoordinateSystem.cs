using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace nanoCAD.enum_AcCoordinateSystem 
{


	[NVP_Manifest(
		Id = "9A988A62-23E1-4776-9426-01334A574348", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcCoordinateSystem.enum_acWorld", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcCoordinateSystem", 
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
			return new NodeResult(nanoCAD.AcCoordinateSystem.acWorld);

		}
	}


	[NVP_Manifest(
		Id = "4F08C048-F106-4BAF-A34F-5B560E6EC609", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcCoordinateSystem.enum_acUCS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcCoordinateSystem", 
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
			return new NodeResult(nanoCAD.AcCoordinateSystem.acUCS);

		}
	}


	[NVP_Manifest(
		Id = "40AB76CD-BD41-4D89-8391-6ADC760B2B1C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcCoordinateSystem.enum_acDisplayDCS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcCoordinateSystem", 
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
			return new NodeResult(nanoCAD.AcCoordinateSystem.acDisplayDCS);

		}
	}


	[NVP_Manifest(
		Id = "D073BF27-255F-4A7E-94E4-853CD65DF222", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcCoordinateSystem.enum_acPaperSpaceDCS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcCoordinateSystem", 
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
			return new NodeResult(nanoCAD.AcCoordinateSystem.acPaperSpaceDCS);

		}
	}


	[NVP_Manifest(
		Id = "AA4B1174-5D69-421B-B48E-2B1D5D521A6B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcCoordinateSystem.enum_acOCS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcCoordinateSystem", 
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
			return new NodeResult(nanoCAD.AcCoordinateSystem.acOCS);

		}
	}
}
