using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace nanoCAD.enum_AcSelect 
{


	[NVP_Manifest(
		Id = "7B061CCB-4587-43ED-9115-3A5384130FB6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcSelect.enum_acSelectionSetWindow", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcSelect", 
		NodeName = "enum_acSelectionSetWindow", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acSelectionSetWindow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcSelect.acSelectionSetWindow);

		}
	}


	[NVP_Manifest(
		Id = "2C27EF62-382F-4542-922F-A46CCE8236A0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcSelect.enum_acSelectionSetCrossing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcSelect", 
		NodeName = "enum_acSelectionSetCrossing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acSelectionSetCrossing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcSelect.acSelectionSetCrossing);

		}
	}


	[NVP_Manifest(
		Id = "FEB77A06-BF2A-4766-88C3-021F80344685", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcSelect.enum_acSelectionSetFence", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcSelect", 
		NodeName = "enum_acSelectionSetFence", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acSelectionSetFence : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcSelect.acSelectionSetFence);

		}
	}


	[NVP_Manifest(
		Id = "E1783CB0-C045-4858-A202-E3E6225DE5D9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcSelect.enum_acSelectionSetPrevious", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcSelect", 
		NodeName = "enum_acSelectionSetPrevious", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acSelectionSetPrevious : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcSelect.acSelectionSetPrevious);

		}
	}


	[NVP_Manifest(
		Id = "CF75BDEA-E19A-4A3E-9513-7FD7BAA7833E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcSelect.enum_acSelectionSetLast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcSelect", 
		NodeName = "enum_acSelectionSetLast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acSelectionSetLast : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcSelect.acSelectionSetLast);

		}
	}


	[NVP_Manifest(
		Id = "27C05FDD-CE19-4216-B2E2-A66F0130027C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcSelect.enum_acSelectionSetAll", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcSelect", 
		NodeName = "enum_acSelectionSetAll", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acSelectionSetAll : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcSelect.acSelectionSetAll);

		}
	}


	[NVP_Manifest(
		Id = "D9C1F9EC-216B-47E9-B4D9-FA91A41DE5F3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcSelect.enum_acSelectionSetWindowPolygon", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcSelect", 
		NodeName = "enum_acSelectionSetWindowPolygon", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acSelectionSetWindowPolygon : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcSelect.acSelectionSetWindowPolygon);

		}
	}


	[NVP_Manifest(
		Id = "E5914115-0B43-4959-B4F6-DB4848649043", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcSelect.enum_acSelectionSetCrossingPolygon", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcSelect", 
		NodeName = "enum_acSelectionSetCrossingPolygon", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acSelectionSetCrossingPolygon : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcSelect.acSelectionSetCrossingPolygon);

		}
	}
}
