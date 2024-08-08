using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///An toolbar
///</summary>
namespace nanoCAD.nanoCADToolbar 
{

	[NVP_Manifest(
		Id = "454FEB11-8C3B-48E2-BF13-AF7634F55CA0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbar.nanoCADToolbar_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbar", 
		NodeName = "_nanoCADToolbar_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADToolbar_Constructor : INode 
	{
		public nanoCAD.InanoCADToolbar _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.InanoCADToolbar;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "AE1E2B4C-FDF2-4E97-80BF-2DEF1A8A4456", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbar.nanoCADToolbar_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbar", 
		NodeName = "_nanoCADToolbar_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADToolbar_ConstructorCast : INode 
	{
		public nanoCAD.InanoCADToolbar _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.InanoCADToolbar;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "CD6471D0-4E03-4520-81FE-EB62484F463C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbar.Item", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbar", 
		NodeName = "Item", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the member object at a given index in a collection, group, or selection set", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbar", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///Gets the member object at a given index in a collection, group, or selection set
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
		Id = "4822FCCF-83A6-4A7B-ACEC-E8B6491D90FA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbar.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbar", 
		NodeName = "Count", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the number of items in the collection, dictionary, group, or selection set", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbar", typeof(object))]

	///<summary>
	///Gets the number of items in the collection, dictionary, group, or selection set
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
		Id = "3C081862-7ABD-493E-BD53-8A366758AF48", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbar.Application", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbar", 
		NodeName = "Application", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the Application object", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbar", typeof(object))]

