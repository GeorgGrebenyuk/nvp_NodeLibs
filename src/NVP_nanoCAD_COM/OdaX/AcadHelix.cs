using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of Helix entity
///</summary>
namespace OdaX.AcadHelix 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
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

	[NVP_Manifest(
		ViewType = "Modifier")]
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


	[NVP_Manifest(
		Text = "Specifies or returns the x, y, and z coordinates for the base center point of a helix.", 
		ViewType = "Data")]
	[NodeInput("AcadHelix", typeof(object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates for the base center point of a helix.
	///</summary>
	public class Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Position);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the x, y, and z coordinates for the base center point of a helix.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHelix", typeof(object))]
	[NodeInput("StartPoint", typeof(System.Object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates for the base center point of a helix.
	///</summary>
	public class Set_Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Position = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the property that is contrained to remain constant when changing other properties of a helix.", 
		ViewType = "Data")]
	[NodeInput("AcadHelix", typeof(object))]

	///<summary>
	///Specifies or returns the property that is contrained to remain constant when changing other properties of a helix.
	///</summary>
	public class Constrain : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Constrain);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the property that is contrained to remain constant when changing other properties of a helix.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHelix", typeof(object))]
	[NodeInput("OdaX.AcHelixConstrainType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the property that is contrained to remain constant when changing other properties of a helix.
	///</summary>
	public class Set_Constrain : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Constrain = ((OdaX.AcHelixConstrainType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the height of a helix.", 
		ViewType = "Data")]
	[NodeInput("AcadHelix", typeof(object))]

	///<summary>
	///Specifies or returns the height of a helix.
	///</summary>
	public class Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Height);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the height of a helix.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHelix", typeof(object))]
	[NodeInput("Length", typeof(System.Double))]

	///<summary>
	///Specifies or returns the height of a helix.
	///</summary>
	public class Set_Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Height = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the number of turns for a helix.", 
		ViewType = "Data")]
	[NodeInput("AcadHelix", typeof(object))]

	///<summary>
	///Specifies or returns the number of turns for a helix.
	///</summary>
	public class Turns : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Turns);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the number of turns for a helix.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHelix", typeof(object))]
	[NodeInput("Turns", typeof(System.Object))]

	///<summary>
	///Specifies or returns the number of turns for a helix.
	///</summary>
	public class Set_Turns : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Turns = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the height of a single turn for a helix.", 
		ViewType = "Data")]
	[NodeInput("AcadHelix", typeof(object))]

	///<summary>
	///Specifies or returns the height of a single turn for a helix.
	///</summary>
	public class TurnHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TurnHeight);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the height of a single turn for a helix.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHelix", typeof(object))]
	[NodeInput("Distance", typeof(System.Double))]

	///<summary>
	///Specifies or returns the height of a single turn for a helix.
	///</summary>
	public class Set_TurnHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TurnHeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the radius of the base of a helix.", 
		ViewType = "Data")]
	[NodeInput("AcadHelix", typeof(object))]

	///<summary>
	///Specifies or returns the radius of the base of a helix.
	///</summary>
	public class BaseRadius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BaseRadius);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the radius of the base of a helix.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHelix", typeof(object))]
	[NodeInput("Radius", typeof(System.Double))]

	///<summary>
	///Specifies or returns the radius of the base of a helix.
	///</summary>
	public class Set_BaseRadius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BaseRadius = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the radius of the top of a helix.", 
		ViewType = "Data")]
	[NodeInput("AcadHelix", typeof(object))]

	///<summary>
	///Specifies or returns the radius of the top of a helix.
	///</summary>
	public class TopRadius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TopRadius);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the radius of the top of a helix.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHelix", typeof(object))]
	[NodeInput("Radius", typeof(System.Double))]

	///<summary>
	///Specifies or returns the radius of the top of a helix.
	///</summary>
	public class Set_TopRadius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TopRadius = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the direction in which a helix turns.", 
		ViewType = "Data")]
	[NodeInput("AcadHelix", typeof(object))]

	///<summary>
	///Specifies or returns the direction in which a helix turns.
	///</summary>
	public class Twist : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Twist);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the direction in which a helix turns.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHelix", typeof(object))]
	[NodeInput("OdaX.AcHelixTwistType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the direction in which a helix turns.
	///</summary>
	public class Set_Twist : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Twist = ((OdaX.AcHelixTwistType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the slope angle in which a helix turns along a path.", 
		ViewType = "Data")]
	[NodeInput("AcadHelix", typeof(object))]

	///<summary>
	///Returns the slope angle in which a helix turns along a path.
	///</summary>
	public class TurnSlope : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TurnSlope);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the length of a helix.", 
		ViewType = "Data")]
	[NodeInput("AcadHelix", typeof(object))]

	///<summary>
	///Specifies the length of a helix.
	///</summary>
	public class TotalLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TotalLength);

		}
	}
}
