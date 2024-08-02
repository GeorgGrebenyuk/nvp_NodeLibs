using NVP.API.Nodes;

namespace nanoCAD.nanoCADApplication 
{
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADApplication_Constructor : INode 
	{
		public nanoCAD.InanoCADApplication _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.InanoCADApplication;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADApplication_ConstructorCast : INode 
	{
		public nanoCAD.InanoCADApplication _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.InanoCADApplication;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///Specifies the visibility of an object or the application
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	public class Visible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Visible);

		}
	}


	///<summary>
	///Specifies the visibility of an object or the application
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("Visible", typeof(System.Object))]
	public class Set_Visible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Visible = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the name of the object
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	///<summary>
	///Sets the text that the user sees displayed for the application or a menu item
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("bstrCaption", typeof(System.String))]
	public class Set_Caption : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Caption = inputs[1];
			return null;
		}
	}


	///<summary>
	///Sets the text that the user sees displayed for the application or a menu item
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	public class Caption : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Caption);

		}
	}


	///<summary>
	///Gets the Application object
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	public class Application : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Application);

		}
	}


	///<summary>
	///drawing file)
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	public class ActiveDocument : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ActiveDocument);

		}
	}


	///<summary>
	///drawing file)
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("pActiveDoc", typeof(System.Object))]
	public class Set_ActiveDocument : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveDocument = inputs[1];
			return null;
		}
	}


	///<summary>
	///Gets the name of the application or document, including the path
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	public class FullName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FullName);

		}
	}


	///<summary>
	///Height of the attribute, shape, text, or view toolbar or the main application window
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	public class Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Height);

		}
	}


	///<summary>
	///Height of the attribute, shape, text, or view toolbar or the main application window
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("Height", typeof(System.Int32))]
	public class Set_Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Height = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the left edge of the application window
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	public class WindowLeft : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WindowLeft);

		}
	}


	///<summary>
	///Specifies the left edge of the application window
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("left", typeof(System.Int32))]
	public class Set_WindowLeft : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WindowLeft = inputs[1];
			return null;
		}
	}


	///<summary>
	///Gets the path of the document, application, or external reference
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	public class Path : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Path);

		}
	}


	///<summary>
	///Gets the locale ID of the current session
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	public class LocaleId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LocaleId);

		}
	}


	///<summary>
	///Specifies the top edge of the application window
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	public class WindowTop : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WindowTop);

		}
	}


	///<summary>
	///Specifies the top edge of the application window
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("top", typeof(System.Int32))]
	public class Set_WindowTop : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WindowTop = inputs[1];
			return null;
		}
	}


	///<summary>
	///Gets the version of the application you are using
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	public class Version : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Version);

		}
	}


	///<summary>
	///Specifies the width of the text boundary, view, image, toolbar, or main application window
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	public class Width : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Width);

		}
	}


	///<summary>
	///Specifies the width of the text boundary, view, image, toolbar, or main application window
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("Width", typeof(System.Int32))]
	public class Set_Width : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Width = inputs[1];
			return null;
		}
	}


	///<summary>
	///Gets the current active status of the viewport
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("VportObj", typeof(System.Object))]
	public class StatusId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StatusId(inputs[1]));

		}
	}


	///<summary>
	///Updates the object to the drawing screen
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	public class Update : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Update();
			return null;
		}
	}


	///<summary>
	///Closes the drawing file and exits the application
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	public class Quit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Quit();
			return null;
		}
	}


	///<summary>
	///Returns the documents collection.
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	public class Documents : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Documents);

		}
	}


	///<summary>
	///Specifies the state of the application or document window
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	public class WindowState : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WindowState);

		}
	}


	///<summary>
	///Specifies the state of the application or document window
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("eWinState", typeof(System.Object))]
	public class Set_WindowState : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WindowState = inputs[1];
			return null;
		}
	}


	///<summary>
	///Zooms the current viewport to the drawing extents
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	public class ZoomExtents : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ZoomExtents();
			return null;
		}
	}


	///<summary>
	///Zooms the current viewport to display the entire drawing
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	public class ZoomAll : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ZoomAll();
			return null;
		}
	}


	///<summary>
	///Zooms the current viewport to a specified center point and magnification
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("Center", typeof(System.Object))]
	[NodeInput("Magnify", typeof(System.Double))]
	public class ZoomCenter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ZoomCenter(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Zooms the current viewport to given scale factor
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("scale", typeof(System.Double))]
	[NodeInput("ScaleType", typeof(System.Object))]
	public class ZoomScaled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ZoomScaled(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Zooms the current viewport to the area specified by two opposite corners of a rectangle
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("LowerLeft", typeof(System.Object))]
	[NodeInput("UpperRight", typeof(System.Object))]
	public class ZoomWindow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ZoomWindow(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Zooms the current viewport to a window defined by points picked on the screen
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	public class ZoomPickWindow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ZoomPickWindow();
			return null;
		}
	}


	///<summary>
	///Retrieves an AcadState object.
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	public class GetState : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetState);

		}
	}


	///<summary>
	///Zooms the current viewport to its previous extents
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	public class ZoomPrevious : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ZoomPrevious();
			return null;
		}
	}


	///<summary>
	///Gets the window handle of the application window frame
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	public class HWND : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HWND);

		}
	}


	///<summary>
	///Gets the Utility object for the application
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	public class Utility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Utility);

		}
	}


	///<summary>
	///Sends a command string from a VB or VBA application to the document for processing
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("Command", typeof(System.String))]
	public class SendCommand : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SendCommand(inputs[1]);
			return null;
		}
	}


	///<summary>
	///Returns sevices collection
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	public class Services : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Services);

		}
	}


	///<summary>
	///Returns the AllUsersAppData
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	public class AllUsersAppData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AllUsersAppData);

		}
	}


	///<summary>
	///Returns the CurUserAppData
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	public class CurUserAppData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CurUserAppData);

		}
	}


	///<summary>
	///Returns the root Profile section
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	public class Profile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Profile);

		}
	}


	///<summary>
	///Invokes help with topic
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("topic", typeof(System.String))]
	public class Help : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Help(inputs[1]);
			return null;
		}
	}


	///<summary>
	///Creates tepmorary param structure
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	public class NewParam : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NewParam);

		}
	}


	///<summary>
	///Loads the specified application
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("Path", typeof(System.String))]
	public class LoadModule : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LoadModule(inputs[1]);
			return null;
		}
	}


	///<summary>
	///Unloads the specified application
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("Name", typeof(System.String))]
	public class UnloadModule : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UnloadModule(inputs[1]);
			return null;
		}
	}


	///<summary>
	///Gets the currently loaded applications
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	public class ListModules : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ListModules);

		}
	}


	///<summary>
	///Loads the specified NRX application
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("Path", typeof(System.String))]
	public class LoadArx : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LoadArx(inputs[1]);
			return null;
		}
	}


	///<summary>
	///Unloads the specified NRX application
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("Name", typeof(System.String))]
	public class UnloadArx : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UnloadArx(inputs[1]);
			return null;
		}
	}


	///<summary>
	///Gets the currently loaded NRX applications
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	public class ListArx : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ListArx);

		}
	}


	///<summary>
	///drawing file)
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("pActiveDoc", typeof(System.Object))]
	public class Put_ActiveDocument : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveDocument = inputs[1];
			return null;
		}
	}


	///<summary>
	///Returns the Preferences object.
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	public class Preferences : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Preferences);

		}
	}


	///<summary>
	///Returns the current MenuGroups collection.
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	public class MenuGroups : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MenuGroups);

		}
	}


	///<summary>
	///Returns the current MenuBar object.
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	public class MenuBar : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MenuBar);

		}
	}


	///<summary>
	///Runs a VBA macro from the Application object
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("MacroPath", typeof(System.String))]
	public class RunMacro : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RunMacro(inputs[1]);
			return null;
		}
	}


	///<summary>
	///Apply profile changes
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	public class ApplyProfile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ApplyProfile();
			return null;
		}
	}


	///<summary>
	///Loads an object using its program ID.
	///</summary>
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("ProgID", typeof(System.String))]
	public class GetInterfaceObject : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetInterfaceObject(inputs[1]));

		}
	}
}
