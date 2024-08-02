using NVP.API.Nodes;

namespace Renga._ISelectionEvents 
{
	[NodeInput("dynamic", typeof(object))]
	public class _ISelectionEvents_Constructor : INode 
	{
		public Renga._ISelectionEvents _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga._ISelectionEvents;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class _ISelectionEvents_ConstructorCast : INode 
	{
		public Renga._ISelectionEvents _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga._ISelectionEvents;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("_ISelectionEvents", typeof(object))]
	public class OnModelSelectionChanged : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OnModelSelectionChanged();
			return null;
		}
	}
}
