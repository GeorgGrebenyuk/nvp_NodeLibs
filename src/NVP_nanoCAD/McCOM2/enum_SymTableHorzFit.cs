using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace McCOM2.enum_SymTableHorzFit 
{


	[NVP_Manifest(
		Id = "5359CA22-A69F-41C4-8E27-1B3490099EBF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymTableHorzFit.enum_mcHorzFitNone", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymTableHorzFit", 
		NodeName = "enum_mcHorzFitNone", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcHorzFitNone : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymTableHorzFit.mcHorzFitNone);

		}
	}


	[NVP_Manifest(
		Id = "F85969E1-4CA3-4F64-AA0E-736537AA76A1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymTableHorzFit.enum_mcHorzFitShrink", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymTableHorzFit", 
		NodeName = "enum_mcHorzFitShrink", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcHorzFitShrink : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymTableHorzFit.mcHorzFitShrink);

		}
	}


	[NVP_Manifest(
		Id = "95797113-30F8-48B2-812A-230A8AB91130", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymTableHorzFit.enum_mcHorzFitWrap", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymTableHorzFit", 
		NodeName = "enum_mcHorzFitWrap", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcHorzFitWrap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymTableHorzFit.mcHorzFitWrap);

		}
	}
}
