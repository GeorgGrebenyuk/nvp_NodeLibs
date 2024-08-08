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
