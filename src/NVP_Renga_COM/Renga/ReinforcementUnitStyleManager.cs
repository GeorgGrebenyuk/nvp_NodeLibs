using NVP.API.Nodes;

namespace Renga.ReinforcementUnitStyleManager 
{
	[NodeInput("dynamic", typeof(object))]
	public class ReinforcementUnitStyleManager_Constructor : INode 
	{
		public Renga.IReinforcementUnitStyleManager _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IReinforcementUnitStyleManager;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class ReinforcementUnitStyleManager_ConstructorCast : INode 
	{
		public Renga.IReinforcementUnitStyleManager _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IReinforcementUnitStyleManager;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("ReinforcementUnitStyleManager", typeof(object))]
	[NodeInput("rebarStyleId", typeof(System.Int32))]
	public class GetRebarStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetRebarStyle(inputs[1]));

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("ReinforcementUnitStyleManager", typeof(object))]
	public class GetRebarStyleIds : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetRebarStyleIds();
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("ReinforcementUnitStyleManager", typeof(object))]
	[NodeInput("rebarStyleId", typeof(System.Int32))]
	public class RebarStyleExists : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RebarStyleExists(inputs[1]));

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("ReinforcementUnitStyleManager", typeof(object))]
	[NodeInput("reinforcementUnitStyleId", typeof(System.Int32))]
	public class GetUnitStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetUnitStyle(inputs[1]));

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("ReinforcementUnitStyleManager", typeof(object))]
	[NodeInput("reinforcementUnitStyleId", typeof(System.Int32))]
	public class UnitStyleExists : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UnitStyleExists(inputs[1]));

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("ReinforcementUnitStyleManager", typeof(object))]
	public class GetReinforcementUnitStyleIds : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetReinforcementUnitStyleIds();
			return null;
		}
	}
}
