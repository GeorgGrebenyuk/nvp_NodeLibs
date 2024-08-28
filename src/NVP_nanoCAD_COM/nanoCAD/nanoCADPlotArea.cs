using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///The set of methods and properties used for plotting layouts
///</summary>
namespace NVP_nanoCAD_COM._nanoCAD.nanoCADPlotArea 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
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

	[NVP_Manifest(
		ViewType = "Modifier")]
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


	[NVP_Manifest(
		Text = "Retrieves offset val", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlotArea", typeof(object))]

	///<summary>
	///Retrieves offset val
	///</summary>
	public class Offset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Offset);

		}
	}


	[NVP_Manifest(
		Text = "Retrieves offset val", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlotArea", typeof(object))]
	[NodeInput("val", typeof(System.Object))]

	///<summary>
	///Retrieves offset val
	///</summary>
	public class Set_Offset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Offset = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Retrieves ptMin val", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlotArea", typeof(object))]

	///<summary>
	///Retrieves ptMin val
	///</summary>
	public class ptMin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ptMin);

		}
	}


	[NVP_Manifest(
		Text = "Retrieves ptMin val", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlotArea", typeof(object))]
	[NodeInput("val", typeof(System.Object))]

	///<summary>
	///Retrieves ptMin val
	///</summary>
	public class Set_ptMin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ptMin = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Retrieves ptMax val", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlotArea", typeof(object))]

	///<summary>
	///Retrieves ptMax val
	///</summary>
	public class ptMax : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ptMax);

		}
	}


	[NVP_Manifest(
		Text = "Retrieves ptMax val", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlotArea", typeof(object))]
	[NodeInput("val", typeof(System.Object))]

	///<summary>
	///Retrieves ptMax val
	///</summary>
	public class Set_ptMax : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ptMax = inputs[1].Value;
			return null;
		}
	}
}
