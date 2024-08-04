using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace McCOM2.enum_SymBreakType 
{


	[NVP_Manifest(
		Id = "694DAB31-C9BA-47DB-B339-F5A12100C2DA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymBreakType.enum_mcBreakSingleLine", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymBreakType", 
		NodeName = "enum_mcBreakSingleLine", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcBreakSingleLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymBreakType.mcBreakSingleLine);

		}
	}


	[NVP_Manifest(
		Id = "CF84A45A-4435-48BF-8083-DA55F4EED2BD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymBreakType.enum_mcBreakDoubleLine", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymBreakType", 
		NodeName = "enum_mcBreakDoubleLine", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcBreakDoubleLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymBreakType.mcBreakDoubleLine);

		}
	}


	[NVP_Manifest(
		Id = "F2DA5C14-1EEA-465B-9092-72A1AD46E67B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymBreakType.enum_mcBreakSingleCurve", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymBreakType", 
		NodeName = "enum_mcBreakSingleCurve", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcBreakSingleCurve : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymBreakType.mcBreakSingleCurve);

		}
	}


	[NVP_Manifest(
		Id = "0163A547-AC46-401D-93CA-73C672076F3F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymBreakType.enum_mcBreakDoubleCurve", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymBreakType", 
		NodeName = "enum_mcBreakDoubleCurve", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcBreakDoubleCurve : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymBreakType.mcBreakDoubleCurve);

		}
	}


	[NVP_Manifest(
		Id = "04208E54-6D97-4DA2-B4EB-F320D615811D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymBreakType.enum_mcBreakTubular", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymBreakType", 
		NodeName = "enum_mcBreakTubular", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcBreakTubular : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymBreakType.mcBreakTubular);

		}
	}
}
