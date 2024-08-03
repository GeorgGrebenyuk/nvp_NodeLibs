using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcPlotPolicyForNewDwgs 
{


	[NVP_Manifest(
		Id = "20D72BF9-907E-405B-8CBA-89E741346437", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcPlotPolicyForNewDwgs.enum_acPolicyNewDefault", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcPlotPolicyForNewDwgs", 
		NodeName = "enum_acPolicyNewDefault", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acPolicyNewDefault : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcPlotPolicyForNewDwgs.acPolicyNewDefault);

		}
	}


	[NVP_Manifest(
		Id = "DF5548E7-2DCC-4FEB-A2F7-4B092C9886AE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcPlotPolicyForNewDwgs.enum_acPolicyNewLegacy", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcPlotPolicyForNewDwgs", 
		NodeName = "enum_acPolicyNewLegacy", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acPolicyNewLegacy : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcPlotPolicyForNewDwgs.acPolicyNewLegacy);

		}
	}
}
