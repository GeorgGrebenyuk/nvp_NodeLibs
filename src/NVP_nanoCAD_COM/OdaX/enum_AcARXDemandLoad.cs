using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcARXDemandLoad 
{


	[NVP_Manifest(
		Id = "43E323FD-EB77-4AAD-885A-4AFA8FC858E6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcARXDemandLoad.enum_acDemanLoadDisable", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcARXDemandLoad", 
		NodeName = "enum_acDemanLoadDisable", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDemanLoadDisable : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcARXDemandLoad.acDemanLoadDisable);

		}
	}


	[NVP_Manifest(
		Id = "38D82795-35FB-4B4E-8233-CDAFAFB1CFC8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcARXDemandLoad.enum_acDemandLoadOnObjectDetect", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcARXDemandLoad", 
		NodeName = "enum_acDemandLoadOnObjectDetect", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDemandLoadOnObjectDetect : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcARXDemandLoad.acDemandLoadOnObjectDetect);

		}
	}


	[NVP_Manifest(
		Id = "B6712A43-C1D6-4521-8643-5DCDB25CE794", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcARXDemandLoad.enum_acDemandLoadCmdInvoke", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcARXDemandLoad", 
		NodeName = "enum_acDemandLoadCmdInvoke", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDemandLoadCmdInvoke : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcARXDemandLoad.acDemandLoadCmdInvoke);

		}
	}
}
