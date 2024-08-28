using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a 3D triangle or quadrilateral plane section
///</summary>
namespace NVP_nanoCAD_COM._OdaX.Acad3DFace 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
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

	[NVP_Manifest(
		ViewType = "Modifier")]
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


	[NVP_Manifest(
		Text = "Specifies the current vertex of a 3DFace object.", 
		ViewType = "Data")]
	[NodeInput("Acad3DFace", typeof(object))]

	///<summary>
	///Specifies the current vertex of a 3DFace object.
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
		Text = "Specifies the current vertex of a 3DFace object.", 
		ViewType = "Modifier")]
	[NodeInput("Acad3DFace", typeof(object))]
	[NodeInput("corners", typeof(System.Object))]

	///<summary>
	///Specifies the current vertex of a 3DFace object.
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
		Text = "Specifies or returns whether edge 1 of a 3DFace is visible or hidden.", 
		ViewType = "Data")]
	[NodeInput("Acad3DFace", typeof(object))]

	///<summary>
	///Specifies or returns whether edge 1 of a 3DFace is visible or hidden.
	///</summary>
	public class VisibilityEdge1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VisibilityEdge1);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether edge 1 of a 3DFace is visible or hidden.", 
		ViewType = "Modifier")]
	[NodeInput("Acad3DFace", typeof(object))]
	[NodeInput("visibility", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether edge 1 of a 3DFace is visible or hidden.
	///</summary>
	public class Set_VisibilityEdge1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.VisibilityEdge1 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether edge 2 of a 3DFace is visible or hidden.", 
		ViewType = "Data")]
	[NodeInput("Acad3DFace", typeof(object))]

	///<summary>
	///Specifies or returns whether edge 2 of a 3DFace is visible or hidden.
	///</summary>
	public class VisibilityEdge2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VisibilityEdge2);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether edge 2 of a 3DFace is visible or hidden.", 
		ViewType = "Modifier")]
	[NodeInput("Acad3DFace", typeof(object))]
	[NodeInput("visibility", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether edge 2 of a 3DFace is visible or hidden.
	///</summary>
	public class Set_VisibilityEdge2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.VisibilityEdge2 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether edge 3 of a 3DFace is visible or hidden.", 
		ViewType = "Data")]
	[NodeInput("Acad3DFace", typeof(object))]

	///<summary>
	///Specifies or returns whether edge 3 of a 3DFace is visible or hidden.
	///</summary>
	public class VisibilityEdge3 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VisibilityEdge3);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether edge 3 of a 3DFace is visible or hidden.", 
		ViewType = "Modifier")]
	[NodeInput("Acad3DFace", typeof(object))]
	[NodeInput("visibility", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether edge 3 of a 3DFace is visible or hidden.
	///</summary>
	public class Set_VisibilityEdge3 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.VisibilityEdge3 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether edge 4 of a 3DFace is visible or hidden.", 
		ViewType = "Data")]
	[NodeInput("Acad3DFace", typeof(object))]

	///<summary>
	///Specifies or returns whether edge 4 of a 3DFace is visible or hidden.
	///</summary>
	public class VisibilityEdge4 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VisibilityEdge4);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether edge 4 of a 3DFace is visible or hidden.", 
		ViewType = "Modifier")]
	[NodeInput("Acad3DFace", typeof(object))]
	[NodeInput("visibility", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether edge 4 of a 3DFace is visible or hidden.
	///</summary>
	public class Set_VisibilityEdge4 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.VisibilityEdge4 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the visibility status of a 3DFace edge.", 
		ViewType = "Data")]
	[NodeInput("Acad3DFace", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]

	///<summary>
	///Returns the visibility status of a 3DFace edge.
	///</summary>
	public class GetInvisibleEdge : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetInvisibleEdge(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Specifies the visibility status of a 3DFace edge.", 
		ViewType = "Modifier")]
	[NodeInput("Acad3DFace", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("State", typeof(System.Object))]

	///<summary>
	///Specifies the visibility status of a 3DFace edge.
	///</summary>
	public class SetInvisibleEdge : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetInvisibleEdge(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the coordinate of a single vertex in an object.", 
		ViewType = "Data")]
	[NodeInput("Acad3DFace", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]

	///<summary>
	///Specifies the coordinate of a single vertex in an object.
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
		Text = "Specifies the coordinate of a single vertex in an object.", 
		ViewType = "Modifier")]
	[NodeInput("Acad3DFace", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies the coordinate of a single vertex in an object.
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
