using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of an elliptical arc or complete ellipse entity
///</summary>
namespace OdaX.AcadEllipse 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadEllipse_Constructor : INode 
	{
		public OdaX.IAcadEllipse _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadEllipse;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadEllipse_ConstructorCast : INode 
	{
		public OdaX.IAcadEllipse _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadEllipse;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Returns the x, y, and z coordinates of an ellipse's start point.", 
		ViewType = "Data")]
	[NodeInput("AcadEllipse", typeof(object))]

	///<summary>
	///Returns the x, y, and z coordinates of an ellipse's start point.
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
		Text = "Specifies or returns the x, y, and z coordinates of an ellipse's center point.", 
		ViewType = "Data")]
	[NodeInput("AcadEllipse", typeof(object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates of an ellipse's center point.
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
		Text = "Specifies or returns the x, y, and z coordinates of an ellipse's center point.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEllipse", typeof(object))]
	[NodeInput("Center", typeof(System.Object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates of an ellipse's center point.
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
		Text = "Returns the x, y, and z coordinates of an ellipse's end point.", 
		ViewType = "Data")]
	[NodeInput("AcadEllipse", typeof(object))]

	///<summary>
	///Returns the x, y, and z coordinates of an ellipse's end point.
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
		Text = "Specifies or returns the radius of the longer axis of an ellipse.", 
		ViewType = "Data")]
	[NodeInput("AcadEllipse", typeof(object))]

	///<summary>
	///Specifies or returns the radius of the longer axis of an ellipse.
	///</summary>
	public class MajorRadius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MajorRadius);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the radius of the longer axis of an ellipse.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEllipse", typeof(object))]
	[NodeInput("MajorRadius", typeof(System.Double))]

	///<summary>
	///Specifies or returns the radius of the longer axis of an ellipse.
	///</summary>
	public class Set_MajorRadius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MajorRadius = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the radius of the smaller axis of an ellipse.", 
		ViewType = "Data")]
	[NodeInput("AcadEllipse", typeof(object))]

	///<summary>
	///Specifies or returns the radius of the smaller axis of an ellipse.
	///</summary>
	public class MinorRadius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MinorRadius);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the radius of the smaller axis of an ellipse.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEllipse", typeof(object))]
	[NodeInput("MinorRadius", typeof(System.Double))]

	///<summary>
	///Specifies or returns the radius of the smaller axis of an ellipse.
	///</summary>
	public class Set_MinorRadius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MinorRadius = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the ratio of the ellipse's major axis length to the minor axis length.", 
		ViewType = "Data")]
	[NodeInput("AcadEllipse", typeof(object))]

	///<summary>
	///Specifies or returns the ratio of the ellipse's major axis length to the minor axis length.
	///</summary>
	public class RadiusRatio : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RadiusRatio);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the ratio of the ellipse's major axis length to the minor axis length.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEllipse", typeof(object))]
	[NodeInput("RadiusRatio", typeof(System.Double))]

	///<summary>
	///Specifies or returns the ratio of the ellipse's major axis length to the minor axis length.
	///</summary>
	public class Set_RadiusRatio : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RadiusRatio = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the start angle of an ellipse.", 
		ViewType = "Data")]
	[NodeInput("AcadEllipse", typeof(object))]

	///<summary>
	///Specifies or returns the start angle of an ellipse.
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
		Text = "Specifies or returns the start angle of an ellipse.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEllipse", typeof(object))]
	[NodeInput("StartAngle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the start angle of an ellipse.
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
		Text = "Specifies or returns the end angle of an ellipse.", 
		ViewType = "Data")]
	[NodeInput("AcadEllipse", typeof(object))]

	///<summary>
	///Specifies or returns the end angle of an ellipse.
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
		Text = "Specifies or returns the end angle of an ellipse.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEllipse", typeof(object))]
	[NodeInput("EndAngle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the end angle of an ellipse.
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
		Text = "Specifies or returns the start parameter of an ellipse.", 
		ViewType = "Data")]
	[NodeInput("AcadEllipse", typeof(object))]

	///<summary>
	///Specifies or returns the start parameter of an ellipse.
	///</summary>
	public class StartParameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartParameter);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the start parameter of an ellipse.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEllipse", typeof(object))]
	[NodeInput("StartParameter", typeof(System.Double))]

	///<summary>
	///Specifies or returns the start parameter of an ellipse.
	///</summary>
	public class Set_StartParameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StartParameter = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the end parameter of an ellipse.", 
		ViewType = "Data")]
	[NodeInput("AcadEllipse", typeof(object))]

	///<summary>
	///Specifies or returns the end parameter of an ellipse.
	///</summary>
	public class EndParameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndParameter);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the end parameter of an ellipse.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEllipse", typeof(object))]
	[NodeInput("EndParameter", typeof(System.Double))]

	///<summary>
	///Specifies or returns the end parameter of an ellipse.
	///</summary>
	public class Set_EndParameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EndParameter = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the length of the longer axis of an ellipse.", 
		ViewType = "Data")]
	[NodeInput("AcadEllipse", typeof(object))]

	///<summary>
	///Specifies or returns the length of the longer axis of an ellipse.
	///</summary>
	public class MajorAxis : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MajorAxis);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the length of the longer axis of an ellipse.", 
		ViewType = "Modifier")]
	[NodeInput("AcadEllipse", typeof(object))]
	[NodeInput("MajorAxis", typeof(System.Object))]

	///<summary>
	///Specifies or returns the length of the longer axis of an ellipse.
	///</summary>
	public class Set_MajorAxis : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MajorAxis = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the length of the shorter axis of an ellipse.", 
		ViewType = "Data")]
	[NodeInput("AcadEllipse", typeof(object))]

	///<summary>
	///Returns the length of the shorter axis of an ellipse.
	///</summary>
	public class MinorAxis : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MinorAxis);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the x, y, and z coordinates of the normal direction vector.", 
		ViewType = "Data")]
	[NodeInput("AcadEllipse", typeof(object))]

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
	[NodeInput("AcadEllipse", typeof(object))]
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


	[NVP_Manifest(
		Text = "Returns the area of an ellipse.", 
		ViewType = "Data")]
	[NodeInput("AcadEllipse", typeof(object))]

	///<summary>
	///Returns the area of an ellipse.
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
		Text = "Not implemented. Creates a new ellipse at a specified distance from an original ellipse.", 
		ViewType = "Data")]
	[NodeInput("AcadEllipse", typeof(object))]
	[NodeInput("Distance", typeof(System.Double))]

	///<summary>
	///Not implemented. Creates a new ellipse at a specified distance from an original ellipse.
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
