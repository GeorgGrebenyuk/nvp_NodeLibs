using NVP.API.Nodes;

namespace OdaX.AcadPolygonMesh 
{
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


	///<summary>
	///Specifies or returns the coordinates of a polygon mesh.
	///</summary>
	[NodeInput("AcadPolygonMesh", typeof(object))]
	public class Coordinates : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Coordinates);

		}
	}


	///<summary>
	///Specifies or returns the coordinates of a polygon mesh.
	///</summary>
	[NodeInput("AcadPolygonMesh", typeof(object))]
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
	///Specifies or returns whether the mesh is open or closed in the M direction.
	///</summary>
	[NodeInput("AcadPolygonMesh", typeof(object))]
	public class MClose : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MClose);

		}
	}


	///<summary>
	///Specifies or returns whether the mesh is open or closed in the M direction.
	///</summary>
	[NodeInput("AcadPolygonMesh", typeof(object))]
	[NodeInput("bClose", typeof(System.Object))]
	public class Set_MClose : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MClose = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether the mesh is open or closed in the N direction.
	///</summary>
	[NodeInput("AcadPolygonMesh", typeof(object))]
	public class NClose : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NClose);

		}
	}


	///<summary>
	///Specifies or returns whether the mesh is open or closed in the N direction.
	///</summary>
	[NodeInput("AcadPolygonMesh", typeof(object))]
	[NodeInput("bClose", typeof(System.Object))]
	public class Set_NClose : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.NClose = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the density of a polygon mesh in the M direction.
	///</summary>
	[NodeInput("AcadPolygonMesh", typeof(object))]
	public class MDensity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MDensity);

		}
	}


	///<summary>
	///Specifies or returns the density of a polygon mesh in the M direction.
	///</summary>
	[NodeInput("AcadPolygonMesh", typeof(object))]
	[NodeInput("density", typeof(System.Object))]
	public class Set_MDensity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MDensity = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the density of a polygon mesh in the N direction
	///</summary>
	[NodeInput("AcadPolygonMesh", typeof(object))]
	public class NDensity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NDensity);

		}
	}


	///<summary>
	///Specifies or returns the density of a polygon mesh in the N direction
	///</summary>
	[NodeInput("AcadPolygonMesh", typeof(object))]
	[NodeInput("density", typeof(System.Object))]
	public class Set_NDensity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.NDensity = inputs[1];
			return null;
		}
	}


	///<summary>
	///Returns the number of verticies in the M direction of a polygon mesh.
	///</summary>
	[NodeInput("AcadPolygonMesh", typeof(object))]
	public class MVertexCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MVertexCount);

		}
	}


	///<summary>
	///Returns the number of verticies in the N direction of a polygon mesh.
	///</summary>
	[NodeInput("AcadPolygonMesh", typeof(object))]
	public class NVertexCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NVertexCount);

		}
	}


	///<summary>
	///Specifies or returns the type of a polygon mesh.
	///</summary>
	[NodeInput("AcadPolygonMesh", typeof(object))]
	public class Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Type);

		}
	}


	///<summary>
	///Specifies or returns the type of a polygon mesh.
	///</summary>
	[NodeInput("AcadPolygonMesh", typeof(object))]
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
	///Appends a new vertex to a polygon mesh.
	///</summary>
	[NodeInput("AcadPolygonMesh", typeof(object))]
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
	///Explodes the polygon mesh and returns the individual entities as an array of the object.
	///</summary>
	[NodeInput("AcadPolygonMesh", typeof(object))]
	public class Explode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Explode);

		}
	}


	///<summary>
	///Specifies or returns the coordinate of a single vertex in a polygon mesh.
	///</summary>
	[NodeInput("AcadPolygonMesh", typeof(object))]
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
	///Specifies or returns the coordinate of a single vertex in a polygon mesh.
	///</summary>
	[NodeInput("AcadPolygonMesh", typeof(object))]
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
}
