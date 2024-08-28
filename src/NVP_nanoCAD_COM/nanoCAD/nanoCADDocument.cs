using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///A drawing
///</summary>
namespace NVP_nanoCAD_COM._nanoCAD.nanoCADDocument 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
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

	[NVP_Manifest(
		ViewType = "Modifier")]
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


	[NVP_Manifest(
		Text = "Gets the Plot object for the document", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Gets the Plot object for the document
	///</summary>
	public class Plot : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Plot);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the active layer", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Specifies the active layer
	///</summary>
	public class ActiveLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ActiveLayer);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the active layer", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pActLayer", typeof(System.Object))]

	///<summary>
	///Specifies the active layer
	///</summary>
	public class Set_ActiveLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveLayer = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the active linetype for the drawing", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Specifies the active linetype for the drawing
	///</summary>
	public class ActiveLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ActiveLinetype);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the active linetype for the drawing", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pActLinetype", typeof(System.Object))]

	///<summary>
	///Specifies the active linetype for the drawing
	///</summary>
	public class Set_ActiveLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveLinetype = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the active dimension style", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Specifies the active dimension style
	///</summary>
	public class ActiveDimStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ActiveDimStyle);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the active dimension style", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pActDimStyle", typeof(System.Object))]

	///<summary>
	///Specifies the active dimension style
	///</summary>
	public class Set_ActiveDimStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveDimStyle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the active text style for the drawing", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Specifies the active text style for the drawing
	///</summary>
	public class ActiveTextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ActiveTextStyle);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the active text style for the drawing", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pActTextStyle", typeof(System.Object))]

	///<summary>
	///Specifies the active text style for the drawing
	///</summary>
	public class Set_ActiveTextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveTextStyle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the active UCS for the drawing", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Specifies the active UCS for the drawing
	///</summary>
	public class ActiveUCS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ActiveUCS);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the active UCS for the drawing", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pActUCS", typeof(System.Object))]

	///<summary>
	///Specifies the active UCS for the drawing
	///</summary>
	public class Set_ActiveUCS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveUCS = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the active viewport for the drawing", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Specifies the active viewport for the drawing
	///</summary>
	public class ActiveViewport : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ActiveViewport);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the active viewport for the drawing", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pActView", typeof(System.Object))]

	///<summary>
	///Specifies the active viewport for the drawing
	///</summary>
	public class Set_ActiveViewport : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveViewport = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the active paper space viewport for the drawing", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Specifies the active paper space viewport for the drawing
	///</summary>
	public class ActivePViewport : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ActivePViewport);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the active paper space viewport for the drawing", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pActView", typeof(System.Object))]

	///<summary>
	///Specifies the active paper space viewport for the drawing
	///</summary>
	public class Set_ActivePViewport : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActivePViewport = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Toggles the active space between paper space and model space", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Toggles the active space between paper space and model space
	///</summary>
	public class ActiveSpace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ActiveSpace);

		}
	}


	[NVP_Manifest(
		Text = "Toggles the active space between paper space and model space", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("nanoCAD.AcActiveSpace", typeof(System.Object))]

	///<summary>
	///Toggles the active space between paper space and model space
	///</summary>
	public class Set_ActiveSpace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveSpace = ((nanoCAD.AcActiveSpace)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Gets the SelectionSets collection for the document", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Gets the SelectionSets collection for the document
	///</summary>
	public class SelectionSets : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SelectionSets);

		}
	}


	[NVP_Manifest(
		Text = "Gets the active selection set for the drawing", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Gets the active selection set for the drawing
	///</summary>
	public class ActiveSelectionSet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ActiveSelectionSet);

		}
	}


	[NVP_Manifest(
		Text = "Gets the name of the application or document, including the path", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

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
		Text = "Specifies the name of the object", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

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
		Text = "Gets the path of the document, application, or external reference", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

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
		Text = "Specifies the setting of the object snap mode", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Specifies the setting of the object snap mode
	///</summary>
	public class ObjectSnapMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ObjectSnapMode);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the setting of the object snap mode", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("fSnapMode", typeof(System.Object))]

	///<summary>
	///Specifies the setting of the object snap mode
	///</summary>
	public class Set_ObjectSnapMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ObjectSnapMode = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies if the document is read-only or read-write", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Specifies if the document is read-only or read-write
	///</summary>
	public class ReadOnly : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ReadOnly);

		}
	}


	[NVP_Manifest(
		Text = "Specifies if the document has any unsaved changes", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Specifies if the document has any unsaved changes
	///</summary>
	public class Saved : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Saved);

		}
	}


	[NVP_Manifest(
		Text = "Allows editing of the model from floating paper space viewports", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Allows editing of the model from floating paper space viewports
	///</summary>
	public class MSpace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MSpace);

		}
	}


	[NVP_Manifest(
		Text = "Allows editing of the model from floating paper space viewports", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("Mode", typeof(System.Object))]

	///<summary>
	///Allows editing of the model from floating paper space viewports
	///</summary>
	public class Set_MSpace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MSpace = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Gets the Utility object for the document", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Gets the Utility object for the document
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
		Text = "DWG) and makes it the active document", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("FullName", typeof(System.String))]
	[NodeInput("Password", typeof(System.Object))]

	///<summary>
	///DWG) and makes it the active document
	///</summary>
	public class Open : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Open(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Text = "Evaluates the integrity of the drawing", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("FixErr", typeof(System.Object))]

	///<summary>
	///Evaluates the integrity of the drawing
	///</summary>
	public class AuditInfo : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AuditInfo(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Imports a drawing file in SAT, EPS, DXF, or WMF format", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("FileName", typeof(System.String))]
	[NodeInput("InsertionPoint", typeof(System.Object))]
	[NodeInput("ScaleFactor", typeof(System.Double))]

	///<summary>
	///Imports a drawing file in SAT, EPS, DXF, or WMF format
	///</summary>
	public class Import : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Import(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Text = "Exports the drawing to a WMF, SAT, EPS, DXF, or BMP format", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("FileName", typeof(System.String))]
	[NodeInput("Extension", typeof(System.String))]
	[NodeInput("SelectionSet", typeof(System.Object))]

	///<summary>
	///Exports the drawing to a WMF, SAT, EPS, DXF, or BMP format
	///</summary>
	public class Export : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Export(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Creates a new document in SDI mode", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("TemplateFileName", typeof(System.String))]

	///<summary>
	///Creates a new document in SDI mode
	///</summary>
	public class New : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.New(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Saves the document or menu group", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Saves the document or menu group
	///</summary>
	public class Save : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Save();
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Saves the document or menu group to a specified file", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("FullFileName", typeof(System.String))]
	[NodeInput("SaveAsType", typeof(System.Object))]
	[NodeInput("vSecurityParams", typeof(System.Object))]

	///<summary>
	///Saves the document or menu group to a specified file
	///</summary>
	public class SaveAs : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SaveAs(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Writes out the given selection set as a new drawing file", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("FileName", typeof(System.String))]
	[NodeInput("SelectionSet", typeof(System.Object))]

	///<summary>
	///Writes out the given selection set as a new drawing file
	///</summary>
	public class Wblock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Wblock(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Removes unused named references such as unused blocks or layers from the document", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Removes unused named references such as unused blocks or layers from the document
	///</summary>
	public class PurgeAll : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PurgeAll();
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Gets the current setting of a system variable", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Gets the current setting of a system variable
	///</summary>
	public class GetVariable : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetVariable(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Sets the value of a system variable", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("Name", typeof(System.String))]
	[NodeInput("Value", typeof(System.Object))]

	///<summary>
	///Sets the value of a system variable
	///</summary>
	public class SetVariable : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetVariable(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Regenerates the entire drawing and recomputes the screen coordinates and view resolution for all objects", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("nanoCAD.AcRegenType", typeof(System.Object))]

	///<summary>
	///Regenerates the entire drawing and recomputes the screen coordinates and view resolution for all objects
	///</summary>
	public class Regen : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Regen(((nanoCAD.AcRegenType)inputs[1].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Gets the pickfirst selection set", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Gets the pickfirst selection set
	///</summary>
	public class PickfirstSelectionSet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PickfirstSelectionSet);

		}
	}


	[NVP_Manifest(
		Text = "Determines if the document is the active document for the session", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Determines if the document is the active document for the session
	///</summary>
	public class Active : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Active);

		}
	}


	[NVP_Manifest(
		Text = "Makes the specified drawing active", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Makes the specified drawing active
	///</summary>
	public class Activate : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Activate();
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Closes the specified drawing, or all open drawings", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("SaveChanges", typeof(System.Object))]
	[NodeInput("FileName", typeof(System.Object))]

	///<summary>
	///Closes the specified drawing, or all open drawings
	///</summary>
	public class Close : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Close(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the state of the application or document window", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
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
		Text = "Specifies the state of the application or document window", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

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
		Text = "Specifies the width of the text boundary, view, image, toolbar, or main application window", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pWidth", typeof(System.Int32))]

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
		Text = "Specifies the width of the text boundary, view, image, toolbar, or main application window", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

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
		Text = "Height of the attribute, shape, text, or view toolbar or the main application window", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pHeight", typeof(System.Int32))]

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
		Text = "Height of the attribute, shape, text, or view toolbar or the main application window", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

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
		Text = "Specifies the active layout", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pLayout", typeof(System.Object))]

	///<summary>
	///Specifies the active layout
	///</summary>
	public class Set_ActiveLayout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveLayout = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the active layout", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Specifies the active layout
	///</summary>
	public class ActiveLayout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ActiveLayout);

		}
	}


	[NVP_Manifest(
		Text = "Sends a command string from a VB or VBA application to the document for processing", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
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
		Text = "Gets the window handle of the document window frame", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Gets the window handle of the document window frame
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
		Text = "Gets the title of the document window", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Gets the title of the document window
	///</summary>
	public class WindowTitle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WindowTitle);

		}
	}


	[NVP_Manifest(
		Text = "Gets the title of the document window", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Gets the title of the document window
	///</summary>
	public class Set_WindowTitle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WindowTitle[inputs[1]] = inputs[2];
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Gets the Application object", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

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
		Text = "Gets the database in which the object belongs", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Gets the database in which the object belongs
	///</summary>
	public class Database : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Database);

		}
	}


	[NVP_Manifest(
		Text = "Marks the beginning of a block of operations", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Marks the beginning of a block of operations
	///</summary>
	public class StartUndoMark : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StartUndoMark();
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Marks the end of a block of operations", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]

	///<summary>
	///Marks the end of a block of operations
	///</summary>
	public class EndUndoMark : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EndUndoMark();
			return null;
		}
	}


	[NVP_Manifest(
		Text = "add custom object to block", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("rxClass", typeof(System.String))]
	[NodeInput("blk", typeof(System.Object))]

	///<summary>
	///add custom object to block
	///</summary>
	public class AddCustomObjectToBlock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddCustomObjectToBlock(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Text = "Specifies the active text style for the drawing", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pActTextStyle", typeof(System.Object))]

	///<summary>
	///Specifies the active text style for the drawing
	///</summary>
	public class Put_ActiveTextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveTextStyle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the active layer", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pActLayer", typeof(System.Object))]

	///<summary>
	///Specifies the active layer
	///</summary>
	public class Put_ActiveLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveLayer = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the active linetype for the drawing", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pActLinetype", typeof(System.Object))]

	///<summary>
	///Specifies the active linetype for the drawing
	///</summary>
	public class Put_ActiveLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveLinetype = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the active dimension style", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pActDimStyle", typeof(System.Object))]

	///<summary>
	///Specifies the active dimension style
	///</summary>
	public class Put_ActiveDimStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveDimStyle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the active UCS for the drawing", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pActUCS", typeof(System.Object))]

	///<summary>
	///Specifies the active UCS for the drawing
	///</summary>
	public class Put_ActiveUCS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveUCS = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the active viewport for the drawing", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pActView", typeof(System.Object))]

	///<summary>
	///Specifies the active viewport for the drawing
	///</summary>
	public class Put_ActiveViewport : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveViewport = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the active paper space viewport for the drawing", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pActView", typeof(System.Object))]

	///<summary>
	///Specifies the active paper space viewport for the drawing
	///</summary>
	public class Put_ActivePViewport : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActivePViewport = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the active layout", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocument", typeof(object))]
	[NodeInput("pLayout", typeof(System.Object))]

	///<summary>
	///Specifies the active layout
	///</summary>
	public class Put_ActiveLayout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveLayout = inputs[1].Value;
			return null;
		}
	}
}
