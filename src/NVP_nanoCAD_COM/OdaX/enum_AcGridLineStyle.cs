using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcGridLineStyle 
{


	[NVP_Manifest(
		Id = "109D1B4C-1AC1-4C0C-BF6D-6D62314BD237", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcGridLineStyle.enum_acGridLineStyleSingle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcGridLineStyle", 
		NodeName = "enum_acGridLineStyleSingle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acGridLineStyleSingle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcGridLineStyle.acGridLineStyleSingle);

		}
	}


	[NVP_Manifest(
		Id = "D77F0CB4-6CFA-45DE-A366-A5FD02A4C09E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcGridLineStyle.enum_acGridLineStyleDouble", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcGridLineStyle", 
		NodeName = "enum_acGridLineStyleDouble", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acGridLineStyleDouble : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcGridLineStyle.acGridLineStyleDouble);

		}
	}
}
