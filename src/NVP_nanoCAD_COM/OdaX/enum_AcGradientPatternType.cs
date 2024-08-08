using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcGradientPatternType 
{


	[NVP_Manifest(
		Id = "C0F7CBC3-267C-4664-A6AB-A575758F9FD0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcGradientPatternType.enum_acPreDefinedGradient", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcGradientPatternType", 
		NodeName = "enum_acPreDefinedGradient", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acPreDefinedGradient : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcGradientPatternType.acPreDefinedGradient);

		}
	}


	[NVP_Manifest(
		Id = "679A4139-2544-4395-9726-E90FC49B7F26", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcGradientPatternType.enum_acUserDefinedGradient", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcGradientPatternType", 
		NodeName = "enum_acUserDefinedGradient", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acUserDefinedGradient : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcGradientPatternType.acUserDefinedGradient);

		}
	}
}
