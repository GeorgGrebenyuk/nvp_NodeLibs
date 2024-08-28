using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Application interface
///</summary>
namespace NVP_nanoCAD_COM._nanoCAD.nanoCADApplication 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
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

	[NVP_Manifest(
		ViewType = "Modifier")]
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


	[NVP_Manifest(
		Text = "Specifies the visibility of an object or the application", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

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
		Text = "Specifies the visibility of an object or the application", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("Visible", typeof(System.Object))]

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
		Text = "Specifies the name of the object", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

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
		Text = "Sets the text that the user sees displayed for the application or a menu item", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("bstrCaption", typeof(System.String))]

	///<summary>
	///Sets the text that the user sees displayed for the application or a menu item
	///</summary>
	public class Set_Caption : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Caption = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Sets the text that the user sees displayed for the application or a menu item", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Sets the text that the user sees displayed for the application or a menu item
	///</summary>
	public class Caption : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Caption);

		}
	}


	[NVP_Manifest(
		Text = "Gets the Application object", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

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
		Text = "drawing file)", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///drawing file)
	///</summary>
	public class ActiveDocument : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ActiveDocument);

		}
	}


	[NVP_Manifest(
		Text = "drawing file)", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("pActiveDoc", typeof(System.Object))]

	///<summary>
	///drawing file)
	///</summary>
	public class Set_ActiveDocument : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveDocument = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Gets the name of the application or document, including the path", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Gets the name of the application or document, including the path
	///</summary>
	public class FullName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FullName);

		}
	}


	[NVP_Manifest(
		Text = "Height of the attribute, shape, text, or view toolbar or the main application window", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

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
		Text = "Height of the attribute, shape, text, or view toolbar or the main application window", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("Height", typeof(System.Int32))]

	///<summary>
	///Height of the attribute, shape, text, or view toolbar or the main application window
	///</summary>
	public class Set_Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Height = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the left edge of the application window", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Specifies the left edge of the application window
	///</summary>
	public class WindowLeft : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WindowLeft);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the left edge of the application window", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("left", typeof(System.Int32))]

	///<summary>
	///Specifies the left edge of the application window
	///</summary>
	public class Set_WindowLeft : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WindowLeft = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Gets the path of the document, application, or external reference", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Gets the path of the document, application, or external reference
	///</summary>
	public class Path : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Path);

		}
	}


	[NVP_Manifest(
		Text = "Gets the locale ID of the current session", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Gets the locale ID of the current session
	///</summary>
	public class LocaleId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LocaleId);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the top edge of the application window", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Specifies the top edge of the application window
	///</summary>
	public class WindowTop : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WindowTop);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the top edge of the application window", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("top", typeof(System.Int32))]

	///<summary>
	///Specifies the top edge of the application window
	///</summary>
	public class Set_WindowTop : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WindowTop = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Gets the version of the application you are using", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Gets the version of the application you are using
	///</summary>
	public class Version : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Version);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the width of the text boundary, view, image, toolbar, or main application window", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

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
		Text = "Specifies the width of the text boundary, view, image, toolbar, or main application window", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("Width", typeof(System.Int32))]

	///<summary>
	///Specifies the width of the text boundary, view, image, toolbar, or main application window
	///</summary>
	public class Set_Width : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Width = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Gets the current active status of the viewport", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("VportObj", typeof(System.Object))]

	///<summary>
	///Gets the current active status of the viewport
	///</summary>
	public class StatusId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StatusId(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Updates the object to the drawing screen", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Updates the object to the drawing screen
	///</summary>
	public class Update : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Update();
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Closes the drawing file and exits the application", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Closes the drawing file and exits the application
	///</summary>
	public class Quit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Quit();
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the documents collection.", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Returns the documents collection.
	///</summary>
	public class Documents : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Documents);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the state of the application or document window", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Specifies the state of the application or document window
	///</summary>
	public class WindowState : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WindowState);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the state of the application or document window", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("nanoCAD.AcWindowState", typeof(System.Object))]

	///<summary>
	///Specifies the state of the application or document window
	///</summary>
	public class Set_WindowState : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WindowState = ((nanoCAD.AcWindowState)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Zooms the current viewport to the drawing extents", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Zooms the current viewport to the drawing extents
	///</summary>
	public class ZoomExtents : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ZoomExtents();
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Zooms the current viewport to display the entire drawing", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Zooms the current viewport to display the entire drawing
	///</summary>
	public class ZoomAll : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ZoomAll();
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Zooms the current viewport to a specified center point and magnification", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("Center", typeof(System.Object))]
	[NodeInput("Magnify", typeof(System.Double))]

	///<summary>
	///Zooms the current viewport to a specified center point and magnification
	///</summary>
	public class ZoomCenter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ZoomCenter(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Zooms the current viewport to given scale factor", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("scale", typeof(System.Double))]
	[NodeInput("nanoCAD.AcZoomScaleType", typeof(System.Object))]

	///<summary>
	///Zooms the current viewport to given scale factor
	///</summary>
	public class ZoomScaled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ZoomScaled(inputs[1].Value,((nanoCAD.AcZoomScaleType)inputs[2].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Zooms the current viewport to the area specified by two opposite corners of a rectangle", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("LowerLeft", typeof(System.Object))]
	[NodeInput("UpperRight", typeof(System.Object))]

	///<summary>
	///Zooms the current viewport to the area specified by two opposite corners of a rectangle
	///</summary>
	public class ZoomWindow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ZoomWindow(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Zooms the current viewport to a window defined by points picked on the screen", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Zooms the current viewport to a window defined by points picked on the screen
	///</summary>
	public class ZoomPickWindow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ZoomPickWindow();
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Retrieves an AcadState object.", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Retrieves an AcadState object.
	///</summary>
	public class GetState : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetState);

		}
	}


	[NVP_Manifest(
		Text = "Zooms the current viewport to its previous extents", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Zooms the current viewport to its previous extents
	///</summary>
	public class ZoomPrevious : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ZoomPrevious();
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Gets the window handle of the application window frame", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Gets the window handle of the application window frame
	///</summary>
	public class HWND : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HWND);

		}
	}


	[NVP_Manifest(
		Text = "Gets the Utility object for the application", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Gets the Utility object for the application
	///</summary>
	public class Utility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Utility);

		}
	}


	[NVP_Manifest(
		Text = "Sends a command string from a VB or VBA application to the document for processing", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("Command", typeof(System.String))]

	///<summary>
	///Sends a command string from a VB or VBA application to the document for processing
	///</summary>
	public class SendCommand : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SendCommand(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns sevices collection", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Returns sevices collection
	///</summary>
	public class Services : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Services);

		}
	}


	[NVP_Manifest(
		Text = "Returns the AllUsersAppData", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Returns the AllUsersAppData
	///</summary>
	public class AllUsersAppData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AllUsersAppData);

		}
	}


	[NVP_Manifest(
		Text = "Returns the CurUserAppData", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Returns the CurUserAppData
	///</summary>
	public class CurUserAppData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CurUserAppData);

		}
	}


	[NVP_Manifest(
		Text = "Returns the root Profile section", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Returns the root Profile section
	///</summary>
	public class Profile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Profile);

		}
	}


	[NVP_Manifest(
		Text = "Invokes help with topic", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("topic", typeof(System.String))]

	///<summary>
	///Invokes help with topic
	///</summary>
	public class Help : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Help(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Creates tepmorary param structure", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Creates tepmorary param structure
	///</summary>
	public class NewParam : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NewParam);

		}
	}


	[NVP_Manifest(
		Text = "Loads the specified application", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("Path", typeof(System.String))]

	///<summary>
	///Loads the specified application
	///</summary>
	public class LoadModule : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LoadModule(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Unloads the specified application", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Unloads the specified application
	///</summary>
	public class UnloadModule : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UnloadModule(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Gets the currently loaded applications", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Gets the currently loaded applications
	///</summary>
	public class ListModules : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ListModules);

		}
	}


	[NVP_Manifest(
		Text = "Loads the specified NRX application", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("Path", typeof(System.String))]

	///<summary>
	///Loads the specified NRX application
	///</summary>
	public class LoadArx : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LoadArx(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Unloads the specified NRX application", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Unloads the specified NRX application
	///</summary>
	public class UnloadArx : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UnloadArx(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Gets the currently loaded NRX applications", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Gets the currently loaded NRX applications
	///</summary>
	public class ListArx : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ListArx);

		}
	}


	[NVP_Manifest(
		Text = "drawing file)", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("pActiveDoc", typeof(System.Object))]

	///<summary>
	///drawing file)
	///</summary>
	public class Put_ActiveDocument : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveDocument = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the Preferences object.", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Returns the Preferences object.
	///</summary>
	public class Preferences : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Preferences);

		}
	}


	[NVP_Manifest(
		Text = "Returns the current MenuGroups collection.", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Returns the current MenuGroups collection.
	///</summary>
	public class MenuGroups : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MenuGroups);

		}
	}


	[NVP_Manifest(
		Text = "Returns the current MenuBar object.", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Returns the current MenuBar object.
	///</summary>
	public class MenuBar : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MenuBar);

		}
	}


	[NVP_Manifest(
		Text = "Runs a VBA macro from the Application object", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("MacroPath", typeof(System.String))]

	///<summary>
	///Runs a VBA macro from the Application object
	///</summary>
	public class RunMacro : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RunMacro(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Apply profile changes", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADApplication", typeof(object))]

	///<summary>
	///Apply profile changes
	///</summary>
	public class ApplyProfile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ApplyProfile();
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Loads an object using its program ID.", 
		ViewType = "Data")]
	[NodeInput("nanoCADApplication", typeof(object))]
	[NodeInput("ProgID", typeof(System.String))]

	///<summary>
	///Loads an object using its program ID.
	///</summary>
	public class GetInterfaceObject : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetInterfaceObject(inputs[1].Value));

		}
	}
}
