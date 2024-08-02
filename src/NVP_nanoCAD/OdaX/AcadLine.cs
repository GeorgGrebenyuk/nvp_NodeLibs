using NVP.API.Nodes;

namespace OdaX.AcadLine 
{
		[NodeInput("dynamic", typeof(object))]
		public class AcadLine_Constructor : INode 
		{
		public OdaX.IAcadLine _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IAcadLine;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class AcadLine_ConstructorCast : INode 
		{
		public OdaX.IAcadLine _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IAcadLine;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Specifies or returns the x, y, z coordinates of the start point of a line.
		///</summary>
		[NodeInput("AcadLine", typeof(object))]
		public class StartPoint : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.StartPoint);

			}
		}


		///<summary>
		///Specifies or returns the x, y, z coordinates of the start point of a line.
		///</summary>
		[NodeInput("AcadLine", typeof(object))]
		[NodeInput("StartPoint", typeof(System.Object))]
		public class Set_StartPoint : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.StartPoint = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the x, y, z coordinates of the end point of a line.
		///</summary>
		[NodeInput("AcadLine", typeof(object))]
		public class EndPoint : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.EndPoint);

			}
		}


		///<summary>
		///Specifies or returns the x, y, z coordinates of the end point of a line.
		///</summary>
		[NodeInput("AcadLine", typeof(object))]
		[NodeInput("EndPoint", typeof(System.Object))]
		public class Set_EndPoint : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.EndPoint = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the x, y, and z coordinates of the normal direction vector.
		///</summary>
		[NodeInput("AcadLine", typeof(object))]
		public class Normal : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Normal);

			}
		}


		///<summary>
		///Specifies or returns the x, y, and z coordinates of the normal direction vector.
		///</summary>
		[NodeInput("AcadLine", typeof(object))]
		[NodeInput("Normal", typeof(System.Object))]
		public class Set_Normal : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Normal = inputs[1];
				return null;
			}
		}


		///<summary>
		///z-direction value) of a line.
		///</summary>
		[NodeInput("AcadLine", typeof(object))]
		public class Thickness : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Thickness);

			}
		}


		///<summary>
		///z-direction value) of a line.
		///</summary>
		[NodeInput("AcadLine", typeof(object))]
		[NodeInput("Thickness", typeof(System.Double))]
		public class Set_Thickness : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Thickness = inputs[1];
				return null;
			}
		}


		///<summary>
		///Not implemented. Copies an existing line and places the copy at a specified distance from the existing line.
		///</summary>
		[NodeInput("AcadLine", typeof(object))]
		[NodeInput("Distance", typeof(System.Double))]
		public class Offset : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Offset(inputs[1]));

			}
		}


		///<summary>
		///Specifies the x, y, z, delta values of a line.
		///</summary>
		[NodeInput("AcadLine", typeof(object))]
		public class Delta : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Delta);

			}
		}


		///<summary>
		///Specifies the length of a line.
		///</summary>
		[NodeInput("AcadLine", typeof(object))]
		public class Length : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Length);

			}
		}


		///<summary>
		///Specifies the angle of a line.
		///</summary>
		[NodeInput("AcadLine", typeof(object))]
		public class Angle : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Angle);

			}
		}
}
