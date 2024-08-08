using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a logical grouping of data, similar to overlays.
///</summary>
namespace OdaX.AcadLayer 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadLayer_Constructor : INode 
	{
		public OdaX.IAcadLayer _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadLayer;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadLayer_ConstructorCast : INode 
	{
		public OdaX.IAcadLayer _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadLayer;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the color of a layer.", 
		ViewType = "Data")]
	[NodeInput("AcadLayer", typeof(object))]

	///<summary>
	///Specifies or returns the color of a layer.
	///</summary>
	public class color : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.color);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the color of a layer.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLayer", typeof(object))]
	[NodeInput("OdaX.AcColor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the color of a layer.
	///</summary>
	public class Set_color : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.color = ((OdaX.AcColor)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the true color of a layer.", 
		ViewType = "Data")]
	[NodeInput("AcadLayer", typeof(object))]

	///<summary>
	///Specifies or returns the true color of a layer.
	///</summary>
	public class TrueColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TrueColor);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the true color of a layer.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLayer", typeof(object))]
	[NodeInput("pColor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the true color of a layer.
	///</summary>
	public class Set_TrueColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TrueColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether objects on a layer are visible, editable, and printable.", 
		ViewType = "Data")]
	[NodeInput("AcadLayer", typeof(object))]

	///<summary>
	///Specifies or returns whether objects on a layer are visible, editable, and printable.
	///</summary>
	public class Freeze : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Freeze);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether objects on a layer are visible, editable, and printable.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLayer", typeof(object))]
	[NodeInput("bFreeze", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether objects on a layer are visible, editable, and printable.
	///</summary>
	public class Set_Freeze : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Freeze = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether objects on a layer are visible and printable.", 
		ViewType = "Data")]
	[NodeInput("AcadLayer", typeof(object))]

	///<summary>
	///Specifies or returns whether objects on a layer are visible and printable.
	///</summary>
	public class LayerOn : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LayerOn);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether objects on a layer are visible and printable.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLayer", typeof(object))]
	[NodeInput("bOn", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether objects on a layer are visible and printable.
	///</summary>
	public class Set_LayerOn : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LayerOn = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the linetype of a layer.", 
		ViewType = "Data")]
	[NodeInput("AcadLayer", typeof(object))]

	///<summary>
	///Specifies or returns the linetype of a layer.
	///</summary>
	public class Linetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Linetype);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the linetype of a layer.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLayer", typeof(object))]
	[NodeInput("Linetype", typeof(System.String))]

	///<summary>
	///Specifies or returns the linetype of a layer.
	///</summary>
	public class Set_Linetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Linetype = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether objects on a layer are editable.", 
		ViewType = "Data")]
	[NodeInput("AcadLayer", typeof(object))]

	///<summary>
	///Specifies or returns whether objects on a layer are editable.
	///</summary>
	public class Lock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Lock);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether objects on a layer are editable.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLayer", typeof(object))]
	[NodeInput("Block", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether objects on a layer are editable.
	///</summary>
	public class Set_Lock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Lock = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the name of a layer.", 
		ViewType = "Data")]
	[NodeInput("AcadLayer", typeof(object))]

	///<summary>
	///Specifies or returns the name of a layer.
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
		Text = "Specifies or returns the name of a layer.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLayer", typeof(object))]
	[NodeInput("bstrName", typeof(System.String))]

	///<summary>
	///Specifies or returns the name of a layer.
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
		Text = "Specifies or returns whether objects of a layer can be printed.", 
		ViewType = "Data")]
	[NodeInput("AcadLayer", typeof(object))]

	///<summary>
	///Specifies or returns whether objects of a layer can be printed.
	///</summary>
	public class Plottable : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Plottable);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether objects of a layer can be printed.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLayer", typeof(object))]
	[NodeInput("bPlottable", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether objects of a layer can be printed.
	///</summary>
	public class Set_Plottable : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Plottable = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the layer is frozen in new viewports.", 
		ViewType = "Data")]
	[NodeInput("AcadLayer", typeof(object))]

	///<summary>
	///Specifies or returns whether the layer is frozen in new viewports.
	///</summary>
	public class ViewportDefault : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ViewportDefault);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the layer is frozen in new viewports.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLayer", typeof(object))]
	[NodeInput("bDefault", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the layer is frozen in new viewports.
	///</summary>
	public class Set_ViewportDefault : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ViewportDefault = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the plot style name of a layer.", 
		ViewType = "Data")]
	[NodeInput("AcadLayer", typeof(object))]

	///<summary>
	///Specifies or returns the plot style name of a layer.
	///</summary>
	public class PlotStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlotStyleName);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the plot style name of a layer.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLayer", typeof(object))]
	[NodeInput("plotStyle", typeof(System.String))]

	///<summary>
	///Specifies or returns the plot style name of a layer.
	///</summary>
	public class Set_PlotStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PlotStyleName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the lineweight of a layer.", 
		ViewType = "Data")]
	[NodeInput("AcadLayer", typeof(object))]

	///<summary>
	///Specifies or returns the lineweight of a layer.
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
		Text = "Specifies or returns the lineweight of a layer.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLayer", typeof(object))]
	[NodeInput("Lineweight", typeof(System.Object))]

	///<summary>
	///Specifies or returns the lineweight of a layer.
	///</summary>
	public class Set_Lineweight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Lineweight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the description of a layer.", 
		ViewType = "Data")]
	[NodeInput("AcadLayer", typeof(object))]

	///<summary>
	///Specifies or returns the description of a layer.
	///</summary>
	public class Description : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Description);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the description of a layer.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLayer", typeof(object))]
	[NodeInput("Description", typeof(System.String))]

	///<summary>
	///Specifies or returns the description of a layer.
	///</summary>
	public class Set_Description : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Description = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns whether the layer is in use.", 
		ViewType = "Data")]
	[NodeInput("AcadLayer", typeof(object))]

	///<summary>
	///Returns whether the layer is in use.
	///</summary>
	public class Used : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Used);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the material of a layer.", 
		ViewType = "Data")]
	[NodeInput("AcadLayer", typeof(object))]

	///<summary>
	///Specifies or returns the material of a layer.
	///</summary>
	public class Material : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Material);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the material of a layer.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLayer", typeof(object))]
	[NodeInput("Material", typeof(System.String))]

	///<summary>
	///Specifies or returns the material of a layer.
	///</summary>
	public class Set_Material : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Material = inputs[1].Value;
			return null;
		}
	}
}
