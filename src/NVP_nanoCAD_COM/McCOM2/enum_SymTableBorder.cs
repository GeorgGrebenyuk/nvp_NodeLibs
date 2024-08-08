using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace McCOM2.enum_SymTableBorder 
{


	[NVP_Manifest(
		Id = "ACF77FD2-1587-48E3-9DEB-566E536B2CBF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymTableBorder.enum_mcBorderLeft", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymTableBorder", 
		NodeName = "enum_mcBorderLeft", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcBorderLeft : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymTableBorder.mcBorderLeft);

		}
	}


	[NVP_Manifest(
		Id = "3B674F82-BB37-4F94-B7B2-60B296265532", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymTableBorder.enum_mcBorderTop", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymTableBorder", 
		NodeName = "enum_mcBorderTop", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcBorderTop : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymTableBorder.mcBorderTop);

		}
	}


	[NVP_Manifest(
		Id = "6ECC02E4-E7A9-47D6-A7E4-FD20F8ED01FC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymTableBorder.enum_mcBorderRight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymTableBorder", 
		NodeName = "enum_mcBorderRight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcBorderRight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymTableBorder.mcBorderRight);

		}
	}


	[NVP_Manifest(
		Id = "9F4D0542-7907-426B-9AB8-AF6B0D24A6C4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymTableBorder.enum_mcBorderBottom", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymTableBorder", 
		NodeName = "enum_mcBorderBottom", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcBorderBottom : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymTableBorder.mcBorderBottom);

		}
	}


	[NVP_Manifest(
		Id = "BF4279F4-5322-433E-A780-6328609AAF35", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymTableBorder.enum_mcBorderInnerVert", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymTableBorder", 
		NodeName = "enum_mcBorderInnerVert", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcBorderInnerVert : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymTableBorder.mcBorderInnerVert);

		}
	}


	[NVP_Manifest(
		Id = "606485A5-4A2E-44A6-84B8-D67AF8B1B3CE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymTableBorder.enum_mcBorderInnerHorz", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymTableBorder", 
		NodeName = "enum_mcBorderInnerHorz", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcBorderInnerHorz : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymTableBorder.mcBorderInnerHorz);

		}
	}
}
