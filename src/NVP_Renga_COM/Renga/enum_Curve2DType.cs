using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.enum_Curve2DType 
{


	[NVP_Manifest(
		Id = "EB0A39FE-44C9-4990-980E-856D8B6D7348", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_Curve2DType.enum_Curve2DType_Undefined", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_Curve2DType", 
		NodeName = "enum_Curve2DType_Undefined", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_Curve2DType_Undefined : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.Curve2DType.Curve2DType_Undefined);

		}
	}


	[NVP_Manifest(
		Id = "B7AF0777-443F-4B42-9F6F-F5C0E054EB07", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_Curve2DType.enum_Curve2DType_LineSegment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_Curve2DType", 
		NodeName = "enum_Curve2DType_LineSegment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_Curve2DType_LineSegment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.Curve2DType.Curve2DType_LineSegment);

		}
	}


	[NVP_Manifest(
		Id = "BE3E266D-EF22-42A8-A529-4C5435417AF1", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_Curve2DType.enum_Curve2DType_Arc", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_Curve2DType", 
		NodeName = "enum_Curve2DType_Arc", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_Curve2DType_Arc : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.Curve2DType.Curve2DType_Arc);

		}
	}


	[NVP_Manifest(
		Id = "EA8372FA-89A8-4035-B1C6-E8B900268583", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_Curve2DType.enum_Curve2DType_PolyCurve", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_Curve2DType", 
		NodeName = "enum_Curve2DType_PolyCurve", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_Curve2DType_PolyCurve : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.Curve2DType.Curve2DType_PolyCurve);

		}
	}
}
