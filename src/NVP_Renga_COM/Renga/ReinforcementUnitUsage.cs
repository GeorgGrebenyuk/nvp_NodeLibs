using NVP.API.Nodes;

namespace Renga.ReinforcementUnitUsage 
{
		[NodeInput("dynamic", typeof(object))]
		public class ReinforcementUnitUsage_Constructor : INode 
		{
		public Renga.IReinforcementUnitUsage _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.IReinforcementUnitUsage;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class ReinforcementUnitUsage_ConstructorCast : INode 
		{
		public Renga.IReinforcementUnitUsage _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.IReinforcementUnitUsage;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("ReinforcementUnitUsage", typeof(object))]
		public class StyleId : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.StyleId);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("ReinforcementUnitUsage", typeof(object))]
		public class GetQuantities : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetQuantities);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("ReinforcementUnitUsage", typeof(object))]
		public class GetPlacements : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetPlacements);

			}
		}
}
