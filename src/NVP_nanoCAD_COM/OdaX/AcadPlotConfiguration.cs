using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a named collection of plot settings
///</summary>
namespace OdaX.AcadPlotConfiguration 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadPlotConfiguration_Constructor : INode 
	{
		public OdaX.IAcadPlotConfiguration _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadPlotConfiguration;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadPlotConfiguration_ConstructorCast : INode 
	{
		public OdaX.IAcadPlotConfiguration _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadPlotConfiguration;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the name of the object.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Specifies or returns the name of the object.
	///</summary>
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the name of the object.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pName", typeof(System.String))]

	///<summary>
	///Specifies or returns the name of the object.
	///</summary>
	public class Set_Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Name = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the name of a plot configuration file.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Specifies or returns the name of a plot configuration file.
	///</summary>
	public class ConfigName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ConfigName);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the name of a plot configuration file.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pName", typeof(System.String))]

	///<summary>
	///Specifies or returns the name of a plot configuration file.
	///</summary>
	public class Set_ConfigName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ConfigName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the name of the media size.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Specifies or returns the name of the media size.
	///</summary>
	public class CanonicalMediaName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CanonicalMediaName);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the name of the media size.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pName", typeof(System.String))]

	///<summary>
	///Specifies or returns the name of the media size.
	///</summary>
	public class Set_CanonicalMediaName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CanonicalMediaName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the units used for plot configuration properties.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Specifies or returns the units used for plot configuration properties.
	///</summary>
	public class PaperUnits : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PaperUnits);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the units used for plot configuration properties.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("OdaX.AcPlotPaperUnits", typeof(System.Object))]

	///<summary>
	///Specifies or returns the units used for plot configuration properties.
	///</summary>
	public class Set_PaperUnits : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PaperUnits = ((OdaX.AcPlotPaperUnits)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether to print the edges of viewports.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Specifies or returns whether to print the edges of viewports.
	///</summary>
	public class PlotViewportBorders : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlotViewportBorders);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether to print the edges of viewports.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pViewportBorders", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether to print the edges of viewports.
	///</summary>
	public class Set_PlotViewportBorders : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PlotViewportBorders = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether plot styles are applied when displaying objects on the screen.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Specifies or returns whether plot styles are applied when displaying objects on the screen.
	///</summary>
	public class ShowPlotStyles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShowPlotStyles);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether plot styles are applied when displaying objects on the screen.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pStyles", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether plot styles are applied when displaying objects on the screen.
	///</summary>
	public class Set_ShowPlotStyles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShowPlotStyles = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the rotation angle of the plot configuration.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Specifies or returns the rotation angle of the plot configuration.
	///</summary>
	public class PlotRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlotRotation);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the rotation angle of the plot configuration.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("OdaX.AcPlotRotation", typeof(System.Object))]

	///<summary>
	///Specifies or returns the rotation angle of the plot configuration.
	///</summary>
	public class Set_PlotRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PlotRotation = ((OdaX.AcPlotRotation)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether objects are centered on the printed media.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Specifies or returns whether objects are centered on the printed media.
	///</summary>
	public class CenterPlot : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CenterPlot);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether objects are centered on the printed media.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pCentered", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether objects are centered on the printed media.
	///</summary>
	public class Set_CenterPlot : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CenterPlot = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether objects are printed.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Specifies or returns whether objects are printed.
	///</summary>
	public class PlotHidden : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlotHidden);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether objects are printed.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pHidden", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether objects are printed.
	///</summary>
	public class Set_PlotHidden : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PlotHidden = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the method used to determine which objects print.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Specifies or returns the method used to determine which objects print.
	///</summary>
	public class PlotType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlotType);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the method used to determine which objects print.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("OdaX.AcPlotType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the method used to determine which objects print.
	///</summary>
	public class Set_PlotType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PlotType = ((OdaX.AcPlotType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the name of the view to print.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Specifies or returns the name of the view to print.
	///</summary>
	public class ViewToPlot : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ViewToPlot);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the name of the view to print.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pName", typeof(System.String))]

	///<summary>
	///Specifies or returns the name of the view to print.
	///</summary>
	public class Set_ViewToPlot : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ViewToPlot = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether to print using a standard scale or custom scale.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Specifies or returns whether to print using a standard scale or custom scale.
	///</summary>
	public class UseStandardScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UseStandardScale);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether to print using a standard scale or custom scale.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pUseStdScale", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether to print using a standard scale or custom scale.
	///</summary>
	public class Set_UseStandardScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UseStandardScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the standard scale value.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Specifies or returns the standard scale value.
	///</summary>
	public class StandardScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StandardScale);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the standard scale value.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("OdaX.AcPlotScale", typeof(System.Object))]

	///<summary>
	///Specifies or returns the standard scale value.
	///</summary>
	public class Set_StandardScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StandardScale = ((OdaX.AcPlotScale)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the custom scale value.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("Numerator", typeof(System.Double))]
	[NodeInput("Denominator", typeof(System.Double))]

	///<summary>
	///Returns the custom scale value.
	///</summary>
	public class GetCustomScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetCustomScale(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Sets the custom scale value.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("Numerator", typeof(System.Double))]
	[NodeInput("Denominator", typeof(System.Double))]

	///<summary>
	///Sets the custom scale value.
	///</summary>
	public class SetCustomScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetCustomScale(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether lineweights are scaled during printing.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Specifies or returns whether lineweights are scaled during printing.
	///</summary>
	public class ScaleLineweights : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ScaleLineweights);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether lineweights are scaled during printing.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pScale", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether lineweights are scaled during printing.
	///</summary>
	public class Set_ScaleLineweights : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ScaleLineweights = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether objects print with lineweights.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Specifies or returns whether objects print with lineweights.
	///</summary>
	public class PlotWithLineweights : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlotWithLineweights);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether objects print with lineweights.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pPlot", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether objects print with lineweights.
	///</summary>
	public class Set_PlotWithLineweights : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PlotWithLineweights = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether objects in paperspace print first.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Specifies or returns whether objects in paperspace print first.
	///</summary>
	public class PlotViewportsFirst : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlotViewportsFirst);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether objects in paperspace print first.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pViewportsFirst", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether objects in paperspace print first.
	///</summary>
	public class Set_PlotViewportsFirst : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PlotViewportsFirst = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the style sheet used for printing.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Specifies or returns the style sheet used for printing.
	///</summary>
	public class StyleSheet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StyleSheet);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the style sheet used for printing.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pName", typeof(System.String))]

	///<summary>
	///Specifies or returns the style sheet used for printing.
	///</summary>
	public class Set_StyleSheet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StyleSheet = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the margins used for printing.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("LowerLeft", typeof(System.Object))]
	[NodeInput("UpperRight", typeof(System.Object))]

	///<summary>
	///Returns the margins used for printing.
	///</summary>
	public class GetPaperMargins : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetPaperMargins(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the width and height of the specified media.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("Width", typeof(System.Double))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Returns the width and height of the specified media.
	///</summary>
	public class GetPaperSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetPaperSize(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the origin point used for printing.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Specifies or returns the origin point used for printing.
	///</summary>
	public class PlotOrigin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlotOrigin);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the origin point used for printing.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pOrigin", typeof(System.Object))]

	///<summary>
	///Specifies or returns the origin point used for printing.
	///</summary>
	public class Set_PlotOrigin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PlotOrigin = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the coordinates that define the area to print.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("LowerLeft", typeof(System.Object))]
	[NodeInput("UpperRight", typeof(System.Object))]

	///<summary>
	///Returns the coordinates that define the area to print.
	///</summary>
	public class GetWindowToPlot : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetWindowToPlot(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Sets the coordinates that define the area to print.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("LowerLeft", typeof(System.Object))]
	[NodeInput("UpperRight", typeof(System.Object))]

	///<summary>
	///Sets the coordinates that define the area to print.
	///</summary>
	public class SetWindowToPlot : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetWindowToPlot(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether objects print with settings from the plot configuration file or settings from the drawing.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Specifies or returns whether objects print with settings from the plot configuration file or settings from the drawing.
	///</summary>
	public class PlotWithPlotStyles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlotWithPlotStyles);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether objects print with settings from the plot configuration file or settings from the drawing.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pStyles", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether objects print with settings from the plot configuration file or settings from the drawing.
	///</summary>
	public class Set_PlotWithPlotStyles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PlotWithPlotStyles = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns whether the settings apply to objects in a modelspace layout only or both modelspace and paperspace layouts.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Returns whether the settings apply to objects in a modelspace layout only or both modelspace and paperspace layouts.
	///</summary>
	public class ModelType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ModelType);

		}
	}


	[NVP_Manifest(
		Text = "Copies settings from a plot configuration file.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pPlotConfig", typeof(System.Object))]

	///<summary>
	///Copies settings from a plot configuration file.
	///</summary>
	public class CopyFrom : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CopyFrom(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns names of the media available for a print device.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Returns names of the media available for a print device.
	///</summary>
	public class GetCanonicalMediaNames : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCanonicalMediaNames);

		}
	}


	[NVP_Manifest(
		Text = "Returns print device names.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Returns print device names.
	///</summary>
	public class GetPlotDeviceNames : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPlotDeviceNames);

		}
	}


	[NVP_Manifest(
		Text = "Returns plot style table names.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Returns plot style table names.
	///</summary>
	public class GetPlotStyleTableNames : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPlotStyleTableNames);

		}
	}


	[NVP_Manifest(
		Text = "Updates print device information with the current settings.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]

	///<summary>
	///Updates print device information with the current settings.
	///</summary>
	public class RefreshPlotDeviceInfo : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RefreshPlotDeviceInfo();
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the localized version of a media name.", 
		ViewType = "Data")]
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Returns the localized version of a media name.
	///</summary>
	public class GetLocaleMediaName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetLocaleMediaName(inputs[1].Value));

		}
	}
}
