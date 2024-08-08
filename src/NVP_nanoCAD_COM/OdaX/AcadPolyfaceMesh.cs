using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a three-dimensional polyface mesh
///</summary>
namespace OdaX.AcadPolyfaceMesh 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadPolyfaceMesh_Constructor : INode 
	{
		public OdaX.IAcadPolyfaceMesh _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadPolyfaceMesh;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadPolyfaceMesh_ConstructorCast : INode 
	{
		public OdaX.IAcadPolyfaceMesh _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadPolyfaceMesh;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the vertices of a polyface mesh.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPolyfaceMesh", typeof(object))]
	[NodeInput("Vertices", typeof(System.Object))]

	///<summary>
	///Specifies or returns the vertices of a polyface mesh.
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
		Text = "Specifies or returns the vertices of a polyface mesh.", 
		ViewType = "Data")]
	[NodeInput("AcadPolyfaceMesh", typeof(object))]

	///<summary>
	///Specifies or returns the vertices of a polyface mesh.
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
		Text = "Specifies or returns the coordinate of a single vertex in a polyface mesh.", 
		ViewType = "Data")]
	[NodeInput("AcadPolyfaceMesh", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]

	///<summary>
	///Specifies or returns the coordinate of a single vertex in a polyface mesh.
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
		Text = "Specifies or returns the coordinate of a single vertex in a polyface mesh.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPolyfaceMesh", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the coordinate of a single vertex in a polyface mesh.
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
		Text = "Returns the number of vertices in a polyface mesh.", 
		ViewType = "Data")]
	[NodeInput("AcadPolyfaceMesh", typeof(object))]

	///<summary>
	///Returns the number of vertices in a polyface mesh.
	///</summary>
	public class NumberOfVertices : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NumberOfVertices);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the number of faces in a polyface mesh.", 
		ViewType = "Data")]
	[NodeInput("AcadPolyfaceMesh", typeof(object))]

	///<summary>
	///Specifies the number of faces in a polyface mesh.
	///</summary>
	public class NumberOfFaces : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NumberOfFaces);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("AcadPolyfaceMesh", typeof(object))]
	[NodeInput("rhs", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_Faces : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Faces = inputs[1].Value;
			return null;
		}
	}
}
