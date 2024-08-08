using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of 2D line with adjustable width composed of line and arc segments entity
///</summary>
namespace OdaX.AcadLWPolyline 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
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

	[NVP_Manifest(
		ViewType = "Modifier")]
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


	[NVP_Manifest(
		Text = "Specifies or returns the current vertex of a lightweight polyline.", 
		ViewType = "Data")]
	[NodeInput("AcadLWPolyline", typeof(object))]

	///<summary>
	///Specifies or returns the current vertex of a lightweight polyline.
	///</summary>
	public class Coordinates : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Coordinates);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the current vertex of a lightweight polyline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLWPolyline", typeof(object))]
	[NodeInput("Coordinates", typeof(System.Object))]

	///<summary>
	///Specifies or returns the current vertex of a lightweight polyline.
	///</summary>
	public class Set_Coordinates : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Coordinates = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the x, y, and z coordinates of the normal direction vector.", 
		ViewType = "Data")]
	[NodeInput("AcadLWPolyline", typeof(object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates of the normal direction vector.
	///</summary>
	public class Normal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Normal);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the x, y, and z coordinates of the normal direction vector.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLWPolyline", typeof(object))]
	[NodeInput("Normal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates of the normal direction vector.
	///</summary>
	public class Set_Normal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Normal = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "z-direction value) of a lightweight polyline.", 
		ViewType = "Data")]
	[NodeInput("AcadLWPolyline", typeof(object))]

	///<summary>
	///z-direction value) of a lightweight polyline.
	///</summary>
	public class Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Thickness);

		}
	}


	[NVP_Manifest(
		Text = "z-direction value) of a lightweight polyline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLWPolyline", typeof(object))]
	[NodeInput("Thickness", typeof(System.Double))]

	///<summary>
	///z-direction value) of a lightweight polyline.
	///</summary>
	public class Set_Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Thickness = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Creates and adds a new vertex to a lightweight polyline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLWPolyline", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("vertex", typeof(System.Object))]

	///<summary>
	///Creates and adds a new vertex to a lightweight polyline.
	///</summary>
	public class AddVertex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AddVertex(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Explodes the lightweight polyline and returns the individual entities as an array of lines and arcs.", 
		ViewType = "Data")]
	[NodeInput("AcadLWPolyline", typeof(object))]

	///<summary>
	///Explodes the lightweight polyline and returns the individual entities as an array of lines and arcs.
	///</summary>
	public class Explode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Explode);

		}
	}


	[NVP_Manifest(
		Text = "Returns the bulge value for a vertex of a lightweight polyline.", 
		ViewType = "Data")]
	[NodeInput("AcadLWPolyline", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]

	///<summary>
	///Returns the bulge value for a vertex of a lightweight polyline.
	///</summary>
	public class GetBulge : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBulge(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Specifies the bulge value for a vertex of a lightweight polyline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLWPolyline", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("bulge", typeof(System.Double))]

	///<summary>
	///Specifies the bulge value for a vertex of a lightweight polyline.
	///</summary>
	public class SetBulge : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetBulge(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the width for a segment of a lightweight polyline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLWPolyline", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("StartWidth", typeof(System.Double))]
	[NodeInput("EndWidth", typeof(System.Double))]

	///<summary>
	///Returns the width for a segment of a lightweight polyline.
	///</summary>
	public class GetWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetWidth(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the width for a segment of a lightweight polyline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLWPolyline", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("StartWidth", typeof(System.Double))]
	[NodeInput("EndWidth", typeof(System.Double))]

	///<summary>
	///Specifies the width for a segment of a lightweight polyline.
	///</summary>
	public class SetWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetWidth(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the width of the entire lightweight polyline.", 
		ViewType = "Data")]
	[NodeInput("AcadLWPolyline", typeof(object))]

	///<summary>
	///Specifies or returns the width of the entire lightweight polyline.
	///</summary>
	public class ConstantWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ConstantWidth);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the width of the entire lightweight polyline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLWPolyline", typeof(object))]
	[NodeInput("Width", typeof(System.Double))]

	///<summary>
	///Specifies or returns the width of the entire lightweight polyline.
	///</summary>
	public class Set_ConstantWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ConstantWidth = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Creates a new lightweight polyline at a specified distance from an original lightweight polyline.", 
		ViewType = "Data")]
	[NodeInput("AcadLWPolyline", typeof(object))]
	[NodeInput("Distance", typeof(System.Double))]

	///<summary>
	///Not implemented. Creates a new lightweight polyline at a specified distance from an original lightweight polyline.
	///</summary>
	public class Offset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Offset(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the elevation of the lightweight polyline relative to the z-axis of the object's coordinate system.", 
		ViewType = "Data")]
	[NodeInput("AcadLWPolyline", typeof(object))]

	///<summary>
	///Specifies or returns the elevation of the lightweight polyline relative to the z-axis of the object's coordinate system.
	///</summary>
	public class Elevation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Elevation);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the elevation of the lightweight polyline relative to the z-axis of the object's coordinate system.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLWPolyline", typeof(object))]
	[NodeInput("Elevation", typeof(System.Double))]

	///<summary>
	///Specifies or returns the elevation of the lightweight polyline relative to the z-axis of the object's coordinate system.
	///</summary>
	public class Set_Elevation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Elevation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the area encompassed by a lightweight polyline.", 
		ViewType = "Data")]
	[NodeInput("AcadLWPolyline", typeof(object))]

	///<summary>
	///Returns the area encompassed by a lightweight polyline.
	///</summary>
	public class Area : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Area);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the coordinate of a single vertex in an object.", 
		ViewType = "Data")]
	[NodeInput("AcadLWPolyline", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]

	///<summary>
	///Specifies or returns the coordinate of a single vertex in an object.
	///</summary>
	public class Coordinate : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Coordinate(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the coordinate of a single vertex in an object.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLWPolyline", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the coordinate of a single vertex in an object.
	///</summary>
	public class Set_Coordinate : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Coordinate[inputs[1]] = inputs[2];
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a lightweight polyline is open or closed.", 
		ViewType = "Data")]
	[NodeInput("AcadLWPolyline", typeof(object))]

	///<summary>
	///Specifies or returns whether a lightweight polyline is open or closed.
	///</summary>
	public class Closed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Closed);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a lightweight polyline is open or closed.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLWPolyline", typeof(object))]
	[NodeInput("fClose", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether a lightweight polyline is open or closed.
	///</summary>
	public class Set_Closed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Closed = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether linetype generation is used for a lightweight polyline.", 
		ViewType = "Data")]
	[NodeInput("AcadLWPolyline", typeof(object))]

	///<summary>
	///Specifies or returns whether linetype generation is used for a lightweight polyline.
	///</summary>
	public class LinetypeGeneration : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LinetypeGeneration);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether linetype generation is used for a lightweight polyline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLWPolyline", typeof(object))]
	[NodeInput("bLinetypeGen", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether linetype generation is used for a lightweight polyline.
	///</summary>
	public class Set_LinetypeGeneration : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LinetypeGeneration = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the length of a lightweight polyline.", 
		ViewType = "Data")]
	[NodeInput("AcadLWPolyline", typeof(object))]

	///<summary>
	///Specifies the length of a lightweight polyline.
	///</summary>
	public class Length : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Length);

		}
	}
}
