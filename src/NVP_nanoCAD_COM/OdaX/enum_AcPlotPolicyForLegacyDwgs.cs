using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcPlotPolicyForLegacyDwgs 
{


	[NVP_Manifest(
		Id = "49C0DEC2-9B76-4C0D-ACFC-6A46F42B31D5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcPlotPolicyForLegacyDwgs.enum_acPolicyLegacyDefault", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcPlotPolicyForLegacyDwgs", 
		NodeName = "enum_acPolicyLegacyDefault", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acPolicyLegacyDefault : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcPlotPolicyForLegacyDwgs.acPolicyLegacyDefault);

		}
	}


	[NVP_Manifest(
		Id = "29A6FD5D-5AE9-4E1D-B837-E4512609D7DC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcPlotPolicyForLegacyDwgs.enum_acPolicyLegacyQuery", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcPlotPolicyForLegacyDwgs", 
		NodeName = "enum_acPolicyLegacyQuery", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acPolicyLegacyQuery : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcPlotPolicyForLegacyDwgs.acPolicyLegacyQuery);

		}
	}


	[NVP_Manifest(
		Id = "CF9ACB69-7C04-449D-9A45-09C841B20D7C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcPlotPolicyForLegacyDwgs.enum_acPolicyLegacyLegacy", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcPlotPolicyForLegacyDwgs", 
		NodeName = "enum_acPolicyLegacyLegacy", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acPolicyLegacyLegacy : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcPlotPolicyForLegacyDwgs.acPolicyLegacyLegacy);

		}
	}
}
