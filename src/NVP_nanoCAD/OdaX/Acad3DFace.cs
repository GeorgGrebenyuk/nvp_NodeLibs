using NVP.API.Nodes;

namespace OdaX.Acad3DFace 
{
	[NodeInput("dynamic", typeof(object))]
	public class Acad3DFace_Constructor : INode 
	{
		public OdaX.IAcad3DFace _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcad3DFace;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class Acad3DFace_ConstructorCast : INode 
	{
		public OdaX.IAcad3DFace _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcad3DFace;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///Specifies the current vertex of a 3DFace object.
	///</summary>
	[NodeInput("Acad3DFace", typeof(object))]
	public class Coordinates : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Coordinates);

		}
	}


	///<summary>
	///Specifies the current vertex of a 3DFace object.
	///</summary>
	[NodeInput("Acad3DFace", typeof(object))]
	[NodeInput("corners", typeof(System.Object))]
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
	///Specifies or returns whether edge 1 of a 3DFace is visible or hidden.
	///</summary>
	[NodeInput("Acad3DFace", typeof(object))]
	public class VisibilityEdge1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VisibilityEdge1);

		}
	}


	///<summary>
	///Specifies or returns whether edge 1 of a 3DFace is visible or hidden.
	///</summary>
	[NodeInput("Acad3DFace", typeof(object))]
	[NodeInput("visibility", typeof(System.Object))]
	public class Set_VisibilityEdge1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.VisibilityEdge1 = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether edge 2 of a 3DFace is visible or hidden.
	///</summary>
	[NodeInput("Acad3DFace", typeof(object))]
	public class VisibilityEdge2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VisibilityEdge2);

		}
	}


	///<summary>
	///Specifies or returns whether edge 2 of a 3DFace is visible or hidden.
	///</summary>
	[NodeInput("Acad3DFace", typeof(object))]
	[NodeInput("visibility", typeof(System.Object))]
	public class Set_VisibilityEdge2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.VisibilityEdge2 = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether edge 3 of a 3DFace is visible or hidden.
	///</summary>
	[NodeInput("Acad3DFace", typeof(object))]
	public class VisibilityEdge3 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VisibilityEdge3);

		}
	}


	///<summary>
	///Specifies or returns whether edge 3 of a 3DFace is visible or hidden.
	///</summary>
	[NodeInput("Acad3DFace", typeof(object))]
	[NodeInput("visibility", typeof(System.Object))]
	public class Set_VisibilityEdge3 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.VisibilityEdge3 = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether edge 4 of a 3DFace is visible or hidden.
	///</summary>
	[NodeInput("Acad3DFace", typeof(object))]
	public class VisibilityEdge4 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VisibilityEdge4);

		}
	}


	///<summary>
	///Specifies or returns whether edge 4 of a 3DFace is visible or hidden.
	///</summary>
	[NodeInput("Acad3DFace", typeof(object))]
	[NodeInput("visibility", typeof(System.Object))]
	public class Set_VisibilityEdge4 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.VisibilityEdge4 = inputs[1];
			return null;
		}
	}


	///<summary>
	///Returns the visibility status of a 3DFace edge.
	///</summary>
	[NodeInput("Acad3DFace", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	public class GetInvisibleEdge : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetInvisibleEdge(inputs[1]));

		}
	}


	///<summary>
	///Specifies the visibility status of a 3DFace edge.
	///</summary>
	[NodeInput("Acad3DFace", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("State", typeof(System.Object))]
	public class SetInvisibleEdge : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetInvisibleEdge(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Specifies the coordinate of a single vertex in an object.
	///</summary>
	[NodeInput("Acad3DFace", typeof(object))]
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
	///Specifies the coordinate of a single vertex in an object.
	///</summary>
	[NodeInput("Acad3DFace", typeof(object))]
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
