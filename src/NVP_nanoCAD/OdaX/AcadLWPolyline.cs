using NVP.API.Nodes;

namespace OdaX.AcadLWPolyline 
{
	[NodeInput("dynamic", typeof(object))]
	public class AcadLWPolyline_Constructor : INode 
	{
		public OdaX.IAcadLWPolyline _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadLWPolyline;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class AcadLWPolyline_ConstructorCast : INode 
	{
		public OdaX.IAcadLWPolyline _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadLWPolyline;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///Specifies or returns the current vertex of a lightweight polyline.
	///</summary>
	[NodeInput("AcadLWPolyline", typeof(object))]
	public class Coordinates : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Coordinates);

		}
	}


	///<summary>
	///Specifies or returns the current vertex of a lightweight polyline.
	///</summary>
	[NodeInput("AcadLWPolyline", typeof(object))]
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
	///Specifies or returns the x, y, and z coordinates of the normal direction vector.
	///</summary>
	[NodeInput("AcadLWPolyline", typeof(object))]
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
	[NodeInput("AcadLWPolyline", typeof(object))]
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
	///z-direction value) of a lightweight polyline.
	///</summary>
	[NodeInput("AcadLWPolyline", typeof(object))]
	public class Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Thickness);

		}
	}


	///<summary>
	///z-direction value) of a lightweight polyline.
	///</summary>
	[NodeInput("AcadLWPolyline", typeof(object))]
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
	///Creates and adds a new vertex to a lightweight polyline.
	///</summary>
	[NodeInput("AcadLWPolyline", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("vertex", typeof(System.Object))]
	public class AddVertex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AddVertex(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Explodes the lightweight polyline and returns the individual entities as an array of lines and arcs.
	///</summary>
	[NodeInput("AcadLWPolyline", typeof(object))]
	public class Explode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Explode);

		}
	}


	///<summary>
	///Returns the bulge value for a vertex of a lightweight polyline.
	///</summary>
	[NodeInput("AcadLWPolyline", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	public class GetBulge : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBulge(inputs[1]));

		}
	}


	///<summary>
	///Specifies the bulge value for a vertex of a lightweight polyline.
	///</summary>
	[NodeInput("AcadLWPolyline", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("bulge", typeof(System.Double))]
	public class SetBulge : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetBulge(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Returns the width for a segment of a lightweight polyline.
	///</summary>
	[NodeInput("AcadLWPolyline", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("StartWidth", typeof(System.Double))]
	[NodeInput("EndWidth", typeof(System.Double))]
	public class GetWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetWidth(inputs[1],inputs[2],inputs[3]);
			return null;
		}
	}


	///<summary>
	///Specifies the width for a segment of a lightweight polyline.
	///</summary>
	[NodeInput("AcadLWPolyline", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("StartWidth", typeof(System.Double))]
	[NodeInput("EndWidth", typeof(System.Double))]
	public class SetWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetWidth(inputs[1],inputs[2],inputs[3]);
			return null;
		}
	}


	///<summary>
	///Specifies or returns the width of the entire lightweight polyline.
	///</summary>
	[NodeInput("AcadLWPolyline", typeof(object))]
	public class ConstantWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ConstantWidth);

		}
	}


	///<summary>
	///Specifies or returns the width of the entire lightweight polyline.
	///</summary>
	[NodeInput("AcadLWPolyline", typeof(object))]
	[NodeInput("Width", typeof(System.Double))]
	public class Set_ConstantWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ConstantWidth = inputs[1];
			return null;
		}
	}


	///<summary>
	///Not implemented. Creates a new lightweight polyline at a specified distance from an original lightweight polyline.
	///</summary>
	[NodeInput("AcadLWPolyline", typeof(object))]
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
	///Specifies or returns the elevation of the lightweight polyline relative to the z-axis of the object's coordinate system.
	///</summary>
	[NodeInput("AcadLWPolyline", typeof(object))]
	public class Elevation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Elevation);

		}
	}


	///<summary>
	///Specifies or returns the elevation of the lightweight polyline relative to the z-axis of the object's coordinate system.
	///</summary>
	[NodeInput("AcadLWPolyline", typeof(object))]
	[NodeInput("Elevation", typeof(System.Double))]
	public class Set_Elevation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Elevation = inputs[1];
			return null;
		}
	}


	///<summary>
	///Returns the area encompassed by a lightweight polyline.
	///</summary>
	[NodeInput("AcadLWPolyline", typeof(object))]
	public class Area : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Area);

		}
	}


	///<summary>
	///Specifies or returns the coordinate of a single vertex in an object.
	///</summary>
	[NodeInput("AcadLWPolyline", typeof(object))]
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
	[NodeInput("AcadLWPolyline", typeof(object))]
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
	///Specifies or returns whether a lightweight polyline is open or closed.
	///</summary>
	[NodeInput("AcadLWPolyline", typeof(object))]
	public class Closed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Closed);

		}
	}


	///<summary>
	///Specifies or returns whether a lightweight polyline is open or closed.
	///</summary>
	[NodeInput("AcadLWPolyline", typeof(object))]
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
	///Specifies or returns whether linetype generation is used for a lightweight polyline.
	///</summary>
	[NodeInput("AcadLWPolyline", typeof(object))]
	public class LinetypeGeneration : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LinetypeGeneration);

		}
	}


	///<summary>
	///Specifies or returns whether linetype generation is used for a lightweight polyline.
	///</summary>
	[NodeInput("AcadLWPolyline", typeof(object))]
	[NodeInput("bLinetypeGen", typeof(System.Object))]
	public class Set_LinetypeGeneration : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LinetypeGeneration = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the length of a lightweight polyline.
	///</summary>
	[NodeInput("AcadLWPolyline", typeof(object))]
	public class Length : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Length);

		}
	}
}
