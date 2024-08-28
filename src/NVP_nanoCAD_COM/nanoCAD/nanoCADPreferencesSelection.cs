using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Specifies selection settings.
///</summary>
namespace NVP_nanoCAD_COM._nanoCAD.nanoCADPreferencesSelection 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPreferencesSelection_Constructor : INode 
	{
		public nanoCAD.InanoCADPreferencesSelection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.InanoCADPreferencesSelection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPreferencesSelection_ConstructorCast : INode 
	{
		public nanoCAD.InanoCADPreferencesSelection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.InanoCADPreferencesSelection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Returns the Application object.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]

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
		Text = "Specifies or returns whether you select objects before or after calling a command.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether you select objects before or after calling a command.
	///</summary>
	public class Set_PickFirst : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PickFirst = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether you select objects before or after calling a command.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]

	///<summary>
	///Specifies or returns whether you select objects before or after calling a command.
	///</summary>
	public class PickFirst : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PickFirst);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether objects can be added to a selection set using the Shift key.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether objects can be added to a selection set using the Shift key.
	///</summary>
	public class Set_PickAdd : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PickAdd = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether objects can be added to a selection set using the Shift key.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]

	///<summary>
	///Specifies or returns whether objects can be added to a selection set using the Shift key.
	///</summary>
	public class PickAdd : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PickAdd);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns how a selection window is defined.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns how a selection window is defined.
	///</summary>
	public class Set_PickDrag : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PickDrag = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns how a selection window is defined.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]

	///<summary>
	///Specifies or returns how a selection window is defined.
	///</summary>
	public class PickDrag : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PickDrag);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns use of the selection window when selecting objects.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns use of the selection window when selecting objects.
	///</summary>
	public class Set_PickAuto : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PickAuto = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns use of the selection window when selecting objects.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]

	///<summary>
	///Specifies or returns use of the selection window when selecting objects.
	///</summary>
	public class PickAuto : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PickAuto);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the target height of object selection.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns the target height of object selection.
	///</summary>
	public class Set_PickBoxSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PickBoxSize = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the target height of object selection.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]

	///<summary>
	///Specifies or returns the target height of object selection.
	///</summary>
	public class PickBoxSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PickBoxSize);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether selection set grips display.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether selection set grips display.
	///</summary>
	public class Set_DisplayGrips : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DisplayGrips = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether selection set grips display.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]

	///<summary>
	///Specifies or returns whether selection set grips display.
	///</summary>
	public class DisplayGrips : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DisplayGrips);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether grips display for the objects in a block when the block is selected.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether grips display for the objects in a block when the block is selected.
	///</summary>
	public class Set_DisplayGripsWithinBlocks : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DisplayGripsWithinBlocks = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether grips display for the objects in a block when the block is selected.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]

	///<summary>
	///Specifies or returns whether grips display for the objects in a block when the block is selected.
	///</summary>
	public class DisplayGripsWithinBlocks : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DisplayGripsWithinBlocks);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the color of selected grips.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns the color of selected grips.
	///</summary>
	public class Set_GripColorSelected : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GripColorSelected = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the color of selected grips.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]

	///<summary>
	///Specifies or returns the color of selected grips.
	///</summary>
	public class GripColorSelected : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GripColorSelected);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the color of unselected grips.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns the color of unselected grips.
	///</summary>
	public class Set_GripColorUnselected : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GripColorUnselected = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the color of unselected grips.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]

	///<summary>
	///Specifies or returns the color of unselected grips.
	///</summary>
	public class GripColorUnselected : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GripColorUnselected);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the size of grips.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns the size of grips.
	///</summary>
	public class Set_GripSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GripSize = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the size of grips.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]

	///<summary>
	///Specifies or returns the size of grips.
	///</summary>
	public class GripSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GripSize);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether selecting an object in a group selects the whole group.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]
	[NodeInput("pick", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether selecting an object in a group selects the whole group.
	///</summary>
	public class Set_PickGroup : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PickGroup = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether selecting an object in a group selects the whole group.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]

	///<summary>
	///Specifies or returns whether selecting an object in a group selects the whole group.
	///</summary>
	public class PickGroup : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PickGroup);

		}
	}
}
