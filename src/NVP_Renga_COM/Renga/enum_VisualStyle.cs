using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.enum_VisualStyle 
{


	[NVP_Manifest(
		Id = "FB9C1A78-0EFC-44CF-B23E-49E6346A7319", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_VisualStyle.enum_VisualStyle_Undefined", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_VisualStyle", 
		NodeName = "enum_VisualStyle_Undefined", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_VisualStyle_Undefined : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.VisualStyle.VisualStyle_Undefined);

		}
	}


	[NVP_Manifest(
		Id = "CC7EA800-1B80-43A3-8B4F-C52A7671FB79", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_VisualStyle.enum_VisualStyle_Wireframe", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_VisualStyle", 
		NodeName = "enum_VisualStyle_Wireframe", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_VisualStyle_Wireframe : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.VisualStyle.VisualStyle_Wireframe);

		}
	}


	[NVP_Manifest(
		Id = "D9313795-15B7-4F7D-B1C6-6BEF65C8A1C5", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_VisualStyle.enum_VisualStyle_Monochrome", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_VisualStyle", 
		NodeName = "enum_VisualStyle_Monochrome", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_VisualStyle_Monochrome : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.VisualStyle.VisualStyle_Monochrome);

		}
	}


	[NVP_Manifest(
		Id = "2C91A86E-8763-4B40-B827-2B7D4D0EBE07", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_VisualStyle.enum_VisualStyle_Color", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_VisualStyle", 
		NodeName = "enum_VisualStyle_Color", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_VisualStyle_Color : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.VisualStyle.VisualStyle_Color);

		}
	}


	[NVP_Manifest(
		Id = "FE7556F1-74EC-4E67-AAEC-07850EF0657E", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_VisualStyle.enum_VisualStyle_Textured", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_VisualStyle", 
		NodeName = "enum_VisualStyle_Textured", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_VisualStyle_Textured : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.VisualStyle.VisualStyle_Textured);

		}
	}
}
