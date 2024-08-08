using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a full circle entity
///</summary>
namespace OdaX.AcadCircle 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadCircle_Constructor : INode 
	{
		public OdaX.IAcadCircle _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadCircle;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadCircle_ConstructorCast : INode 
	{
		public OdaX.IAcadCircle _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadCircle;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the x, y, z coordinates of the center of a circle.", 
		ViewType = "Data")]
	[NodeInput("AcadCircle", typeof(object))]

	///<summary>
	///Specifies or returns the x, y, z coordinates of the center of a circle.
	///</summary>
	public class Center : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Center);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the x, y, z coordinates of the center of a circle.", 
		ViewType = "Modifier")]
	[NodeInput("AcadCircle", typeof(object))]
	[NodeInput("CenterPoint", typeof(System.Object))]

	///<summary>
	///Specifies or returns the x, y, z coordinates of the center of a circle.
	///</summary>
	public class Set_Center : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Center = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the radius of a circle.", 
		ViewType = "Data")]
	[NodeInput("AcadCircle", typeof(object))]

	///<summary>
	///Specifies or returns the radius of a circle.
	///</summary>
	public class Radius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Radius);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the radius of a circle.", 
		ViewType = "Modifier")]
	[NodeInput("AcadCircle", typeof(object))]
	[NodeInput("Radius", typeof(System.Double))]

	///<summary>
	///Specifies or returns the radius of a circle.
	///</summary>
	public class Set_Radius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Radius = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the diameter of a circle.", 
		ViewType = "Data")]
	[NodeInput("AcadCircle", typeof(object))]

	///<summary>
	///Specifies or returns the diameter of a circle.
	///</summary>
	public class Diameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Diameter);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the diameter of a circle.", 
		ViewType = "Modifier")]
	[NodeInput("AcadCircle", typeof(object))]
	[NodeInput("Diameter", typeof(System.Double))]

	///<summary>
	///Specifies or returns the diameter of a circle.
	///</summary>
	public class Set_Diameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Diameter = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the circumference of a circle.", 
		ViewType = "Data")]
	[NodeInput("AcadCircle", typeof(object))]

	///<summary>
	///Specifies or returns the circumference of a circle.
	///</summary>
	public class Circumference : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Circumference);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the circumference of a circle.", 
		ViewType = "Modifier")]
	[NodeInput("AcadCircle", typeof(object))]
	[NodeInput("Circumference", typeof(System.Double))]

	///<summary>
	///Specifies or returns the circumference of a circle.
	///</summary>
	public class Set_Circumference : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Circumference = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the area of a circle.", 
		ViewType = "Data")]
	[NodeInput("AcadCircle", typeof(object))]

	///<summary>
	///Specifies or returns the area of a circle.
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
		Text = "Specifies or returns the area of a circle.", 
		ViewType = "Modifier")]
	[NodeInput("AcadCircle", typeof(object))]
	[NodeInput("Area", typeof(System.Double))]

	///<summary>
	///Specifies or returns the area of a circle.
	///</summary>
	public class Set_Area : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Area = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the x, y, z coordinates of the normal direction vector.", 
		ViewType = "Data")]
	[NodeInput("AcadCircle", typeof(object))]

	///<summary>
	///Specifies or returns the x, y, z coordinates of the normal direction vector.
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
		Text = "Specifies or returns the x, y, z coordinates of the normal direction vector.", 
		ViewType = "Modifier")]
	[NodeInput("AcadCircle", typeof(object))]
	[NodeInput("Normal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the x, y, z coordinates of the normal direction vector.
	///</summary>
	public class Set_Normal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Normal = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "z-direction value) of a circle.", 
		ViewType = "Data")]
	[NodeInput("AcadCircle", typeof(object))]

	///<summary>
	///z-direction value) of a circle.
	///</summary>
	public class Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Thickness);

		}
	}


	[NVP_Manifest(
		Text = "z-direction value) of a circle.", 
		ViewType = "Modifier")]
	[NodeInput("AcadCircle", typeof(object))]
	[NodeInput("Thickness", typeof(System.Double))]

	///<summary>
	///z-direction value) of a circle.
	///</summary>
	public class Set_Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Thickness = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Creates a new circle at a specified distance from an original circle.", 
		ViewType = "Data")]
	[NodeInput("AcadCircle", typeof(object))]
	[NodeInput("Distance", typeof(System.Double))]

	///<summary>
	///Not implemented. Creates a new circle at a specified distance from an original circle.
	///</summary>
	public class Offset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Offset(inputs[1].Value));

		}
	}
}
