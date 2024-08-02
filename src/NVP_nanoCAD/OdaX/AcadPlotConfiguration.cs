using NVP.API.Nodes;

namespace OdaX.AcadPlotConfiguration 
{
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


	///<summary>
	///Specifies or returns the name of the object.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	///<summary>
	///Specifies or returns the name of the object.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pName", typeof(System.String))]
	public class Set_Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Name = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the name of a plot configuration file.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	public class ConfigName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ConfigName);

		}
	}


	///<summary>
	///Specifies or returns the name of a plot configuration file.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pName", typeof(System.String))]
	public class Set_ConfigName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ConfigName = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the name of the media size.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	public class CanonicalMediaName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CanonicalMediaName);

		}
	}


	///<summary>
	///Specifies or returns the name of the media size.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pName", typeof(System.String))]
	public class Set_CanonicalMediaName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CanonicalMediaName = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the units used for plot configuration properties.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	public class PaperUnits : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PaperUnits);

		}
	}


	///<summary>
	///Specifies or returns the units used for plot configuration properties.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pPaperUnits", typeof(System.Object))]
	public class Set_PaperUnits : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PaperUnits = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether to print the edges of viewports.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	public class PlotViewportBorders : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlotViewportBorders);

		}
	}


	///<summary>
	///Specifies or returns whether to print the edges of viewports.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pViewportBorders", typeof(System.Object))]
	public class Set_PlotViewportBorders : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PlotViewportBorders = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether plot styles are applied when displaying objects on the screen.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	public class ShowPlotStyles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShowPlotStyles);

		}
	}


	///<summary>
	///Specifies or returns whether plot styles are applied when displaying objects on the screen.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pStyles", typeof(System.Object))]
	public class Set_ShowPlotStyles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShowPlotStyles = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the rotation angle of the plot configuration.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	public class PlotRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlotRotation);

		}
	}


	///<summary>
	///Specifies or returns the rotation angle of the plot configuration.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pRotation", typeof(System.Object))]
	public class Set_PlotRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PlotRotation = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether objects are centered on the printed media.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	public class CenterPlot : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CenterPlot);

		}
	}


	///<summary>
	///Specifies or returns whether objects are centered on the printed media.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pCentered", typeof(System.Object))]
	public class Set_CenterPlot : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CenterPlot = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether objects are printed.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	public class PlotHidden : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlotHidden);

		}
	}


	///<summary>
	///Specifies or returns whether objects are printed.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pHidden", typeof(System.Object))]
	public class Set_PlotHidden : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PlotHidden = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the method used to determine which objects print.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	public class PlotType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlotType);

		}
	}


	///<summary>
	///Specifies or returns the method used to determine which objects print.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pType", typeof(System.Object))]
	public class Set_PlotType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PlotType = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the name of the view to print.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	public class ViewToPlot : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ViewToPlot);

		}
	}


	///<summary>
	///Specifies or returns the name of the view to print.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pName", typeof(System.String))]
	public class Set_ViewToPlot : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ViewToPlot = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether to print using a standard scale or custom scale.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	public class UseStandardScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UseStandardScale);

		}
	}


	///<summary>
	///Specifies or returns whether to print using a standard scale or custom scale.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pUseStdScale", typeof(System.Object))]
	public class Set_UseStandardScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UseStandardScale = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the standard scale value.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	public class StandardScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StandardScale);

		}
	}


	///<summary>
	///Specifies or returns the standard scale value.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pStdScale", typeof(System.Object))]
	public class Set_StandardScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StandardScale = inputs[1];
			return null;
		}
	}


	///<summary>
	///Returns the custom scale value.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("Numerator", typeof(System.Double))]
	[NodeInput("Denominator", typeof(System.Double))]
	public class GetCustomScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetCustomScale(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Sets the custom scale value.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("Numerator", typeof(System.Double))]
	[NodeInput("Denominator", typeof(System.Double))]
	public class SetCustomScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetCustomScale(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether lineweights are scaled during printing.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	public class ScaleLineweights : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ScaleLineweights);

		}
	}


	///<summary>
	///Specifies or returns whether lineweights are scaled during printing.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pScale", typeof(System.Object))]
	public class Set_ScaleLineweights : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ScaleLineweights = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether objects print with lineweights.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	public class PlotWithLineweights : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlotWithLineweights);

		}
	}


	///<summary>
	///Specifies or returns whether objects print with lineweights.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pPlot", typeof(System.Object))]
	public class Set_PlotWithLineweights : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PlotWithLineweights = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether objects in paperspace print first.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	public class PlotViewportsFirst : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlotViewportsFirst);

		}
	}


	///<summary>
	///Specifies or returns whether objects in paperspace print first.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pViewportsFirst", typeof(System.Object))]
	public class Set_PlotViewportsFirst : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PlotViewportsFirst = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the style sheet used for printing.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	public class StyleSheet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StyleSheet);

		}
	}


	///<summary>
	///Specifies or returns the style sheet used for printing.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pName", typeof(System.String))]
	public class Set_StyleSheet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StyleSheet = inputs[1];
			return null;
		}
	}


	///<summary>
	///Returns the margins used for printing.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("LowerLeft", typeof(System.Object))]
	[NodeInput("UpperRight", typeof(System.Object))]
	public class GetPaperMargins : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetPaperMargins(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Returns the width and height of the specified media.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("Width", typeof(System.Double))]
	[NodeInput("Height", typeof(System.Double))]
	public class GetPaperSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetPaperSize(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Specifies or returns the origin point used for printing.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	public class PlotOrigin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlotOrigin);

		}
	}


	///<summary>
	///Specifies or returns the origin point used for printing.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pOrigin", typeof(System.Object))]
	public class Set_PlotOrigin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PlotOrigin = inputs[1];
			return null;
		}
	}


	///<summary>
	///Returns the coordinates that define the area to print.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("LowerLeft", typeof(System.Object))]
	[NodeInput("UpperRight", typeof(System.Object))]
	public class GetWindowToPlot : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetWindowToPlot(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Sets the coordinates that define the area to print.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("LowerLeft", typeof(System.Object))]
	[NodeInput("UpperRight", typeof(System.Object))]
	public class SetWindowToPlot : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetWindowToPlot(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether objects print with settings from the plot configuration file or settings from the drawing.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	public class PlotWithPlotStyles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlotWithPlotStyles);

		}
	}


	///<summary>
	///Specifies or returns whether objects print with settings from the plot configuration file or settings from the drawing.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pStyles", typeof(System.Object))]
	public class Set_PlotWithPlotStyles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PlotWithPlotStyles = inputs[1];
			return null;
		}
	}


	///<summary>
	///Returns whether the settings apply to objects in a modelspace layout only or both modelspace and paperspace layouts.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	public class ModelType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ModelType);

		}
	}


	///<summary>
	///Copies settings from a plot configuration file.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("pPlotConfig", typeof(System.Object))]
	public class CopyFrom : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CopyFrom(inputs[1]);
			return null;
		}
	}


	///<summary>
	///Returns names of the media available for a print device.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	public class GetCanonicalMediaNames : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCanonicalMediaNames);

		}
	}


	///<summary>
	///Returns print device names.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	public class GetPlotDeviceNames : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPlotDeviceNames);

		}
	}


	///<summary>
	///Returns plot style table names.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	public class GetPlotStyleTableNames : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPlotStyleTableNames);

		}
	}


	///<summary>
	///Updates print device information with the current settings.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	public class RefreshPlotDeviceInfo : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RefreshPlotDeviceInfo();
			return null;
		}
	}


	///<summary>
	///Returns the localized version of a media name.
	///</summary>
	[NodeInput("AcadPlotConfiguration", typeof(object))]
	[NodeInput("Name", typeof(System.String))]
	public class GetLocaleMediaName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetLocaleMediaName(inputs[1]));

		}
	}
}
