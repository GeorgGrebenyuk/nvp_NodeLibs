using NVP.API.Nodes;

namespace OdaX.AcadCircle 
{
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


	///<summary>
	///Specifies or returns the x, y, z coordinates of the center of a circle.
	///</summary>
	[NodeInput("AcadCircle", typeof(object))]
	public class Center : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Center);

		}
	}


	///<summary>
	///Specifies or returns the x, y, z coordinates of the center of a circle.
	///</summary>
	[NodeInput("AcadCircle", typeof(object))]
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
	///Specifies or returns the radius of a circle.
	///</summary>
	[NodeInput("AcadCircle", typeof(object))]
	public class Radius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Radius);

		}
	}


	///<summary>
	///Specifies or returns the radius of a circle.
	///</summary>
	[NodeInput("AcadCircle", typeof(object))]
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
	///Specifies or returns the diameter of a circle.
	///</summary>
	[NodeInput("AcadCircle", typeof(object))]
	public class Diameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Diameter);

		}
	}


	///<summary>
	///Specifies or returns the diameter of a circle.
	///</summary>
	[NodeInput("AcadCircle", typeof(object))]
	[NodeInput("Diameter", typeof(System.Double))]
	public class Set_Diameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Diameter = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the circumference of a circle.
	///</summary>
	[NodeInput("AcadCircle", typeof(object))]
	public class Circumference : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Circumference);

		}
	}


	///<summary>
	///Specifies or returns the circumference of a circle.
	///</summary>
	[NodeInput("AcadCircle", typeof(object))]
	[NodeInput("Circumference", typeof(System.Double))]
	public class Set_Circumference : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Circumference = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the area of a circle.
	///</summary>
	[NodeInput("AcadCircle", typeof(object))]
	public class Area : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Area);

		}
	}


	///<summary>
	///Specifies or returns the area of a circle.
	///</summary>
	[NodeInput("AcadCircle", typeof(object))]
	[NodeInput("Area", typeof(System.Double))]
	public class Set_Area : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Area = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the x, y, z coordinates of the normal direction vector.
	///</summary>
	[NodeInput("AcadCircle", typeof(object))]
	public class Normal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Normal);

		}
	}


	///<summary>
	///Specifies or returns the x, y, z coordinates of the normal direction vector.
	///</summary>
	[NodeInput("AcadCircle", typeof(object))]
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
	///z-direction value) of a circle.
	///</summary>
	[NodeInput("AcadCircle", typeof(object))]
	public class Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Thickness);

		}
	}


	///<summary>
	///z-direction value) of a circle.
	///</summary>
	[NodeInput("AcadCircle", typeof(object))]
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
	///Not implemented. Creates a new circle at a specified distance from an original circle.
	///</summary>
	[NodeInput("AcadCircle", typeof(object))]
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
