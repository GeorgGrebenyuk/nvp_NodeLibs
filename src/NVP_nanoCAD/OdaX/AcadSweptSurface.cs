using NVP.API.Nodes;

namespace OdaX.AcadSweptSurface 
{
	[NodeInput("dynamic", typeof(object))]
	public class AcadSweptSurface_Constructor : INode 
	{
		public OdaX.IAcadSweptSurface _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadSweptSurface;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class AcadSweptSurface_ConstructorCast : INode 
	{
		public OdaX.IAcadSweptSurface _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadSweptSurface;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///Specifies or returns the rotation of the profile used for a swept surface.
	///</summary>
	[NodeInput("AcadSweptSurface", typeof(object))]
	public class ProfileRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ProfileRotation);

		}
	}


	///<summary>
	///Specifies or returns the rotation of the profile used for a swept surface.
	///</summary>
	[NodeInput("AcadSweptSurface", typeof(object))]
	[NodeInput("profileRotationAngle", typeof(System.Object))]
	public class Set_ProfileRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ProfileRotation = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether the profile of a swept surface is banked along the path.
	///</summary>
	[NodeInput("AcadSweptSurface", typeof(object))]
	public class Bank : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Bank);

		}
	}


	///<summary>
	///Specifies or returns whether the profile of a swept surface is banked along the path.
	///</summary>
	[NodeInput("AcadSweptSurface", typeof(object))]
	[NodeInput("bBank", typeof(System.Object))]
	public class Set_Bank : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Bank = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the rotation value applied along the path of a swept surface.
	///</summary>
	[NodeInput("AcadSweptSurface", typeof(object))]
	public class Twist : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Twist);

		}
	}


	///<summary>
	///Specifies or returns the rotation value applied along the path of a swept surface.
	///</summary>
	[NodeInput("AcadSweptSurface", typeof(object))]
	[NodeInput("TwistAngle", typeof(System.Object))]
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
	///Specifies or returns the scale factor of a swept surface.
	///</summary>
	[NodeInput("AcadSweptSurface", typeof(object))]
	public class scale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.scale);

		}
	}


	///<summary>
	///Specifies or returns the scale factor of a swept surface.
	///</summary>
	[NodeInput("AcadSweptSurface", typeof(object))]
	[NodeInput("scale", typeof(System.Double))]
	public class Set_scale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.scale = inputs[1];
			return null;
		}
	}


	///<summary>
	///Not implemented. Returns the length of the path for a swept surface.
	///</summary>
	[NodeInput("AcadSweptSurface", typeof(object))]
	public class Length : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Length);

		}
	}
}
