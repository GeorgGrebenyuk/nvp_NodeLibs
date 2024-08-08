using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///The set of methods and properties used for plotting layouts
///</summary>
namespace nanoCAD.nanoCADPlotAreas 
{

	[NVP_Manifest(
		Id = "AC306C04-46B3-4C3A-9ECA-BE2A75CCCAB1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotAreas.nanoCADPlotAreas_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotAreas", 
		NodeName = "_nanoCADPlotAreas_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "CF21D6BC-61CA-4327-BFFC-2141EECE6F14", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotAreas.nanoCADPlotAreas_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotAreas", 
		NodeName = "_nanoCADPlotAreas_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "B810E91D-CEAA-4752-9B27-514A24106B9D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotAreas.Item", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotAreas", 
		NodeName = "Item", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "DBFD7EFF-395D-48C7-B909-8737641A8F87", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotAreas.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotAreas", 
		NodeName = "Count", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "0CF48E07-2851-4A0E-88F7-A74991994231", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotAreas.Add", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotAreas", 
		NodeName = "Add", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "A32D11C6-4329-4EDB-B33C-BD6723516406", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlotAreas.Clear", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlotAreas", 
		NodeName = "Clear", 
		NodeType = "Loaded", 
		CADType = "None", 
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
