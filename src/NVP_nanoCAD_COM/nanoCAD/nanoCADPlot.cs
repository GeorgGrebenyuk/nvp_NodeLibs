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
		Id = "9C4E7A2A-19D0-4133-A309-C1BE780287D6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlot.nanoCADPlot_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlot", 
		NodeName = "_nanoCADPlot_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "FC1B4E07-FEAB-4A51-8872-991ED4D722B9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlot.nanoCADPlot_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlot", 
		NodeName = "_nanoCADPlot_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "51269D45-8DDE-4322-A0C8-C0D9A1F39785", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlot.Application", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlot", 
		NodeName = "Application", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "C20FB3DB-D7AF-4CE0-892A-5D2D064C8B76", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlot.QuietErrorMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlot", 
		NodeName = "QuietErrorMode", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "BE312F7C-18FA-4E6E-B890-18B6F89E59FF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlot.Set_QuietErrorMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlot", 
		NodeName = "Set_QuietErrorMode", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "F1FCC3C5-199E-4002-8F0C-03941455249D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlot.NumberOfCopies", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlot", 
		NodeName = "NumberOfCopies", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "45336E34-654E-46B5-8A6C-093B202C41AF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlot.Set_NumberOfCopies", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlot", 
		NodeName = "Set_NumberOfCopies", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "EAD730AD-AB66-4655-84F7-859448B515CC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlot.BatchPlotProgress", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlot", 
		NodeName = "BatchPlotProgress", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "D9473CAF-F73F-4BAA-B6ED-8A1EE064EE7E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlot.Set_BatchPlotProgress", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlot", 
		NodeName = "Set_BatchPlotProgress", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "4C3E1C3E-B6AB-4C4D-97CA-58A4B380C21D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlot.DisplayPlotPreview", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlot", 
		NodeName = "DisplayPlotPreview", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "890AB2BA-BB9C-4085-A3D8-3095BE8F5A65", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlot.PlotToFile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlot", 
		NodeName = "PlotToFile", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "3E12BF69-D41E-4B7E-8B63-DF3C0BE932AA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlot.PlotToDevice", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlot", 
		NodeName = "PlotToDevice", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "C6A7DD98-1754-47DF-8B08-1817FDAAD4B0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlot.SetLayoutsToPlot", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlot", 
		NodeName = "SetLayoutsToPlot", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "22DC5946-A538-4285-870D-5C1844D58A8C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlot.StartBatchMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlot", 
		NodeName = "StartBatchMode", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "7E83B25C-AD18-4A85-958B-74ECE20BE7B4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlot.CustomPlotSettings", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlot", 
		NodeName = "CustomPlotSettings", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "214E510F-40D5-40D5-BBE7-47DC4CB09E85", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlot.Set_CustomPlotSettings", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlot", 
		NodeName = "Set_CustomPlotSettings", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "5BB2D5B3-F5B9-42EC-94B8-3562B52A9F47", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlot.Put_CustomPlotSettings", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlot", 
		NodeName = "Put_CustomPlotSettings", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "0559A882-D2B7-48B7-84CE-EF9A19823DD4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlot.BeginPage", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlot", 
		NodeName = "BeginPage", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "1EF77137-8EF7-42F3-B805-5EAC767BFDA5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPlot.EndPage", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPlot", 
		NodeName = "EndPage", 
		NodeType = "Loaded", 
		CADType = "None", 
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
