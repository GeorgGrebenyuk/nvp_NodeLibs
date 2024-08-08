using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace McCOM2.enum_SymFixType 
{


	[NVP_Manifest(
		Id = "14D443C1-BEF2-43E6-9FDF-BFBDA623A943", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymFixType.enum_mcFixTypeWeldLeg", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymFixType", 
		NodeName = "enum_mcFixTypeWeldLeg", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcFixTypeWeldLeg : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymFixType.mcFixTypeWeldLeg);

		}
	}


	[NVP_Manifest(
		Id = "B051F4FE-CCF0-4DAA-9172-7A026EA0A7A8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymFixType.enum_mcFixTypeWeldPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymFixType", 
		NodeName = "enum_mcFixTypeWeldPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcFixTypeWeldPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymFixType.mcFixTypeWeldPoint);

		}
	}


	[NVP_Manifest(
		Id = "CFCB7305-7254-4B35-B188-349435C54FB2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymFixType.enum_mcFixTypeMark", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymFixType", 
		NodeName = "enum_mcFixTypeMark", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcFixTypeMark : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymFixType.mcFixTypeMark);

		}
	}
}
