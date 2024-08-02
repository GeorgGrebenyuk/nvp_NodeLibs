using NVP.API.Nodes;

namespace Renga.PolyCurve2D 
{
		[NodeInput("dynamic", typeof(object))]
		public class PolyCurve2D_Constructor : INode 
		{
		public Renga.IPolyCurve2D _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.IPolyCurve2D;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class PolyCurve2D_ConstructorCast : INode 
		{
		public Renga.IPolyCurve2D _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.IPolyCurve2D;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("PolyCurve2D", typeof(object))]
		public class GetSegmentCount : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetSegmentCount);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("PolyCurve2D", typeof(object))]
		[NodeInput("index", typeof(System.Int32))]
		public class GetSegment : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetSegment(inputs[1]));

			}
		}
}
