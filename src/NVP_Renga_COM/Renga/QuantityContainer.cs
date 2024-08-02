using NVP.API.Nodes;

namespace Renga.QuantityContainer 
{
		[NodeInput("dynamic", typeof(object))]
		public class QuantityContainer_Constructor : INode 
		{
		public Renga.IQuantityContainer _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.IQuantityContainer;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class QuantityContainer_ConstructorCast : INode 
		{
		public Renga.IQuantityContainer _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.IQuantityContainer;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("QuantityContainer", typeof(object))]
		[NodeInput("Id", typeof(System.Object))]
		public class Contains : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Contains(inputs[1]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("QuantityContainer", typeof(object))]
		[NodeInput("Id", typeof(System.Object))]
		public class Get : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Get(inputs[1]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("QuantityContainer", typeof(object))]
		[NodeInput("Id", typeof(System.String))]
		public class ContainsS : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ContainsS(inputs[1]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("QuantityContainer", typeof(object))]
		[NodeInput("Id", typeof(System.String))]
		public class GetS : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetS(inputs[1]));

			}
		}
}
