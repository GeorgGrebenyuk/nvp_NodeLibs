using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///A series of methods provided for utility purposes
///</summary>
namespace nanoCAD.nanoCADUtility 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADUtility_Constructor : INode 
	{
		public nanoCAD.InanoCADUtility _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.InanoCADUtility;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADUtility_ConstructorCast : INode 
	{
		public nanoCAD.InanoCADUtility _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.InanoCADUtility;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "double) value", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Angle", typeof(System.String))]
	[NodeInput("Unit", typeof(System.Object))]

	///<summary>
	///double) value
	///</summary>
	public class AngleToReal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AngleToReal(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Text = "double) value to a string", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Angle", typeof(System.Double))]
	[NodeInput("Unit", typeof(System.Object))]
	[NodeInput("precision", typeof(System.Int32))]

	///<summary>
	///double) value to a string
	///</summary>
	public class AngleToString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AngleToString(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Text = "double) value", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Distance", typeof(System.String))]
	[NodeInput("nanoCAD.AcUnits", typeof(System.Object))]

	///<summary>
	///double) value
	///</summary>
	public class DistanceToReal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DistanceToReal(inputs[1].Value,((nanoCAD.AcUnits)inputs[2].Value)));

		}
	}


	[NVP_Manifest(
		Text = "double) value to a string", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Value", typeof(System.Double))]
	[NodeInput("nanoCAD.AcUnits", typeof(System.Object))]
	[NodeInput("precision", typeof(System.Int32))]

	///<summary>
	///double) value to a string
	///</summary>
	public class RealToString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RealToString(inputs[1].Value,((nanoCAD.AcUnits)inputs[2].Value),inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Text = "Translates a point from one coordinate system to another coordinate system", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Point", typeof(System.Object))]
	[NodeInput("nanoCAD.AcCoordinateSystem", typeof(System.Object))]
	[NodeInput("nanoCAD.AcCoordinateSystem", typeof(System.Object))]
	[NodeInput("Displacement", typeof(System.Int32))]
	[NodeInput("OCSNormal", typeof(System.Object))]

	///<summary>
	///Translates a point from one coordinate system to another coordinate system
	///</summary>
	public class TranslateCoordinates : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TranslateCoordinates(inputs[1].Value,((nanoCAD.AcCoordinateSystem)inputs[2].Value),((nanoCAD.AcCoordinateSystem)inputs[3].Value),inputs[4].Value,inputs[5].Value));

		}
	}


	[NVP_Manifest(
		Text = "Initializes the GetKeyword method", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Bits", typeof(System.Int32))]
	[NodeInput("KeyWordList", typeof(System.Object))]

	///<summary>
	///Initializes the GetKeyword method
	///</summary>
	public class InitializeUserInput : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.InitializeUserInput(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Gets an integer value from the user", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Prompt", typeof(System.Object))]

	///<summary>
	///Gets an integer value from the user
	///</summary>
	public class GetInteger : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetInteger(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "double) value from the user", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Prompt", typeof(System.Object))]

	///<summary>
	///double) value from the user
	///</summary>
	public class GetReal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetReal(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Converts an input string from the user into a keyword index", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]

	///<summary>
	///Converts an input string from the user into a keyword index
	///</summary>
	public class GetInput : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetInput);

		}
	}


	[NVP_Manifest(
		Text = "Gets a keyword string from the user", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Prompt", typeof(System.Object))]

	///<summary>
	///Gets a keyword string from the user
	///</summary>
	public class GetKeyword : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetKeyword(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Gets a string from the user", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("HasSpaces", typeof(System.Int32))]
	[NodeInput("Prompt", typeof(System.Object))]

	///<summary>
	///Gets a string from the user
	///</summary>
	public class GetString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetString(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Text = "Gets the angle specified. Considers the setting of the ANGBASE system variable", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Point", typeof(System.Object))]
	[NodeInput("Prompt", typeof(System.Object))]

	///<summary>
	///Gets the angle specified. Considers the setting of the ANGBASE system variable
	///</summary>
	public class GetAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetAngle(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Text = "Gets the angle of a line from the X axis", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("StartPoint", typeof(System.Object))]
	[NodeInput("EndPoint", typeof(System.Object))]

	///<summary>
	///Gets the angle of a line from the X axis
	///</summary>
	public class AngleFromXAxis : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AngleFromXAxis(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Text = "Gets a corner of a rectangle", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Point", typeof(System.Object))]
	[NodeInput("Prompt", typeof(System.Object))]

	///<summary>
	///Gets a corner of a rectangle
	///</summary>
	public class GetCorner : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCorner(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Text = "Gets the distance from the prompt line or a selected set of points on the screen", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Point", typeof(System.Object))]
	[NodeInput("Prompt", typeof(System.Object))]

	///<summary>
	///Gets the distance from the prompt line or a selected set of points on the screen
	///</summary>
	public class GetDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetDistance(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Text = "Gets the angle specified. Ignores the setting of the ANGBASE system variable", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Point", typeof(System.Object))]
	[NodeInput("Prompt", typeof(System.Object))]

	///<summary>
	///Gets the angle specified. Ignores the setting of the ANGBASE system variable
	///</summary>
	public class GetOrientation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetOrientation(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Text = "Gets the point selected", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Point", typeof(System.Object))]
	[NodeInput("Prompt", typeof(System.Object))]

	///<summary>
	///Gets the point selected
	///</summary>
	public class GetPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPoint(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Text = "Gets the point at a specified angle and distance from a given point", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Point", typeof(System.Object))]
	[NodeInput("Angle", typeof(System.Double))]
	[NodeInput("Distance", typeof(System.Double))]

	///<summary>
	///Gets the point at a specified angle and distance from a given point
	///</summary>
	public class PolarPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PolarPoint(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Text = "Creates a variant that contains an array of typed arguments", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("varArr", typeof(System.Object))]
	[NodeInput("Type", typeof(System.Int32))]

	///<summary>
	///Creates a variant that contains an array of typed arguments
	///</summary>
	public class CreateTypedArray : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateTypedArray(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Text = "Gets an object interactively", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Object", typeof(System.Object))]
	[NodeInput("PickedPoint", typeof(System.Object))]
	[NodeInput("Prompt", typeof(System.Object))]

	///<summary>
	///Gets an object interactively
	///</summary>
	public class GetEntity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetEntity(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Posts a prompt to the command line", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Message", typeof(System.String))]

	///<summary>
	///Posts a prompt to the command line
	///</summary>
	public class Prompt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Prompt(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Gets an object or subentity interactively", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Object", typeof(System.Object))]
	[NodeInput("PickedPoint", typeof(System.Object))]
	[NodeInput("transMatrix", typeof(System.Object))]
	[NodeInput("ContextData", typeof(System.Object))]
	[NodeInput("Prompt", typeof(System.Object))]

	///<summary>
	///Gets an object or subentity interactively
	///</summary>
	public class GetSubEntity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetSubEntity(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value,inputs[5].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Validates a given URL", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("URL", typeof(System.String))]

	///<summary>
	///Validates a given URL
	///</summary>
	public class IsURL : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsURL(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Downloads the file specified by a URL", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("URL", typeof(System.String))]
	[NodeInput("LocalFile", typeof(System.String))]
	[NodeInput("IgnoreCache", typeof(System.Object))]

	///<summary>
	///Downloads the file specified by a URL
	///</summary>
	public class GetRemoteFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetRemoteFile(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Uploads a file to a remote location specified by a URL", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("URL", typeof(System.String))]
	[NodeInput("LocalFile", typeof(System.String))]

	///<summary>
	///Uploads a file to a remote location specified by a URL
	///</summary>
	public class PutRemoteFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PutRemoteFile(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the URL that a remote file was downloaded from", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("LocalFile", typeof(System.String))]
	[NodeInput("URL", typeof(System.Object))]

	///<summary>
	///Returns the URL that a remote file was downloaded from
	///</summary>
	public class IsRemoteFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsRemoteFile(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Text = "Launches the Web Browser dialog that allows the user to navigate to any URL and select a URL", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("SelectedURL", typeof(System.String))]
	[NodeInput("DialogTitle", typeof(System.String))]
	[NodeInput("OpenButtonCaption", typeof(System.String))]
	[NodeInput("StartPageURL", typeof(System.String))]
	[NodeInput("RegistryRootKey", typeof(System.String))]
	[NodeInput("OpenButtonAlwaysEnabled", typeof(System.Object))]

	///<summary>
	///Launches the Web Browser dialog that allows the user to navigate to any URL and select a URL
	///</summary>
	public class LaunchBrowserDialog : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LaunchBrowserDialog(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value,inputs[5].Value,inputs[6].Value));

		}
	}


	[NVP_Manifest(
		Text = "Creates a safearray from variant", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("varVec", typeof(System.Object))]

	///<summary>
	///Creates a safearray from variant
	///</summary>
	public class CreateSafeArrayFromVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CreateSafeArrayFromVector(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Creates a safearray from variant", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Type", typeof(System.Int32))]
	[NodeInput("varJSArray", typeof(System.Object))]

	///<summary>
	///Creates a safearray from variant
	///</summary>
	public class CreateTypedArrayFromJSArray : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateTypedArrayFromJSArray(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Text = "Analyze an ent", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("ent", typeof(System.Object))]

	///<summary>
	///Analyze an ent
	///</summary>
	public class AnalyzeEnt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AnalyzeEnt(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Analyze an ent", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Prompt", typeof(System.Object))]
	[NodeInput("secondPrompt", typeof(System.Object))]
	[NodeInput("closed", typeof(System.Object))]

	///<summary>
	///Analyze an ent
	///</summary>
	public class GetPolyline : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPolyline(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Text = "Create Matrix - safe array", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("str", typeof(System.String))]

	///<summary>
	///Create Matrix - safe array
	///</summary>
	public class Matrix4x4 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Matrix4x4(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Translates string", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("inStr", typeof(System.String))]

	///<summary>
	///Translates string
	///</summary>
	public class TranslateString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TranslateString(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Displays ChooseFile dialog", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("title", typeof(System.String))]
	[NodeInput("format", typeof(System.String))]
	[NodeInput("flags", typeof(System.Object))]
	[NodeInput("folder", typeof(System.String))]

	///<summary>
	///Displays ChooseFile dialog
	///</summary>
	public class ChooseFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ChooseFile(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value));

		}
	}


	[NVP_Manifest(
		Text = "Displays ChooseFolder dialog", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("title", typeof(System.String))]
	[NodeInput("inifolder", typeof(System.String))]

	///<summary>
	///Displays ChooseFolder dialog
	///</summary>
	public class ChooseFolder : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ChooseFolder(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Text = "ShellExec", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("op", typeof(System.String))]
	[NodeInput("file", typeof(System.String))]
	[NodeInput("param", typeof(System.String))]
	[NodeInput("dir", typeof(System.String))]
	[NodeInput("flags", typeof(System.Object))]

	///<summary>
	///ShellExec
	///</summary>
	public class ShellExec : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShellExec(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value,inputs[5].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Create new empty database", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]

	///<summary>
	///Create new empty database
	///</summary>
	public class NewDatabase : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NewDatabase);

		}
	}


	[NVP_Manifest(
		Text = "Open database", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Open database
	///</summary>
	public class OpenDatabase : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OpenDatabase(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Save database", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("FullFileName", typeof(System.String))]
	[NodeInput("SaveAsType", typeof(System.Object))]
	[NodeInput("vSecurityParams", typeof(System.Object))]

	///<summary>
	///Save database
	///</summary>
	public class SaveDatabase : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SaveDatabase(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Show menu", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("menu", typeof(System.Object))]
	[NodeInput("x", typeof(System.Object))]
	[NodeInput("y", typeof(System.Object))]

	///<summary>
	///Show menu
	///</summary>
	public class ShowMenu : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShowMenu(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Text = "hostGetWinNum", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Point", typeof(System.Object))]

	///<summary>
	///hostGetWinNum
	///</summary>
	public class GetWinNum : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetWinNum(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "hostCoordFromPixelToWorld", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("num", typeof(System.Object))]
	[NodeInput("Point", typeof(System.Object))]

	///<summary>
	///hostCoordFromPixelToWorld
	///</summary>
	public class CoordFromPixelToWorld : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CoordFromPixelToWorld(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Text = "hostCoordFromWorldToPixel", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("num", typeof(System.Object))]
	[NodeInput("Point", typeof(System.Object))]

	///<summary>
	///hostCoordFromWorldToPixel
	///</summary>
	public class CoordFromWorldToPixel : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CoordFromWorldToPixel(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Text = "Converts ObjectId to string", 
		ViewType = "Data")]
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Object", typeof(System.Object))]
	[NodeInput("asHex", typeof(System.Object))]

	///<summary>
	///Converts ObjectId to string
	///</summary>
	public class GetObjectIdString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetObjectIdString(inputs[1].Value,inputs[2].Value));

		}
	}
}
