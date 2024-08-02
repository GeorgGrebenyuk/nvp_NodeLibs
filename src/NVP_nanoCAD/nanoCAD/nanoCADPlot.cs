using NVP.API.Nodes;

namespace nanoCAD.nanoCADPlot 
{
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


	///<summary>
	///Gets the Application object
	///</summary>
	[NodeInput("nanoCADPlot", typeof(object))]
	public class Application : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Application);

		}
	}


	///<summary>
	///Toggles the quiet error mode for plot error reporting
	///</summary>
	[NodeInput("nanoCADPlot", typeof(object))]
	public class QuietErrorMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.QuietErrorMode);

		}
	}


	///<summary>
	///Toggles the quiet error mode for plot error reporting
	///</summary>
	[NodeInput("nanoCADPlot", typeof(object))]
	[NodeInput("bErrorMode", typeof(System.Object))]
	public class Set_QuietErrorMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.QuietErrorMode = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the number of copies to plot
	///</summary>
	[NodeInput("nanoCADPlot", typeof(object))]
	public class NumberOfCopies : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NumberOfCopies);

		}
	}


	///<summary>
	///Specifies the number of copies to plot
	///</summary>
	[NodeInput("nanoCADPlot", typeof(object))]
	[NodeInput("numCopies", typeof(System.Object))]
	public class Set_NumberOfCopies : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.NumberOfCopies = inputs[1];
			return null;
		}
	}


	///<summary>
	///Gets the current status of the batch plot, or terminates the batch plot
	///</summary>
	[NodeInput("nanoCADPlot", typeof(object))]
	public class BatchPlotProgress : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BatchPlotProgress);

		}
	}


	///<summary>
	///Gets the current status of the batch plot, or terminates the batch plot
	///</summary>
	[NodeInput("nanoCADPlot", typeof(object))]
	[NodeInput("bProgressStatus", typeof(System.Object))]
	public class Set_BatchPlotProgress : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BatchPlotProgress = inputs[1];
			return null;
		}
	}


	///<summary>
	///Displays the Plot Preview dialog box with the specified partial or full view preview
	///</summary>
	[NodeInput("nanoCADPlot", typeof(object))]
	[NodeInput("Preview", typeof(System.Object))]
	public class DisplayPlotPreview : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DisplayPlotPreview(inputs[1]);
			return null;
		}
	}


	///<summary>
	///Plots a layout to the specified file
	///</summary>
	[NodeInput("nanoCADPlot", typeof(object))]
	[NodeInput("plotFile", typeof(System.String))]
	[NodeInput("plotConfig", typeof(System.Object))]
	public class PlotToFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlotToFile(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Plots a layout to a device
	///</summary>
	[NodeInput("nanoCADPlot", typeof(object))]
	[NodeInput("plotConfig", typeof(System.Object))]
	public class PlotToDevice : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlotToDevice(inputs[1]));

		}
	}


	///<summary>
	///Specifies the layout or layouts to plot
	///</summary>
	[NodeInput("nanoCADPlot", typeof(object))]
	[NodeInput("layoutList", typeof(System.Object))]
	public class SetLayoutsToPlot : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetLayoutsToPlot(inputs[1]);
			return null;
		}
	}


	///<summary>
	///Invokes batchmode printing
	///</summary>
	[NodeInput("nanoCADPlot", typeof(object))]
	[NodeInput("entryCount", typeof(System.Object))]
	public class StartBatchMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StartBatchMode(inputs[1]);
			return null;
		}
	}


	///<summary>
	///Retrieves custom plot settings
	///</summary>
	[NodeInput("nanoCADPlot", typeof(object))]
	[NodeInput("config", typeof(System.Object))]
	public class CustomPlotSettings : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CustomPlotSettings(inputs[1]));

		}
	}


	///<summary>
	///Retrieves custom plot settings
	///</summary>
	[NodeInput("nanoCADPlot", typeof(object))]
	[NodeInput("config", typeof(System.Object))]
	[NodeInput("param", typeof(System.Object))]
	public class Set_CustomPlotSettings : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CustomPlotSettings[inputs[1]] = inputs[2];
			return null;
		}
	}


	///<summary>
	///Retrieves custom plot settings
	///</summary>
	[NodeInput("nanoCADPlot", typeof(object))]
	[NodeInput("config", typeof(System.Object))]
	[NodeInput("param", typeof(System.Object))]
	public class Put_CustomPlotSettings : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CustomPlotSettings[inputs[1]] = inputs[2];
			return null;
		}
	}


	///<summary>
	///Triggered before page beging printing
	///</summary>
	[NodeInput("nanoCADPlot", typeof(object))]
	[NodeInput("TODOName", typeof(System.String))]
	public class BeginPage : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BeginPage(inputs[1]);
			return null;
		}
	}


	///<summary>
	///Triggered just after page has been plotted
	///</summary>
	[NodeInput("nanoCADPlot", typeof(object))]
	[NodeInput("Cancel", typeof(System.Object))]
	public class EndPage : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EndPage(inputs[1]);
			return null;
		}
	}
}
