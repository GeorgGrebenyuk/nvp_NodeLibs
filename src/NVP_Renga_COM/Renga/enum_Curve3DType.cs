using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.enum_Curve3DType 
{


	[NVP_Manifest(
		Id = "787918C5-A714-40E4-A6FC-BF076B96C58C", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_Curve3DType.enum_Curve3DType_Undefined", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_Curve3DType", 
		NodeName = "enum_Curve3DType_Undefined", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_Curve3DType_Undefined : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.Curve3DType.Curve3DType_Undefined);

		}
	}


	[NVP_Manifest(
		Id = "EB71AA72-53C2-4EB4-9DC0-5D48E68C9568", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_Curve3DType.enum_Curve3DType_LineSegment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_Curve3DType", 
		NodeName = "enum_Curve3DType_LineSegment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_Curve3DType_LineSegment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.Curve3DType.Curve3DType_LineSegment);

		}
	}


	[NVP_Manifest(
		Id = "4525A1CE-8810-4F8B-B067-2D798087A7B8", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_Curve3DType.enum_Curve3DType_Arc", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_Curve3DType", 
		NodeName = "enum_Curve3DType_Arc", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_Curve3DType_Arc : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.Curve3DType.Curve3DType_Arc);

		}
	}


	[NVP_Manifest(
		Id = "1D2BF162-65B8-4585-85B8-D0015D70F820", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_Curve3DType.enum_Curve3DType_PolyCurve", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_Curve3DType", 
		NodeName = "enum_Curve3DType_PolyCurve", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_Curve3DType_PolyCurve : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.Curve3DType.Curve3DType_PolyCurve);

		}
	}
}
