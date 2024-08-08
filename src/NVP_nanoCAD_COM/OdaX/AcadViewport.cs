using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a bounded area that displays some portion of a drawing's model space
///</summary>
namespace OdaX.AcadViewport 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadViewport_Constructor : INode 
	{
		public OdaX.IAcadViewport _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadViewport;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadViewport_ConstructorCast : INode 
	{
		public OdaX.IAcadViewport _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadViewport;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Specifies the center of an arc, circle, ellipse, view, or viewport", 
		ViewType = "Data")]
	[NodeInput("AcadViewport", typeof(object))]

	///<summary>
	///Specifies the center of an arc, circle, ellipse, view, or viewport
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
		Text = "Specifies the center of an arc, circle, ellipse, view, or viewport", 
		ViewType = "Modifier")]
	[NodeInput("AcadViewport", typeof(object))]
	[NodeInput("Center", typeof(System.Object))]

	///<summary>
	///Specifies the center of an arc, circle, ellipse, view, or viewport
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
		Text = "Height of the attribute, shape, text, or view toolbar or the main application window", 
		ViewType = "Data")]
	[NodeInput("AcadViewport", typeof(object))]

	///<summary>
	///Height of the attribute, shape, text, or view toolbar or the main application window
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
		Text = "Height of the attribute, shape, text, or view toolbar or the main application window", 
		ViewType = "Modifier")]
	[NodeInput("AcadViewport", typeof(object))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Height of the attribute, shape, text, or view toolbar or the main application window
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
		Text = "Specifies the width of the text boundary, view, image, toolbar, or main application window", 
		ViewType = "Data")]
	[NodeInput("AcadViewport", typeof(object))]

	///<summary>
	///Specifies the width of the text boundary, view, image, toolbar, or main application window
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
		Text = "Specifies the width of the text boundary, view, image, toolbar, or main application window", 
		ViewType = "Modifier")]
	[NodeInput("AcadViewport", typeof(object))]
	[NodeInput("Width", typeof(System.Double))]

	///<summary>
	///Specifies the width of the text boundary, view, image, toolbar, or main application window
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
		Text = "Specifies the target point for the view or viewport", 
		ViewType = "Data")]
	[NodeInput("AcadViewport", typeof(object))]

	///<summary>
	///Specifies the target point for the view or viewport
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
		Text = "Specifies the target point for the view or viewport", 
		ViewType = "Modifier")]
	[NodeInput("AcadViewport", typeof(object))]
	[NodeInput("targetPoint", typeof(System.Object))]

	///<summary>
	///Specifies the target point for the view or viewport
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
		Text = "Specifies the viewing direction for a 3D visualization of the drawing", 
		ViewType = "Data")]
	[NodeInput("AcadViewport", typeof(object))]

	///<summary>
	///Specifies the viewing direction for a 3D visualization of the drawing
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
		Text = "Specifies the viewing direction for a 3D visualization of the drawing", 
		ViewType = "Modifier")]
	[NodeInput("AcadViewport", typeof(object))]
	[NodeInput("dirVec", typeof(System.Object))]

	///<summary>
	///Specifies the viewing direction for a 3D visualization of the drawing
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
		Text = "Specifies the name of the object", 
		ViewType = "Data")]
	[NodeInput("AcadViewport", typeof(object))]

	///<summary>
	///Specifies the name of the object
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
		Text = "Specifies the name of the object", 
		ViewType = "Modifier")]
	[NodeInput("AcadViewport", typeof(object))]
	[NodeInput("bstrName", typeof(System.String))]

	///<summary>
	///Specifies the name of the object
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
		Text = "Specifies the status of the viewport grid", 
		ViewType = "Data")]
	[NodeInput("AcadViewport", typeof(object))]

	///<summary>
	///Specifies the status of the viewport grid
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
		Text = "Specifies the status of the viewport grid", 
		ViewType = "Modifier")]
	[NodeInput("AcadViewport", typeof(object))]
	[NodeInput("bGridOn", typeof(System.Object))]

	///<summary>
	///Specifies the status of the viewport grid
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
		Text = "Specifies the status of the Ortho mode for the viewport", 
		ViewType = "Data")]
	[NodeInput("AcadViewport", typeof(object))]

	///<summary>
	///Specifies the status of the Ortho mode for the viewport
	///</summary>
	public class OrthoOn : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OrthoOn);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the status of the Ortho mode for the viewport", 
		ViewType = "Modifier")]
	[NodeInput("AcadViewport", typeof(object))]
	[NodeInput("bOrthoOn", typeof(System.Object))]

	///<summary>
	///Specifies the status of the Ortho mode for the viewport
	///</summary>
	public class Set_OrthoOn : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OrthoOn = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the snap base point for the viewport", 
		ViewType = "Data")]
	[NodeInput("AcadViewport", typeof(object))]

	///<summary>
	///Specifies the snap base point for the viewport
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
		Text = "Specifies the snap base point for the viewport", 
		ViewType = "Modifier")]
	[NodeInput("AcadViewport", typeof(object))]
	[NodeInput("lowLeft", typeof(System.Object))]

	///<summary>
	///Specifies the snap base point for the viewport
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
		Text = "Specifies the status of snap", 
		ViewType = "Data")]
	[NodeInput("AcadViewport", typeof(object))]

	///<summary>
	///Specifies the status of snap
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
		Text = "Specifies the status of snap", 
		ViewType = "Modifier")]
	[NodeInput("AcadViewport", typeof(object))]
	[NodeInput("bSnapOn", typeof(System.Object))]

	///<summary>
	///Specifies the status of snap
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
		Text = "Specifies the snap rotation angle of the viewport relative to the current UCS", 
		ViewType = "Data")]
	[NodeInput("AcadViewport", typeof(object))]

	///<summary>
	///Specifies the snap rotation angle of the viewport relative to the current UCS
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
		Text = "Specifies the snap rotation angle of the viewport relative to the current UCS", 
		ViewType = "Modifier")]
	[NodeInput("AcadViewport", typeof(object))]
	[NodeInput("Angle", typeof(System.Object))]

	///<summary>
	///Specifies the snap rotation angle of the viewport relative to the current UCS
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
		Text = "Specifies if the UCS icon is on", 
		ViewType = "Data")]
	[NodeInput("AcadViewport", typeof(object))]

	///<summary>
	///Specifies if the UCS icon is on
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
		Text = "Specifies if the UCS icon is on", 
		ViewType = "Modifier")]
	[NodeInput("AcadViewport", typeof(object))]
	[NodeInput("bIconOn", typeof(System.Object))]

	///<summary>
	///Specifies if the UCS icon is on
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
		Text = "Specifies if the UCS icon is displayed at the origin", 
		ViewType = "Data")]
	[NodeInput("AcadViewport", typeof(object))]

	///<summary>
	///Specifies if the UCS icon is displayed at the origin
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
		Text = "Specifies if the UCS icon is displayed at the origin", 
		ViewType = "Modifier")]
	[NodeInput("AcadViewport", typeof(object))]
	[NodeInput("bIconAtOrigin", typeof(System.Object))]

	///<summary>
	///Specifies if the UCS icon is displayed at the origin
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
		Text = "Gets the lower-left corner of the current active viewport", 
		ViewType = "Data")]
	[NodeInput("AcadViewport", typeof(object))]

	///<summary>
	///Gets the lower-left corner of the current active viewport
	///</summary>
	public class LowerLeftCorner : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LowerLeftCorner);

		}
	}


	[NVP_Manifest(
		Text = "Gets the upper-right corner of the current active viewport", 
		ViewType = "Data")]
	[NodeInput("AcadViewport", typeof(object))]

	///<summary>
	///Gets the upper-right corner of the current active viewport
	///</summary>
	public class UpperRightCorner : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UpperRightCorner);

		}
	}


	[NVP_Manifest(
		Text = "Splits a viewport into the given number of views", 
		ViewType = "Modifier")]
	[NodeInput("AcadViewport", typeof(object))]
	[NodeInput("OdaX.AcViewportSplitType", typeof(System.Object))]

	///<summary>
	///Splits a viewport into the given number of views
	///</summary>
	public class Split : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Split(((OdaX.AcViewportSplitType)inputs[1].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Gets the grid spacing for the viewport", 
		ViewType = "Modifier")]
	[NodeInput("AcadViewport", typeof(object))]
	[NodeInput("XSpacing", typeof(System.Double))]
	[NodeInput("YSpacing", typeof(System.Double))]

	///<summary>
	///Gets the grid spacing for the viewport
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
		Text = "Sets the grid spacing for the viewport", 
		ViewType = "Modifier")]
	[NodeInput("AcadViewport", typeof(object))]
	[NodeInput("XSpacing", typeof(System.Double))]
	[NodeInput("YSpacing", typeof(System.Double))]

	///<summary>
	///Sets the grid spacing for the viewport
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
		Text = "Gets the snap spacing for the viewport", 
		ViewType = "Modifier")]
	[NodeInput("AcadViewport", typeof(object))]
	[NodeInput("XSpacing", typeof(System.Double))]
	[NodeInput("YSpacing", typeof(System.Double))]

	///<summary>
	///Gets the snap spacing for the viewport
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
		Text = "Sets the snap spacing for the viewport", 
		ViewType = "Modifier")]
	[NodeInput("AcadViewport", typeof(object))]
	[NodeInput("XSpacing", typeof(System.Double))]
	[NodeInput("YSpacing", typeof(System.Double))]

	///<summary>
	///Sets the snap spacing for the viewport
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
		Text = "Sets the view in a viewport to a saved view in the Views Collection object", 
		ViewType = "Modifier")]
	[NodeInput("AcadViewport", typeof(object))]
	[NodeInput("View", typeof(System.Object))]

	///<summary>
	///Sets the view in a viewport to a saved view in the Views Collection object
	///</summary>
	public class SetView : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetView(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the smoothness of circles, arcs, and ellipses", 
		ViewType = "Data")]
	[NodeInput("AcadViewport", typeof(object))]

	///<summary>
	///Specifies the smoothness of circles, arcs, and ellipses
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
		Text = "Specifies the smoothness of circles, arcs, and ellipses", 
		ViewType = "Modifier")]
	[NodeInput("AcadViewport", typeof(object))]
	[NodeInput("arcSmooth", typeof(System.Object))]

	///<summary>
	///Specifies the smoothness of circles, arcs, and ellipses
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
}
