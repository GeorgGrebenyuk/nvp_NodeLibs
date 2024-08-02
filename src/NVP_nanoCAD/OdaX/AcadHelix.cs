using NVP.API.Nodes;

namespace OdaX.AcadHelix 
{
	[NodeInput("dynamic", typeof(object))]
	public class AcadHelix_Constructor : INode 
	{
		public OdaX.IAcadHelix _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadHelix;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class AcadHelix_ConstructorCast : INode 
	{
		public OdaX.IAcadHelix _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadHelix;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///Specifies or returns the x, y, and z coordinates for the base center point of a helix.
	///</summary>
	[NodeInput("AcadHelix", typeof(object))]
	public class Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Position);

		}
	}


	///<summary>
	///Specifies or returns the x, y, and z coordinates for the base center point of a helix.
	///</summary>
	[NodeInput("AcadHelix", typeof(object))]
	[NodeInput("StartPoint", typeof(System.Object))]
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
	///Specifies or returns the property that is contrained to remain constant when changing other properties of a helix.
	///</summary>
	[NodeInput("AcadHelix", typeof(object))]
	public class Constrain : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Constrain);

		}
	}


	///<summary>
	///Specifies or returns the property that is contrained to remain constant when changing other properties of a helix.
	///</summary>
	[NodeInput("AcadHelix", typeof(object))]
	[NodeInput("constrainType", typeof(System.Object))]
	public class Set_Constrain : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Constrain = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the height of a helix.
	///</summary>
	[NodeInput("AcadHelix", typeof(object))]
	public class Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Height);

		}
	}


	///<summary>
	///Specifies or returns the height of a helix.
	///</summary>
	[NodeInput("AcadHelix", typeof(object))]
	[NodeInput("Length", typeof(System.Double))]
	public class Set_Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Height = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the number of turns for a helix.
	///</summary>
	[NodeInput("AcadHelix", typeof(object))]
	public class Turns : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Turns);

		}
	}


	///<summary>
	///Specifies or returns the number of turns for a helix.
	///</summary>
	[NodeInput("AcadHelix", typeof(object))]
	[NodeInput("Turns", typeof(System.Object))]
	public class Set_Turns : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Turns = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the height of a single turn for a helix.
	///</summary>
	[NodeInput("AcadHelix", typeof(object))]
	public class TurnHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TurnHeight);

		}
	}


	///<summary>
	///Specifies or returns the height of a single turn for a helix.
	///</summary>
	[NodeInput("AcadHelix", typeof(object))]
	[NodeInput("Distance", typeof(System.Double))]
	public class Set_TurnHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TurnHeight = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the radius of the base of a helix.
	///</summary>
	[NodeInput("AcadHelix", typeof(object))]
	public class BaseRadius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BaseRadius);

		}
	}


	///<summary>
	///Specifies or returns the radius of the base of a helix.
	///</summary>
	[NodeInput("AcadHelix", typeof(object))]
	[NodeInput("Radius", typeof(System.Double))]
	public class Set_BaseRadius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BaseRadius = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the radius of the top of a helix.
	///</summary>
	[NodeInput("AcadHelix", typeof(object))]
	public class TopRadius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TopRadius);

		}
	}


	///<summary>
	///Specifies or returns the radius of the top of a helix.
	///</summary>
	[NodeInput("AcadHelix", typeof(object))]
	[NodeInput("Radius", typeof(System.Double))]
	public class Set_TopRadius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TopRadius = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the direction in which a helix turns.
	///</summary>
	[NodeInput("AcadHelix", typeof(object))]
	public class Twist : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Twist);

		}
	}


	///<summary>
	///Specifies or returns the direction in which a helix turns.
	///</summary>
	[NodeInput("AcadHelix", typeof(object))]
	[NodeInput("twistType", typeof(System.Object))]
	public class Set_Twist : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Twist = inputs[1];
			return null;
		}
	}


	///<summary>
	///Returns the slope angle in which a helix turns along a path.
	///</summary>
	[NodeInput("AcadHelix", typeof(object))]
	public class TurnSlope : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TurnSlope);

		}
	}


	///<summary>
	///Specifies the length of a helix.
	///</summary>
	[NodeInput("AcadHelix", typeof(object))]
	public class TotalLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TotalLength);

		}
	}
}
