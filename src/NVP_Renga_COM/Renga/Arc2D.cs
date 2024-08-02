using NVP.API.Nodes;

namespace Renga.Arc2D 
{
		[NodeInput("dynamic", typeof(object))]
		public class Arc2D_Constructor : INode 
		{
		public Renga.IArc2D _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.IArc2D;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class Arc2D_ConstructorCast : INode 
		{
		public Renga.IArc2D _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.IArc2D;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Arc2D", typeof(object))]
		public class GetPlacement : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetPlacement);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Arc2D", typeof(object))]
		public class GetRadius : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetRadius);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Arc2D", typeof(object))]
		public class GetRadiusA : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetRadiusA);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Arc2D", typeof(object))]
		public class GetRadiusB : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetRadiusB);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Arc2D", typeof(object))]
		public class GetBeginAngle : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetBeginAngle);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Arc2D", typeof(object))]
		public class GetEndAngle : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetEndAngle);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Arc2D", typeof(object))]
		public class GetBeginGlobalAngle : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetBeginGlobalAngle);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Arc2D", typeof(object))]
		public class GetEndGlobalAngle : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetEndGlobalAngle);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Arc2D", typeof(object))]
		public class IsCircular : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.IsCircular);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Arc2D", typeof(object))]
		public class IsClockwise : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.IsClockwise);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Arc2D", typeof(object))]
		public class GetCenter : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetCenter);

			}
		}
}