	///<summary>
	///Gets the Application object
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
		Id = "6F580BD1-5C72-4924-BFFC-59CDFFB0F900", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbar.Parent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbar", 
		NodeName = "Parent", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the parent of the object", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbar", typeof(object))]

	///<summary>
	///Gets the parent of the object
	///</summary>
	public class Parent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Parent);

		}
	}


	[NVP_Manifest(
		Id = "F373959A-C7A9-4916-A904-05DC0154AC4A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbar.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbar", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the name of the object", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbar", typeof(object))]

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
		Id = "FF1480B5-1622-404D-A586-AA5E7D4814EE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbar.Set_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbar", 
		NodeName = "Set_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the name of the object", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADToolbar", typeof(object))]
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
		Id = "45F641A2-E6F7-4A34-B82E-698811186D04", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbar.Visible", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbar", 
		NodeName = "Visible", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the visibility of an object or the application", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbar", typeof(object))]

	///<summary>
	///Specifies the visibility of an object or the application
	///</summary>
	public class Visible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Visible);

		}
	}


	[NVP_Manifest(
		Id = "D73678F2-6510-4A23-A05D-7FEFED78E5C1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbar.Set_Visible", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbar", 
		NodeName = "Set_Visible", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the visibility of an object or the application", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADToolbar", typeof(object))]
	[NodeInput("bFlag", typeof(System.Object))]

	///<summary>
	///Specifies the visibility of an object or the application
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
		Id = "53B882A9-1572-4F70-A15E-76737B510705", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbar.DockStatus", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbar", 
		NodeName = "DockStatus", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies if the toolbar is docked or floating", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbar", typeof(object))]

	///<summary>
	///Specifies if the toolbar is docked or floating
	///</summary>
	public class DockStatus : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DockStatus);

		}
	}


	[NVP_Manifest(
		Id = "C5A9E061-45BC-4815-89D1-D57A3A60F8A3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbar.LargeButtons", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbar", 
		NodeName = "LargeButtons", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies if the toolbar button is large or small", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbar", typeof(object))]

	///<summary>
	///Specifies if the toolbar button is large or small
	///</summary>
	public class LargeButtons : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LargeButtons);

		}
	}


	[NVP_Manifest(
		Id = "DACE47E4-CBA1-436B-BAF9-EC19E9A3D455", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbar.left", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbar", 
		NodeName = "left", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the left edge of a toolbar", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbar", typeof(object))]

	///<summary>
	///Specifies the left edge of a toolbar
	///</summary>
	public class left : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.left);

		}
	}


	[NVP_Manifest(
		Id = "CF86ABEB-BD4D-4267-BD55-D4170EB07ADB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbar.Set_left", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbar", 
		NodeName = "Set_left", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the left edge of a toolbar", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADToolbar", typeof(object))]
	[NodeInput("nLeft", typeof(System.Int32))]

	///<summary>
	///Specifies the left edge of a toolbar
	///</summary>
	public class Set_left : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.left = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9753758C-59EB-4DEA-A792-AEFDE54ECBA1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbar.top", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbar", 
		NodeName = "top", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the top edge of a toolbar", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbar", typeof(object))]

	///<summary>
	///Specifies the top edge of a toolbar
	///</summary>
	public class top : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.top);

		}
	}


	[NVP_Manifest(
		Id = "E4C2CD2A-4AF5-4BC5-91DF-22B6542EA83A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbar.Set_top", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbar", 
		NodeName = "Set_top", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the top edge of a toolbar", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADToolbar", typeof(object))]
	[NodeInput("nTop", typeof(System.Int32))]

	///<summary>
	///Specifies the top edge of a toolbar
	///</summary>
	public class Set_top : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.top = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6EA81FAF-97F0-4124-B1EE-EED0125FB66F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbar.Width", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbar", 
		NodeName = "Width", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the width of the text boundary, view, image, toolbar, or main application window", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbar", typeof(object))]

	///<summary>
	///Specifies the width of the text boundary, view, image, toolbar, or main application window
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
		Id = "962D5066-1125-49E2-A535-D202E2A9249F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbar.Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbar", 
		NodeName = "Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Height of the attribute, shape, text, or view toolbar or the main application window", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbar", typeof(object))]

	///<summary>
	///Height of the attribute, shape, text, or view toolbar or the main application window
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
		Id = "9B8EA1F6-5733-4731-9568-66017A39D2C3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbar.FloatingRows", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbar", 
		NodeName = "FloatingRows", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the number of rows for a floating toolbar", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbar", typeof(object))]

	///<summary>
	///Specifies the number of rows for a floating toolbar
	///</summary>
	public class FloatingRows : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FloatingRows);

		}
	}


	[NVP_Manifest(
		Id = "E25672BC-078C-4A13-9B72-869849086A11", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbar.Set_FloatingRows", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbar", 
		NodeName = "Set_FloatingRows", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the number of rows for a floating toolbar", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADToolbar", typeof(object))]
	[NodeInput("nRows", typeof(System.Int32))]

	///<summary>
	///Specifies the number of rows for a floating toolbar
	///</summary>
	public class Set_FloatingRows : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FloatingRows = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "35ACE2E6-F8A0-4A11-8709-A13C0FF673E8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbar.HelpString", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbar", 
		NodeName = "HelpString", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the help string for the toolbar, toolbar item, or menu item", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbar", typeof(object))]

	///<summary>
	///Specifies the help string for the toolbar, toolbar item, or menu item
	///</summary>
	public class HelpString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HelpString);

		}
	}


	[NVP_Manifest(
		Id = "02B93104-2E51-4742-BF44-6F3FBA249A7D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbar.Set_HelpString", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbar", 
		NodeName = "Set_HelpString", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the help string for the toolbar, toolbar item, or menu item", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADToolbar", typeof(object))]
	[NodeInput("bstrHelp", typeof(System.String))]

	///<summary>
	///Specifies the help string for the toolbar, toolbar item, or menu item
	///</summary>
	public class Set_HelpString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HelpString = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "47DC723B-90ED-47AC-B0F2-90A3677B9BE3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbar.AddToolbarButton", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbar", 
		NodeName = "AddToolbarButton", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Adds a toolbar item to a toolbar at a specified position", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbar", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]
	[NodeInput("Name", typeof(System.String))]
	[NodeInput("HelpString", typeof(System.String))]
	[NodeInput("Macro", typeof(System.String))]
	[NodeInput("FlyoutButton", typeof(System.Object))]

	///<summary>
	///Adds a toolbar item to a toolbar at a specified position
	///</summary>
	public class AddToolbarButton : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddToolbarButton(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value,inputs[5].Value));

		}
	}


	[NVP_Manifest(
		Id = "E27478D0-0D51-49D2-957F-697FEAEBD0EF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbar.AddSeparator", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbar", 
		NodeName = "AddSeparator", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Adds a separator to an existing menu or toolbar", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbar", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///Adds a separator to an existing menu or toolbar
	///</summary>
	public class AddSeparator : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddSeparator(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "CAC2B1D1-03C3-45DA-8BD4-DBB8DDA85467", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbar.Dock", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbar", 
		NodeName = "Dock", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Docks the toolbar to the owning frame window", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADToolbar", typeof(object))]
	[NodeInput("nanoCAD.AcToolbarDockStatus", typeof(System.Object))]

	///<summary>
	///Docks the toolbar to the owning frame window
	///</summary>
	public class Dock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Dock(((nanoCAD.AcToolbarDockStatus)inputs[1].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Id = "46116CCB-F168-492C-B47B-9E151BCBDF5F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbar.Float", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbar", 
		NodeName = "Float", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Floats the toolbar", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADToolbar", typeof(object))]
	[NodeInput("top", typeof(System.Int32))]
	[NodeInput("left", typeof(System.Int32))]
	[NodeInput("NumberFloatRows", typeof(System.Int32))]

	///<summary>
	///Floats the toolbar
	///</summary>
	public class Float : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Float(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "47FEEA3D-022B-4FCC-A132-E14F91A8010D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbar.Delete", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbar", 
		NodeName = "Delete", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Deletes a specified object", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADToolbar", typeof(object))]

	///<summary>
	///Deletes a specified object
	///</summary>
	public class Delete : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Delete();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "399EDB71-58A4-49EF-8B3F-917BEEBA2033", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADToolbar.TagString", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADToolbar", 
		NodeName = "TagString", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the tag string of the object", 
		ViewType = "Data")]
	[NodeInput("nanoCADToolbar", typeof(object))]

	///<summary>
	///Specifies the tag string of the object
	///</summary>
	public class TagString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TagString);

		}
	}
}
