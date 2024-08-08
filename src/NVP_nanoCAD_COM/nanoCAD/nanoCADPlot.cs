using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///The set of methods and properties used for plotting layouts
///</summary>
namespace nanoCAD.nanoCADPlot 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPlot_Constructor : INode 
	{
		public nanoCAD.InanoCADPlot _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.InanoCADPlot;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPlot_ConstructorCast : INode 
	{
		public nanoCAD.InanoCADPlot _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.InanoCADPlot;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Gets the Application object", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlot", typeof(object))]

	///<summary>
	///Gets the Application object
	///</summary>
	public class Application : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Application);

		}
	}


	[NVP_Manifest(
		Text = "Toggles the quiet error mode for plot error reporting", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlot", typeof(object))]

	///<summary>
	///Toggles the quiet error mode for plot error reporting
	///</summary>
	public class QuietErrorMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.QuietErrorMode);

		}
	}


	[NVP_Manifest(
		Text = "Toggles the quiet error mode for plot error reporting", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlot", typeof(object))]
	[NodeInput("bErrorMode", typeof(System.Object))]

	///<summary>
	///Toggles the quiet error mode for plot error reporting
	///</summary>
	public class Set_QuietErrorMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.QuietErrorMode = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the number of copies to plot", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlot", typeof(object))]

	///<summary>
	///Specifies the number of copies to plot
	///</summary>
	public class NumberOfCopies : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NumberOfCopies);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the number of copies to plot", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlot", typeof(object))]
	[NodeInput("numCopies", typeof(System.Object))]

	///<summary>
	///Specifies the number of copies to plot
	///</summary>
	public class Set_NumberOfCopies : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.NumberOfCopies = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Gets the current status of the batch plot, or terminates the batch plot", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlot", typeof(object))]

	///<summary>
	///Gets the current status of the batch plot, or terminates the batch plot
	///</summary>
	public class BatchPlotProgress : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BatchPlotProgress);

		}
	}


	[NVP_Manifest(
		Text = "Gets the current status of the batch plot, or terminates the batch plot", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlot", typeof(object))]
	[NodeInput("bProgressStatus", typeof(System.Object))]

	///<summary>
	///Gets the current status of the batch plot, or terminates the batch plot
	///</summary>
	public class Set_BatchPlotProgress : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BatchPlotProgress = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Displays the Plot Preview dialog box with the specified partial or full view preview", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlot", typeof(object))]
	[NodeInput("nanoCAD.AcPreviewMode", typeof(System.Object))]

	///<summary>
	///Displays the Plot Preview dialog box with the specified partial or full view preview
	///</summary>
	public class DisplayPlotPreview : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DisplayPlotPreview(((nanoCAD.AcPreviewMode)inputs[1].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Plots a layout to the specified file", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlot", typeof(object))]
	[NodeInput("plotFile", typeof(System.String))]
	[NodeInput("plotConfig", typeof(System.Object))]

	///<summary>
	///Plots a layout to the specified file
	///</summary>
	public class PlotToFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlotToFile(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Text = "Plots a layout to a device", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlot", typeof(object))]
	[NodeInput("plotConfig", typeof(System.Object))]

	///<summary>
	///Plots a layout to a device
	///</summary>
	public class PlotToDevice : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlotToDevice(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Specifies the layout or layouts to plot", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlot", typeof(object))]
	[NodeInput("layoutList", typeof(System.Object))]

	///<summary>
	///Specifies the layout or layouts to plot
	///</summary>
	public class SetLayoutsToPlot : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetLayoutsToPlot(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Invokes batchmode printing", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlot", typeof(object))]
	[NodeInput("entryCount", typeof(System.Object))]

	///<summary>
	///Invokes batchmode printing
	///</summary>
	public class StartBatchMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StartBatchMode(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Retrieves custom plot settings", 
		ViewType = "Data")]
	[NodeInput("nanoCADPlot", typeof(object))]
	[NodeInput("config", typeof(System.Object))]

	///<summary>
	///Retrieves custom plot settings
	///</summary>
	public class CustomPlotSettings : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CustomPlotSettings(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Retrieves custom plot settings", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlot", typeof(object))]
	[NodeInput("config", typeof(System.Object))]
	[NodeInput("param", typeof(System.Object))]

	///<summary>
	///Retrieves custom plot settings
	///</summary>
	public class Set_CustomPlotSettings : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CustomPlotSettings[inputs[1]] = inputs[2];
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Retrieves custom plot settings", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlot", typeof(object))]
	[NodeInput("config", typeof(System.Object))]
	[NodeInput("param", typeof(System.Object))]

	///<summary>
	///Retrieves custom plot settings
	///</summary>
	public class Put_CustomPlotSettings : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CustomPlotSettings[inputs[1]] = inputs[2];
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Triggered before page beging printing", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlot", typeof(object))]
	[NodeInput("TODOName", typeof(System.String))]

	///<summary>
	///Triggered before page beging printing
	///</summary>
	public class BeginPage : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BeginPage(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Triggered just after page has been plotted", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPlot", typeof(object))]
	[NodeInput("Cancel", typeof(System.Object))]

	///<summary>
	///Triggered just after page has been plotted
	///</summary>
	public class EndPage : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EndPage(inputs[1].Value);
			return null;
		}
	}
}
