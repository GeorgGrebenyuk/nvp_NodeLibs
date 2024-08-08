using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcBlockConnectionType 
{


	[NVP_Manifest(
		Id = "20BD8AC3-77E1-4955-ACCD-53D59B64C9C4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcBlockConnectionType.enum_acConnectExtents", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcBlockConnectionType", 
		NodeName = "enum_acConnectExtents", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acConnectExtents : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcBlockConnectionType.acConnectExtents);

		}
	}


	[NVP_Manifest(
		Id = "A7DFD1DC-CB97-4DE4-AE2E-4CBF457A7581", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcBlockConnectionType.enum_acConnectBase", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcBlockConnectionType", 
		NodeName = "enum_acConnectBase", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acConnectBase : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcBlockConnectionType.acConnectBase);

		}
	}
}
