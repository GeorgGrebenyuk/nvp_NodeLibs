using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace NVP_Renga_COM._Renga.Grid 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Grid_Constructor : INode 
	{
		public Renga.IGrid _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IGrid;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Grid_ConstructorCast : INode 
	{
		public Renga.IGrid _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IGrid;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Grid", typeof(object))]

	///<summary>
	///
	///</summary>
	public class TriangleCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TriangleCount);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Grid", typeof(object))]
	[NodeInput("index", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class GetTriangle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetTriangle(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Grid", typeof(object))]

	///<summary>
	///
	///</summary>
	public class VertexCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VertexCount);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Grid", typeof(object))]
	[NodeInput("index", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class GetVertex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetVertex(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Grid", typeof(object))]

	///<summary>
	///
	///</summary>
	public class NormalCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NormalCount);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Grid", typeof(object))]
	[NodeInput("index", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class GetNormal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetNormal(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Grid", typeof(object))]

	///<summary>
	///
	///</summary>
	public class TextureCoordinateCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextureCoordinateCount);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Grid", typeof(object))]
	[NodeInput("index", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class GetTextureCoordinate : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetTextureCoordinate(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Grid", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GridType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GridType);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Grid", typeof(object))]

	///<summary>
	///
	///</summary>
	public class DoubleSided : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleSided);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("Grid", typeof(object))]
	[NodeInput("index", typeof(System.Int32))]
	[NodeInput("int*", typeof(System.Object))]
	[NodeInput("int*", typeof(System.Object))]
	[NodeInput("int*", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class GetTriangleComponents : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetTriangleComponents(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("Grid", typeof(object))]
	[NodeInput("index", typeof(System.Int32))]
	[NodeInput("pX", typeof(System.Object))]
	[NodeInput("pY", typeof(System.Object))]
	[NodeInput("pZ", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class GetVertexComponents : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetVertexComponents(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("Grid", typeof(object))]
	[NodeInput("index", typeof(System.Int32))]
	[NodeInput("pX", typeof(System.Object))]
	[NodeInput("pY", typeof(System.Object))]
	[NodeInput("pZ", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class GetNormalComponents : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetNormalComponents(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("Grid", typeof(object))]
	[NodeInput("index", typeof(System.Int32))]
	[NodeInput("pX", typeof(System.Object))]
	[NodeInput("pY", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class GetTextureCoordinateComponents : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetTextureCoordinateComponents(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}
}
