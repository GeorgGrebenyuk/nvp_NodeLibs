using NVP.API.Nodes;

namespace OdaX.AcadPolyfaceMesh 
{
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


		///<summary>
		///Specifies or returns the vertices of a polyface mesh.
		///</summary>
		[NodeInput("AcadPolyfaceMesh", typeof(object))]
		[NodeInput("Vertices", typeof(System.Object))]
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
		///Specifies or returns the vertices of a polyface mesh.
		///</summary>
		[NodeInput("AcadPolyfaceMesh", typeof(object))]
		public class Coordinates : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Coordinates);

			}
		}


		///<summary>
		///Specifies or returns the coordinate of a single vertex in a polyface mesh.
		///</summary>
		[NodeInput("AcadPolyfaceMesh", typeof(object))]
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
		///Specifies or returns the coordinate of a single vertex in a polyface mesh.
		///</summary>
		[NodeInput("AcadPolyfaceMesh", typeof(object))]
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


		///<summary>
		///Returns the number of vertices in a polyface mesh.
		///</summary>
		[NodeInput("AcadPolyfaceMesh", typeof(object))]
		public class NumberOfVertices : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.NumberOfVertices);

			}
		}


		///<summary>
		///Specifies the number of faces in a polyface mesh.
		///</summary>
		[NodeInput("AcadPolyfaceMesh", typeof(object))]
		public class NumberOfFaces : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.NumberOfFaces);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("AcadPolyfaceMesh", typeof(object))]
		[NodeInput("rhs", typeof(System.Object))]
		public class Set_Faces : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Faces = inputs[1];
				return null;
			}
		}
}
