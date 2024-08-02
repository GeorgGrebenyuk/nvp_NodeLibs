using NVP.API.Nodes;

namespace OdaX.AcadDatabasePreferences 
{
		[NodeInput("dynamic", typeof(object))]
		public class AcadDatabasePreferences_Constructor : INode 
		{
		public OdaX.IAcadDatabasePreferences _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IAcadDatabasePreferences;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class AcadDatabasePreferences_ConstructorCast : INode 
		{
		public OdaX.IAcadDatabasePreferences _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IAcadDatabasePreferences;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Returns the Application object.
		///</summary>
		[NodeInput("AcadDatabasePreferences", typeof(object))]
		public class Application : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Application);

			}
		}


		///<summary>
		///Specifies or returns whether certain objects in a document are filled in.
		///</summary>
		[NodeInput("AcadDatabasePreferences", typeof(object))]
		public class SolidFill : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.SolidFill);

			}
		}


		///<summary>
		///Specifies or returns whether certain objects in a document are filled in.
		///</summary>
		[NodeInput("AcadDatabasePreferences", typeof(object))]
		[NodeInput("Fill", typeof(System.Object))]
		public class Set_SolidFill : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SolidFill = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether a document can be edited when it is used as an external reference.
		///</summary>
		[NodeInput("AcadDatabasePreferences", typeof(object))]
		public class XRefEdit : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.XRefEdit);

			}
		}


		///<summary>
		///Specifies or returns whether a document can be edited when it is used as an external reference.
		///</summary>
		[NodeInput("AcadDatabasePreferences", typeof(object))]
		[NodeInput("Edit", typeof(System.Object))]
		public class Set_XRefEdit : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.XRefEdit = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether changes to layers and paths of an external reference are saved with the document.
		///</summary>
		[NodeInput("AcadDatabasePreferences", typeof(object))]
		public class XRefLayerVisibility : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.XRefLayerVisibility);

			}
		}


		///<summary>
		///Specifies or returns whether changes to layers and paths of an external reference are saved with the document.
		///</summary>
		[NodeInput("AcadDatabasePreferences", typeof(object))]
		[NodeInput("XRefLayerVis", typeof(System.Object))]
		public class Set_XRefLayerVisibility : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.XRefLayerVisibility = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether to open an OLE object's corresponding application when printing the OLE object.
		///</summary>
		[NodeInput("AcadDatabasePreferences", typeof(object))]
		public class OLELaunch : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.OLELaunch);

			}
		}


		///<summary>
		///Specifies or returns whether to open an OLE object's corresponding application when printing the OLE object.
		///</summary>
		[NodeInput("AcadDatabasePreferences", typeof(object))]
		[NodeInput("Launch", typeof(System.Object))]
		public class Set_OLELaunch : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.OLELaunch = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether symbol names can include extended characters.
		///</summary>
		[NodeInput("AcadDatabasePreferences", typeof(object))]
		public class AllowLongSymbolNames : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.AllowLongSymbolNames);

			}
		}


		///<summary>
		///Specifies or returns whether symbol names can include extended characters.
		///</summary>
		[NodeInput("AcadDatabasePreferences", typeof(object))]
		[NodeInput("LongNames", typeof(System.Object))]
		public class Set_AllowLongSymbolNames : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.AllowLongSymbolNames = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether objects are sorted by entity selection.
		///</summary>
		[NodeInput("AcadDatabasePreferences", typeof(object))]
		public class ObjectSortBySelection : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ObjectSortBySelection);

			}
		}


		///<summary>
		///Specifies or returns whether objects are sorted by entity selection.
		///</summary>
		[NodeInput("AcadDatabasePreferences", typeof(object))]
		[NodeInput("Sort", typeof(System.Object))]
		public class Set_ObjectSortBySelection : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ObjectSortBySelection = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether objects are sorted by object snap.
		///</summary>
		[NodeInput("AcadDatabasePreferences", typeof(object))]
		public class ObjectSortBySnap : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ObjectSortBySnap);

			}
		}


		///<summary>
		///Specifies or returns whether objects are sorted by object snap.
		///</summary>
		[NodeInput("AcadDatabasePreferences", typeof(object))]
		[NodeInput("Sort", typeof(System.Object))]
		public class Set_ObjectSortBySnap : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ObjectSortBySnap = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether objects are sorted by redraw order.
		///</summary>
		[NodeInput("AcadDatabasePreferences", typeof(object))]
		public class ObjectSortByRedraws : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ObjectSortByRedraws);

			}
		}


		///<summary>
		///Specifies or returns whether objects are sorted by redraw order.
		///</summary>
		[NodeInput("AcadDatabasePreferences", typeof(object))]
		[NodeInput("Sort", typeof(System.Object))]
		public class Set_ObjectSortByRedraws : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ObjectSortByRedraws = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether objects are sorted by regeneration order.
		///</summary>
		[NodeInput("AcadDatabasePreferences", typeof(object))]
		public class ObjectSortByRegens : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ObjectSortByRegens);

			}
		}


		///<summary>
		///Specifies or returns whether objects are sorted by regeneration order.
		///</summary>
		[NodeInput("AcadDatabasePreferences", typeof(object))]
		[NodeInput("Sort", typeof(System.Object))]
		public class Set_ObjectSortByRegens : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ObjectSortByRegens = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether objects are sorted by printing order.
		///</summary>
		[NodeInput("AcadDatabasePreferences", typeof(object))]
		public class ObjectSortByPlotting : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ObjectSortByPlotting);

			}
		}


		///<summary>
		///Specifies or returns whether objects are sorted by printing order.
		///</summary>
		[NodeInput("AcadDatabasePreferences", typeof(object))]
		[NodeInput("Sort", typeof(System.Object))]
		public class Set_ObjectSortByPlotting : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ObjectSortByPlotting = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether objects are sorted by PostScript output order.
		///</summary>
		[NodeInput("AcadDatabasePreferences", typeof(object))]
		public class ObjectSortByPSOutput : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ObjectSortByPSOutput);

			}
		}


		///<summary>
		///Specifies or returns whether objects are sorted by PostScript output order.
		///</summary>
		[NodeInput("AcadDatabasePreferences", typeof(object))]
		[NodeInput("Sort", typeof(System.Object))]
		public class Set_ObjectSortByPSOutput : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ObjectSortByPSOutput = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the number of isolines per surface for objects.
		///</summary>
		[NodeInput("AcadDatabasePreferences", typeof(object))]
		[NodeInput("Path", typeof(System.Object))]
		public class Set_ContourLinesPerSurface : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ContourLinesPerSurface = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the number of isolines per surface for objects.
		///</summary>
		[NodeInput("AcadDatabasePreferences", typeof(object))]
		public class ContourLinesPerSurface : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ContourLinesPerSurface);

			}
		}


		///<summary>
		///Specifies or returns whether silhouette curves of 3D solids display in wireframe view.
		///</summary>
		[NodeInput("AcadDatabasePreferences", typeof(object))]
		[NodeInput("Path", typeof(System.Object))]
		public class Set_DisplaySilhouette : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.DisplaySilhouette = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether silhouette curves of 3D solids display in wireframe view.
		///</summary>
		[NodeInput("AcadDatabasePreferences", typeof(object))]
		public class DisplaySilhouette : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.DisplaySilhouette);

			}
		}


		///<summary>
		///Specifies or returns the maximum number of active viewports allowed in a document.
		///</summary>
		[NodeInput("AcadDatabasePreferences", typeof(object))]
		[NodeInput("Path", typeof(System.Object))]
		public class Set_MaxActiveViewports : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.MaxActiveViewports = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the maximum number of active viewports allowed in a document.
		///</summary>
		[NodeInput("AcadDatabasePreferences", typeof(object))]
		public class MaxActiveViewports : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.MaxActiveViewports);

			}
		}


		///<summary>
		///Specifies or returns the quality of hidden, shaded, and rendered objects.
		///</summary>
		[NodeInput("AcadDatabasePreferences", typeof(object))]
		[NodeInput("Path", typeof(System.Double))]
		public class Set_RenderSmoothness : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.RenderSmoothness = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the quality of hidden, shaded, and rendered objects.
		///</summary>
		[NodeInput("AcadDatabasePreferences", typeof(object))]
		public class RenderSmoothness : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.RenderSmoothness);

			}
		}


		///<summary>
		///Specifies or returns the number of line segments generated for polylines.
		///</summary>
		[NodeInput("AcadDatabasePreferences", typeof(object))]
		[NodeInput("Path", typeof(System.Object))]
		public class Set_SegmentPerPolyline : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SegmentPerPolyline = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the number of line segments generated for polylines.
		///</summary>
		[NodeInput("AcadDatabasePreferences", typeof(object))]
		public class SegmentPerPolyline : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.SegmentPerPolyline);

			}
		}


		///<summary>
		///Specifies or returns whether text frames display instead of text.
		///</summary>
		[NodeInput("AcadDatabasePreferences", typeof(object))]
		[NodeInput("Path", typeof(System.Object))]
		public class Set_TextFrameDisplay : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TextFrameDisplay = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether text frames display instead of text.
		///</summary>
		[NodeInput("AcadDatabasePreferences", typeof(object))]
		public class TextFrameDisplay : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TextFrameDisplay);

			}
		}


		///<summary>
		///Not implemented. Specifies or returns the default lineweight for a document.
		///</summary>
		[NodeInput("AcadDatabasePreferences", typeof(object))]
		[NodeInput("Path", typeof(System.Object))]
		public class Set_Lineweight : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Lineweight = inputs[1];
				return null;
			}
		}


		///<summary>
		///Not implemented. Specifies or returns the default lineweight for a document.
		///</summary>
		[NodeInput("AcadDatabasePreferences", typeof(object))]
		public class Lineweight : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Lineweight);

			}
		}


		///<summary>
		///Specifies or returns whether lineweights display in a document.
		///</summary>
		[NodeInput("AcadDatabasePreferences", typeof(object))]
		[NodeInput("Path", typeof(System.Object))]
		public class Set_LineWeightDisplay : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.LineWeightDisplay = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether lineweights display in a document.
		///</summary>
		[NodeInput("AcadDatabasePreferences", typeof(object))]
		public class LineWeightDisplay : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LineWeightDisplay);

			}
		}
}
