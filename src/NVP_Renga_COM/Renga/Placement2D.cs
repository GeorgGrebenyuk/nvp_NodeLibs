using NVP.API.Nodes;

namespace Renga.Placement2D 
{
		[NodeInput("dynamic", typeof(object))]
		public class Placement2D_Constructor : INode 
		{
		public Renga.IPlacement2D _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.IPlacement2D;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class Placement2D_ConstructorCast : INode 
		{
		public Renga.IPlacement2D _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.IPlacement2D;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Placement2D", typeof(object))]
		public class Origin : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Origin);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Placement2D", typeof(object))]
		public class AxisX : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.AxisX);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Placement2D", typeof(object))]
		public class AxisY : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.AxisY);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Placement2D", typeof(object))]
		public class IsOrthogonal : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.IsOrthogonal);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Placement2D", typeof(object))]
		public class IsNormal : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.IsNormal);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Placement2D", typeof(object))]
		public class IsLeft : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.IsLeft);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Placement2D", typeof(object))]
		public class GetTransformFrom : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetTransformFrom);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Placement2D", typeof(object))]
		public class GetTransformInto : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetTransformInto);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Placement2D", typeof(object))]
		public class GetCopy : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetCopy);

			}
		}
}
