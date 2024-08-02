using NVP.API.Nodes;

namespace OdaX.AcadArc 
{
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


	///<summary>
	///Returns the x, y, and z coordinates of an arc's start point.
	///</summary>
	[NodeInput("AcadArc", typeof(object))]
	public class StartPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartPoint);

		}
	}


	///<summary>
	///Specifies or returns the x, y, and z coordinates of an arc's center point.
	///</summary>
	[NodeInput("AcadArc", typeof(object))]
	public class Center : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Center);

		}
	}


	///<summary>
	///Specifies or returns the x, y, and z coordinates of an arc's center point.
	///</summary>
	[NodeInput("AcadArc", typeof(object))]
	[NodeInput("CenterPoint", typeof(System.Object))]
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
	///Returns the x, y, and z coordinates of an arc's end point.
	///</summary>
	[NodeInput("AcadArc", typeof(object))]
	public class EndPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndPoint);

		}
	}


	///<summary>
	///Specifies or returns the radius of an arc.
	///</summary>
	[NodeInput("AcadArc", typeof(object))]
	public class Radius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Radius);

		}
	}


	///<summary>
	///Specifies or returns the radius of an arc.
	///</summary>
	[NodeInput("AcadArc", typeof(object))]
	[NodeInput("Radius", typeof(System.Double))]
	public class Set_Radius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Radius = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the start angle of an arc.
	///</summary>
	[NodeInput("AcadArc", typeof(object))]
	public class StartAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartAngle);

		}
	}


	///<summary>
	///Specifies or returns the start angle of an arc.
	///</summary>
	[NodeInput("AcadArc", typeof(object))]
	[NodeInput("Angle", typeof(System.Object))]
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
	///Specifies or returns the end angle of an arc.
	///</summary>
	[NodeInput("AcadArc", typeof(object))]
	public class EndAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndAngle);

		}
	}


	///<summary>
	///Specifies or returns the end angle of an arc.
	///</summary>
	[NodeInput("AcadArc", typeof(object))]
	[NodeInput("Angle", typeof(System.Object))]
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
	///Returns the total angle of an arc.
	///</summary>
	[NodeInput("AcadArc", typeof(object))]
	public class TotalAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TotalAngle);

		}
	}


	///<summary>
	///Returns the length of an arc.
	///</summary>
	[NodeInput("AcadArc", typeof(object))]
	public class ArcLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArcLength);

		}
	}


	///<summary>
	///z-direction value) of an arc.
	///</summary>
	[NodeInput("AcadArc", typeof(object))]
	public class Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Thickness);

		}
	}


	///<summary>
	///z-direction value) of an arc.
	///</summary>
	[NodeInput("AcadArc", typeof(object))]
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
	///Not implemented. Creates a new arc at a specified distance from an original arc.
	///</summary>
	[NodeInput("AcadArc", typeof(object))]
	[NodeInput("Distance", typeof(System.Double))]
	public class Offset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Offset(inputs[1]));

		}
	}


	///<summary>
	///Returns the area of an arc as if it was closed with a line.
	///</summary>
	[NodeInput("AcadArc", typeof(object))]
	public class Area : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Area);

		}
	}


	///<summary>
	///Specifies or returns the x, y, and z coordinates of the normal direction vector.
	///</summary>
	[NodeInput("AcadArc", typeof(object))]
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
	[NodeInput("AcadArc", typeof(object))]
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
}
