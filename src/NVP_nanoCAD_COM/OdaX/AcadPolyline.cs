using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a 2D line of adjustable width or a 3D line or mesh of nonadjustable width composed of line and arc segments
///</summary>
namespace NVP_nanoCAD_COM._OdaX.AcadPolyline 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadPolyline_Constructor : INode 
	{
		public OdaX.IAcadPolyline _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadPolyline;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadPolyline_ConstructorCast : INode 
	{
		public OdaX.IAcadPolyline _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadPolyline;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the current vertex of a polyline.", 
		ViewType = "Data")]
	[NodeInput("AcadPolyline", typeof(object))]

	///<summary>
	///Specifies or returns the current vertex of a polyline.
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
		Text = "Specifies or returns the current vertex of a polyline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPolyline", typeof(object))]
	[NodeInput("Coordinates", typeof(System.Object))]

	///<summary>
	///Specifies or returns the current vertex of a polyline.
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
	[NodeInput("AcadPolyline", typeof(object))]

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
	[NodeInput("AcadPolyline", typeof(object))]
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
		Text = "z-direction value) of a polyline.", 
		ViewType = "Data")]
	[NodeInput("AcadPolyline", typeof(object))]

	///<summary>
	///z-direction value) of a polyline.
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
		Text = "z-direction value) of a polyline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPolyline", typeof(object))]
	[NodeInput("Thickness", typeof(System.Double))]

	///<summary>
	///z-direction value) of a polyline.
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
		Text = "Appends a new vertex to a polyline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPolyline", typeof(object))]
	[NodeInput("vertex", typeof(System.Object))]

	///<summary>
	///Appends a new vertex to a polyline.
	///</summary>
	public class AppendVertex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AppendVertex(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Explodes the polyline and returns the individual entities as an array of the object.", 
		ViewType = "Data")]
	[NodeInput("AcadPolyline", typeof(object))]

	///<summary>
	///Explodes the polyline and returns the individual entities as an array of the object.
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
		Text = "Returns the bulge value for a vertex of a polyline.", 
		ViewType = "Data")]
	[NodeInput("AcadPolyline", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]

	///<summary>
	///Returns the bulge value for a vertex of a polyline.
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
		Text = "Specifies the bulge value for a vertex of a polyline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPolyline", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("bulge", typeof(System.Double))]

	///<summary>
	///Specifies the bulge value for a vertex of a polyline.
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
		Text = "Returns the width for a segment of a polyline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPolyline", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("StartWidth", typeof(System.Double))]

	///<summary>
	///Returns the width for a segment of a polyline.
	///</summary>
	public class GetWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetWidth(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the width for a segment of a polyline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPolyline", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("StartWidth", typeof(System.Double))]

	///<summary>
	///Specifies the width for a segment of a polyline.
	///</summary>
	public class SetWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetWidth(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the width of the entire polyline.", 
		ViewType = "Data")]
	[NodeInput("AcadPolyline", typeof(object))]

	///<summary>
	///Specifies or returns the width of the entire polyline.
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
		Text = "Specifies or returns the width of the entire polyline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPolyline", typeof(object))]
	[NodeInput("Width", typeof(System.Double))]

	///<summary>
	///Specifies or returns the width of the entire polyline.
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
		Text = "Not implemented. Creates a new polyline at a specified distance from an original lightweight polyline.", 
		ViewType = "Data")]
	[NodeInput("AcadPolyline", typeof(object))]
	[NodeInput("Distance", typeof(System.Double))]

	///<summary>
	///Not implemented. Creates a new polyline at a specified distance from an original lightweight polyline.
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
		Text = "Specifies or returns the elevation of the polyline relative to the z-axis of the object's coordinate system.", 
		ViewType = "Data")]
	[NodeInput("AcadPolyline", typeof(object))]

	///<summary>
	///Specifies or returns the elevation of the polyline relative to the z-axis of the object's coordinate system.
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
		Text = "Specifies or returns the elevation of the polyline relative to the z-axis of the object's coordinate system.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPolyline", typeof(object))]
	[NodeInput("Elevation", typeof(System.Double))]

	///<summary>
	///Specifies or returns the elevation of the polyline relative to the z-axis of the object's coordinate system.
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
		Text = "Specifies or returns the type of polyline.", 
		ViewType = "Data")]
	[NodeInput("AcadPolyline", typeof(object))]

	///<summary>
	///Specifies or returns the type of polyline.
	///</summary>
	public class Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Type);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the type of polyline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPolyline", typeof(object))]
	[NodeInput("OdaX.AcPolylineType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the type of polyline.
	///</summary>
	public class Set_Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Type = ((OdaX.AcPolylineType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a polyline is open or closed.", 
		ViewType = "Data")]
	[NodeInput("AcadPolyline", typeof(object))]

	///<summary>
	///Specifies or returns whether a polyline is open or closed.
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
		Text = "Specifies or returns whether a polyline is open or closed.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPolyline", typeof(object))]
	[NodeInput("fClose", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether a polyline is open or closed.
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
		Text = "Specifies or returns whether linetype generation is used for a polyline.", 
		ViewType = "Data")]
	[NodeInput("AcadPolyline", typeof(object))]

	///<summary>
	///Specifies or returns whether linetype generation is used for a polyline.
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
		Text = "Specifies or returns whether linetype generation is used for a polyline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPolyline", typeof(object))]
	[NodeInput("bLinetypeGen", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether linetype generation is used for a polyline.
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
		Text = "Specifies the area of a polyline.", 
		ViewType = "Data")]
	[NodeInput("AcadPolyline", typeof(object))]

	///<summary>
	///Specifies the area of a polyline.
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
	[NodeInput("AcadPolyline", typeof(object))]
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
	[NodeInput("AcadPolyline", typeof(object))]
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
		Text = "Specifies the length of a polyline.", 
		ViewType = "Data")]
	[NodeInput("AcadPolyline", typeof(object))]

	///<summary>
	///Specifies the length of a polyline.
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
