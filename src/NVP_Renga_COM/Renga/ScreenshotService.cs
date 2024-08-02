using NVP.API.Nodes;

namespace Renga.ScreenshotService 
{
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


	///<summary>
	///
	///</summary>
	[NodeInput("ScreenshotService", typeof(object))]
	[NodeInput("pSettings", typeof(System.Object))]
	public class MakeScreenshot : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MakeScreenshot(inputs[1]));

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("ScreenshotService", typeof(object))]
	public class CreateSettings : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateSettings);

		}
	}
}
