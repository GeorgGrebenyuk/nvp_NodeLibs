using NVP.API.Nodes;

namespace Renga.LevelViewParams 
{
	[NodeInput("dynamic", typeof(object))]
	public class LevelViewParams_Constructor : INode 
	{
		public Renga.ILevelViewParams _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.ILevelViewParams;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class LevelViewParams_ConstructorCast : INode 
	{
		public Renga.ILevelViewParams _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.ILevelViewParams;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("LevelViewParams", typeof(object))]
	public class LevelId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LevelId);

		}
	}
}
