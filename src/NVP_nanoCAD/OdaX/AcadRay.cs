using NVP.API.Nodes;

namespace OdaX.AcadRay 
{
	[NodeInput("dynamic", typeof(object))]
	public class AcadRay_Constructor : INode 
	{
		public OdaX.IAcadRay _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadRay;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class AcadRay_ConstructorCast : INode 
	{
		public OdaX.IAcadRay _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadRay;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///Specifies or returns the start point of a ray.
	///</summary>
	[NodeInput("AcadRay", typeof(object))]
	public class BasePoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BasePoint);

		}
	}


	///<summary>
	///Specifies or returns the start point of a ray.
	///</summary>
	[NodeInput("AcadRay", typeof(object))]
	[NodeInput("BasePoint", typeof(System.Object))]
	public class Set_BasePoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BasePoint = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the second point of a ray.
	///</summary>
	[NodeInput("AcadRay", typeof(object))]
	public class SecondPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SecondPoint);

		}
	}


	///<summary>
	///Specifies or returns the second point of a ray.
	///</summary>
	[NodeInput("AcadRay", typeof(object))]
	[NodeInput("SecondPoint", typeof(System.Object))]
	public class Set_SecondPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SecondPoint = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the direction vector of a ray.
	///</summary>
	[NodeInput("AcadRay", typeof(object))]
	public class DirectionVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DirectionVector);

		}
	}


	///<summary>
	///Specifies or returns the direction vector of a ray.
	///</summary>
	[NodeInput("AcadRay", typeof(object))]
	[NodeInput("dirVector", typeof(System.Object))]
	public class Set_DirectionVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DirectionVector = inputs[1];
			return null;
		}
	}
}
