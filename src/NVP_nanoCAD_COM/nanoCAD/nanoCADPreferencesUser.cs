using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Specifies user settings.
///</summary>
namespace NVP_nanoCAD_COM._nanoCAD.nanoCADPreferencesUser 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
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

	[NVP_Manifest(
		ViewType = "Modifier")]
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


	[NVP_Manifest(
		Text = "Returns the Application object.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesUser", typeof(object))]

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
		Text = "Specifies or returns which keyboard configuration is used.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesUser", typeof(object))]
	[NodeInput("nanoCAD.AcKeyboardAccelerator", typeof(System.Object))]

	///<summary>
	///Specifies or returns which keyboard configuration is used.
	///</summary>
	public class Set_KeyboardAccelerator : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.KeyboardAccelerator = ((nanoCAD.AcKeyboardAccelerator)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns which keyboard configuration is used.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesUser", typeof(object))]

	///<summary>
	///Specifies or returns which keyboard configuration is used.
	///</summary>
	public class KeyboardAccelerator : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.KeyboardAccelerator);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns how to obtain coordinate input.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesUser", typeof(object))]
	[NodeInput("nanoCAD.AcKeyboardPriority", typeof(System.Object))]

	///<summary>
	///Specifies or returns how to obtain coordinate input.
	///</summary>
	public class Set_KeyboardPriority : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.KeyboardPriority = ((nanoCAD.AcKeyboardPriority)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns how to obtain coordinate input.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesUser", typeof(object))]

	///<summary>
	///Specifies or returns how to obtain coordinate input.
	///</summary>
	public class KeyboardPriority : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.KeyboardPriority);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns wherther a hyperlink cursor displays when the pointer is over an object that has an assigned hyperlink.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesUser", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns wherther a hyperlink cursor displays when the pointer is over an object that has an assigned hyperlink.
	///</summary>
	public class Set_HyperlinkDisplayCursor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HyperlinkDisplayCursor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns wherther a hyperlink cursor displays when the pointer is over an object that has an assigned hyperlink.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesUser", typeof(object))]

	///<summary>
	///Specifies or returns wherther a hyperlink cursor displays when the pointer is over an object that has an assigned hyperlink.
	///</summary>
	public class HyperlinkDisplayCursor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HyperlinkDisplayCursor);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether hyperlink tooltips display when the pointer is over an object that contains a hyperlink.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesUser", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether hyperlink tooltips display when the pointer is over an object that contains a hyperlink.
	///</summary>
	public class Set_HyperlinkDisplayTooltip : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HyperlinkDisplayTooltip = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether hyperlink tooltips display when the pointer is over an object that contains a hyperlink.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesUser", typeof(object))]

	///<summary>
	///Specifies or returns whether hyperlink tooltips display when the pointer is over an object that contains a hyperlink.
	///</summary>
	public class HyperlinkDisplayTooltip : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HyperlinkDisplayTooltip);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the units for objects that are from a drawing without insert units assigned.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesUser", typeof(object))]
	[NodeInput("pIU", typeof(System.Object))]

	///<summary>
	///Specifies or returns the units for objects that are from a drawing without insert units assigned.
	///</summary>
	public class Set_ADCInsertUnitsDefaultSource : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ADCInsertUnitsDefaultSource = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the units for objects that are from a drawing without insert units assigned.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesUser", typeof(object))]

	///<summary>
	///Specifies or returns the units for objects that are from a drawing without insert units assigned.
	///</summary>
	public class ADCInsertUnitsDefaultSource : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ADCInsertUnitsDefaultSource);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the units for objects that are meant for a drawing without insert units assigned.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesUser", typeof(object))]
	[NodeInput("pSUunits", typeof(System.Object))]

	///<summary>
	///Specifies or returns the units for objects that are meant for a drawing without insert units assigned.
	///</summary>
	public class Set_ADCInsertUnitsDefaultTarget : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ADCInsertUnitsDefaultTarget = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the units for objects that are meant for a drawing without insert units assigned.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesUser", typeof(object))]

	///<summary>
	///Specifies or returns the units for objects that are meant for a drawing without insert units assigned.
	///</summary>
	public class ADCInsertUnitsDefaultTarget : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ADCInsertUnitsDefaultTarget);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a shortcut menu displays when right-clicking in a drawing.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesUser", typeof(object))]
	[NodeInput("pSCM", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether a shortcut menu displays when right-clicking in a drawing.
	///</summary>
	public class Set_ShortCutMenuDisplay : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShortCutMenuDisplay = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a shortcut menu displays when right-clicking in a drawing.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesUser", typeof(object))]

	///<summary>
	///Specifies or returns whether a shortcut menu displays when right-clicking in a drawing.
	///</summary>
	public class ShortCutMenuDisplay : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShortCutMenuDisplay);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the action to take if a right-click occurs when no objects are selected and no commands are active.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesUser", typeof(object))]
	[NodeInput("nanoCAD.AcDrawingAreaSCMDefault", typeof(System.Object))]

	///<summary>
	///Specifies or returns the action to take if a right-click occurs when no objects are selected and no commands are active.
	///</summary>
	public class Set_SCMDefaultMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SCMDefaultMode = ((nanoCAD.AcDrawingAreaSCMDefault)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the action to take if a right-click occurs when no objects are selected and no commands are active.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesUser", typeof(object))]

	///<summary>
	///Specifies or returns the action to take if a right-click occurs when no objects are selected and no commands are active.
	///</summary>
	public class SCMDefaultMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SCMDefaultMode);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the action to take if a right-click occurs when objects are selected and no commands are active.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesUser", typeof(object))]
	[NodeInput("nanoCAD.AcDrawingAreaSCMEdit", typeof(System.Object))]

	///<summary>
	///Specifies or returns the action to take if a right-click occurs when objects are selected and no commands are active.
	///</summary>
	public class Set_SCMEditMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SCMEditMode = ((nanoCAD.AcDrawingAreaSCMEdit)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the action to take if a right-click occurs when objects are selected and no commands are active.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesUser", typeof(object))]

	///<summary>
	///Specifies or returns the action to take if a right-click occurs when objects are selected and no commands are active.
	///</summary>
	public class SCMEditMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SCMEditMode);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the action to take if a right-click occurs when a command is active.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesUser", typeof(object))]
	[NodeInput("nanoCAD.AcDrawingAreaSCMCommand", typeof(System.Object))]

	///<summary>
	///Specifies or returns the action to take if a right-click occurs when a command is active.
	///</summary>
	public class Set_SCMCommandMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SCMCommandMode = ((nanoCAD.AcDrawingAreaSCMCommand)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the action to take if a right-click occurs when a command is active.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesUser", typeof(object))]

	///<summary>
	///Specifies or returns the action to take if a right-click occurs when a command is active.
	///</summary>
	public class SCMCommandMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SCMCommandMode);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a short right-click initiates Enter and a long right-click initiates a shortcut menu.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesUser", typeof(object))]
	[NodeInput("time", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether a short right-click initiates Enter and a long right-click initiates a shortcut menu.
	///</summary>
	public class Set_SCMTimeMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SCMTimeMode = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a short right-click initiates Enter and a long right-click initiates a shortcut menu.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesUser", typeof(object))]

	///<summary>
	///Specifies or returns whether a short right-click initiates Enter and a long right-click initiates a shortcut menu.
	///</summary>
	public class SCMTimeMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SCMTimeMode);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the time for SCMTimeMode.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesUser", typeof(object))]
	[NodeInput("time", typeof(System.Int32))]

	///<summary>
	///Specifies or returns the time for SCMTimeMode.
	///</summary>
	public class Set_SCMTimeValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SCMTimeValue = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the time for SCMTimeMode.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesUser", typeof(object))]

	///<summary>
	///Specifies or returns the time for SCMTimeMode.
	///</summary>
	public class SCMTimeValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SCMTimeValue);

		}
	}
}
