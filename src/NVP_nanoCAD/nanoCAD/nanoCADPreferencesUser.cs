using NVP.API.Nodes;

namespace nanoCAD.nanoCADPreferencesUser 
{
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPreferencesUser_Constructor : INode 
	{
		public nanoCAD.InanoCADPreferencesUser _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.InanoCADPreferencesUser;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPreferencesUser_ConstructorCast : INode 
	{
		public nanoCAD.InanoCADPreferencesUser _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.InanoCADPreferencesUser;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///Returns the Application object.
	///</summary>
	[NodeInput("nanoCADPreferencesUser", typeof(object))]
	public class Application : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Application);

		}
	}


	///<summary>
	///Specifies or returns which keyboard configuration is used.
	///</summary>
	[NodeInput("nanoCADPreferencesUser", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]
	public class Set_KeyboardAccelerator : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.KeyboardAccelerator = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns which keyboard configuration is used.
	///</summary>
	[NodeInput("nanoCADPreferencesUser", typeof(object))]
	public class KeyboardAccelerator : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.KeyboardAccelerator);

		}
	}


	///<summary>
	///Specifies or returns how to obtain coordinate input.
	///</summary>
	[NodeInput("nanoCADPreferencesUser", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]
	public class Set_KeyboardPriority : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.KeyboardPriority = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns how to obtain coordinate input.
	///</summary>
	[NodeInput("nanoCADPreferencesUser", typeof(object))]
	public class KeyboardPriority : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.KeyboardPriority);

		}
	}


	///<summary>
	///Specifies or returns wherther a hyperlink cursor displays when the pointer is over an object that has an assigned hyperlink.
	///</summary>
	[NodeInput("nanoCADPreferencesUser", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]
	public class Set_HyperlinkDisplayCursor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HyperlinkDisplayCursor = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns wherther a hyperlink cursor displays when the pointer is over an object that has an assigned hyperlink.
	///</summary>
	[NodeInput("nanoCADPreferencesUser", typeof(object))]
	public class HyperlinkDisplayCursor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HyperlinkDisplayCursor);

		}
	}


	///<summary>
	///Specifies or returns whether hyperlink tooltips display when the pointer is over an object that contains a hyperlink.
	///</summary>
	[NodeInput("nanoCADPreferencesUser", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]
	public class Set_HyperlinkDisplayTooltip : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HyperlinkDisplayTooltip = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether hyperlink tooltips display when the pointer is over an object that contains a hyperlink.
	///</summary>
	[NodeInput("nanoCADPreferencesUser", typeof(object))]
	public class HyperlinkDisplayTooltip : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HyperlinkDisplayTooltip);

		}
	}


	///<summary>
	///Specifies or returns the units for objects that are from a drawing without insert units assigned.
	///</summary>
	[NodeInput("nanoCADPreferencesUser", typeof(object))]
	[NodeInput("pIU", typeof(System.Object))]
	public class Set_ADCInsertUnitsDefaultSource : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ADCInsertUnitsDefaultSource = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the units for objects that are from a drawing without insert units assigned.
	///</summary>
	[NodeInput("nanoCADPreferencesUser", typeof(object))]
	public class ADCInsertUnitsDefaultSource : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ADCInsertUnitsDefaultSource);

		}
	}


	///<summary>
	///Specifies or returns the units for objects that are meant for a drawing without insert units assigned.
	///</summary>
	[NodeInput("nanoCADPreferencesUser", typeof(object))]
	[NodeInput("pSUunits", typeof(System.Object))]
	public class Set_ADCInsertUnitsDefaultTarget : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ADCInsertUnitsDefaultTarget = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the units for objects that are meant for a drawing without insert units assigned.
	///</summary>
	[NodeInput("nanoCADPreferencesUser", typeof(object))]
	public class ADCInsertUnitsDefaultTarget : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ADCInsertUnitsDefaultTarget);

		}
	}


	///<summary>
	///Specifies or returns whether a shortcut menu displays when right-clicking in a drawing.
	///</summary>
	[NodeInput("nanoCADPreferencesUser", typeof(object))]
	[NodeInput("pSCM", typeof(System.Object))]
	public class Set_ShortCutMenuDisplay : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShortCutMenuDisplay = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether a shortcut menu displays when right-clicking in a drawing.
	///</summary>
	[NodeInput("nanoCADPreferencesUser", typeof(object))]
	public class ShortCutMenuDisplay : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShortCutMenuDisplay);

		}
	}


	///<summary>
	///Specifies or returns the action to take if a right-click occurs when no objects are selected and no commands are active.
	///</summary>
	[NodeInput("nanoCADPreferencesUser", typeof(object))]
	[NodeInput("pSCM", typeof(System.Object))]
	public class Set_SCMDefaultMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SCMDefaultMode = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the action to take if a right-click occurs when no objects are selected and no commands are active.
	///</summary>
	[NodeInput("nanoCADPreferencesUser", typeof(object))]
	public class SCMDefaultMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SCMDefaultMode);

		}
	}


	///<summary>
	///Specifies or returns the action to take if a right-click occurs when objects are selected and no commands are active.
	///</summary>
	[NodeInput("nanoCADPreferencesUser", typeof(object))]
	[NodeInput("pSCM", typeof(System.Object))]
	public class Set_SCMEditMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SCMEditMode = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the action to take if a right-click occurs when objects are selected and no commands are active.
	///</summary>
	[NodeInput("nanoCADPreferencesUser", typeof(object))]
	public class SCMEditMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SCMEditMode);

		}
	}


	///<summary>
	///Specifies or returns the action to take if a right-click occurs when a command is active.
	///</summary>
	[NodeInput("nanoCADPreferencesUser", typeof(object))]
	[NodeInput("pSCM", typeof(System.Object))]
	public class Set_SCMCommandMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SCMCommandMode = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the action to take if a right-click occurs when a command is active.
	///</summary>
	[NodeInput("nanoCADPreferencesUser", typeof(object))]
	public class SCMCommandMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SCMCommandMode);

		}
	}


	///<summary>
	///Specifies or returns whether a short right-click initiates Enter and a long right-click initiates a shortcut menu.
	///</summary>
	[NodeInput("nanoCADPreferencesUser", typeof(object))]
	[NodeInput("time", typeof(System.Object))]
	public class Set_SCMTimeMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SCMTimeMode = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether a short right-click initiates Enter and a long right-click initiates a shortcut menu.
	///</summary>
	[NodeInput("nanoCADPreferencesUser", typeof(object))]
	public class SCMTimeMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SCMTimeMode);

		}
	}


	///<summary>
	///Specifies or returns the time for SCMTimeMode.
	///</summary>
	[NodeInput("nanoCADPreferencesUser", typeof(object))]
	[NodeInput("time", typeof(System.Int32))]
	public class Set_SCMTimeValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SCMTimeValue = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the time for SCMTimeMode.
	///</summary>
	[NodeInput("nanoCADPreferencesUser", typeof(object))]
	public class SCMTimeValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SCMTimeValue);

		}
	}
}
