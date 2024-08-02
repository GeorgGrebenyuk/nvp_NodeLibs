using NVP.API.Nodes;

namespace Renga.Grid 
{
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


		///<summary>
		///
		///</summary>
		[NodeInput("Grid", typeof(object))]
		public class TriangleCount : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TriangleCount);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Grid", typeof(object))]
		[NodeInput("index", typeof(System.Int32))]
		public class GetTriangle : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetTriangle(inputs[1]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Grid", typeof(object))]
		public class VertexCount : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.VertexCount);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Grid", typeof(object))]
		[NodeInput("index", typeof(System.Int32))]
		public class GetVertex : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetVertex(inputs[1]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Grid", typeof(object))]
		public class NormalCount : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.NormalCount);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Grid", typeof(object))]
		[NodeInput("index", typeof(System.Int32))]
		public class GetNormal : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetNormal(inputs[1]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Grid", typeof(object))]
		public class TextureCoordinateCount : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TextureCoordinateCount);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Grid", typeof(object))]
		[NodeInput("index", typeof(System.Int32))]
		public class GetTextureCoordinate : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetTextureCoordinate(inputs[1]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Grid", typeof(object))]
		public class GridType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GridType);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Grid", typeof(object))]
		public class DoubleSided : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.DoubleSided);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Grid", typeof(object))]
		[NodeInput("index", typeof(System.Int32))]
		[NodeInput("int*", typeof(System.Object))]
		[NodeInput("int*", typeof(System.Object))]
		[NodeInput("int*", typeof(System.Object))]
		public class GetTriangleComponents : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.GetTriangleComponents(inputs[1],inputs[2],inputs[3],inputs[4]);
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Grid", typeof(object))]
		[NodeInput("index", typeof(System.Int32))]
		[NodeInput("pX", typeof(System.Object))]
		[NodeInput("pY", typeof(System.Object))]
		[NodeInput("pZ", typeof(System.Object))]
		public class GetVertexComponents : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.GetVertexComponents(inputs[1],inputs[2],inputs[3],inputs[4]);
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Grid", typeof(object))]
		[NodeInput("index", typeof(System.Int32))]
		[NodeInput("pX", typeof(System.Object))]
		[NodeInput("pY", typeof(System.Object))]
		[NodeInput("pZ", typeof(System.Object))]
		public class GetNormalComponents : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.GetNormalComponents(inputs[1],inputs[2],inputs[3],inputs[4]);
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Grid", typeof(object))]
		[NodeInput("index", typeof(System.Int32))]
		[NodeInput("pX", typeof(System.Object))]
		[NodeInput("pY", typeof(System.Object))]
		public class GetTextureCoordinateComponents : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.GetTextureCoordinateComponents(inputs[1],inputs[2],inputs[3]);
				return null;
			}
		}
}
