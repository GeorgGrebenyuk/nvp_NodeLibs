using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcLeaderType 
{


	[NVP_Manifest(
		Id = "020397F3-01EB-4313-8564-D18BC45D5FEA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcLeaderType.enum_acLineNoArrow", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcLeaderType", 
		NodeName = "enum_acLineNoArrow", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acLineNoArrow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcLeaderType.acLineNoArrow);

		}
	}


	[NVP_Manifest(
		Id = "220A4A6F-0D1A-4FEC-87E3-04D15A01A9CF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcLeaderType.enum_acSplineNoArrow", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcLeaderType", 
		NodeName = "enum_acSplineNoArrow", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acSplineNoArrow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcLeaderType.acSplineNoArrow);

		}
	}


	[NVP_Manifest(
		Id = "8BB38607-394F-476F-8286-3C63A5D76CFB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcLeaderType.enum_acLineWithArrow", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcLeaderType", 
		NodeName = "enum_acLineWithArrow", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acLineWithArrow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcLeaderType.acLineWithArrow);

		}
	}


	[NVP_Manifest(
		Id = "1E46524C-10AB-44A1-8F37-130AA4BCE4ED", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcLeaderType.enum_acSplineWithArrow", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcLeaderType", 
		NodeName = "enum_acSplineWithArrow", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acSplineWithArrow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcLeaderType.acSplineWithArrow);

		}
	}
}
