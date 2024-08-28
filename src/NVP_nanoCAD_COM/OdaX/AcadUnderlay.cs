using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace NVP_nanoCAD_COM._OdaX.AcadUnderlay 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadUnderlay_Constructor : INode 
	{
		public OdaX.IAcadUnderlay _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadUnderlay;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadUnderlay_ConstructorCast : INode 
	{
		public OdaX.IAcadUnderlay _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadUnderlay;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the contrast of the underlay.", 
		ViewType = "Data")]
	[NodeInput("AcadUnderlay", typeof(object))]

	///<summary>
	///Specifies or returns the contrast of the underlay.
	///</summary>
	public class Contrast : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Contrast);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the contrast of the underlay.", 
		ViewType = "Modifier")]
	[NodeInput("AcadUnderlay", typeof(object))]
	[NodeInput("Contrast", typeof(System.Object))]

	///<summary>
	///Specifies or returns the contrast of the underlay.
	///</summary>
	public class Set_Contrast : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Contrast = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the fade of the underlay.", 
		ViewType = "Data")]
	[NodeInput("AcadUnderlay", typeof(object))]

	///<summary>
	///Specifies or returns the fade of the underlay.
	///</summary>
	public class Fade : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Fade);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the fade of the underlay.", 
		ViewType = "Modifier")]
	[NodeInput("AcadUnderlay", typeof(object))]
	[NodeInput("Fade", typeof(System.Object))]

	///<summary>
	///Specifies or returns the fade of the underlay.
	///</summary>
	public class Set_Fade : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Fade = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the lower left point of the underlay position.", 
		ViewType = "Data")]
	[NodeInput("AcadUnderlay", typeof(object))]

	///<summary>
	///Specifies or returns the lower left point of the underlay position.
	///</summary>
	public class Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Position);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the lower left point of the underlay position.", 
		ViewType = "Modifier")]
	[NodeInput("AcadUnderlay", typeof(object))]
	[NodeInput("pos", typeof(System.Object))]

	///<summary>
	///Specifies or returns the lower left point of the underlay position.
	///</summary>
	public class Set_Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Position = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the rotation of the underlay.", 
		ViewType = "Data")]
	[NodeInput("AcadUnderlay", typeof(object))]

	///<summary>
	///Specifies or returns the rotation of the underlay.
	///</summary>
	public class Rotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Rotation);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the rotation of the underlay.", 
		ViewType = "Modifier")]
	[NodeInput("AcadUnderlay", typeof(object))]
	[NodeInput("rotAngle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the rotation of the underlay.
	///</summary>
	public class Set_Rotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Rotation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the width of the underlay.", 
		ViewType = "Data")]
	[NodeInput("AcadUnderlay", typeof(object))]

	///<summary>
	///Specifies or returns the width of the underlay.
	///</summary>
	public class Width : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Width);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the width of the underlay.", 
		ViewType = "Modifier")]
	[NodeInput("AcadUnderlay", typeof(object))]
	[NodeInput("Width", typeof(System.Double))]

	///<summary>
	///Specifies or returns the width of the underlay.
	///</summary>
	public class Set_Width : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Width = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the height of the underlay.", 
		ViewType = "Data")]
	[NodeInput("AcadUnderlay", typeof(object))]

	///<summary>
	///Specifies or returns the height of the underlay.
	///</summary>
	public class Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Height);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the height of the underlay.", 
		ViewType = "Modifier")]
	[NodeInput("AcadUnderlay", typeof(object))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Specifies or returns the height of the underlay.
	///</summary>
	public class Set_Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Height = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the name of the underlay file.", 
		ViewType = "Data")]
	[NodeInput("AcadUnderlay", typeof(object))]

	///<summary>
	///Specifies or returns the name of the underlay file.
	///</summary>
	public class UnderlayName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UnderlayName);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the name of the underlay file.", 
		ViewType = "Modifier")]
	[NodeInput("AcadUnderlay", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Specifies or returns the name of the underlay file.
	///</summary>
	public class Set_UnderlayName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UnderlayName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the item name of the underlay file.", 
		ViewType = "Modifier")]
	[NodeInput("AcadUnderlay", typeof(object))]
	[NodeInput("sheetName", typeof(System.String))]

	///<summary>
	///Specifies or returns the item name of the underlay file.
	///</summary>
	public class Set_ItemName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ItemName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the item name of the underlay file.", 
		ViewType = "Data")]
	[NodeInput("AcadUnderlay", typeof(object))]

	///<summary>
	///Specifies or returns the item name of the underlay file.
	///</summary>
	public class ItemName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ItemName);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the underlay displays in monochrome.", 
		ViewType = "Data")]
	[NodeInput("AcadUnderlay", typeof(object))]

	///<summary>
	///Specifies or returns whether the underlay displays in monochrome.
	///</summary>
	public class Monochrome : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Monochrome);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the underlay displays in monochrome.", 
		ViewType = "Modifier")]
	[NodeInput("AcadUnderlay", typeof(object))]
	[NodeInput("bMono", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the underlay displays in monochrome.
	///</summary>
	public class Set_Monochrome : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Monochrome = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether underlay colors are adjusted according to the background color.", 
		ViewType = "Data")]
	[NodeInput("AcadUnderlay", typeof(object))]

	///<summary>
	///Specifies or returns whether underlay colors are adjusted according to the background color.
	///</summary>
	public class AdjustForBackground : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AdjustForBackground);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether underlay colors are adjusted according to the background color.", 
		ViewType = "Modifier")]
	[NodeInput("AcadUnderlay", typeof(object))]
	[NodeInput("Value", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether underlay colors are adjusted according to the background color.
	///</summary>
	public class Set_AdjustForBackground : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AdjustForBackground = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies an area for displaying and printing the underlay.", 
		ViewType = "Modifier")]
	[NodeInput("AcadUnderlay", typeof(object))]
	[NodeInput("boundry", typeof(System.Object))]

	///<summary>
	///Specifies an area for displaying and printing the underlay.
	///</summary>
	public class ClipBoundary : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ClipBoundary(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the scale factor of the underlay.", 
		ViewType = "Data")]
	[NodeInput("AcadUnderlay", typeof(object))]

	///<summary>
	///Specifies or returns the scale factor of the underlay.
	///</summary>
	public class ScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ScaleFactor);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the scale factor of the underlay.", 
		ViewType = "Modifier")]
	[NodeInput("AcadUnderlay", typeof(object))]
	[NodeInput("ScaleFactor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the scale factor of the underlay.
	///</summary>
	public class Set_ScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ScaleFactor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the path to the underlay file.", 
		ViewType = "Data")]
	[NodeInput("AcadUnderlay", typeof(object))]

	///<summary>
	///Specifies or returns the path to the underlay file.
	///</summary>
	public class File : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.File);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the path to the underlay file.", 
		ViewType = "Modifier")]
	[NodeInput("AcadUnderlay", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Specifies or returns the path to the underlay file.
	///</summary>
	public class Set_File : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.File = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether underlay displays in the drawing.", 
		ViewType = "Data")]
	[NodeInput("AcadUnderlay", typeof(object))]

	///<summary>
	///Specifies or returns whether underlay displays in the drawing.
	///</summary>
	public class UnderlayVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UnderlayVisibility);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether underlay displays in the drawing.", 
		ViewType = "Modifier")]
	[NodeInput("AcadUnderlay", typeof(object))]
	[NodeInput("fVisible", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether underlay displays in the drawing.
	///</summary>
	public class Set_UnderlayVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UnderlayVisibility = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the clipping boundary of the underlay is turned on.", 
		ViewType = "Data")]
	[NodeInput("AcadUnderlay", typeof(object))]

	///<summary>
	///Specifies or returns whether the clipping boundary of the underlay is turned on.
	///</summary>
	public class ClippingEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ClippingEnabled);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the clipping boundary of the underlay is turned on.", 
		ViewType = "Modifier")]
	[NodeInput("AcadUnderlay", typeof(object))]
	[NodeInput("kClip", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the clipping boundary of the underlay is turned on.
	///</summary>
	public class Set_ClippingEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ClippingEnabled = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the layers of a DWF underlay are applied.", 
		ViewType = "Data")]
	[NodeInput("AcadUnderlay", typeof(object))]

	///<summary>
	///Specifies or returns whether the layers of a DWF underlay are applied.
	///</summary>
	public class UnderlayLayerOverrideApplied : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UnderlayLayerOverrideApplied);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the layers of a DWF underlay are applied.", 
		ViewType = "Modifier")]
	[NodeInput("AcadUnderlay", typeof(object))]
	[NodeInput("OdaX.AcUnderlayLayerOverrideType", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the layers of a DWF underlay are applied.
	///</summary>
	public class Set_UnderlayLayerOverrideApplied : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UnderlayLayerOverrideApplied = ((OdaX.AcUnderlayLayerOverrideType)inputs[1].Value);
			return null;
		}
	}
}
