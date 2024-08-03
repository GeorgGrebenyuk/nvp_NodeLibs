using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcActiveSpace 
{


	[NVP_Manifest(
		Id = "911EABE8-5DF9-4BB2-A5F2-6B19F3C4CA46", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcActiveSpace.enum_acPaperSpace", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcActiveSpace", 
		NodeName = "enum_acPaperSpace", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acPaperSpace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcActiveSpace.acPaperSpace);

		}
	}


	[NVP_Manifest(
		Id = "3BDCDF42-F7AF-4FFB-B2E2-8F4AF6624AA2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcActiveSpace.enum_acModelSpace", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcActiveSpace", 
		NodeName = "enum_acModelSpace", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acModelSpace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcActiveSpace.acModelSpace);

		}
	}
}
