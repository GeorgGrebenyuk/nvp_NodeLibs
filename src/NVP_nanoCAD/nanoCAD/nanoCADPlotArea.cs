using NVP.API.Nodes;

namespace nanoCAD.nanoCADPlotArea 
{
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPlotArea_Constructor : INode 
	{
		public nanoCAD.InanoCADPlotArea _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.InanoCADPlotArea;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPlotArea_ConstructorCast : INode 
	{
		public nanoCAD.InanoCADPlotArea _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.InanoCADPlotArea;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///Retrieves offset val
	///</summary>
	[NodeInput("nanoCADPlotArea", typeof(object))]
	public class Offset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Offset);

		}
	}


	///<summary>
	///Retrieves offset val
	///</summary>
	[NodeInput("nanoCADPlotArea", typeof(object))]
	[NodeInput("val", typeof(System.Object))]
	public class Set_Offset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Offset = inputs[1];
			return null;
		}
	}


	///<summary>
	///Retrieves ptMin val
	///</summary>
	[NodeInput("nanoCADPlotArea", typeof(object))]
	public class ptMin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ptMin);

		}
	}


	///<summary>
	///Retrieves ptMin val
	///</summary>
	[NodeInput("nanoCADPlotArea", typeof(object))]
	[NodeInput("val", typeof(System.Object))]
	public class Set_ptMin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ptMin = inputs[1];
			return null;
		}
	}


	///<summary>
	///Retrieves ptMax val
	///</summary>
	[NodeInput("nanoCADPlotArea", typeof(object))]
	public class ptMax : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ptMax);

		}
	}


	///<summary>
	///Retrieves ptMax val
	///</summary>
	[NodeInput("nanoCADPlotArea", typeof(object))]
	[NodeInput("val", typeof(System.Object))]
	public class Set_ptMax : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ptMax = inputs[1];
			return null;
		}
	}
}
