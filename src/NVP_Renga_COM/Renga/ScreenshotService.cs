using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.ScreenshotService 
{

	[NVP_Manifest(
		Id = "550CCD44-DFD7-4CE2-8F47-A81A512DED99", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ScreenshotService.ScreenshotService_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ScreenshotService", 
		NodeName = "_ScreenshotService_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ScreenshotService_Constructor : INode 
	{
		public Renga.IScreenshotService _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IScreenshotService;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "3EB44110-DBE6-4072-AFEA-8F12831C5A71", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ScreenshotService.ScreenshotService_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ScreenshotService", 
		NodeName = "_ScreenshotService_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ScreenshotService_ConstructorCast : INode 
	{
		public Renga.IScreenshotService _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IScreenshotService;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "DA6D43BF-F0A1-4F04-A7DE-FC03F375FA9B", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ScreenshotService.MakeScreenshot", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ScreenshotService", 
		NodeName = "MakeScreenshot", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ScreenshotService", typeof(object))]
	[NodeInput("pSettings", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class MakeScreenshot : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MakeScreenshot(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "7DDDFC53-58B2-4BBB-9027-2124A536872C", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ScreenshotService.CreateSettings", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ScreenshotService", 
		NodeName = "CreateSettings", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ScreenshotService", typeof(object))]

	///<summary>
	///
	///</summary>
	public class CreateSettings : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateSettings);

		}
	}
}
