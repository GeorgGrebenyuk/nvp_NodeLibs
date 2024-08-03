using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcDimToleranceJustify 
{


	[NVP_Manifest(
		Id = "B55C63BF-E118-4F65-A1A1-58CD2E083B36", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimToleranceJustify.enum_acTolBottom", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimToleranceJustify", 
		NodeName = "enum_acTolBottom", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTolBottom : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimToleranceJustify.acTolBottom);

		}
	}


	[NVP_Manifest(
		Id = "99E687A1-F4BB-4114-B6C0-348272A28E0E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimToleranceJustify.enum_acTolMiddle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimToleranceJustify", 
		NodeName = "enum_acTolMiddle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTolMiddle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimToleranceJustify.acTolMiddle);

		}
	}


	[NVP_Manifest(
		Id = "B353DEE9-D95E-48D8-86A1-78C4B0ECA97B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimToleranceJustify.enum_acTolTop", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimToleranceJustify", 
		NodeName = "enum_acTolTop", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTolTop : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimToleranceJustify.acTolTop);

		}
	}
}
