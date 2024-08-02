using NVP.API.Nodes;

namespace OdaX.AcadRevolvedSurface 
{
	[NodeInput("dynamic", typeof(object))]
	public class AcadRevolvedSurface_Constructor : INode 
	{
		public OdaX.IAcadRevolvedSurface _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadRevolvedSurface;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class AcadRevolvedSurface_ConstructorCast : INode 
	{
		public OdaX.IAcadRevolvedSurface _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadRevolvedSurface;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///Specifies or returns the angle of revolution for a revolved surface.
	///</summary>
	[NodeInput("AcadRevolvedSurface", typeof(object))]
	public class RevolutionAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RevolutionAngle);

		}
	}


	///<summary>
	///Specifies or returns the angle of revolution for a revolved surface.
	///</summary>
	[NodeInput("AcadRevolvedSurface", typeof(object))]
	[NodeInput("revAngle", typeof(System.Object))]
	public class Set_RevolutionAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RevolutionAngle = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the start point of the revolution axis for a revolved surface.
	///</summary>
	[NodeInput("AcadRevolvedSurface", typeof(object))]
	public class AxisPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AxisPosition);

		}
	}


	///<summary>
	///Specifies or returns the start point of the revolution axis for a revolved surface.
	///</summary>
	[NodeInput("AcadRevolvedSurface", typeof(object))]
	[NodeInput("AxisPosition", typeof(System.Object))]
	public class Set_AxisPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AxisPosition = inputs[1];
			return null;
		}
	}


	///<summary>
	///Returns the direction of the revolution axis for a revolved surface.
	///</summary>
	[NodeInput("AcadRevolvedSurface", typeof(object))]
	public class AxisDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AxisDirection);

		}
	}
}
