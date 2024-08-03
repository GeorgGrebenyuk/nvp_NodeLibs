using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcDimToleranceMethod 
{


	[NVP_Manifest(
		Id = "888EE3D2-6EDF-4423-8E07-E727E17546D1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimToleranceMethod.enum_acTolNone", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimToleranceMethod", 
		NodeName = "enum_acTolNone", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTolNone : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimToleranceMethod.acTolNone);

		}
	}


	[NVP_Manifest(
		Id = "41D00544-788A-4E34-8959-A2E388855F54", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimToleranceMethod.enum_acTolSymmetrical", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimToleranceMethod", 
		NodeName = "enum_acTolSymmetrical", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTolSymmetrical : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimToleranceMethod.acTolSymmetrical);

		}
	}


	[NVP_Manifest(
		Id = "1D78D16B-3C4E-4548-B884-B4847A42A362", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimToleranceMethod.enum_acTolDeviation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimToleranceMethod", 
		NodeName = "enum_acTolDeviation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTolDeviation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimToleranceMethod.acTolDeviation);

		}
	}


	[NVP_Manifest(
		Id = "ABB8A194-4572-480B-B3F8-671E34DFD38F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimToleranceMethod.enum_acTolLimits", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimToleranceMethod", 
		NodeName = "enum_acTolLimits", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTolLimits : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimToleranceMethod.acTolLimits);

		}
	}


	[NVP_Manifest(
		Id = "9100D837-C073-4896-B019-C6E19E472DF2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimToleranceMethod.enum_acTolBasic", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimToleranceMethod", 
		NodeName = "enum_acTolBasic", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTolBasic : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimToleranceMethod.acTolBasic);

		}
	}
}
