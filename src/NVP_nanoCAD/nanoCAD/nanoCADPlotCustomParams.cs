using NVP.API.Nodes;

namespace nanoCAD.nanoCADPlotCustomParams 
{
		[NodeInput("dynamic", typeof(object))]
		public class nanoCADPlotCustomParams_Constructor : INode 
		{
		public nanoCAD.InanoCADPlotCustomParams _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as nanoCAD.InanoCADPlotCustomParams;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class nanoCADPlotCustomParams_ConstructorCast : INode 
		{
		public nanoCAD.InanoCADPlotCustomParams _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as nanoCAD.InanoCADPlotCustomParams;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///value
		///</summary>
		[NodeInput("nanoCADPlotCustomParams", typeof(object))]
		public class Params : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Params);

			}
		}


		///<summary>
		///value
		///</summary>
		[NodeInput("nanoCADPlotCustomParams", typeof(object))]
		[NodeInput("param", typeof(System.Object))]
		public class Set_Params : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Params = inputs[1];
				return null;
			}
		}


		///<summary>
		///value
		///</summary>
		[NodeInput("nanoCADPlotCustomParams", typeof(object))]
		[NodeInput("param", typeof(System.Object))]
		public class Put_Params : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Params = inputs[1];
				return null;
			}
		}


		///<summary>
		///Retrieves color mode value
		///</summary>
		[NodeInput("nanoCADPlotCustomParams", typeof(object))]
		public class ColorMode : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ColorMode);

			}
		}


		///<summary>
		///Retrieves color mode value
		///</summary>
		[NodeInput("nanoCADPlotCustomParams", typeof(object))]
		[NodeInput("val", typeof(System.Object))]
		public class Set_ColorMode : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ColorMode = inputs[1];
				return null;
			}
		}


		///<summary>
		///Retrieves PrinterDPI value
		///</summary>
		[NodeInput("nanoCADPlotCustomParams", typeof(object))]
		public class PrinterDPI : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.PrinterDPI);

			}
		}


		///<summary>
		///Retrieves PrinterDPI value
		///</summary>
		[NodeInput("nanoCADPlotCustomParams", typeof(object))]
		[NodeInput("val", typeof(System.Object))]
		public class Set_PrinterDPI : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.PrinterDPI = inputs[1];
				return null;
			}
		}


		///<summary>
		///Retrieves UsePrefinedNames value
		///</summary>
		[NodeInput("nanoCADPlotCustomParams", typeof(object))]
		public class UsePrefinedNames : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.UsePrefinedNames);

			}
		}


		///<summary>
		///Retrieves UsePrefinedNames value
		///</summary>
		[NodeInput("nanoCADPlotCustomParams", typeof(object))]
		[NodeInput("val", typeof(System.Object))]
		public class Set_UsePrefinedNames : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.UsePrefinedNames = inputs[1];
				return null;
			}
		}


		///<summary>
		///Retrieves IfFileExist value
		///</summary>
		[NodeInput("nanoCADPlotCustomParams", typeof(object))]
		public class IfFileExist : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.IfFileExist);

			}
		}


		///<summary>
		///Retrieves IfFileExist value
		///</summary>
		[NodeInput("nanoCADPlotCustomParams", typeof(object))]
		[NodeInput("val", typeof(System.Object))]
		public class Set_IfFileExist : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.IfFileExist = inputs[1];
				return null;
			}
		}


		///<summary>
		///Retrieves RunPDFApp value
		///</summary>
		[NodeInput("nanoCADPlotCustomParams", typeof(object))]
		public class RunPDFApp : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.RunPDFApp);

			}
		}


		///<summary>
		///Retrieves RunPDFApp value
		///</summary>
		[NodeInput("nanoCADPlotCustomParams", typeof(object))]
		[NodeInput("val", typeof(System.Object))]
		public class Set_RunPDFApp : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.RunPDFApp = inputs[1];
				return null;
			}
		}


		///<summary>
		///Retrieves UseDWGPath value
		///</summary>
		[NodeInput("nanoCADPlotCustomParams", typeof(object))]
		public class UseDWGPath : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.UseDWGPath);

			}
		}


		///<summary>
		///Retrieves UseDWGPath value
		///</summary>
		[NodeInput("nanoCADPlotCustomParams", typeof(object))]
		[NodeInput("val", typeof(System.Object))]
		public class Set_UseDWGPath : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.UseDWGPath = inputs[1];
				return null;
			}
		}


		///<summary>
		///Retrieves FileFolder value
		///</summary>
		[NodeInput("nanoCADPlotCustomParams", typeof(object))]
		public class FileFolder : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.FileFolder);

			}
		}


		///<summary>
		///Retrieves FileFolder value
		///</summary>
		[NodeInput("nanoCADPlotCustomParams", typeof(object))]
		[NodeInput("val", typeof(System.String))]
		public class Set_FileFolder : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.FileFolder = inputs[1];
				return null;
			}
		}


		///<summary>
		///Retrieves FileMask value
		///</summary>
		[NodeInput("nanoCADPlotCustomParams", typeof(object))]
		public class FileMask : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.FileMask);

			}
		}


		///<summary>
		///Retrieves FileMask value
		///</summary>
		[NodeInput("nanoCADPlotCustomParams", typeof(object))]
		[NodeInput("val", typeof(System.String))]
		public class Set_FileMask : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.FileMask = inputs[1];
				return null;
			}
		}


		///<summary>
		///Retrieves PlotToFile value
		///</summary>
		[NodeInput("nanoCADPlotCustomParams", typeof(object))]
		public class PlotToFile : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.PlotToFile);

			}
		}


		///<summary>
		///Retrieves PlotToFile value
		///</summary>
		[NodeInput("nanoCADPlotCustomParams", typeof(object))]
		[NodeInput("val", typeof(System.Object))]
		public class Set_PlotToFile : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.PlotToFile = inputs[1];
				return null;
			}
		}


		///<summary>
		///Retrieves Multipage value
		///</summary>
		[NodeInput("nanoCADPlotCustomParams", typeof(object))]
		public class Multipage : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Multipage);

			}
		}


		///<summary>
		///Retrieves Multipage value
		///</summary>
		[NodeInput("nanoCADPlotCustomParams", typeof(object))]
		[NodeInput("val", typeof(System.Object))]
		public class Set_Multipage : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Multipage = inputs[1];
				return null;
			}
		}


		///<summary>
		///Retrieves InflateWidth value
		///</summary>
		[NodeInput("nanoCADPlotCustomParams", typeof(object))]
		public class InflateWidth : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.InflateWidth);

			}
		}


		///<summary>
		///Retrieves InflateWidth value
		///</summary>
		[NodeInput("nanoCADPlotCustomParams", typeof(object))]
		[NodeInput("val", typeof(System.Double))]
		public class Set_InflateWidth : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.InflateWidth = inputs[1];
				return null;
			}
		}


		///<summary>
		///Retrieves Alignment value
		///</summary>
		[NodeInput("nanoCADPlotCustomParams", typeof(object))]
		public class Alignment : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Alignment);

			}
		}


		///<summary>
		///Retrieves Alignment value
		///</summary>
		[NodeInput("nanoCADPlotCustomParams", typeof(object))]
		[NodeInput("val", typeof(System.Object))]
		public class Set_Alignment : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Alignment = inputs[1];
				return null;
			}
		}


		///<summary>
		///Retrieves PaperOutMargins value
		///</summary>
		[NodeInput("nanoCADPlotCustomParams", typeof(object))]
		public class PaperOutMargins : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.PaperOutMargins);

			}
		}


		///<summary>
		///Retrieves PaperOutMargins value
		///</summary>
		[NodeInput("nanoCADPlotCustomParams", typeof(object))]
		[NodeInput("val", typeof(System.Object))]
		public class Set_PaperOutMargins : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.PaperOutMargins = inputs[1];
				return null;
			}
		}


		///<summary>
		///Retrieves Plot Areas
		///</summary>
		[NodeInput("nanoCADPlotCustomParams", typeof(object))]
		public class PlotAreas : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.PlotAreas);

			}
		}
}
