using NVP.API.Nodes;

namespace Renga._IActionEvents 
{
	[NodeInput("dynamic", typeof(object))]
	public class _IActionEvents_Constructor : INode 
	{
		public Renga._IActionEvents _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga._IActionEvents;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class _IActionEvents_ConstructorCast : INode 
	{
		public Renga._IActionEvents _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga._IActionEvents;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("_IActionEvents", typeof(object))]
	public class OnTriggered : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OnTriggered();
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("_IActionEvents", typeof(object))]
	public class OnToggled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OnToggled();
			return null;
		}
	}
}
