using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcViewportSplitType 
{


	[NVP_Manifest(
		Id = "5C4095CD-FFCB-4896-A5CC-A5A53CD6562E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcViewportSplitType.enum_acViewport2Horizontal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcViewportSplitType", 
		NodeName = "enum_acViewport2Horizontal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acViewport2Horizontal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcViewportSplitType.acViewport2Horizontal);

		}
	}


	[NVP_Manifest(
		Id = "285A898D-D595-4F84-81EA-2C35266D5C9F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcViewportSplitType.enum_acViewport2Vertical", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcViewportSplitType", 
		NodeName = "enum_acViewport2Vertical", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acViewport2Vertical : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcViewportSplitType.acViewport2Vertical);

		}
	}


	[NVP_Manifest(
		Id = "2ED64BF8-B1D8-421B-ACB8-FD581CFB0A39", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcViewportSplitType.enum_acViewport3Left", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcViewportSplitType", 
		NodeName = "enum_acViewport3Left", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acViewport3Left : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcViewportSplitType.acViewport3Left);

		}
	}


	[NVP_Manifest(
		Id = "8AA45554-3249-46D7-BA73-A7B71773DF84", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcViewportSplitType.enum_acViewport3Right", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcViewportSplitType", 
		NodeName = "enum_acViewport3Right", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acViewport3Right : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcViewportSplitType.acViewport3Right);

		}
	}


	[NVP_Manifest(
		Id = "FBE6E81E-B246-47FF-8107-BCEF3D8F7727", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcViewportSplitType.enum_acViewport3Horizontal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcViewportSplitType", 
		NodeName = "enum_acViewport3Horizontal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acViewport3Horizontal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcViewportSplitType.acViewport3Horizontal);

		}
	}


	[NVP_Manifest(
		Id = "7E35FF60-2A93-4DB8-B436-D3F523BDA775", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcViewportSplitType.enum_acViewport3Vertical", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcViewportSplitType", 
		NodeName = "enum_acViewport3Vertical", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acViewport3Vertical : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcViewportSplitType.acViewport3Vertical);

		}
	}


	[NVP_Manifest(
		Id = "D2AF8942-15A9-44C9-9575-49E09BD847BA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcViewportSplitType.enum_acViewport3Above", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcViewportSplitType", 
		NodeName = "enum_acViewport3Above", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acViewport3Above : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcViewportSplitType.acViewport3Above);

		}
	}


	[NVP_Manifest(
		Id = "653C00A4-9605-4D08-9B18-8238F53479A6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcViewportSplitType.enum_acViewport3Below", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcViewportSplitType", 
		NodeName = "enum_acViewport3Below", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acViewport3Below : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcViewportSplitType.acViewport3Below);

		}
	}


	[NVP_Manifest(
		Id = "7BF37593-D7F8-447D-B082-F6AD7A189659", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcViewportSplitType.enum_acViewport4", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcViewportSplitType", 
		NodeName = "enum_acViewport4", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acViewport4 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcViewportSplitType.acViewport4);

		}
	}
}
