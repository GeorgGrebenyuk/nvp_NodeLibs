using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a bounded planar face consisting of lines, circles, arcs, elliptical arcs, and spline curves
///</summary>
namespace NVP_nanoCAD_COM._OdaX.AcadRegion 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
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

	[NVP_Manifest(
		ViewType = "Modifier")]
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


	[NVP_Manifest(
		Text = "Not implemented. Returns the area of a region.", 
		ViewType = "Data")]
	[NodeInput("AcadRegion", typeof(object))]

	///<summary>
	///Not implemented. Returns the area of a region.
	///</summary>
	public class Area : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Area);

		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Returns the center point of the area for a region.", 
		ViewType = "Data")]
	[NodeInput("AcadRegion", typeof(object))]

	///<summary>
	///Not implemented. Returns the center point of the area for a region.
	///</summary>
	public class Centroid : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Centroid);

		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Returns the moment of inertia for a region.", 
		ViewType = "Data")]
	[NodeInput("AcadRegion", typeof(object))]

	///<summary>
	///Not implemented. Returns the moment of inertia for a region.
	///</summary>
	public class MomentOfInertia : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MomentOfInertia);

		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Returns the x, y, and z coordinates of the normal direction vector.", 
		ViewType = "Data")]
	[NodeInput("AcadRegion", typeof(object))]

	///<summary>
	///Not implemented. Returns the x, y, and z coordinates of the normal direction vector.
	///</summary>
	public class Normal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Normal);

		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Returns the perimeter of a region.", 
		ViewType = "Data")]
	[NodeInput("AcadRegion", typeof(object))]

	///<summary>
	///Not implemented. Returns the perimeter of a region.
	///</summary>
	public class Perimeter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Perimeter);

		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Returns the set of principal direction points for a region.", 
		ViewType = "Data")]
	[NodeInput("AcadRegion", typeof(object))]

	///<summary>
	///Not implemented. Returns the set of principal direction points for a region.
	///</summary>
	public class PrincipalDirections : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PrincipalDirections);

		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Returns the set of principal moment points for a region.", 
		ViewType = "Data")]
	[NodeInput("AcadRegion", typeof(object))]

	///<summary>
	///Not implemented. Returns the set of principal moment points for a region.
	///</summary>
	public class PrincipalMoments : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PrincipalMoments);

		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Returns the product of inertia for a region.", 
		ViewType = "Data")]
	[NodeInput("AcadRegion", typeof(object))]

	///<summary>
	///Not implemented. Returns the product of inertia for a region.
	///</summary>
	public class ProductOfInertia : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ProductOfInertia);

		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Returns the radius of gyration for a region.", 
		ViewType = "Data")]
	[NodeInput("AcadRegion", typeof(object))]

	///<summary>
	///Not implemented. Returns the radius of gyration for a region.
	///</summary>
	public class RadiiOfGyration : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RadiiOfGyration);

		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Performs a Boolean operation with another region.", 
		ViewType = "Modifier")]
	[NodeInput("AcadRegion", typeof(object))]
	[NodeInput("OdaX.AcBoolean", typeof(System.Object))]
	[NodeInput("Object", typeof(System.Object))]

	///<summary>
	///Not implemented. Performs a Boolean operation with another region.
	///</summary>
	public class Boolean : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Boolean(((OdaX.AcBoolean)inputs[1].Value),inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Explodes the region and returns the individual entities as an array of the object.", 
		ViewType = "Data")]
	[NodeInput("AcadRegion", typeof(object))]

	///<summary>
	///Explodes the region and returns the individual entities as an array of the object.
	///</summary>
	public class Explode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Explode);

		}
	}
}
