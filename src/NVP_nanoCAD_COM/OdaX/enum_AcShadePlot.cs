using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcShadePlot 
{


	[NVP_Manifest(
		Id = "A9840BC0-2140-42AA-8A4B-D04AB33E1BC5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcShadePlot.enum_acShadePlotAsDisplayed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcShadePlot", 
		NodeName = "enum_acShadePlotAsDisplayed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acShadePlotAsDisplayed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcShadePlot.acShadePlotAsDisplayed);

		}
	}


	[NVP_Manifest(
		Id = "3BC4867C-28A6-4186-9D74-132907DA8569", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcShadePlot.enum_acShadePlotWireframe", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcShadePlot", 
		NodeName = "enum_acShadePlotWireframe", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acShadePlotWireframe : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcShadePlot.acShadePlotWireframe);

		}
	}


	[NVP_Manifest(
		Id = "B80AE8A7-D42B-4CE3-B617-B2E337DF9D61", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcShadePlot.enum_acShadePlotHidden", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcShadePlot", 
		NodeName = "enum_acShadePlotHidden", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acShadePlotHidden : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcShadePlot.acShadePlotHidden);

		}
	}


	[NVP_Manifest(
		Id = "037F2A28-3F37-4013-9506-2A118EAF0D11", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcShadePlot.enum_acShadePlotRendered", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcShadePlot", 
		NodeName = "enum_acShadePlotRendered", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acShadePlotRendered : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcShadePlot.acShadePlotRendered);

		}
	}
}
