using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Specifies selection settings.
///</summary>
namespace nanoCAD.nanoCADPreferencesSelection 
{

	[NVP_Manifest(
		Id = "362CF47C-3746-4675-B0AD-08256AD51CEA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesSelection.nanoCADPreferencesSelection_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesSelection", 
		NodeName = "_nanoCADPreferencesSelection_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "986293A8-67CB-4D74-A849-39CF9E586B85", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesSelection.nanoCADPreferencesSelection_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesSelection", 
		NodeName = "_nanoCADPreferencesSelection_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "3D526294-88A1-4DB8-BB73-A5403F0D6098", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesSelection.Application", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesSelection", 
		NodeName = "Application", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "9DE5EC72-123F-4EAA-BC20-333D79A9CB17", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesSelection.Set_PickFirst", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesSelection", 
		NodeName = "Set_PickFirst", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "4C76B77E-A75F-4D18-8DDF-2756E8164DD6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesSelection.PickFirst", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesSelection", 
		NodeName = "PickFirst", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "328255B4-1F3B-4128-B45E-638461E07599", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesSelection.Set_PickAdd", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesSelection", 
		NodeName = "Set_PickAdd", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "D0D2A808-10AD-4A93-A31D-FD260FFFAC94", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesSelection.PickAdd", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesSelection", 
		NodeName = "PickAdd", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "706F45A7-C0CD-4B8B-B68A-90D715EAB90E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesSelection.Set_PickDrag", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesSelection", 
		NodeName = "Set_PickDrag", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "C7FF46D2-561F-4972-AF8D-60DF0167ACFB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesSelection.PickDrag", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesSelection", 
		NodeName = "PickDrag", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "55F064A2-D9B6-4B53-9FA6-7A2E9D2B202C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesSelection.Set_PickAuto", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesSelection", 
		NodeName = "Set_PickAuto", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "11F6412D-3B5E-443A-84C9-9D96AE50BE4F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesSelection.PickAuto", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesSelection", 
		NodeName = "PickAuto", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "CBCC9B49-B3D9-4ECE-8388-AAA2D793B13E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesSelection.Set_PickBoxSize", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesSelection", 
		NodeName = "Set_PickBoxSize", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "2F0018B4-816E-4F90-BED4-58F904DA8504", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesSelection.PickBoxSize", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesSelection", 
		NodeName = "PickBoxSize", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "D5862202-4F75-4551-8C3B-9551D76B3C9A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesSelection.Set_DisplayGrips", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesSelection", 
		NodeName = "Set_DisplayGrips", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "1A6DA1FE-77FA-47E1-BD42-7E544E95305A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesSelection.DisplayGrips", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesSelection", 
		NodeName = "DisplayGrips", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "15FE6621-8787-44D7-8732-622B7CBD38DA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesSelection.Set_DisplayGripsWithinBlocks", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesSelection", 
		NodeName = "Set_DisplayGripsWithinBlocks", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "87E60D9F-644A-439D-8082-F433EBD7CDF0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesSelection.DisplayGripsWithinBlocks", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesSelection", 
		NodeName = "DisplayGripsWithinBlocks", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "3B69EF38-97B3-43FF-BCB9-188E1B137BB3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesSelection.Set_GripColorSelected", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesSelection", 
		NodeName = "Set_GripColorSelected", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "33885D8E-4AA8-459B-8770-9DB85692977B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesSelection.GripColorSelected", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesSelection", 
		NodeName = "GripColorSelected", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "0C0A9B06-060E-4F50-9E8D-9B0C929B1254", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesSelection.Set_GripColorUnselected", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesSelection", 
		NodeName = "Set_GripColorUnselected", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "BA9360D6-9156-49B5-8FF2-FD8BF0F0763B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesSelection.GripColorUnselected", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesSelection", 
		NodeName = "GripColorUnselected", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "FEB87717-65BA-49A2-9280-5BBA8FFDBFA4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesSelection.Set_GripSize", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesSelection", 
		NodeName = "Set_GripSize", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "96D5467F-9466-4894-B1CB-79761596F5DE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesSelection.GripSize", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesSelection", 
		NodeName = "GripSize", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "F59677BD-F150-432C-88D8-8B8A1A93D7BF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesSelection.Set_PickGroup", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesSelection", 
		NodeName = "Set_PickGroup", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "3C1F1973-0859-4349-9D49-F1E3D837A686", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesSelection.PickGroup", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesSelection", 
		NodeName = "PickGroup", 
		NodeType = "Loaded", 
		CADType = "None", 
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
