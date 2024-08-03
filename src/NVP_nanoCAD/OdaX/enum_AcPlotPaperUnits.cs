using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcPlotPaperUnits 
{


	[NVP_Manifest(
		Id = "351F0DA3-C60D-484E-840A-45B814F70719", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcPlotPaperUnits.enum_acInches", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcPlotPaperUnits", 
		NodeName = "enum_acInches", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acInches : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcPlotPaperUnits.acInches);

		}
	}


	[NVP_Manifest(
		Id = "4D246978-64BC-4A1A-A75E-CF7790C937BD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcPlotPaperUnits.enum_acMillimeters", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcPlotPaperUnits", 
		NodeName = "enum_acMillimeters", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acMillimeters : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcPlotPaperUnits.acMillimeters);

		}
	}


	[NVP_Manifest(
		Id = "13EE1B3A-FCBD-4BD1-8DF3-F748C3696CA5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcPlotPaperUnits.enum_acPixels", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcPlotPaperUnits", 
		NodeName = "enum_acPixels", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acPixels : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcPlotPaperUnits.acPixels);

		}
	}
}
