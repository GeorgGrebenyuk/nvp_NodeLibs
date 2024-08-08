using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a named SelectionSet object
///</summary>
namespace OdaX.AcadGroup 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadGroup_Constructor : INode 
	{
		public OdaX.IAcadGroup _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadGroup;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadGroup_ConstructorCast : INode 
	{
		public OdaX.IAcadGroup _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadGroup;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Returns an object at a given index in the group.", 
		ViewType = "Data")]
	[NodeInput("AcadGroup", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///Returns an object at a given index in the group.
	///</summary>
	public class Item : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Item(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Returns the number of items in the group.", 
		ViewType = "Data")]
	[NodeInput("AcadGroup", typeof(object))]

	///<summary>
	///Returns the number of items in the group.
	///</summary>
	public class Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Count);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the true color of all entities in the group.", 
		ViewType = "Modifier")]
	[NodeInput("AcadGroup", typeof(object))]
	[NodeInput("rhs", typeof(System.Object))]

	///<summary>
	///Specifies the true color of all entities in the group.
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
		Text = "Specifies the layer of all entites in the group.", 
		ViewType = "Modifier")]
	[NodeInput("AcadGroup", typeof(object))]
	[NodeInput("rhs", typeof(System.String))]

	///<summary>
	///Specifies the layer of all entites in the group.
	///</summary>
	public class Set_Layer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Layer = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the linetype of all entites in the group.", 
		ViewType = "Modifier")]
	[NodeInput("AcadGroup", typeof(object))]
	[NodeInput("rhs", typeof(System.String))]

	///<summary>
	///Specifies the linetype of all entites in the group.
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
		Text = "Specifies the linetype scale of all entites in the group.", 
		ViewType = "Modifier")]
	[NodeInput("AcadGroup", typeof(object))]
	[NodeInput("rhs", typeof(System.Object))]

	///<summary>
	///Specifies the linetype scale of all entites in the group.
	///</summary>
	public class Set_LinetypeScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LinetypeScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the visibility of all entites in the group.", 
		ViewType = "Modifier")]
	[NodeInput("AcadGroup", typeof(object))]
	[NodeInput("rhs", typeof(System.Object))]

	///<summary>
	///Specifies the visibility of all entites in the group.
	///</summary>
	public class Set_Visible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Visible = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Sets the highlight status of all entites in the group.", 
		ViewType = "Modifier")]
	[NodeInput("AcadGroup", typeof(object))]
	[NodeInput("HighlightFlag", typeof(System.Object))]

	///<summary>
	///Not implemented. Sets the highlight status of all entites in the group.
	///</summary>
	public class Highlight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Highlight(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the plot style of all entites in the group.", 
		ViewType = "Modifier")]
	[NodeInput("AcadGroup", typeof(object))]
	[NodeInput("rhs", typeof(System.String))]

	///<summary>
	///Specifies the plot style of all entites in the group.
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
		Text = "Specifies the lineweight of all entites in the group.", 
		ViewType = "Modifier")]
	[NodeInput("AcadGroup", typeof(object))]
	[NodeInput("rhs", typeof(System.Object))]

	///<summary>
	///Specifies the lineweight of all entites in the group.
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
		Text = "Specifies or returns the name of the group.", 
		ViewType = "Data")]
	[NodeInput("AcadGroup", typeof(object))]

	///<summary>
	///Specifies or returns the name of the group.
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
		Text = "Specifies or returns the name of the group.", 
		ViewType = "Modifier")]
	[NodeInput("AcadGroup", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Specifies or returns the name of the group.
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
		Text = "Adds one or more objects to the group.", 
		ViewType = "Modifier")]
	[NodeInput("AcadGroup", typeof(object))]
	[NodeInput("Objects", typeof(System.Object))]

	///<summary>
	///Adds one or more objects to the group.
	///</summary>
	public class AppendItems : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AppendItems(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Removes objects from the group.", 
		ViewType = "Modifier")]
	[NodeInput("AcadGroup", typeof(object))]
	[NodeInput("Objects", typeof(System.Object))]

	///<summary>
	///Removes objects from the group.
	///</summary>
	public class RemoveItems : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RemoveItems(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Updates the group on the screen.", 
		ViewType = "Modifier")]
	[NodeInput("AcadGroup", typeof(object))]

	///<summary>
	///Updates the group on the screen.
	///</summary>
	public class Update : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Update();
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the material assigned to all entities in the group.", 
		ViewType = "Modifier")]
	[NodeInput("AcadGroup", typeof(object))]
	[NodeInput("rhs", typeof(System.String))]

	///<summary>
	///Specifies the material assigned to all entities in the group.
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


	[NVP_Manifest(
		Text = "Specifies the color of all entities in the group.", 
		ViewType = "Modifier")]
	[NodeInput("AcadGroup", typeof(object))]
	[NodeInput("OdaX.AcColor", typeof(System.Object))]

	///<summary>
	///Specifies the color of all entities in the group.
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
}
