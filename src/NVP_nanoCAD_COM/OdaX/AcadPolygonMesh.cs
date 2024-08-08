using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a free-form 3D mesh entity
///</summary>
namespace OdaX.AcadPolygonMesh 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadPolygonMesh_Constructor : INode 
	{
		public OdaX.IAcadPolygonMesh _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadPolygonMesh;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadPolygonMesh_ConstructorCast : INode 
	{
		public OdaX.IAcadPolygonMesh _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadPolygonMesh;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the coordinates of a polygon mesh.", 
		ViewType = "Data")]
	[NodeInput("AcadPolygonMesh", typeof(object))]

	///<summary>
	///Specifies or returns the coordinates of a polygon mesh.
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
		Text = "Specifies or returns the coordinates of a polygon mesh.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPolygonMesh", typeof(object))]
	[NodeInput("Coordinates", typeof(System.Object))]

	///<summary>
	///Specifies or returns the coordinates of a polygon mesh.
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
		Text = "Specifies or returns whether the mesh is open or closed in the M direction.", 
		ViewType = "Data")]
	[NodeInput("AcadPolygonMesh", typeof(object))]

	///<summary>
	///Specifies or returns whether the mesh is open or closed in the M direction.
	///</summary>
	public class MClose : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MClose);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the mesh is open or closed in the M direction.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPolygonMesh", typeof(object))]
	[NodeInput("bClose", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the mesh is open or closed in the M direction.
	///</summary>
	public class Set_MClose : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MClose = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the mesh is open or closed in the N direction.", 
		ViewType = "Data")]
	[NodeInput("AcadPolygonMesh", typeof(object))]

	///<summary>
	///Specifies or returns whether the mesh is open or closed in the N direction.
	///</summary>
	public class NClose : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NClose);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the mesh is open or closed in the N direction.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPolygonMesh", typeof(object))]
	[NodeInput("bClose", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the mesh is open or closed in the N direction.
	///</summary>
	public class Set_NClose : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.NClose = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the density of a polygon mesh in the M direction.", 
		ViewType = "Data")]
	[NodeInput("AcadPolygonMesh", typeof(object))]

	///<summary>
	///Specifies or returns the density of a polygon mesh in the M direction.
	///</summary>
	public class MDensity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MDensity);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the density of a polygon mesh in the M direction.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPolygonMesh", typeof(object))]
	[NodeInput("density", typeof(System.Object))]

	///<summary>
	///Specifies or returns the density of a polygon mesh in the M direction.
	///</summary>
	public class Set_MDensity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MDensity = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the density of a polygon mesh in the N direction", 
		ViewType = "Data")]
	[NodeInput("AcadPolygonMesh", typeof(object))]

	///<summary>
	///Specifies or returns the density of a polygon mesh in the N direction
	///</summary>
	public class NDensity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NDensity);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the density of a polygon mesh in the N direction", 
		ViewType = "Modifier")]
	[NodeInput("AcadPolygonMesh", typeof(object))]
	[NodeInput("density", typeof(System.Object))]

	///<summary>
	///Specifies or returns the density of a polygon mesh in the N direction
	///</summary>
	public class Set_NDensity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.NDensity = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the number of verticies in the M direction of a polygon mesh.", 
		ViewType = "Data")]
	[NodeInput("AcadPolygonMesh", typeof(object))]

	///<summary>
	///Returns the number of verticies in the M direction of a polygon mesh.
	///</summary>
	public class MVertexCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MVertexCount);

		}
	}


	[NVP_Manifest(
		Text = "Returns the number of verticies in the N direction of a polygon mesh.", 
		ViewType = "Data")]
	[NodeInput("AcadPolygonMesh", typeof(object))]

	///<summary>
	///Returns the number of verticies in the N direction of a polygon mesh.
	///</summary>
	public class NVertexCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NVertexCount);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the type of a polygon mesh.", 
		ViewType = "Data")]
	[NodeInput("AcadPolygonMesh", typeof(object))]

	///<summary>
	///Specifies or returns the type of a polygon mesh.
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
		Text = "Specifies or returns the type of a polygon mesh.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPolygonMesh", typeof(object))]
	[NodeInput("OdaX.AcPolymeshType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the type of a polygon mesh.
	///</summary>
	public class Set_Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Type = ((OdaX.AcPolymeshType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Appends a new vertex to a polygon mesh.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPolygonMesh", typeof(object))]
	[NodeInput("vertex", typeof(System.Object))]

	///<summary>
	///Appends a new vertex to a polygon mesh.
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
		Text = "Explodes the polygon mesh and returns the individual entities as an array of the object.", 
		ViewType = "Data")]
	[NodeInput("AcadPolygonMesh", typeof(object))]

	///<summary>
	///Explodes the polygon mesh and returns the individual entities as an array of the object.
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
		Text = "Specifies or returns the coordinate of a single vertex in a polygon mesh.", 
		ViewType = "Data")]
	[NodeInput("AcadPolygonMesh", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]

	///<summary>
	///Specifies or returns the coordinate of a single vertex in a polygon mesh.
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
		Text = "Specifies or returns the coordinate of a single vertex in a polygon mesh.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPolygonMesh", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the coordinate of a single vertex in a polygon mesh.
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
}
