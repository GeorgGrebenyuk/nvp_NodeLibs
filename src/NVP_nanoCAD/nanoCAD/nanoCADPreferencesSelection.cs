using NVP.API.Nodes;

namespace nanoCAD.nanoCADPreferencesSelection 
{
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


	///<summary>
	///Returns the Application object.
	///</summary>
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]
	public class Application : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Application);

		}
	}


	///<summary>
	///Specifies or returns whether you select objects before or after calling a command.
	///</summary>
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]
	public class Set_PickFirst : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PickFirst = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether you select objects before or after calling a command.
	///</summary>
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]
	public class PickFirst : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PickFirst);

		}
	}


	///<summary>
	///Specifies or returns whether objects can be added to a selection set using the Shift key.
	///</summary>
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]
	public class Set_PickAdd : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PickAdd = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether objects can be added to a selection set using the Shift key.
	///</summary>
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]
	public class PickAdd : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PickAdd);

		}
	}


	///<summary>
	///Specifies or returns how a selection window is defined.
	///</summary>
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]
	public class Set_PickDrag : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PickDrag = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns how a selection window is defined.
	///</summary>
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]
	public class PickDrag : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PickDrag);

		}
	}


	///<summary>
	///Specifies or returns use of the selection window when selecting objects.
	///</summary>
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]
	public class Set_PickAuto : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PickAuto = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns use of the selection window when selecting objects.
	///</summary>
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]
	public class PickAuto : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PickAuto);

		}
	}


	///<summary>
	///Specifies or returns the target height of object selection.
	///</summary>
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]
	public class Set_PickBoxSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PickBoxSize = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the target height of object selection.
	///</summary>
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]
	public class PickBoxSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PickBoxSize);

		}
	}


	///<summary>
	///Specifies or returns whether selection set grips display.
	///</summary>
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]
	public class Set_DisplayGrips : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DisplayGrips = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether selection set grips display.
	///</summary>
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]
	public class DisplayGrips : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DisplayGrips);

		}
	}


	///<summary>
	///Specifies or returns whether grips display for the objects in a block when the block is selected.
	///</summary>
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]
	public class Set_DisplayGripsWithinBlocks : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DisplayGripsWithinBlocks = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether grips display for the objects in a block when the block is selected.
	///</summary>
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]
	public class DisplayGripsWithinBlocks : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DisplayGripsWithinBlocks);

		}
	}


	///<summary>
	///Specifies or returns the color of selected grips.
	///</summary>
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]
	public class Set_GripColorSelected : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GripColorSelected = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the color of selected grips.
	///</summary>
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]
	public class GripColorSelected : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GripColorSelected);

		}
	}


	///<summary>
	///Specifies or returns the color of unselected grips.
	///</summary>
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]
	public class Set_GripColorUnselected : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GripColorUnselected = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the color of unselected grips.
	///</summary>
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]
	public class GripColorUnselected : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GripColorUnselected);

		}
	}


	///<summary>
	///Specifies or returns the size of grips.
	///</summary>
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]
	public class Set_GripSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GripSize = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the size of grips.
	///</summary>
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]
	public class GripSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GripSize);

		}
	}


	///<summary>
	///Specifies or returns whether selecting an object in a group selects the whole group.
	///</summary>
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]
	[NodeInput("pick", typeof(System.Object))]
	public class Set_PickGroup : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PickGroup = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether selecting an object in a group selects the whole group.
	///</summary>
	[NodeInput("nanoCADPreferencesSelection", typeof(object))]
	public class PickGroup : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PickGroup);

		}
	}
}
