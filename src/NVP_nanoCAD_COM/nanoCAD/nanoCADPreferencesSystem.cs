using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Specifies system settings.
///</summary>
namespace nanoCAD.nanoCADPreferencesSystem 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPreferencesSystem_Constructor : INode 
	{
		public nanoCAD.InanoCADPreferencesSystem _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.InanoCADPreferencesSystem;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPreferencesSystem_ConstructorCast : INode 
	{
		public nanoCAD.InanoCADPreferencesSystem _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.InanoCADPreferencesSystem;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Returns the Application object.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]

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
		Text = "Specifies or returns whether single or multiple drawings can be open at the same time.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether single or multiple drawings can be open at the same time.
	///</summary>
	public class Set_SingleDocumentMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SingleDocumentMode = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether single or multiple drawings can be open at the same time.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]

	///<summary>
	///Specifies or returns whether single or multiple drawings can be open at the same time.
	///</summary>
	public class SingleDocumentMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SingleDocumentMode);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the user is prompted to scale OLE objects when adding OLE objects to a drawing.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the user is prompted to scale OLE objects when adding OLE objects to a drawing.
	///</summary>
	public class Set_DisplayOLEScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DisplayOLEScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the user is prompted to scale OLE objects when adding OLE objects to a drawing.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]

	///<summary>
	///Specifies or returns whether the user is prompted to scale OLE objects when adding OLE objects to a drawing.
	///</summary>
	public class DisplayOLEScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DisplayOLEScale);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the SQL index is stored in drawings.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the SQL index is stored in drawings.
	///</summary>
	public class Set_StoreSQLIndex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StoreSQLIndex = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the SQL index is stored in drawings.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]

	///<summary>
	///Specifies or returns whether the SQL index is stored in drawings.
	///</summary>
	public class StoreSQLIndex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StoreSQLIndex);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether to database tables are read-only.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether to database tables are read-only.
	///</summary>
	public class Set_TablesReadOnly : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TablesReadOnly = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether to database tables are read-only.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]

	///<summary>
	///Specifies or returns whether to database tables are read-only.
	///</summary>
	public class TablesReadOnly : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TablesReadOnly);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a Startup dialog box displays automatically when the application starts.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether a Startup dialog box displays automatically when the application starts.
	///</summary>
	public class Set_EnableStartupDialog : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EnableStartupDialog = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a Startup dialog box displays automatically when the application starts.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]

	///<summary>
	///Specifies or returns whether a Startup dialog box displays automatically when the application starts.
	///</summary>
	public class EnableStartupDialog : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EnableStartupDialog);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a beep sounds automatically when user input results in an error.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]
	[NodeInput("BeepOnError", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether a beep sounds automatically when user input results in an error.
	///</summary>
	public class Set_BeepOnError : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BeepOnError = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a beep sounds automatically when user input results in an error.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]

	///<summary>
	///Specifies or returns whether a beep sounds automatically when user input results in an error.
	///</summary>
	public class BeepOnError : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BeepOnError);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether all warning dialog boxes display.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether all warning dialog boxes display.
	///</summary>
	public class Set_ShowWarningMessages : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShowWarningMessages = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether all warning dialog boxes display.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]

	///<summary>
	///Specifies or returns whether all warning dialog boxes display.
	///</summary>
	public class ShowWarningMessages : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShowWarningMessages);

		}
	}


	[NVP_Manifest(
		Text = "Not implemented.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]
	[NodeInput("pALID", typeof(System.Object))]

	///<summary>
	///Not implemented.
	///</summary>
	public class Set_LoadAcadLspInAllDocuments : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LoadAcadLspInAllDocuments = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Not implemented.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]

	///<summary>
	///Not implemented.
	///</summary>
	public class LoadAcadLspInAllDocuments : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LoadAcadLspInAllDocuments);

		}
	}
}
