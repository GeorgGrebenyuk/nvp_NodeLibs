using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Specifies user settings.
///</summary>
namespace nanoCAD.nanoCADPreferencesUser 
{

	[NVP_Manifest(
		Id = "18CFE816-0D66-4E89-8F49-AEBE824B0032", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesUser.nanoCADPreferencesUser_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesUser", 
		NodeName = "_nanoCADPreferencesUser_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "FA16A086-A126-44E6-916B-F569B07D7F42", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesUser.nanoCADPreferencesUser_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesUser", 
		NodeName = "_nanoCADPreferencesUser_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "A76B9BF8-66E7-46B1-AA29-634966D101FF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesUser.Application", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesUser", 
		NodeName = "Application", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "9F218872-9B69-4E8E-BEE3-384C1FFCB1A5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesUser.Set_KeyboardAccelerator", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesUser", 
		NodeName = "Set_KeyboardAccelerator", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "5DCFE3E6-F9DC-4A8A-9104-1B5197FB6E80", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesUser.KeyboardAccelerator", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesUser", 
		NodeName = "KeyboardAccelerator", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "43A2A722-52D3-4D04-9526-687EC6DE36C9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesUser.Set_KeyboardPriority", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesUser", 
		NodeName = "Set_KeyboardPriority", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "FE74A050-47E4-44B3-B503-8EA38F390E73", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesUser.KeyboardPriority", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesUser", 
		NodeName = "KeyboardPriority", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "E6A18E75-984D-41CE-BD1D-81635D4A4CA7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesUser.Set_HyperlinkDisplayCursor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesUser", 
		NodeName = "Set_HyperlinkDisplayCursor", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "F8DB3658-0C42-4E15-99AF-897DE95C85F1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesUser.HyperlinkDisplayCursor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesUser", 
		NodeName = "HyperlinkDisplayCursor", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "6830BAB4-BB3C-47CA-A9AB-14BC2FEB29A6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesUser.Set_HyperlinkDisplayTooltip", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesUser", 
		NodeName = "Set_HyperlinkDisplayTooltip", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "0C47DB4D-A32D-48C9-A1F8-BF6863F748D8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesUser.HyperlinkDisplayTooltip", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesUser", 
		NodeName = "HyperlinkDisplayTooltip", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "80685191-E0C0-4D52-924B-2E66C7231ED4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesUser.Set_ADCInsertUnitsDefaultSource", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesUser", 
		NodeName = "Set_ADCInsertUnitsDefaultSource", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "E3617ABB-B6A2-4F9C-ADE4-D1CC426554E7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesUser.ADCInsertUnitsDefaultSource", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesUser", 
		NodeName = "ADCInsertUnitsDefaultSource", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "158D4E1A-4526-41BA-94AA-0DFB6E43C0F5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesUser.Set_ADCInsertUnitsDefaultTarget", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesUser", 
		NodeName = "Set_ADCInsertUnitsDefaultTarget", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "B81E8A38-1BE7-4DB2-BA7F-352E934A5F97", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesUser.ADCInsertUnitsDefaultTarget", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesUser", 
		NodeName = "ADCInsertUnitsDefaultTarget", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "8541B79C-CCBD-4B6E-BC68-B176CD3D6600", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesUser.Set_ShortCutMenuDisplay", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesUser", 
		NodeName = "Set_ShortCutMenuDisplay", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "EB5ECBE5-FF70-4B4B-9E87-F42B42D7B1C2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesUser.ShortCutMenuDisplay", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesUser", 
		NodeName = "ShortCutMenuDisplay", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "1C91A5F0-7F5F-4DFC-AC33-5B9AC2389A2D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesUser.Set_SCMDefaultMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesUser", 
		NodeName = "Set_SCMDefaultMode", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "BDCB7111-8B3B-430C-A203-57E82AB0CFD8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesUser.SCMDefaultMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesUser", 
		NodeName = "SCMDefaultMode", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "D9392EA5-01F6-4777-B2CF-0A38EB4C007A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesUser.Set_SCMEditMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesUser", 
		NodeName = "Set_SCMEditMode", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "6B9AED4C-97D9-4716-A211-A624242B2ADF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesUser.SCMEditMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesUser", 
		NodeName = "SCMEditMode", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "B5258E3C-6F56-43C9-8AAA-A7E9DC14E227", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesUser.Set_SCMCommandMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesUser", 
		NodeName = "Set_SCMCommandMode", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "AFEFA4FB-2222-4CB9-96E2-4F069E01DF00", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesUser.SCMCommandMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesUser", 
		NodeName = "SCMCommandMode", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "111D7F5A-E32F-444D-85D3-2E6C66D177FB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesUser.Set_SCMTimeMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesUser", 
		NodeName = "Set_SCMTimeMode", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "E1837D23-A979-4360-A6C5-10947CE0AE5D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesUser.SCMTimeMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesUser", 
		NodeName = "SCMTimeMode", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "13195EC1-E9A3-44A3-8591-0F8588144C8F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesUser.Set_SCMTimeValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesUser", 
		NodeName = "Set_SCMTimeValue", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "6D792B93-D69B-49F9-BC4F-B36BED2EC864", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesUser.SCMTimeValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesUser", 
		NodeName = "SCMTimeValue", 
		NodeType = "Loaded", 
		CADType = "None", 
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
