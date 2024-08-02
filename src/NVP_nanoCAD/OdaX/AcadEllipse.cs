using NVP.API.Nodes;

namespace OdaX.AcadEllipse 
{
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


	///<summary>
	///Returns the x, y, and z coordinates of an ellipse's start point.
	///</summary>
	[NodeInput("AcadEllipse", typeof(object))]
	public class StartPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartPoint);

		}
	}


	///<summary>
	///Specifies or returns the x, y, and z coordinates of an ellipse's center point.
	///</summary>
	[NodeInput("AcadEllipse", typeof(object))]
	public class Center : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Center);

		}
	}


	///<summary>
	///Specifies or returns the x, y, and z coordinates of an ellipse's center point.
	///</summary>
	[NodeInput("AcadEllipse", typeof(object))]
	[NodeInput("Center", typeof(System.Object))]
	public class Set_Center : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Center = inputs[1];
			return null;
		}
	}


	///<summary>
	///Returns the x, y, and z coordinates of an ellipse's end point.
	///</summary>
	[NodeInput("AcadEllipse", typeof(object))]
	public class EndPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndPoint);

		}
	}


	///<summary>
	///Specifies or returns the radius of the longer axis of an ellipse.
	///</summary>
	[NodeInput("AcadEllipse", typeof(object))]
	public class MajorRadius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MajorRadius);

		}
	}


	///<summary>
	///Specifies or returns the radius of the longer axis of an ellipse.
	///</summary>
	[NodeInput("AcadEllipse", typeof(object))]
	[NodeInput("MajorRadius", typeof(System.Double))]
	public class Set_MajorRadius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MajorRadius = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the radius of the smaller axis of an ellipse.
	///</summary>
	[NodeInput("AcadEllipse", typeof(object))]
	public class MinorRadius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MinorRadius);

		}
	}


	///<summary>
	///Specifies or returns the radius of the smaller axis of an ellipse.
	///</summary>
	[NodeInput("AcadEllipse", typeof(object))]
	[NodeInput("MinorRadius", typeof(System.Double))]
	public class Set_MinorRadius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MinorRadius = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the ratio of the ellipse's major axis length to the minor axis length.
	///</summary>
	[NodeInput("AcadEllipse", typeof(object))]
	public class RadiusRatio : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RadiusRatio);

		}
	}


	///<summary>
	///Specifies or returns the ratio of the ellipse's major axis length to the minor axis length.
	///</summary>
	[NodeInput("AcadEllipse", typeof(object))]
	[NodeInput("RadiusRatio", typeof(System.Double))]
	public class Set_RadiusRatio : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RadiusRatio = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the start angle of an ellipse.
	///</summary>
	[NodeInput("AcadEllipse", typeof(object))]
	public class StartAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartAngle);

		}
	}


	///<summary>
	///Specifies or returns the start angle of an ellipse.
	///</summary>
	[NodeInput("AcadEllipse", typeof(object))]
	[NodeInput("StartAngle", typeof(System.Object))]
	public class Set_StartAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StartAngle = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the end angle of an ellipse.
	///</summary>
	[NodeInput("AcadEllipse", typeof(object))]
	public class EndAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndAngle);

		}
	}


	///<summary>
	///Specifies or returns the end angle of an ellipse.
	///</summary>
	[NodeInput("AcadEllipse", typeof(object))]
	[NodeInput("EndAngle", typeof(System.Object))]
	public class Set_EndAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EndAngle = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the start parameter of an ellipse.
	///</summary>
	[NodeInput("AcadEllipse", typeof(object))]
	public class StartParameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartParameter);

		}
	}


	///<summary>
	///Specifies or returns the start parameter of an ellipse.
	///</summary>
	[NodeInput("AcadEllipse", typeof(object))]
	[NodeInput("StartParameter", typeof(System.Double))]
	public class Set_StartParameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StartParameter = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the end parameter of an ellipse.
	///</summary>
	[NodeInput("AcadEllipse", typeof(object))]
	public class EndParameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndParameter);

		}
	}


	///<summary>
	///Specifies or returns the end parameter of an ellipse.
	///</summary>
	[NodeInput("AcadEllipse", typeof(object))]
	[NodeInput("EndParameter", typeof(System.Double))]
	public class Set_EndParameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EndParameter = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the length of the longer axis of an ellipse.
	///</summary>
	[NodeInput("AcadEllipse", typeof(object))]
	public class MajorAxis : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MajorAxis);

		}
	}


	///<summary>
	///Specifies or returns the length of the longer axis of an ellipse.
	///</summary>
	[NodeInput("AcadEllipse", typeof(object))]
	[NodeInput("MajorAxis", typeof(System.Object))]
	public class Set_MajorAxis : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MajorAxis = inputs[1];
			return null;
		}
	}


	///<summary>
	///Returns the length of the shorter axis of an ellipse.
	///</summary>
	[NodeInput("AcadEllipse", typeof(object))]
	public class MinorAxis : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MinorAxis);

		}
	}


	///<summary>
	///Specifies or returns the x, y, and z coordinates of the normal direction vector.
	///</summary>
	[NodeInput("AcadEllipse", typeof(object))]
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
	[NodeInput("AcadEllipse", typeof(object))]
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
	///Returns the area of an ellipse.
	///</summary>
	[NodeInput("AcadEllipse", typeof(object))]
	public class Area : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Area);

		}
	}


	///<summary>
	///Not implemented. Creates a new ellipse at a specified distance from an original ellipse.
	///</summary>
	[NodeInput("AcadEllipse", typeof(object))]
	[NodeInput("Distance", typeof(System.Double))]
	public class Offset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Offset(inputs[1]));

		}
	}
}
