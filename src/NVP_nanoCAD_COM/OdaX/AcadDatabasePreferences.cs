using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of an object that specifies the settings for the current TeighaX drawing
///</summary>
namespace OdaX.AcadDatabasePreferences 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
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

	[NVP_Manifest(
		ViewType = "Modifier")]
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


	[NVP_Manifest(
		Text = "Returns the Application object.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]

	///<summary>
	///Returns the Application object.
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
		Text = "Specifies or returns whether certain objects in a document are filled in.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]

	///<summary>
	///Specifies or returns whether certain objects in a document are filled in.
	///</summary>
	public class SolidFill : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SolidFill);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether certain objects in a document are filled in.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]
	[NodeInput("Fill", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether certain objects in a document are filled in.
	///</summary>
	public class Set_SolidFill : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SolidFill = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a document can be edited when it is used as an external reference.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]

	///<summary>
	///Specifies or returns whether a document can be edited when it is used as an external reference.
	///</summary>
	public class XRefEdit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.XRefEdit);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a document can be edited when it is used as an external reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]
	[NodeInput("Edit", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether a document can be edited when it is used as an external reference.
	///</summary>
	public class Set_XRefEdit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.XRefEdit = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether changes to layers and paths of an external reference are saved with the document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]

	///<summary>
	///Specifies or returns whether changes to layers and paths of an external reference are saved with the document.
	///</summary>
	public class XRefLayerVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.XRefLayerVisibility);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether changes to layers and paths of an external reference are saved with the document.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]
	[NodeInput("XRefLayerVis", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether changes to layers and paths of an external reference are saved with the document.
	///</summary>
	public class Set_XRefLayerVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.XRefLayerVisibility = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether to open an OLE object's corresponding application when printing the OLE object.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]

	///<summary>
	///Specifies or returns whether to open an OLE object's corresponding application when printing the OLE object.
	///</summary>
	public class OLELaunch : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OLELaunch);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether to open an OLE object's corresponding application when printing the OLE object.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]
	[NodeInput("Launch", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether to open an OLE object's corresponding application when printing the OLE object.
	///</summary>
	public class Set_OLELaunch : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OLELaunch = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether symbol names can include extended characters.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]

	///<summary>
	///Specifies or returns whether symbol names can include extended characters.
	///</summary>
	public class AllowLongSymbolNames : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AllowLongSymbolNames);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether symbol names can include extended characters.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]
	[NodeInput("LongNames", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether symbol names can include extended characters.
	///</summary>
	public class Set_AllowLongSymbolNames : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AllowLongSymbolNames = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether objects are sorted by entity selection.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]

	///<summary>
	///Specifies or returns whether objects are sorted by entity selection.
	///</summary>
	public class ObjectSortBySelection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ObjectSortBySelection);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether objects are sorted by entity selection.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]
	[NodeInput("Sort", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether objects are sorted by entity selection.
	///</summary>
	public class Set_ObjectSortBySelection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ObjectSortBySelection = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether objects are sorted by object snap.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]

	///<summary>
	///Specifies or returns whether objects are sorted by object snap.
	///</summary>
	public class ObjectSortBySnap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ObjectSortBySnap);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether objects are sorted by object snap.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]
	[NodeInput("Sort", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether objects are sorted by object snap.
	///</summary>
	public class Set_ObjectSortBySnap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ObjectSortBySnap = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether objects are sorted by redraw order.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]

	///<summary>
	///Specifies or returns whether objects are sorted by redraw order.
	///</summary>
	public class ObjectSortByRedraws : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ObjectSortByRedraws);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether objects are sorted by redraw order.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]
	[NodeInput("Sort", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether objects are sorted by redraw order.
	///</summary>
	public class Set_ObjectSortByRedraws : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ObjectSortByRedraws = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether objects are sorted by regeneration order.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]

	///<summary>
	///Specifies or returns whether objects are sorted by regeneration order.
	///</summary>
	public class ObjectSortByRegens : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ObjectSortByRegens);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether objects are sorted by regeneration order.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]
	[NodeInput("Sort", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether objects are sorted by regeneration order.
	///</summary>
	public class Set_ObjectSortByRegens : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ObjectSortByRegens = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether objects are sorted by printing order.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]

	///<summary>
	///Specifies or returns whether objects are sorted by printing order.
	///</summary>
	public class ObjectSortByPlotting : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ObjectSortByPlotting);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether objects are sorted by printing order.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]
	[NodeInput("Sort", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether objects are sorted by printing order.
	///</summary>
	public class Set_ObjectSortByPlotting : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ObjectSortByPlotting = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether objects are sorted by PostScript output order.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]

	///<summary>
	///Specifies or returns whether objects are sorted by PostScript output order.
	///</summary>
	public class ObjectSortByPSOutput : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ObjectSortByPSOutput);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether objects are sorted by PostScript output order.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]
	[NodeInput("Sort", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether objects are sorted by PostScript output order.
	///</summary>
	public class Set_ObjectSortByPSOutput : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ObjectSortByPSOutput = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the number of isolines per surface for objects.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns the number of isolines per surface for objects.
	///</summary>
	public class Set_ContourLinesPerSurface : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ContourLinesPerSurface = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the number of isolines per surface for objects.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]

	///<summary>
	///Specifies or returns the number of isolines per surface for objects.
	///</summary>
	public class ContourLinesPerSurface : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ContourLinesPerSurface);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether silhouette curves of 3D solids display in wireframe view.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether silhouette curves of 3D solids display in wireframe view.
	///</summary>
	public class Set_DisplaySilhouette : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DisplaySilhouette = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether silhouette curves of 3D solids display in wireframe view.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]

	///<summary>
	///Specifies or returns whether silhouette curves of 3D solids display in wireframe view.
	///</summary>
	public class DisplaySilhouette : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DisplaySilhouette);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the maximum number of active viewports allowed in a document.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns the maximum number of active viewports allowed in a document.
	///</summary>
	public class Set_MaxActiveViewports : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MaxActiveViewports = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the maximum number of active viewports allowed in a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]

	///<summary>
	///Specifies or returns the maximum number of active viewports allowed in a document.
	///</summary>
	public class MaxActiveViewports : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MaxActiveViewports);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the quality of hidden, shaded, and rendered objects.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]
	[NodeInput("Path", typeof(System.Double))]

	///<summary>
	///Specifies or returns the quality of hidden, shaded, and rendered objects.
	///</summary>
	public class Set_RenderSmoothness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RenderSmoothness = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the quality of hidden, shaded, and rendered objects.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]

	///<summary>
	///Specifies or returns the quality of hidden, shaded, and rendered objects.
	///</summary>
	public class RenderSmoothness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RenderSmoothness);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the number of line segments generated for polylines.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns the number of line segments generated for polylines.
	///</summary>
	public class Set_SegmentPerPolyline : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SegmentPerPolyline = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the number of line segments generated for polylines.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]

	///<summary>
	///Specifies or returns the number of line segments generated for polylines.
	///</summary>
	public class SegmentPerPolyline : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SegmentPerPolyline);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether text frames display instead of text.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether text frames display instead of text.
	///</summary>
	public class Set_TextFrameDisplay : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextFrameDisplay = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether text frames display instead of text.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]

	///<summary>
	///Specifies or returns whether text frames display instead of text.
	///</summary>
	public class TextFrameDisplay : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextFrameDisplay);

		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Specifies or returns the default lineweight for a document.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]
	[NodeInput("OdaX.AcLineWeight", typeof(System.Object))]

	///<summary>
	///Not implemented. Specifies or returns the default lineweight for a document.
	///</summary>
	public class Set_Lineweight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Lineweight = ((OdaX.AcLineWeight)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Specifies or returns the default lineweight for a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]

	///<summary>
	///Not implemented. Specifies or returns the default lineweight for a document.
	///</summary>
	public class Lineweight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Lineweight);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether lineweights display in a document.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether lineweights display in a document.
	///</summary>
	public class Set_LineWeightDisplay : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LineWeightDisplay = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether lineweights display in a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabasePreferences", typeof(object))]

	///<summary>
	///Specifies or returns whether lineweights display in a document.
	///</summary>
	public class LineWeightDisplay : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LineWeightDisplay);

		}
	}
}
