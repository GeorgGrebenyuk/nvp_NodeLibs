using NVP.API.Nodes;

namespace OdaX.Acad3DPolyline 
{
		[NodeInput("dynamic", typeof(object))]
		public class Acad3DPolyline_Constructor : INode 
		{
		public OdaX.IAcad3DPolyline _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IAcad3DPolyline;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class Acad3DPolyline_ConstructorCast : INode 
		{
		public OdaX.IAcad3DPolyline _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IAcad3DPolyline;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Specifies or returns the current vertex of a 3D polyline.
		///</summary>
		[NodeInput("Acad3DPolyline", typeof(object))]
		public class Coordinates : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Coordinates);

			}
		}


		///<summary>
		///Specifies or returns the current vertex of a 3D polyline.
		///</summary>
		[NodeInput("Acad3DPolyline", typeof(object))]
		[NodeInput("Coordinates", typeof(System.Object))]
		public class Set_Coordinates : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Coordinates = inputs[1];
				return null;
			}
		}


		///<summary>
		///Appends a vertex to a 3D polyline.
		///</summary>
		[NodeInput("Acad3DPolyline", typeof(object))]
		[NodeInput("vertex", typeof(System.Object))]
		public class AppendVertex : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.AppendVertex(inputs[1]);
				return null;
			}
		}


		///<summary>
		///Explodes a 3D polyline.
		///</summary>
		[NodeInput("Acad3DPolyline", typeof(object))]
		public class Explode : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Explode);

			}
		}


		///<summary>
		///Specifies or returns the coordinate of a single vertex in an object.
		///</summary>
		[NodeInput("Acad3DPolyline", typeof(object))]
		[NodeInput("Index", typeof(System.Int32))]
		public class Coordinate : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Coordinate(inputs[1]));

			}
		}


		///<summary>
		///Specifies or returns the coordinate of a single vertex in an object.
		///</summary>
		[NodeInput("Acad3DPolyline", typeof(object))]
		[NodeInput("Index", typeof(System.Int32))]
		[NodeInput("pVal", typeof(System.Object))]
		public class Set_Coordinate : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Coordinate[inputs[1]] = inputs[2];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the type of line or surface curve fitting.
		///</summary>
		[NodeInput("Acad3DPolyline", typeof(object))]
		public class Type : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Type);

			}
		}


		///<summary>
		///Specifies or returns the type of line or surface curve fitting.
		///</summary>
		[NodeInput("Acad3DPolyline", typeof(object))]
		[NodeInput("Type", typeof(System.Object))]
		public class Set_Type : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Type = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether a 3D polyline is open or closed.
		///</summary>
		[NodeInput("Acad3DPolyline", typeof(object))]
		public class Closed : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Closed);

			}
		}


		///<summary>
		///Specifies or returns whether a 3D polyline is open or closed.
		///</summary>
		[NodeInput("Acad3DPolyline", typeof(object))]
		[NodeInput("fClose", typeof(System.Object))]
		public class Set_Closed : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Closed = inputs[1];
				return null;
			}
		}


		///<summary>
		///Returns the length of a 3D polyline.
		///</summary>
		[NodeInput("Acad3DPolyline", typeof(object))]
		public class Length : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Length);

			}
		}
}
