using NVP.API.Nodes;

namespace Renga.ObjectOnRoutePlacement 
{
	[NodeInput("dynamic", typeof(object))]
	public class ObjectOnRoutePlacement_Constructor : INode 
	{
		public Renga.IObjectOnRoutePlacement _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IObjectOnRoutePlacement;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class ObjectOnRoutePlacement_ConstructorCast : INode 
	{
		public Renga.IObjectOnRoutePlacement _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IObjectOnRoutePlacement;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("ObjectOnRoutePlacement", typeof(object))]
	public class Id : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Id);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("ObjectOnRoutePlacement", typeof(object))]
	public class parameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.parameter);

		}
	}
}
