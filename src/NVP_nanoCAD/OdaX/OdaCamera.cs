using NVP.API.Nodes;

namespace OdaX.OdaCamera 
{
		[NodeInput("dynamic", typeof(object))]
		public class OdaCamera_Constructor : INode 
		{
		public OdaX.IOdaCamera _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IOdaCamera;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class OdaCamera_ConstructorCast : INode 
		{
		public OdaX.IOdaCamera _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IOdaCamera;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaCamera", typeof(object))]
		public class Name : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Name);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaCamera", typeof(object))]
		[NodeInput("pVal", typeof(System.String))]
		public class Set_Name : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Name = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaCamera", typeof(object))]
		public class Location : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Location);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaCamera", typeof(object))]
		[NodeInput("pVal", typeof(System.Object))]
		public class Set_Location : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Location = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaCamera", typeof(object))]
		public class Target : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Target);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaCamera", typeof(object))]
		[NodeInput("pVal", typeof(System.Object))]
		public class Set_Target : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Target = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaCamera", typeof(object))]
		public class LensLength : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LensLength);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaCamera", typeof(object))]
		[NodeInput("pVal", typeof(System.Object))]
		public class Set_LensLength : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.LensLength = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaCamera", typeof(object))]
		public class FieldOfView : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.FieldOfView);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaCamera", typeof(object))]
		[NodeInput("pVal", typeof(System.Object))]
		public class Set_FieldOfView : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.FieldOfView = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaCamera", typeof(object))]
		public class FrameHeight : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.FrameHeight);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaCamera", typeof(object))]
		[NodeInput("pVal", typeof(System.Double))]
		public class Set_FrameHeight : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.FrameHeight = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaCamera", typeof(object))]
		public class FrameWidth : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.FrameWidth);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaCamera", typeof(object))]
		[NodeInput("pVal", typeof(System.Double))]
		public class Set_FrameWidth : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.FrameWidth = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaCamera", typeof(object))]
		public class RollAngle : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.RollAngle);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaCamera", typeof(object))]
		[NodeInput("pVal", typeof(System.Object))]
		public class Set_RollAngle : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.RollAngle = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaCamera", typeof(object))]
		public class IsPlotable : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.IsPlotable);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaCamera", typeof(object))]
		[NodeInput("pVal", typeof(System.Object))]
		public class Set_IsPlotable : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.IsPlotable = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaCamera", typeof(object))]
		public class FrontPlane : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.FrontPlane);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaCamera", typeof(object))]
		[NodeInput("pVal", typeof(System.Double))]
		public class Set_FrontPlane : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.FrontPlane = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaCamera", typeof(object))]
		public class BackPlane : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.BackPlane);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaCamera", typeof(object))]
		[NodeInput("pVal", typeof(System.Double))]
		public class Set_BackPlane : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.BackPlane = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaCamera", typeof(object))]
		public class Clipping : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Clipping);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaCamera", typeof(object))]
		[NodeInput("pVal", typeof(System.String))]
		public class Set_Clipping : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Clipping = inputs[1];
				return null;
			}
		}
}
