using NVP.API.Nodes;

namespace Renga.Curve2D 
{
		[NodeInput("dynamic", typeof(object))]
		public class Curve2D_Constructor : INode 
		{
		public Renga.ICurve2D _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.ICurve2D;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class Curve2D_ConstructorCast : INode 
		{
		public Renga.ICurve2D _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.ICurve2D;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Curve2D", typeof(object))]
		public class Curve2DType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Curve2DType);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Curve2D", typeof(object))]
		public class GetCopy : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetCopy);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Curve2D", typeof(object))]
		public class GetBeginPoint : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetBeginPoint);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Curve2D", typeof(object))]
		public class GetEndPoint : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetEndPoint);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Curve2D", typeof(object))]
		[NodeInput("param", typeof(System.Double))]
		public class GetPointOn : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetPointOn(inputs[1]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Curve2D", typeof(object))]
		public class MinParameter : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.MinParameter);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Curve2D", typeof(object))]
		public class MaxParameter : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.MaxParameter);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Curve2D", typeof(object))]
		public class GetLength : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetLength);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Curve2D", typeof(object))]
		[NodeInput("p1", typeof(System.Object))]
		[NodeInput("p2", typeof(System.Object))]
		public class GetGabarit : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.GetGabarit(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Curve2D", typeof(object))]
		public class IsClosed : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.IsClosed);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Curve2D", typeof(object))]
		[NodeInput("startT", typeof(System.Double))]
		[NodeInput("distance", typeof(System.Double))]
		[NodeInput("direction", typeof(System.Int32))]
		public class GetParameterAtDistance : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetParameterAtDistance(inputs[1],inputs[2],inputs[3]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Curve2D", typeof(object))]
		[NodeInput("t1", typeof(System.Double))]
		[NodeInput("t2", typeof(System.Double))]
		[NodeInput("sense", typeof(System.Int32))]
		public class GetTrimmed : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetTrimmed(inputs[1],inputs[2],inputs[3]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Curve2D", typeof(object))]
		[NodeInput("point", typeof(System.Object))]
		public class PointProjection : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.PointProjection(inputs[1]));

			}
		}
}
