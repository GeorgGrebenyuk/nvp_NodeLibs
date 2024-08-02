using NVP.API.Nodes;

namespace nanoCAD.nanoCADPreferencesOutput 
{
		[NodeInput("dynamic", typeof(object))]
		public class nanoCADPreferencesOutput_Constructor : INode 
		{
		public nanoCAD.InanoCADPreferencesOutput _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as nanoCAD.InanoCADPreferencesOutput;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class nanoCADPreferencesOutput_ConstructorCast : INode 
		{
		public nanoCAD.InanoCADPreferencesOutput _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as nanoCAD.InanoCADPreferencesOutput;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Returns the Application object.
		///</summary>
		[NodeInput("nanoCADPreferencesOutput", typeof(object))]
		public class Application : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Application);

			}
		}


		///<summary>
		///Specifies or returns the default printer for new layouts and modelspace.
		///</summary>
		[NodeInput("nanoCADPreferencesOutput", typeof(object))]
		[NodeInput("Path", typeof(System.String))]
		public class Set_DefaultOutputDevice : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.DefaultOutputDevice = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the default printer for new layouts and modelspace.
		///</summary>
		[NodeInput("nanoCADPreferencesOutput", typeof(object))]
		public class DefaultOutputDevice : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.DefaultOutputDevice);

			}
		}


		///<summary>
		///Specifies or returns whether to display a warning when printing must be spooled.
		///</summary>
		[NodeInput("nanoCADPreferencesOutput", typeof(object))]
		[NodeInput("Path", typeof(System.Object))]
		public class Set_PrinterSpoolAlert : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.PrinterSpoolAlert = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether to display a warning when printing must be spooled.
		///</summary>
		[NodeInput("nanoCADPreferencesOutput", typeof(object))]
		public class PrinterSpoolAlert : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.PrinterSpoolAlert);

			}
		}


		///<summary>
		///Specifies or returns whether to display a warning when there is a conflict with the specified paper size.
		///</summary>
		[NodeInput("nanoCADPreferencesOutput", typeof(object))]
		[NodeInput("Path", typeof(System.Object))]
		public class Set_PrinterPaperSizeAlert : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.PrinterPaperSizeAlert = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether to display a warning when there is a conflict with the specified paper size.
		///</summary>
		[NodeInput("nanoCADPreferencesOutput", typeof(object))]
		public class PrinterPaperSizeAlert : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.PrinterPaperSizeAlert);

			}
		}


		///<summary>
		///Specifies or returns whether older print scripts can be used.
		///</summary>
		[NodeInput("nanoCADPreferencesOutput", typeof(object))]
		[NodeInput("Path", typeof(System.Object))]
		public class Set_PlotLegacy : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.PlotLegacy = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether older print scripts can be used.
		///</summary>
		[NodeInput("nanoCADPreferencesOutput", typeof(object))]
		public class PlotLegacy : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.PlotLegacy);

			}
		}


		///<summary>
		///Specifies or returns the print quality of OLE objects.
		///</summary>
		[NodeInput("nanoCADPreferencesOutput", typeof(object))]
		[NodeInput("Path", typeof(System.Object))]
		public class Set_OLEQuality : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.OLEQuality = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the print quality of OLE objects.
		///</summary>
		[NodeInput("nanoCADPreferencesOutput", typeof(object))]
		public class OLEQuality : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.OLEQuality);

			}
		}


		///<summary>
		///Specifies or returns whether the print settings are used from the previous successful print job.
		///</summary>
		[NodeInput("nanoCADPreferencesOutput", typeof(object))]
		[NodeInput("Path", typeof(System.Object))]
		public class Set_UseLastPlotSettings : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.UseLastPlotSettings = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether the print settings are used from the previous successful print job.
		///</summary>
		[NodeInput("nanoCADPreferencesOutput", typeof(object))]
		public class UseLastPlotSettings : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.UseLastPlotSettings);

			}
		}


		///<summary>
		///Specifies or returns whether color-dependent plot style tables are used for new drawings.
		///</summary>
		[NodeInput("nanoCADPreferencesOutput", typeof(object))]
		[NodeInput("Path", typeof(System.Object))]
		public class Set_PlotPolicy : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.PlotPolicy = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether color-dependent plot style tables are used for new drawings.
		///</summary>
		[NodeInput("nanoCADPreferencesOutput", typeof(object))]
		public class PlotPolicy : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.PlotPolicy);

			}
		}


		///<summary>
		///Specifies or returns the default plot style table.
		///</summary>
		[NodeInput("nanoCADPreferencesOutput", typeof(object))]
		[NodeInput("Path", typeof(System.String))]
		public class Set_DefaultPlotStyleTable : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.DefaultPlotStyleTable = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the default plot style table.
		///</summary>
		[NodeInput("nanoCADPreferencesOutput", typeof(object))]
		public class DefaultPlotStyleTable : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.DefaultPlotStyleTable);

			}
		}


		///<summary>
		///Specifies or returns the default print style table for new drawings.
		///</summary>
		[NodeInput("nanoCADPreferencesOutput", typeof(object))]
		[NodeInput("Path", typeof(System.String))]
		public class Set_DefaultPlotStyleForObjects : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.DefaultPlotStyleForObjects = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the default print style table for new drawings.
		///</summary>
		[NodeInput("nanoCADPreferencesOutput", typeof(object))]
		public class DefaultPlotStyleForObjects : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.DefaultPlotStyleForObjects);

			}
		}


		///<summary>
		///Specifies or returns the default print style for new drawings.
		///</summary>
		[NodeInput("nanoCADPreferencesOutput", typeof(object))]
		[NodeInput("Path", typeof(System.String))]
		public class Set_DefaultPlotStyleForLayer : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.DefaultPlotStyleForLayer = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the default print style for new drawings.
		///</summary>
		[NodeInput("nanoCADPreferencesOutput", typeof(object))]
		public class DefaultPlotStyleForLayer : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.DefaultPlotStyleForLayer);

			}
		}
}
