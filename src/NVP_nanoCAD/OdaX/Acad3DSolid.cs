using NVP.API.Nodes;

namespace OdaX.Acad3DSolid 
{
		[NodeInput("dynamic", typeof(object))]
		public class Acad3DSolid_Constructor : INode 
		{
		public OdaX.IAcad3DSolid _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IAcad3DSolid;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class Acad3DSolid_ConstructorCast : INode 
		{
		public OdaX.IAcad3DSolid _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IAcad3DSolid;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Not implemented. Returns the center of the area or mass for a 3D solid or region.
		///</summary>
		[NodeInput("Acad3DSolid", typeof(object))]
		public class Centroid : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Centroid);

			}
		}


		///<summary>
		///Not implemented. Returns the moment of inertia for a 3D solid.
		///</summary>
		[NodeInput("Acad3DSolid", typeof(object))]
		public class MomentOfInertia : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.MomentOfInertia);

			}
		}


		///<summary>
		///Not implemented. Returns the principal directions of a 3D solid or region.
		///</summary>
		[NodeInput("Acad3DSolid", typeof(object))]
		public class PrincipalDirections : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.PrincipalDirections);

			}
		}


		///<summary>
		///Not implemented. Returns the principal moments of a 3D solid or region.
		///</summary>
		[NodeInput("Acad3DSolid", typeof(object))]
		public class PrincipalMoments : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.PrincipalMoments);

			}
		}


		///<summary>
		///Not implemented. Returns the product of inertia of a 3D solid or region.
		///</summary>
		[NodeInput("Acad3DSolid", typeof(object))]
		public class ProductOfInertia : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ProductOfInertia);

			}
		}


		///<summary>
		///Not implemented. Returns the radius of gyration of a 3D solid or region.
		///</summary>
		[NodeInput("Acad3DSolid", typeof(object))]
		public class RadiiOfGyration : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.RadiiOfGyration);

			}
		}


		///<summary>
		///Not implemented. Returns the volume of a 3D solid.
		///</summary>
		[NodeInput("Acad3DSolid", typeof(object))]
		public class Volume : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Volume);

			}
		}


		///<summary>
		///Not implemented. Performs a boolean operation on an object and another 3D solid or region.
		///</summary>
		[NodeInput("Acad3DSolid", typeof(object))]
		[NodeInput("Operation", typeof(System.Object))]
		[NodeInput("SolidObject", typeof(System.Object))]
		public class Boolean : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Boolean(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///Not implemented. Checks the interference between two 3D solids.
		///</summary>
		[NodeInput("Acad3DSolid", typeof(object))]
		[NodeInput("Object", typeof(System.Object))]
		[NodeInput("CreateInterferenceSolid", typeof(System.Object))]
		public class CheckInterference : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.CheckInterference(inputs[1],inputs[2]));

			}
		}


		///<summary>
		///Not implemented. Creates a section of a 3D solid; the resulting section is a region.
		///</summary>
		[NodeInput("Acad3DSolid", typeof(object))]
		[NodeInput("Point1", typeof(System.Object))]
		[NodeInput("Point2", typeof(System.Object))]
		[NodeInput("point3", typeof(System.Object))]
		public class SectionSolid : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.SectionSolid(inputs[1],inputs[2],inputs[3]));

			}
		}


		///<summary>
		///Not implemented. Creates a slice of a 3D solid; the resulting slice is an array of the 3D solid.
		///</summary>
		[NodeInput("Acad3DSolid", typeof(object))]
		[NodeInput("Point1", typeof(System.Object))]
		[NodeInput("Point2", typeof(System.Object))]
		[NodeInput("point3", typeof(System.Object))]
		[NodeInput("Negative", typeof(System.Object))]
		public class SliceSolid : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.SliceSolid(inputs[1],inputs[2],inputs[3],inputs[4]));

			}
		}


		///<summary>
		///Not implemented. Returns the type of 3D solid.
		///</summary>
		[NodeInput("Acad3DSolid", typeof(object))]
		public class SolidType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.SolidType);

			}
		}


		///<summary>
		///Not implemented. Specifies or returns the center of a 3D solid.
		///</summary>
		[NodeInput("Acad3DSolid", typeof(object))]
		public class Position : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Position);

			}
		}


		///<summary>
		///Not implemented. Specifies or returns the center of a 3D solid.
		///</summary>
		[NodeInput("Acad3DSolid", typeof(object))]
		[NodeInput("Position", typeof(System.Object))]
		public class Set_Position : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Position = inputs[1];
				return null;
			}
		}


		///<summary>
		///Not implemented. Specifies or returns whether history is saved for a 3D solid.
		///</summary>
		[NodeInput("Acad3DSolid", typeof(object))]
		public class History : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.History);

			}
		}


		///<summary>
		///Not implemented. Specifies or returns whether history is saved for a 3D solid.
		///</summary>
		[NodeInput("Acad3DSolid", typeof(object))]
		[NodeInput("bHistory", typeof(System.Object))]
		public class Set_History : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.History = inputs[1];
				return null;
			}
		}


		///<summary>
		///Not implemented. Specifies or returns whether to show the history of a 3D solid.
		///</summary>
		[NodeInput("Acad3DSolid", typeof(object))]
		public class ShowHistory : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ShowHistory);

			}
		}


		///<summary>
		///Not implemented. Specifies or returns whether to show the history of a 3D solid.
		///</summary>
		[NodeInput("Acad3DSolid", typeof(object))]
		[NodeInput("Position", typeof(System.Object))]
		public class Set_ShowHistory : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ShowHistory = inputs[1];
				return null;
			}
		}
}
