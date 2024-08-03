using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcCellOption 
{


	[NVP_Manifest(
		Id = "CDABB7BF-3EF5-4D54-8715-31D0FA06E643", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcCellOption.enum_kCellOptionNone", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcCellOption", 
		NodeName = "enum_kCellOptionNone", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_kCellOptionNone : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcCellOption.kCellOptionNone);

		}
	}


	[NVP_Manifest(
		Id = "4EA95DAC-0D85-4FAE-9B69-85BAA0970D6E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcCellOption.enum_kInheritCellFormat", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcCellOption", 
		NodeName = "enum_kInheritCellFormat", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_kInheritCellFormat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcCellOption.kInheritCellFormat);

		}
	}
}
