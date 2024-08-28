using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///The set of methods and properties used for plotting layouts
///</summary>
namespace NVP_nanoCAD_COM._nanoCAD.nanoCADPlotAreas 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
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

	[NVP_Manifest(
		ViewType = "Modifier")]
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


	[NVP_Manifest(
		Text = "Returns plot area by index", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlotAreas", typeof(object))]
	[NodeInput("idx", typeof(System.Object))]

	///<summary>
	///Returns plot area by index
	///</summary>
	public class Item : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Item(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Returns count of plot areas", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlotAreas", typeof(object))]

	///<summary>
	///Returns count of plot areas
	///</summary>
	public class Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Count);

		}
	}


	[NVP_Manifest(
		Text = "Create new plot area", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlotAreas", typeof(object))]

	///<summary>
	///Create new plot area
	///</summary>
	public class Add : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Add);

		}
	}


	[NVP_Manifest(
		Text = "clears all plot areas", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlotAreas", typeof(object))]

	///<summary>
	///clears all plot areas
	///</summary>
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
