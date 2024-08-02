using NVP.API.Nodes;

namespace OdaX.AcadView 
{
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


	///<summary>
	///Specifies the center of an arc, circle, ellipse, view, or viewport
	///</summary>
	[NodeInput("AcadView", typeof(object))]
	public class Center : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Center);

		}
	}


	///<summary>
	///Specifies the center of an arc, circle, ellipse, view, or viewport
	///</summary>
	[NodeInput("AcadView", typeof(object))]
	[NodeInput("Center", typeof(System.Object))]
	public class Set_Center : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Center = inputs[1];
			return null;
		}
	}


	///<summary>
	///Height of the object
	///</summary>
	[NodeInput("AcadView", typeof(object))]
	public class Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Height);

		}
	}


	///<summary>
	///Height of the object
	///</summary>
	[NodeInput("AcadView", typeof(object))]
	[NodeInput("Height", typeof(System.Double))]
	public class Set_Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Height = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the width of the object
	///</summary>
	[NodeInput("AcadView", typeof(object))]
	public class Width : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Width);

		}
	}


	///<summary>
	///Specifies the width of the object
	///</summary>
	[NodeInput("AcadView", typeof(object))]
	[NodeInput("Width", typeof(System.Double))]
	public class Set_Width : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Width = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the target point for the view or viewport
	///</summary>
	[NodeInput("AcadView", typeof(object))]
	public class Target : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Target);

		}
	}


	///<summary>
	///Specifies the target point for the view or viewport
	///</summary>
	[NodeInput("AcadView", typeof(object))]
	[NodeInput("targetPoint", typeof(System.Object))]
	public class Set_Target : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Target = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the viewing direction for a 3D visualization of the drawing
	///</summary>
	[NodeInput("AcadView", typeof(object))]
	public class Direction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Direction);

		}
	}


	///<summary>
	///Specifies the viewing direction for a 3D visualization of the drawing
	///</summary>
	[NodeInput("AcadView", typeof(object))]
	[NodeInput("dirVec", typeof(System.Object))]
	public class Set_Direction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Direction = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the name of the object
	///</summary>
	[NodeInput("AcadView", typeof(object))]
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	///<summary>
	///Specifies the name of the object
	///</summary>
	[NodeInput("AcadView", typeof(object))]
	[NodeInput("bstrName", typeof(System.String))]
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
	///Returns and sets the name of the category of the view.
	///</summary>
	[NodeInput("AcadView", typeof(object))]
	public class CategoryName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CategoryName);

		}
	}


	///<summary>
	///Returns and sets the name of the category of the view.
	///</summary>
	[NodeInput("AcadView", typeof(object))]
	[NodeInput("category", typeof(System.String))]
	public class Set_CategoryName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CategoryName = inputs[1];
			return null;
		}
	}


	///<summary>
	///Returns and sets the layout of the view.
	///</summary>
	[NodeInput("AcadView", typeof(object))]
	public class LayoutId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LayoutId);

		}
	}


	///<summary>
	///Returns and sets the layout of the view.
	///</summary>
	[NodeInput("AcadView", typeof(object))]
	[NodeInput("ObjectID", typeof(System.Object))]
	public class Set_LayoutId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LayoutId = inputs[1];
			return null;
		}
	}


	///<summary>
	///Returns and sets the name of the layer state of the view.
	///</summary>
	[NodeInput("AcadView", typeof(object))]
	public class LayerState : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LayerState);

		}
	}


	///<summary>
	///Returns and sets the name of the layer state of the view.
	///</summary>
	[NodeInput("AcadView", typeof(object))]
	[NodeInput("LayerState", typeof(System.String))]
	public class Set_LayerState : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LayerState = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies whether the view is associated with a paperspace viewport.
	///</summary>
	[NodeInput("AcadView", typeof(object))]
	public class HasVpAssociation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasVpAssociation);

		}
	}


	///<summary>
	///Specifies whether the view is associated with a paperspace viewport.
	///</summary>
	[NodeInput("AcadView", typeof(object))]
	[NodeInput("bVpAssoc", typeof(System.Object))]
	public class Set_HasVpAssociation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HasVpAssociation = inputs[1];
			return null;
		}
	}
}
