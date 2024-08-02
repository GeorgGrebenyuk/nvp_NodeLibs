using NVP.API.Nodes;

namespace nanoCAD.nanoCADPlotAreas 
{
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPlotAreas_Constructor : INode 
	{
		public nanoCAD.InanoCADPlotAreas _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.InanoCADPlotAreas;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPlotAreas_ConstructorCast : INode 
	{
		public nanoCAD.InanoCADPlotAreas _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.InanoCADPlotAreas;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///Returns plot area by index
	///</summary>
	[NodeInput("nanoCADPlotAreas", typeof(object))]
	[NodeInput("idx", typeof(System.Object))]
	public class Item : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Item(inputs[1]));

		}
	}


	///<summary>
	///Returns count of plot areas
	///</summary>
	[NodeInput("nanoCADPlotAreas", typeof(object))]
	public class Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Count);

		}
	}


	///<summary>
	///Create new plot area
	///</summary>
	[NodeInput("nanoCADPlotAreas", typeof(object))]
	public class Add : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Add);

		}
	}


	///<summary>
	///clears all plot areas
	///</summary>
	[NodeInput("nanoCADPlotAreas", typeof(object))]
	public class Clear : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Clear();
			return null;
		}
	}
}
