﻿using NVP.API.Nodes;

namespace Renga.Placement3D 
{
		[NodeInput("dynamic", typeof(object))]
		public class Placement3D_Constructor : INode 
		{
		public Renga.IPlacement3D _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.IPlacement3D;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class Placement3D_ConstructorCast : INode 
		{
		public Renga.IPlacement3D _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.IPlacement3D;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Placement3D", typeof(object))]
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
		[NodeInput("Placement3D", typeof(object))]
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
		[NodeInput("Placement3D", typeof(object))]
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
		[NodeInput("Placement3D", typeof(object))]
		public class AxisZ : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.AxisZ);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Placement3D", typeof(object))]
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
		[NodeInput("Placement3D", typeof(object))]
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
		[NodeInput("Placement3D", typeof(object))]
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
		[NodeInput("Placement3D", typeof(object))]
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
		[NodeInput("Placement3D", typeof(object))]
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
		[NodeInput("Placement3D", typeof(object))]
		[NodeInput("vector_", typeof(System.Object))]
		public class Move : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Move(inputs[1]);
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Placement3D", typeof(object))]
		[NodeInput("axis_", typeof(System.Object))]
		[NodeInput("angle_", typeof(System.Double))]
		public class Rotate : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Rotate(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Placement3D", typeof(object))]
		[NodeInput("pTransform", typeof(System.Object))]
		public class Transform : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Transform(inputs[1]);
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Placement3D", typeof(object))]
		public class GetCopy : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetCopy);

			}
		}
}
