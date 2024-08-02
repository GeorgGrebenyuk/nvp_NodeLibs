using NVP.API.Nodes;

namespace OdaX.AcadExtrudedSurface 
{
	[NodeInput("dynamic", typeof(object))]
	public class AcadExtrudedSurface_Constructor : INode 
	{
		public OdaX.IAcadExtrudedSurface _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadExtrudedSurface;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class AcadExtrudedSurface_ConstructorCast : INode 
	{
		public OdaX.IAcadExtrudedSurface _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadExtrudedSurface;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///Specifies or returns the height of the extruded surface.
	///</summary>
	[NodeInput("AcadExtrudedSurface", typeof(object))]
	public class Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Height);

		}
	}


	///<summary>
	///Specifies or returns the height of the extruded surface.
	///</summary>
	[NodeInput("AcadExtrudedSurface", typeof(object))]
	[NodeInput("Height", typeof(System.Double))]
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
	///Specifies or returns the taper angle of the extruded surface.
	///</summary>
	[NodeInput("AcadExtrudedSurface", typeof(object))]
	public class TaperAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TaperAngle);

		}
	}


	///<summary>
	///Specifies or returns the taper angle of the extruded surface.
	///</summary>
	[NodeInput("AcadExtrudedSurface", typeof(object))]
	[NodeInput("TaperAngle", typeof(System.Object))]
	public class Set_TaperAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TaperAngle = inputs[1];
			return null;
		}
	}


	///<summary>
	///Returns the direction of the extruded surface.
	///</summary>
	[NodeInput("AcadExtrudedSurface", typeof(object))]
	public class Direction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Direction);

		}
	}
}
