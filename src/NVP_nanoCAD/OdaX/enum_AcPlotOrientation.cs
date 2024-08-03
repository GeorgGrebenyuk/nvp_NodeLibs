using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcPlotOrientation 
{


	[NVP_Manifest(
		Id = "01960BFA-9373-4054-8AF8-2A6CB9CD972F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcPlotOrientation.enum_acPlotOrientationPortrait", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcPlotOrientation", 
		NodeName = "enum_acPlotOrientationPortrait", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acPlotOrientationPortrait : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcPlotOrientation.acPlotOrientationPortrait);

		}
	}


	[NVP_Manifest(
		Id = "BDE5ED76-DAB9-467B-8BC5-49BFA7AEA4A4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcPlotOrientation.enum_acPlotOrientationLandscape", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcPlotOrientation", 
		NodeName = "enum_acPlotOrientationLandscape", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acPlotOrientationLandscape : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcPlotOrientation.acPlotOrientationLandscape);

		}
	}
}
