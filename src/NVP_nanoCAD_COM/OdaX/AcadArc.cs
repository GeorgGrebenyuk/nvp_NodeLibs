using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a circular arc entity
///</summary>
namespace NVP_nanoCAD_COM._OdaX.AcadArc 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadArc_Constructor : INode 
	{
		public OdaX.IAcadArc _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadArc;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadArc_ConstructorCast : INode 
	{
		public OdaX.IAcadArc _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadArc;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Returns the x, y, and z coordinates of an arc's start point.", 
		ViewType = "Data")]
	[NodeInput("AcadArc", typeof(object))]

	///<summary>
	///Returns the x, y, and z coordinates of an arc's start point.
	///</summary>
	public class StartPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartPoint);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the x, y, and z coordinates of an arc's center point.", 
		ViewType = "Data")]
	[NodeInput("AcadArc", typeof(object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates of an arc's center point.
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
		Text = "Specifies or returns the x, y, and z coordinates of an arc's center point.", 
		ViewType = "Modifier")]
	[NodeInput("AcadArc", typeof(object))]
	[NodeInput("CenterPoint", typeof(System.Object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates of an arc's center point.
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
		Text = "Returns the x, y, and z coordinates of an arc's end point.", 
		ViewType = "Data")]
	[NodeInput("AcadArc", typeof(object))]

	///<summary>
	///Returns the x, y, and z coordinates of an arc's end point.
	///</summary>
	public class EndPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndPoint);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the radius of an arc.", 
		ViewType = "Data")]
	[NodeInput("AcadArc", typeof(object))]

	///<summary>
	///Specifies or returns the radius of an arc.
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
		Text = "Specifies or returns the radius of an arc.", 
		ViewType = "Modifier")]
	[NodeInput("AcadArc", typeof(object))]
	[NodeInput("Radius", typeof(System.Double))]

	///<summary>
	///Specifies or returns the radius of an arc.
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
		Text = "Specifies or returns the start angle of an arc.", 
		ViewType = "Data")]
	[NodeInput("AcadArc", typeof(object))]

	///<summary>
	///Specifies or returns the start angle of an arc.
	///</summary>
	public class StartAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartAngle);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the start angle of an arc.", 
		ViewType = "Modifier")]
	[NodeInput("AcadArc", typeof(object))]
	[NodeInput("Angle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the start angle of an arc.
	///</summary>
	public class Set_StartAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StartAngle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the end angle of an arc.", 
		ViewType = "Data")]
	[NodeInput("AcadArc", typeof(object))]

	///<summary>
	///Specifies or returns the end angle of an arc.
	///</summary>
	public class EndAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndAngle);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the end angle of an arc.", 
		ViewType = "Modifier")]
	[NodeInput("AcadArc", typeof(object))]
	[NodeInput("Angle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the end angle of an arc.
	///</summary>
	public class Set_EndAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EndAngle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the total angle of an arc.", 
		ViewType = "Data")]
	[NodeInput("AcadArc", typeof(object))]

	///<summary>
	///Returns the total angle of an arc.
	///</summary>
	public class TotalAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TotalAngle);

		}
	}


	[NVP_Manifest(
		Text = "Returns the length of an arc.", 
		ViewType = "Data")]
	[NodeInput("AcadArc", typeof(object))]

	///<summary>
	///Returns the length of an arc.
	///</summary>
	public class ArcLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArcLength);

		}
	}


	[NVP_Manifest(
		Text = "z-direction value) of an arc.", 
		ViewType = "Data")]
	[NodeInput("AcadArc", typeof(object))]

	///<summary>
	///z-direction value) of an arc.
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
		Text = "z-direction value) of an arc.", 
		ViewType = "Modifier")]
	[NodeInput("AcadArc", typeof(object))]
	[NodeInput("Thickness", typeof(System.Double))]

	///<summary>
	///z-direction value) of an arc.
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
		Text = "Not implemented. Creates a new arc at a specified distance from an original arc.", 
		ViewType = "Data")]
	[NodeInput("AcadArc", typeof(object))]
	[NodeInput("Distance", typeof(System.Double))]

	///<summary>
	///Not implemented. Creates a new arc at a specified distance from an original arc.
	///</summary>
	public class Offset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Offset(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Returns the area of an arc as if it was closed with a line.", 
		ViewType = "Data")]
	[NodeInput("AcadArc", typeof(object))]

	///<summary>
	///Returns the area of an arc as if it was closed with a line.
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
		Text = "Specifies or returns the x, y, and z coordinates of the normal direction vector.", 
		ViewType = "Data")]
	[NodeInput("AcadArc", typeof(object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates of the normal direction vector.
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
		Text = "Specifies or returns the x, y, and z coordinates of the normal direction vector.", 
		ViewType = "Modifier")]
	[NodeInput("AcadArc", typeof(object))]
	[NodeInput("Normal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates of the normal direction vector.
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
}
