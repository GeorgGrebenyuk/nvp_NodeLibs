using NVP.API.Nodes;

namespace Renga.ObjectReinforcementModel 
{
	[NodeInput("dynamic", typeof(object))]
	public class ObjectReinforcementModel_Constructor : INode 
	{
		public Renga.IObjectReinforcementModel _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IObjectReinforcementModel;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class ObjectReinforcementModel_ConstructorCast : INode 
	{
		public Renga.IObjectReinforcementModel _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IObjectReinforcementModel;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("ObjectReinforcementModel", typeof(object))]
	public class GetRebarUsages : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetRebarUsages);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("ObjectReinforcementModel", typeof(object))]
	public class GetReinforcementUnitUsages : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetReinforcementUnitUsages);

		}
	}
}
