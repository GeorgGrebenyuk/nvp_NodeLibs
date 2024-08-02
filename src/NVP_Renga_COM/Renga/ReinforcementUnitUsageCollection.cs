using NVP.API.Nodes;

namespace Renga.ReinforcementUnitUsageCollection 
{
	[NodeInput("dynamic", typeof(object))]
	public class ReinforcementUnitUsageCollection_Constructor : INode 
	{
		public Renga.IReinforcementUnitUsageCollection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IReinforcementUnitUsageCollection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class ReinforcementUnitUsageCollection_ConstructorCast : INode 
	{
		public Renga.IReinforcementUnitUsageCollection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IReinforcementUnitUsageCollection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("ReinforcementUnitUsageCollection", typeof(object))]
	public class Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Count);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("ReinforcementUnitUsageCollection", typeof(object))]
	[NodeInput("index", typeof(System.Int32))]
	public class Get : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Get(inputs[1]));

		}
	}
}
