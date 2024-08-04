using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace McCOM2.enum_SymBoundFormType 
{


	[NVP_Manifest(
		Id = "73D2E367-D2E4-438D-8F5C-AB9A9C6A19E8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymBoundFormType.enum_mcBoundLineOnly", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymBoundFormType", 
		NodeName = "enum_mcBoundLineOnly", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcBoundLineOnly : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymBoundFormType.mcBoundLineOnly);

		}
	}


	[NVP_Manifest(
		Id = "969AFA2D-0851-4C32-B35E-4838B216713F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymBoundFormType.enum_mcBoundDashBand", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymBoundFormType", 
		NodeName = "enum_mcBoundDashBand", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcBoundDashBand : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymBoundFormType.mcBoundDashBand);

		}
	}


	[NVP_Manifest(
		Id = "B6C97A3E-351A-4F18-84C9-BD73BA00CAC0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymBoundFormType.enum_mcBoundHeatIsolation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymBoundFormType", 
		NodeName = "enum_mcBoundHeatIsolation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcBoundHeatIsolation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymBoundFormType.mcBoundHeatIsolation);

		}
	}


	[NVP_Manifest(
		Id = "D3D96913-F432-45E1-AB01-62C85A2FD4C5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymBoundFormType.enum_mcBoundWaterIsolation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymBoundFormType", 
		NodeName = "enum_mcBoundWaterIsolation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcBoundWaterIsolation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymBoundFormType.mcBoundWaterIsolation);

		}
	}


	[NVP_Manifest(
		Id = "61C30CBC-77D9-43FC-B193-6415FC428A15", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymBoundFormType.enum_mcBoundBoundHatch", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymBoundFormType", 
		NodeName = "enum_mcBoundBoundHatch", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcBoundBoundHatch : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymBoundFormType.mcBoundBoundHatch);

		}
	}


	[NVP_Manifest(
		Id = "D1B08DCA-4800-43BA-8B24-570AED8BEA68", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymBoundFormType.enum_mcBoundGroundBorder", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymBoundFormType", 
		NodeName = "enum_mcBoundGroundBorder", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcBoundGroundBorder : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymBoundFormType.mcBoundGroundBorder);

		}
	}
}
