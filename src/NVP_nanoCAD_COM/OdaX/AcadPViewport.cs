using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of rectangular object created in paper space that display view
///</summary>
namespace OdaX.AcadPViewport 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadPViewport_Constructor : INode 
	{
		public OdaX.IAcadPViewport _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadPViewport;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadPViewport_ConstructorCast : INode 
	{
		public OdaX.IAcadPViewport _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadPViewport;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the x, y, and z coordinates of a paperspace viewports's center point.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates of a paperspace viewports's center point.
	///</summary>
	public class Center : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Center);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the x, y, and z coordinates of a paperspace viewports's center point.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("CenterPoint", typeof(System.Object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates of a paperspace viewports's center point.
	///</summary>
	public class Set_Center : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Center = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the viewing direction fof a paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies or returns the viewing direction fof a paperspace viewport.
	///</summary>
	public class Direction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Direction);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the viewing direction fof a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("dirVector", typeof(System.Object))]

	///<summary>
	///Specifies or returns the viewing direction fof a paperspace viewport.
	///</summary>
	public class Set_Direction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Direction = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the grid is on for a paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies or returns whether the grid is on for a paperspace viewport.
	///</summary>
	public class GridOn : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GridOn);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the grid is on for a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("bGridOn", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the grid is on for a paperspace viewport.
	///</summary>
	public class Set_GridOn : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GridOn = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the height of a paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies or returns the height of a paperspace viewport.
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
		Text = "Specifies or returns the height of a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Specifies or returns the height of a paperspace viewport.
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
		Text = "Specifies or returns the width of a paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies or returns the width of a paperspace viewport.
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
		Text = "Specifies or returns the width of a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("Width", typeof(System.Double))]

	///<summary>
	///Specifies or returns the width of a paperspace viewport.
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
		Text = "Specifies or returns whether a paperspace viewport is on.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies or returns whether a paperspace viewport is on.
	///</summary>
	public class ViewportOn : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ViewportOn);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a paperspace viewport is on.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("bOn", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether a paperspace viewport is on.
	///</summary>
	public class Set_ViewportOn : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ViewportOn = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns whether a paperspace viewport is clipped.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Returns whether a paperspace viewport is clipped.
	///</summary>
	public class Clipped : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Clipped);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a paperspace viewport is locked.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies or returns whether a paperspace viewport is locked.
	///</summary>
	public class DisplayLocked : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DisplayLocked);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a paperspace viewport is locked.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("bLocked", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether a paperspace viewport is locked.
	///</summary>
	public class Set_DisplayLocked : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DisplayLocked = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the standard scale of a paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies or returns the standard scale of a paperspace viewport.
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
		Text = "Specifies or returns the standard scale of a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("OdaX.AcViewportScale", typeof(System.Object))]

	///<summary>
	///Specifies or returns the standard scale of a paperspace viewport.
	///</summary>
	public class Set_StandardScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StandardScale = ((OdaX.AcViewportScale)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns a custom scale for a paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies or returns a custom scale for a paperspace viewport.
	///</summary>
	public class CustomScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CustomScale);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns a custom scale for a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("scale", typeof(System.Double))]

	///<summary>
	///Specifies or returns a custom scale for a paperspace viewport.
	///</summary>
	public class Set_CustomScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CustomScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the style sheet to use for a paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies or returns the style sheet to use for a paperspace viewport.
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
		Text = "Specifies or returns the style sheet to use for a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("pName", typeof(System.String))]

	///<summary>
	///Specifies or returns the style sheet to use for a paperspace viewport.
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
		Text = "Specifies or returns whether the UCS is saved with a paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies or returns whether the UCS is saved with a paperspace viewport.
	///</summary>
	public class UCSPerViewport : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UCSPerViewport);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the UCS is saved with a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("UCSSaved", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the UCS is saved with a paperspace viewport.
	///</summary>
	public class Set_UCSPerViewport : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UCSPerViewport = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the snap base point for a paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies or returns the snap base point for a paperspace viewport.
	///</summary>
	public class SnapBasePoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SnapBasePoint);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the snap base point for a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("lowLeft", typeof(System.Object))]

	///<summary>
	///Specifies or returns the snap base point for a paperspace viewport.
	///</summary>
	public class Set_SnapBasePoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SnapBasePoint = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the snap is turned on for a paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies or returns whether the snap is turned on for a paperspace viewport.
	///</summary>
	public class SnapOn : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SnapOn);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the snap is turned on for a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("bSnapOn", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the snap is turned on for a paperspace viewport.
	///</summary>
	public class Set_SnapOn : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SnapOn = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the snap rotation angle of a paperspace viewport relative to the current UCS.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies or returns the snap rotation angle of a paperspace viewport relative to the current UCS.
	///</summary>
	public class SnapRotationAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SnapRotationAngle);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the snap rotation angle of a paperspace viewport relative to the current UCS.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("Angle", typeof(System.Double))]

	///<summary>
	///Specifies or returns the snap rotation angle of a paperspace viewport relative to the current UCS.
	///</summary>
	public class Set_SnapRotationAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SnapRotationAngle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the UCS icon is turned on for a paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies or returns whether the UCS icon is turned on for a paperspace viewport.
	///</summary>
	public class UCSIconOn : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UCSIconOn);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the UCS icon is turned on for a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("bIconOn", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the UCS icon is turned on for a paperspace viewport.
	///</summary>
	public class Set_UCSIconOn : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UCSIconOn = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the UCS icon displays at the origin for a paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies or returns whether the UCS icon displays at the origin for a paperspace viewport.
	///</summary>
	public class UCSIconAtOrigin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UCSIconAtOrigin);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the UCS icon displays at the origin for a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("bIconAtOrigin", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the UCS icon displays at the origin for a paperspace viewport.
	///</summary>
	public class Set_UCSIconAtOrigin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UCSIconAtOrigin = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the grid spacing for a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("XSpacing", typeof(System.Double))]
	[NodeInput("YSpacing", typeof(System.Double))]

	///<summary>
	///Specifies or returns the grid spacing for a paperspace viewport.
	///</summary>
	public class GetGridSpacing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetGridSpacing(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the grid spacing for a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("XSpacing", typeof(System.Double))]
	[NodeInput("YSpacing", typeof(System.Double))]

	///<summary>
	///Specifies or returns the grid spacing for a paperspace viewport.
	///</summary>
	public class SetGridSpacing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetGridSpacing(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the snap spacing for a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("XSpacing", typeof(System.Double))]
	[NodeInput("YSpacing", typeof(System.Double))]

	///<summary>
	///Specifies or returns the snap spacing for a paperspace viewport.
	///</summary>
	public class GetSnapSpacing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetSnapSpacing(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the snap spacing for a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("XSpacing", typeof(System.Double))]
	[NodeInput("YSpacing", typeof(System.Double))]

	///<summary>
	///Specifies or returns the snap spacing for a paperspace viewport.
	///</summary>
	public class SetSnapSpacing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetSnapSpacing(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Turns the display of a paperspace viewport on or off.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("bStatus", typeof(System.Object))]

	///<summary>
	///Turns the display of a paperspace viewport on or off.
	///</summary>
	public class Display : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Display(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the twist angle, in radians, for a paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies or returns the twist angle, in radians, for a paperspace viewport.
	///</summary>
	public class TwistAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TwistAngle);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the twist angle, in radians, for a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("Angle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the twist angle, in radians, for a paperspace viewport.
	///</summary>
	public class Set_TwistAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TwistAngle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the lens length used in perspective viewing for a paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies or returns the lens length used in perspective viewing for a paperspace viewport.
	///</summary>
	public class LensLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LensLength);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the lens length used in perspective viewing for a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("Length", typeof(System.Double))]

	///<summary>
	///Specifies or returns the lens length used in perspective viewing for a paperspace viewport.
	///</summary>
	public class Set_LensLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LensLength = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether hidden line removal is turned on for a paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies or returns whether hidden line removal is turned on for a paperspace viewport.
	///</summary>
	public class RemoveHiddenLines : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RemoveHiddenLines);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether hidden line removal is turned on for a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("bRemoval", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether hidden line removal is turned on for a paperspace viewport.
	///</summary>
	public class Set_RemoveHiddenLines : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RemoveHiddenLines = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the target point for a paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies or returns the target point for a paperspace viewport.
	///</summary>
	public class Target : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Target);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the target point for a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("targetPoint", typeof(System.Object))]

	///<summary>
	///Specifies or returns the target point for a paperspace viewport.
	///</summary>
	public class Set_Target : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Target = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the smoothness of circles, arcs, and ellipses that display in a paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies or returns the smoothness of circles, arcs, and ellipses that display in a paperspace viewport.
	///</summary>
	public class ArcSmoothness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArcSmoothness);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the smoothness of circles, arcs, and ellipses that display in a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("arcSmooth", typeof(System.Object))]

	///<summary>
	///Specifies or returns the smoothness of circles, arcs, and ellipses that display in a paperspace viewport.
	///</summary>
	public class Set_ArcSmoothness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArcSmoothness = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Specifies or returns the visual style of a paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Not implemented. Specifies or returns the visual style of a paperspace viewport.
	///</summary>
	public class VisualStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VisualStyle);

		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Specifies or returns the visual style of a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("pVisualStyleIndex", typeof(System.Int32))]

	///<summary>
	///Not implemented. Specifies or returns the visual style of a paperspace viewport.
	///</summary>
	public class Set_VisualStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.VisualStyle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the shade plot mode of a paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies or returns the shade plot mode of a paperspace viewport.
	///</summary>
	public class ShadePlot : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShadePlot);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the shade plot mode of a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("pShadePlotIndex", typeof(System.Int32))]

	///<summary>
	///Specifies or returns the shade plot mode of a paperspace viewport.
	///</summary>
	public class Set_ShadePlot : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShadePlot = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Specifies or returns the model view associated with the paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Not implemented. Specifies or returns the model view associated with the paperspace viewport.
	///</summary>
	public class ModelView : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ModelView);

		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Specifies or returns the model view associated with the paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("View", typeof(System.Object))]

	///<summary>
	///Not implemented. Specifies or returns the model view associated with the paperspace viewport.
	///</summary>
	public class Set_ModelView : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ModelView = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Specifies or returns the sheet view associated with the paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Not implemented. Specifies or returns the sheet view associated with the paperspace viewport.
	///</summary>
	public class SheetView : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SheetView);

		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Specifies or returns the sheet view associated with the paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("View", typeof(System.Object))]

	///<summary>
	///Not implemented. Specifies or returns the sheet view associated with the paperspace viewport.
	///</summary>
	public class Set_SheetView : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SheetView = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Specifies or returns the label block ID associated with the paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Not implemented. Specifies or returns the label block ID associated with the paperspace viewport.
	///</summary>
	public class LabelBlockId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LabelBlockId);

		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Specifies or returns the label block ID associated with the paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("ObjectID", typeof(System.Object))]

	///<summary>
	///Not implemented. Specifies or returns the label block ID associated with the paperspace viewport.
	///</summary>
	public class Set_LabelBlockId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LabelBlockId = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Specifies whether the paperspace viewport is linked to a corresponding sheet view.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Not implemented. Specifies whether the paperspace viewport is linked to a corresponding sheet view.
	///</summary>
	public class HasSheetView : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasSheetView);

		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Updates the paperspace viewport parameters with the parameters in the associated model view.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Not implemented. Updates the paperspace viewport parameters with the parameters in the associated model view.
	///</summary>
	public class SyncModelView : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SyncModelView();
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the standard scale for the viewport", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies the standard scale for the viewport
	///</summary>
	public class StandardScale2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StandardScale2);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the standard scale for the viewport", 
		ViewType = "Modifier")]
	[NodeInput("AcadPViewport", typeof(object))]
	[NodeInput("scale", typeof(System.Int32))]

	///<summary>
	///Specifies the standard scale for the viewport
	///</summary>
	public class Set_StandardScale2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StandardScale2 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies whether the viewport has layer property overrides.", 
		ViewType = "Data")]
	[NodeInput("AcadPViewport", typeof(object))]

	///<summary>
	///Specifies whether the viewport has layer property overrides.
	///</summary>
	public class LayerPropertyOverrides : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LayerPropertyOverrides);

		}
	}
}
