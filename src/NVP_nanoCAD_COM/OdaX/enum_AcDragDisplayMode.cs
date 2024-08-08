using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcDragDisplayMode 
{


	[NVP_Manifest(
		Id = "D9944510-201D-4AC4-BDF1-161FBC9FC88F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDragDisplayMode.enum_acDragDoNotDisplay", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDragDisplayMode", 
		NodeName = "enum_acDragDoNotDisplay", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDragDoNotDisplay : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDragDisplayMode.acDragDoNotDisplay);

		}
	}


	[NVP_Manifest(
		Id = "C85ECA02-DB67-4E48-A64E-12D6962EF27A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDragDisplayMode.enum_acDragDisplayOnRequest", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDragDisplayMode", 
		NodeName = "enum_acDragDisplayOnRequest", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDragDisplayOnRequest : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDragDisplayMode.acDragDisplayOnRequest);

		}
	}


	[NVP_Manifest(
		Id = "7B4A15B6-EF37-42E3-ADD0-4703CF5BE8C6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDragDisplayMode.enum_acDragDisplayAutomatically", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDragDisplayMode", 
		NodeName = "enum_acDragDisplayAutomatically", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDragDisplayAutomatically : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDragDisplayMode.acDragDisplayAutomatically);

		}
	}
}
