using NVP.API.Nodes;

namespace OdaX.AcadSubEntity 
{
	[NodeInput("dynamic", typeof(object))]
	public class AcadSubEntity_Constructor : INode 
	{
		public OdaX.IAcadSubEntity _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadSubEntity;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class AcadSubEntity_ConstructorCast : INode 
	{
		public OdaX.IAcadSubEntity _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadSubEntity;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("AcadSubEntity", typeof(object))]
	public class OnModified : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OnModified();
			return null;
		}
	}


	///<summary>
	///Gets the AutoCAD class name of the object
	///</summary>
	[NodeInput("AcadSubEntity", typeof(object))]
	public class ObjectName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ObjectName);

		}
	}


	///<summary>
	///Returns the true color of the object.
	///</summary>
	[NodeInput("AcadSubEntity", typeof(object))]
	public class color : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.color);

		}
	}


	///<summary>
	///Returns the true color of the object.
	///</summary>
	[NodeInput("AcadSubEntity", typeof(object))]
	[NodeInput("pColor", typeof(System.Object))]
	public class Set_color : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.color = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the current layer of the object
	///</summary>
	[NodeInput("AcadSubEntity", typeof(object))]
	public class Layer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Layer);

		}
	}


	///<summary>
	///Specifies the current linetype of the object
	///</summary>
	[NodeInput("AcadSubEntity", typeof(object))]
	public class Linetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Linetype);

		}
	}


	///<summary>
	///Specifies the linetype scale factor of the object
	///</summary>
	[NodeInput("AcadSubEntity", typeof(object))]
	public class LinetypeScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LinetypeScale);

		}
	}


	///<summary>
	///Specifies the plotstyle name for the object
	///</summary>
	[NodeInput("AcadSubEntity", typeof(object))]
	public class PlotStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlotStyleName);

		}
	}


	///<summary>
	///Specifies the lineweight for the object
	///</summary>
	[NodeInput("AcadSubEntity", typeof(object))]
	public class Lineweight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Lineweight);

		}
	}


	///<summary>
	///if one is specified)
	///</summary>
	[NodeInput("AcadSubEntity", typeof(object))]
	public class Hyperlinks : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Hyperlinks);

		}
	}
}
