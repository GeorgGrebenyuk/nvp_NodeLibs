using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a 3D polyline of straight line segments entity
///</summary>
namespace NVP_nanoCAD_COM._OdaX.Acad3DPolyline 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
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

	[NVP_Manifest(
		ViewType = "Modifier")]
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


	[NVP_Manifest(
		Text = "Specifies or returns the current vertex of a 3D polyline.", 
		ViewType = "Data")]
	[NodeInput("Acad3DPolyline", typeof(object))]

	///<summary>
	///Specifies or returns the current vertex of a 3D polyline.
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
		Text = "Specifies or returns the current vertex of a 3D polyline.", 
		ViewType = "Modifier")]
	[NodeInput("Acad3DPolyline", typeof(object))]
	[NodeInput("Coordinates", typeof(System.Object))]

	///<summary>
	///Specifies or returns the current vertex of a 3D polyline.
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
		Text = "Appends a vertex to a 3D polyline.", 
		ViewType = "Modifier")]
	[NodeInput("Acad3DPolyline", typeof(object))]
	[NodeInput("vertex", typeof(System.Object))]

	///<summary>
	///Appends a vertex to a 3D polyline.
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
		Text = "Explodes a 3D polyline.", 
		ViewType = "Data")]
	[NodeInput("Acad3DPolyline", typeof(object))]

	///<summary>
	///Explodes a 3D polyline.
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
		Text = "Specifies or returns the coordinate of a single vertex in an object.", 
		ViewType = "Data")]
	[NodeInput("Acad3DPolyline", typeof(object))]
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
	[NodeInput("Acad3DPolyline", typeof(object))]
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
		Text = "Specifies or returns the type of line or surface curve fitting.", 
		ViewType = "Data")]
	[NodeInput("Acad3DPolyline", typeof(object))]

	///<summary>
	///Specifies or returns the type of line or surface curve fitting.
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
		Text = "Specifies or returns the type of line or surface curve fitting.", 
		ViewType = "Modifier")]
	[NodeInput("Acad3DPolyline", typeof(object))]
	[NodeInput("OdaX.Ac3DPolylineType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the type of line or surface curve fitting.
	///</summary>
	public class Set_Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Type = ((OdaX.Ac3DPolylineType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a 3D polyline is open or closed.", 
		ViewType = "Data")]
	[NodeInput("Acad3DPolyline", typeof(object))]

	///<summary>
	///Specifies or returns whether a 3D polyline is open or closed.
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
		Text = "Specifies or returns whether a 3D polyline is open or closed.", 
		ViewType = "Modifier")]
	[NodeInput("Acad3DPolyline", typeof(object))]
	[NodeInput("fClose", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether a 3D polyline is open or closed.
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
		Text = "Returns the length of a 3D polyline.", 
		ViewType = "Data")]
	[NodeInput("Acad3DPolyline", typeof(object))]

	///<summary>
	///Returns the length of a 3D polyline.
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
