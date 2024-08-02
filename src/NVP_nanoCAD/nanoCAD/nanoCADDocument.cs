using NVP.API.Nodes;

namespace nanoCAD.nanoCADDocument 
{
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADDocument_Constructor : INode 
	{
		public nanoCAD.InanoCADDocument _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.InanoCADDocument;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADDocument_ConstructorCast : INode 
	{
		public nanoCAD.InanoCADDocument _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.InanoCADDocument;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///Gets the Plot object for the document
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	public class Plot : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Plot);

		}
	}


	///<summary>
	///Specifies the active layer
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	public class ActiveLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ActiveLayer);

		}
	}


	///<summary>
	///Specifies the active layer
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pActLayer", typeof(System.Object))]
	public class Set_ActiveLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveLayer = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the active linetype for the drawing
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	public class ActiveLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ActiveLinetype);

		}
	}


	///<summary>
	///Specifies the active linetype for the drawing
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pActLinetype", typeof(System.Object))]
	public class Set_ActiveLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveLinetype = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the active dimension style
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	public class ActiveDimStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ActiveDimStyle);

		}
	}


	///<summary>
	///Specifies the active dimension style
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pActDimStyle", typeof(System.Object))]
	public class Set_ActiveDimStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveDimStyle = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the active text style for the drawing
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	public class ActiveTextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ActiveTextStyle);

		}
	}


	///<summary>
	///Specifies the active text style for the drawing
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pActTextStyle", typeof(System.Object))]
	public class Set_ActiveTextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveTextStyle = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the active UCS for the drawing
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	public class ActiveUCS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ActiveUCS);

		}
	}


	///<summary>
	///Specifies the active UCS for the drawing
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pActUCS", typeof(System.Object))]
	public class Set_ActiveUCS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveUCS = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the active viewport for the drawing
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	public class ActiveViewport : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ActiveViewport);

		}
	}


	///<summary>
	///Specifies the active viewport for the drawing
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pActView", typeof(System.Object))]
	public class Set_ActiveViewport : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveViewport = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the active paper space viewport for the drawing
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	public class ActivePViewport : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ActivePViewport);

		}
	}


	///<summary>
	///Specifies the active paper space viewport for the drawing
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pActView", typeof(System.Object))]
	public class Set_ActivePViewport : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActivePViewport = inputs[1];
			return null;
		}
	}


	///<summary>
	///Toggles the active space between paper space and model space
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	public class ActiveSpace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ActiveSpace);

		}
	}


	///<summary>
	///Toggles the active space between paper space and model space
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("ActSpace", typeof(System.Object))]
	public class Set_ActiveSpace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveSpace = inputs[1];
			return null;
		}
	}


	///<summary>
	///Gets the SelectionSets collection for the document
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	public class SelectionSets : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SelectionSets);

		}
	}


	///<summary>
	///Gets the active selection set for the drawing
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	public class ActiveSelectionSet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ActiveSelectionSet);

		}
	}


	///<summary>
	///Gets the name of the application or document, including the path
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	public class FullName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FullName);

		}
	}


	///<summary>
	///Specifies the name of the object
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	///<summary>
	///Gets the path of the document, application, or external reference
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	public class Path : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Path);

		}
	}


	///<summary>
	///Specifies the setting of the object snap mode
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	public class ObjectSnapMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ObjectSnapMode);

		}
	}


	///<summary>
	///Specifies the setting of the object snap mode
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("fSnapMode", typeof(System.Object))]
	public class Set_ObjectSnapMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ObjectSnapMode = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies if the document is read-only or read-write
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	public class ReadOnly : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ReadOnly);

		}
	}


	///<summary>
	///Specifies if the document has any unsaved changes
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	public class Saved : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Saved);

		}
	}


	///<summary>
	///Allows editing of the model from floating paper space viewports
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	public class MSpace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MSpace);

		}
	}


	///<summary>
	///Allows editing of the model from floating paper space viewports
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("Mode", typeof(System.Object))]
	public class Set_MSpace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MSpace = inputs[1];
			return null;
		}
	}


	///<summary>
	///Gets the Utility object for the document
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	public class Utility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Utility);

		}
	}


	///<summary>
	///DWG) and makes it the active document
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("FullName", typeof(System.String))]
	[NodeInput("Password", typeof(System.Object))]
	public class Open : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Open(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Evaluates the integrity of the drawing
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("FixErr", typeof(System.Object))]
	public class AuditInfo : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AuditInfo(inputs[1]);
			return null;
		}
	}


	///<summary>
	///Imports a drawing file in SAT, EPS, DXF, or WMF format
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("FileName", typeof(System.String))]
	[NodeInput("InsertionPoint", typeof(System.Object))]
	[NodeInput("ScaleFactor", typeof(System.Double))]
	public class Import : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Import(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Exports the drawing to a WMF, SAT, EPS, DXF, or BMP format
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("FileName", typeof(System.String))]
	[NodeInput("Extension", typeof(System.String))]
	[NodeInput("SelectionSet", typeof(System.Object))]
	public class Export : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Export(inputs[1],inputs[2],inputs[3]);
			return null;
		}
	}


	///<summary>
	///Creates a new document in SDI mode
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("TemplateFileName", typeof(System.String))]
	public class New : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.New(inputs[1]));

		}
	}


	///<summary>
	///Saves the document or menu group
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	public class Save : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Save();
			return null;
		}
	}


	///<summary>
	///Saves the document or menu group to a specified file
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("FullFileName", typeof(System.String))]
	[NodeInput("SaveAsType", typeof(System.Object))]
	[NodeInput("vSecurityParams", typeof(System.Object))]
	public class SaveAs : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SaveAs(inputs[1],inputs[2],inputs[3]);
			return null;
		}
	}


	///<summary>
	///Writes out the given selection set as a new drawing file
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("FileName", typeof(System.String))]
	[NodeInput("SelectionSet", typeof(System.Object))]
	public class Wblock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Wblock(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Removes unused named references such as unused blocks or layers from the document
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	public class PurgeAll : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PurgeAll();
			return null;
		}
	}


	///<summary>
	///Gets the current setting of a system variable
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("Name", typeof(System.String))]
	public class GetVariable : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetVariable(inputs[1]));

		}
	}


	///<summary>
	///Sets the value of a system variable
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("Name", typeof(System.String))]
	[NodeInput("Value", typeof(System.Object))]
	public class SetVariable : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetVariable(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Regenerates the entire drawing and recomputes the screen coordinates and view resolution for all objects
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("WhichViewports", typeof(System.Object))]
	public class Regen : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Regen(inputs[1]);
			return null;
		}
	}


	///<summary>
	///Gets the pickfirst selection set
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	public class PickfirstSelectionSet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PickfirstSelectionSet);

		}
	}


	///<summary>
	///Determines if the document is the active document for the session
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	public class Active : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Active);

		}
	}


	///<summary>
	///Makes the specified drawing active
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	public class Activate : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Activate();
			return null;
		}
	}


	///<summary>
	///Closes the specified drawing, or all open drawings
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("SaveChanges", typeof(System.Object))]
	[NodeInput("FileName", typeof(System.Object))]
	public class Close : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Close(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Specifies the state of the application or document window
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pWinState", typeof(System.Object))]
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
	///Specifies the state of the application or document window
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	public class WindowState : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WindowState);

		}
	}


	///<summary>
	///Specifies the width of the text boundary, view, image, toolbar, or main application window
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pWidth", typeof(System.Int32))]
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
	///Specifies the width of the text boundary, view, image, toolbar, or main application window
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	public class Width : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Width);

		}
	}


	///<summary>
	///Height of the attribute, shape, text, or view toolbar or the main application window
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pHeight", typeof(System.Int32))]
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
	///Height of the attribute, shape, text, or view toolbar or the main application window
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	public class Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Height);

		}
	}


	///<summary>
	///Specifies the active layout
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pLayout", typeof(System.Object))]
	public class Set_ActiveLayout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveLayout = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the active layout
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	public class ActiveLayout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ActiveLayout);

		}
	}


	///<summary>
	///Sends a command string from a VB or VBA application to the document for processing
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
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
	///Gets the window handle of the document window frame
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	public class HWND : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HWND);

		}
	}


	///<summary>
	///Gets the title of the document window
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	public class WindowTitle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WindowTitle);

		}
	}


	///<summary>
	///Gets the title of the document window
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	public class Set_WindowTitle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WindowTitle[inputs[1]] = inputs[2];
			return null;
		}
	}


	///<summary>
	///Gets the Application object
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	public class Application : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Application);

		}
	}


	///<summary>
	///Gets the database in which the object belongs
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	public class Database : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Database);

		}
	}


	///<summary>
	///Marks the beginning of a block of operations
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	public class StartUndoMark : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StartUndoMark();
			return null;
		}
	}


	///<summary>
	///Marks the end of a block of operations
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	public class EndUndoMark : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EndUndoMark();
			return null;
		}
	}


	///<summary>
	///add custom object to block
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("rxClass", typeof(System.String))]
	[NodeInput("blk", typeof(System.Object))]
	public class AddCustomObjectToBlock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddCustomObjectToBlock(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Specifies the active text style for the drawing
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pActTextStyle", typeof(System.Object))]
	public class Put_ActiveTextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveTextStyle = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the active layer
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pActLayer", typeof(System.Object))]
	public class Put_ActiveLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveLayer = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the active linetype for the drawing
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pActLinetype", typeof(System.Object))]
	public class Put_ActiveLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveLinetype = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the active dimension style
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pActDimStyle", typeof(System.Object))]
	public class Put_ActiveDimStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveDimStyle = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the active UCS for the drawing
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pActUCS", typeof(System.Object))]
	public class Put_ActiveUCS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveUCS = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the active viewport for the drawing
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pActView", typeof(System.Object))]
	public class Put_ActiveViewport : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveViewport = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the active paper space viewport for the drawing
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pActView", typeof(System.Object))]
	public class Put_ActivePViewport : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActivePViewport = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the active layout
	///</summary>
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pLayout", typeof(System.Object))]
	public class Put_ActiveLayout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveLayout = inputs[1];
			return null;
		}
	}
}
