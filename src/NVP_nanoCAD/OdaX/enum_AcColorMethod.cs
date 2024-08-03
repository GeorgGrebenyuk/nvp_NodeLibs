using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcColorMethod 
{


	[NVP_Manifest(
		Id = "6F1FF776-F54B-4150-A013-356F59FDD6D4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcColorMethod.enum_acColorMethodByLayer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcColorMethod", 
		NodeName = "enum_acColorMethodByLayer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acColorMethodByLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcColorMethod.acColorMethodByLayer);

		}
	}


	[NVP_Manifest(
		Id = "D11795FF-626C-4B6E-813C-6946766F4355", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcColorMethod.enum_acColorMethodByBlock", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcColorMethod", 
		NodeName = "enum_acColorMethodByBlock", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acColorMethodByBlock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcColorMethod.acColorMethodByBlock);

		}
	}


	[NVP_Manifest(
		Id = "897BFB57-211C-422F-81FD-3EA8D48A3C88", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcColorMethod.enum_acColorMethodByRGB", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcColorMethod", 
		NodeName = "enum_acColorMethodByRGB", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acColorMethodByRGB : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcColorMethod.acColorMethodByRGB);

		}
	}


	[NVP_Manifest(
		Id = "93C2750D-4164-47DE-B911-53DDA08CB329", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcColorMethod.enum_acColorMethodByACI", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcColorMethod", 
		NodeName = "enum_acColorMethodByACI", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acColorMethodByACI : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcColorMethod.acColorMethodByACI);

		}
	}


	[NVP_Manifest(
		Id = "BEA12491-C69E-4A04-A203-1D9B74716C85", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcColorMethod.enum_acColorMethodForeground", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcColorMethod", 
		NodeName = "enum_acColorMethodForeground", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acColorMethodForeground : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcColorMethod.acColorMethodForeground);

		}
	}
}
