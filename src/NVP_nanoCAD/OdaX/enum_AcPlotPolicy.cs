using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcPlotPolicy 
{


	[NVP_Manifest(
		Id = "0C8EF1DA-A6CA-402D-A5B7-97A54C815CEB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcPlotPolicy.enum_acPolicyNamed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcPlotPolicy", 
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
			return new NodeResult(OdaX.AcPlotPolicy.acPolicyNamed);

		}
	}


	[NVP_Manifest(
		Id = "466BF3DB-4F41-4AE8-90E6-E13D69B6F8D1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcPlotPolicy.enum_acPolicyLegacy", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcPlotPolicy", 
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
			return new NodeResult(OdaX.AcPlotPolicy.acPolicyLegacy);

		}
	}
}
