using NVP.API.Nodes;

namespace OdaX.AcadRegion 
{
		[NodeInput("dynamic", typeof(object))]
		public class AcadRegion_Constructor : INode 
		{
		public OdaX.IAcadRegion _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IAcadRegion;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class AcadRegion_ConstructorCast : INode 
		{
		public OdaX.IAcadRegion _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IAcadRegion;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Not implemented. Returns the area of a region.
		///</summary>
		[NodeInput("AcadRegion", typeof(object))]
		public class Area : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Area);

			}
		}


		///<summary>
		///Not implemented. Returns the center point of the area for a region.
		///</summary>
		[NodeInput("AcadRegion", typeof(object))]
		public class Centroid : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Centroid);

			}
		}


		///<summary>
		///Not implemented. Returns the moment of inertia for a region.
		///</summary>
		[NodeInput("AcadRegion", typeof(object))]
		public class MomentOfInertia : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.MomentOfInertia);

			}
		}


		///<summary>
		///Not implemented. Returns the x, y, and z coordinates of the normal direction vector.
		///</summary>
		[NodeInput("AcadRegion", typeof(object))]
		public class Normal : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Normal);

			}
		}


		///<summary>
		///Not implemented. Returns the perimeter of a region.
		///</summary>
		[NodeInput("AcadRegion", typeof(object))]
		public class Perimeter : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Perimeter);

			}
		}


		///<summary>
		///Not implemented. Returns the set of principal direction points for a region.
		///</summary>
		[NodeInput("AcadRegion", typeof(object))]
		public class PrincipalDirections : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.PrincipalDirections);

			}
		}


		///<summary>
		///Not implemented. Returns the set of principal moment points for a region.
		///</summary>
		[NodeInput("AcadRegion", typeof(object))]
		public class PrincipalMoments : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.PrincipalMoments);

			}
		}


		///<summary>
		///Not implemented. Returns the product of inertia for a region.
		///</summary>
		[NodeInput("AcadRegion", typeof(object))]
		public class ProductOfInertia : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ProductOfInertia);

			}
		}


		///<summary>
		///Not implemented. Returns the radius of gyration for a region.
		///</summary>
		[NodeInput("AcadRegion", typeof(object))]
		public class RadiiOfGyration : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.RadiiOfGyration);

			}
		}


		///<summary>
		///Not implemented. Performs a Boolean operation with another region.
		///</summary>
		[NodeInput("AcadRegion", typeof(object))]
		[NodeInput("Operation", typeof(System.Object))]
		[NodeInput("Object", typeof(System.Object))]
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
		///Explodes the region and returns the individual entities as an array of the object.
		///</summary>
		[NodeInput("AcadRegion", typeof(object))]
		public class Explode : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Explode);

			}
		}
}
