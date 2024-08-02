using NVP.API.Nodes;

namespace OdaX.AcadSolid 
{
		[NodeInput("dynamic", typeof(object))]
		public class AcadSolid_Constructor : INode 
		{
		public OdaX.IAcadSolid _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IAcadSolid;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class AcadSolid_ConstructorCast : INode 
		{
		public OdaX.IAcadSolid _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IAcadSolid;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Specifies or returns the current vertex of a solid.
		///</summary>
		[NodeInput("AcadSolid", typeof(object))]
		public class Coordinates : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Coordinates);

			}
		}


		///<summary>
		///Specifies or returns the current vertex of a solid.
		///</summary>
		[NodeInput("AcadSolid", typeof(object))]
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
		///Specifies or returns the x, y, and z coordinates of the normal direction vector.
		///</summary>
		[NodeInput("AcadSolid", typeof(object))]
		public class Normal : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Normal);

			}
		}


		///<summary>
		///Specifies or returns the x, y, and z coordinates of the normal direction vector.
		///</summary>
		[NodeInput("AcadSolid", typeof(object))]
		[NodeInput("Normal", typeof(System.Object))]
		public class Set_Normal : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Normal = inputs[1];
				return null;
			}
		}


		///<summary>
		///z-direction value) of a solid.
		///</summary>
		[NodeInput("AcadSolid", typeof(object))]
		public class Thickness : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Thickness);

			}
		}


		///<summary>
		///z-direction value) of a solid.
		///</summary>
		[NodeInput("AcadSolid", typeof(object))]
		[NodeInput("Thickness", typeof(System.Double))]
		public class Set_Thickness : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Thickness = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the coordinates of a single vertex in a solid.
		///</summary>
		[NodeInput("AcadSolid", typeof(object))]
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
		///Specifies or returns the coordinates of a single vertex in a solid.
		///</summary>
		[NodeInput("AcadSolid", typeof(object))]
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
