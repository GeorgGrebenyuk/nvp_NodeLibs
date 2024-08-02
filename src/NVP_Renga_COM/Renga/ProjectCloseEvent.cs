using NVP.API.Nodes;

namespace Renga.ProjectCloseEvent 
{
	[NodeInput("dynamic", typeof(object))]
	public class ProjectCloseEvent_Constructor : INode 
	{
		public Renga.IProjectCloseEvent _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IProjectCloseEvent;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class ProjectCloseEvent_ConstructorCast : INode 
	{
		public Renga.IProjectCloseEvent _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IProjectCloseEvent;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("ProjectCloseEvent", typeof(object))]
	public class Prevent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Prevent();
			return null;
		}
	}
}
