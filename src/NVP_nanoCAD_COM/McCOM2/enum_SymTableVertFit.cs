using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace McCOM2.enum_SymTableVertFit 
{


	[NVP_Manifest(
		Id = "A44E601D-D2AA-4E95-A9FD-6414F364F773", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymTableVertFit.enum_mcVertFitNone", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymTableVertFit", 
		NodeName = "enum_mcVertFitNone", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcVertFitNone : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymTableVertFit.mcVertFitNone);

		}
	}


	[NVP_Manifest(
		Id = "B0029492-3E69-48C1-B430-C8DF0041887F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymTableVertFit.enum_mcVertFitShrink", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymTableVertFit", 
		NodeName = "enum_mcVertFitShrink", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcVertFitShrink : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymTableVertFit.mcVertFitShrink);

		}
	}


	[NVP_Manifest(
		Id = "909DA387-A7E9-46EA-8F66-CD88315C15E6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymTableVertFit.enum_mcVertFitExpandRow", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymTableVertFit", 
		NodeName = "enum_mcVertFitExpandRow", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcVertFitExpandRow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymTableVertFit.mcVertFitExpandRow);

		}
	}


	[NVP_Manifest(
		Id = "6E4F0155-1C03-4F80-A544-7EFB44B7C682", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymTableVertFit.enum_mcVertFitAddRow", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymTableVertFit", 
		NodeName = "enum_mcVertFitAddRow", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcVertFitAddRow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymTableVertFit.mcVertFitAddRow);

		}
	}
}
