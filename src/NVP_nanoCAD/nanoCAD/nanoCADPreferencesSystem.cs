using NVP.API.Nodes;

namespace nanoCAD.nanoCADPreferencesSystem 
{
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


	///<summary>
	///Returns the Application object.
	///</summary>
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]
	public class Application : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Application);

		}
	}


	///<summary>
	///Specifies or returns whether single or multiple drawings can be open at the same time.
	///</summary>
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]
	public class Set_SingleDocumentMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SingleDocumentMode = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether single or multiple drawings can be open at the same time.
	///</summary>
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]
	public class SingleDocumentMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SingleDocumentMode);

		}
	}


	///<summary>
	///Specifies or returns whether the user is prompted to scale OLE objects when adding OLE objects to a drawing.
	///</summary>
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]
	public class Set_DisplayOLEScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DisplayOLEScale = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether the user is prompted to scale OLE objects when adding OLE objects to a drawing.
	///</summary>
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]
	public class DisplayOLEScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DisplayOLEScale);

		}
	}


	///<summary>
	///Specifies or returns whether the SQL index is stored in drawings.
	///</summary>
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]
	public class Set_StoreSQLIndex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StoreSQLIndex = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether the SQL index is stored in drawings.
	///</summary>
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]
	public class StoreSQLIndex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StoreSQLIndex);

		}
	}


	///<summary>
	///Specifies or returns whether to database tables are read-only.
	///</summary>
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]
	public class Set_TablesReadOnly : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TablesReadOnly = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether to database tables are read-only.
	///</summary>
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]
	public class TablesReadOnly : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TablesReadOnly);

		}
	}


	///<summary>
	///Specifies or returns whether a Startup dialog box displays automatically when the application starts.
	///</summary>
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]
	public class Set_EnableStartupDialog : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EnableStartupDialog = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether a Startup dialog box displays automatically when the application starts.
	///</summary>
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]
	public class EnableStartupDialog : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EnableStartupDialog);

		}
	}


	///<summary>
	///Specifies or returns whether a beep sounds automatically when user input results in an error.
	///</summary>
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]
	[NodeInput("BeepOnError", typeof(System.Object))]
	public class Set_BeepOnError : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BeepOnError = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether a beep sounds automatically when user input results in an error.
	///</summary>
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]
	public class BeepOnError : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BeepOnError);

		}
	}


	///<summary>
	///Specifies or returns whether all warning dialog boxes display.
	///</summary>
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]
	public class Set_ShowWarningMessages : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShowWarningMessages = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether all warning dialog boxes display.
	///</summary>
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]
	public class ShowWarningMessages : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShowWarningMessages);

		}
	}


	///<summary>
	///Not implemented.
	///</summary>
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]
	[NodeInput("pALID", typeof(System.Object))]
	public class Set_LoadAcadLspInAllDocuments : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LoadAcadLspInAllDocuments = inputs[1];
			return null;
		}
	}


	///<summary>
	///Not implemented.
	///</summary>
	[NodeInput("nanoCADPreferencesSystem", typeof(object))]
	public class LoadAcadLspInAllDocuments : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LoadAcadLspInAllDocuments);

		}
	}
}
