using NVP.API.Nodes;

namespace Renga.Curve2DCollection 
{
		[NodeInput("dynamic", typeof(object))]
		public class Curve2DCollection_Constructor : INode 
		{
		public Renga.ICurve2DCollection _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.ICurve2DCollection;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class Curve2DCollection_ConstructorCast : INode 
		{
		public Renga.ICurve2DCollection _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.ICurve2DCollection;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Curve2DCollection", typeof(object))]
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
		[NodeInput("Curve2DCollection", typeof(object))]
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
