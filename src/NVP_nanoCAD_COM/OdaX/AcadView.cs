using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///viewpoint) in space
///</summary>
namespace NVP_nanoCAD_COM._OdaX.AcadView 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadView_Constructor : INode 
	{
		public OdaX.IAcadView _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadView;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadView_ConstructorCast : INode 
	{
		public OdaX.IAcadView _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadView;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Specifies the center of an arc, circle, ellipse, view, or viewport", 
		ViewType = "Data")]
	[NodeInput("AcadView", typeof(object))]

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
	[NodeInput("AcadView", typeof(object))]
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
		Text = "Height of the object", 
		ViewType = "Data")]
	[NodeInput("AcadView", typeof(object))]

	///<summary>
	///Height of the object
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
		Text = "Height of the object", 
		ViewType = "Modifier")]
	[NodeInput("AcadView", typeof(object))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Height of the object
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
		Text = "Specifies the width of the object", 
		ViewType = "Data")]
	[NodeInput("AcadView", typeof(object))]

	///<summary>
	///Specifies the width of the object
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
		Text = "Specifies the width of the object", 
		ViewType = "Modifier")]
	[NodeInput("AcadView", typeof(object))]
	[NodeInput("Width", typeof(System.Double))]

	///<summary>
	///Specifies the width of the object
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
	[NodeInput("AcadView", typeof(object))]

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
	[NodeInput("AcadView", typeof(object))]
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
	[NodeInput("AcadView", typeof(object))]

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
	[NodeInput("AcadView", typeof(object))]
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
	[NodeInput("AcadView", typeof(object))]

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
	[NodeInput("AcadView", typeof(object))]
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
		Text = "Returns and sets the name of the category of the view.", 
		ViewType = "Data")]
	[NodeInput("AcadView", typeof(object))]

	///<summary>
	///Returns and sets the name of the category of the view.
	///</summary>
	public class CategoryName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CategoryName);

		}
	}


	[NVP_Manifest(
		Text = "Returns and sets the name of the category of the view.", 
		ViewType = "Modifier")]
	[NodeInput("AcadView", typeof(object))]
	[NodeInput("category", typeof(System.String))]

	///<summary>
	///Returns and sets the name of the category of the view.
	///</summary>
	public class Set_CategoryName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CategoryName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns and sets the layout of the view.", 
		ViewType = "Data")]
	[NodeInput("AcadView", typeof(object))]

	///<summary>
	///Returns and sets the layout of the view.
	///</summary>
	public class LayoutId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LayoutId);

		}
	}


	[NVP_Manifest(
		Text = "Returns and sets the layout of the view.", 
		ViewType = "Modifier")]
	[NodeInput("AcadView", typeof(object))]
	[NodeInput("ObjectID", typeof(System.Object))]

	///<summary>
	///Returns and sets the layout of the view.
	///</summary>
	public class Set_LayoutId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LayoutId = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns and sets the name of the layer state of the view.", 
		ViewType = "Data")]
	[NodeInput("AcadView", typeof(object))]

	///<summary>
	///Returns and sets the name of the layer state of the view.
	///</summary>
	public class LayerState : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LayerState);

		}
	}


	[NVP_Manifest(
		Text = "Returns and sets the name of the layer state of the view.", 
		ViewType = "Modifier")]
	[NodeInput("AcadView", typeof(object))]
	[NodeInput("LayerState", typeof(System.String))]

	///<summary>
	///Returns and sets the name of the layer state of the view.
	///</summary>
	public class Set_LayerState : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LayerState = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies whether the view is associated with a paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadView", typeof(object))]

	///<summary>
	///Specifies whether the view is associated with a paperspace viewport.
	///</summary>
	public class HasVpAssociation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasVpAssociation);

		}
	}


	[NVP_Manifest(
		Text = "Specifies whether the view is associated with a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadView", typeof(object))]
	[NodeInput("bVpAssoc", typeof(System.Object))]

	///<summary>
	///Specifies whether the view is associated with a paperspace viewport.
	///</summary>
	public class Set_HasVpAssociation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HasVpAssociation = inputs[1].Value;
			return null;
		}
	}
}
