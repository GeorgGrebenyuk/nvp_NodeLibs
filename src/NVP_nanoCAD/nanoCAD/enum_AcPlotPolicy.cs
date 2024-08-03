using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace nanoCAD.enum_AcPlotPolicy 
{


	[NVP_Manifest(
		Id = "B275E583-D4BC-4059-B62A-F3F3C6E9D53D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcPlotPolicy.enum_acPolicyNamed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcPlotPolicy", 
		NodeName = "enum_acPolicyNamed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acPolicyNamed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcPlotPolicy.acPolicyNamed);

		}
	}


	[NVP_Manifest(
		Id = "7A7C63CB-2398-4AEE-B58A-FB9FECB5ACBE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcPlotPolicy.enum_acPolicyLegacy", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcPlotPolicy", 
		NodeName = "enum_acPolicyLegacy", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acPolicyLegacy : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcPlotPolicy.acPolicyLegacy);

		}
	}
}
