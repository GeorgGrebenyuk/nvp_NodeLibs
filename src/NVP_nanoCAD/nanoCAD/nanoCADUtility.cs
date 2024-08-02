using NVP.API.Nodes;

namespace nanoCAD.nanoCADUtility 
{
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


	///<summary>
	///double) value
	///</summary>
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Angle", typeof(System.String))]
	[NodeInput("Unit", typeof(System.Object))]
	public class AngleToReal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AngleToReal(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///double) value to a string
	///</summary>
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Angle", typeof(System.Double))]
	[NodeInput("Unit", typeof(System.Object))]
	[NodeInput("precision", typeof(System.Int32))]
	public class AngleToString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AngleToString(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///double) value
	///</summary>
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Distance", typeof(System.String))]
	[NodeInput("Unit", typeof(System.Object))]
	public class DistanceToReal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DistanceToReal(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///double) value to a string
	///</summary>
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Value", typeof(System.Double))]
	[NodeInput("Unit", typeof(System.Object))]
	[NodeInput("precision", typeof(System.Int32))]
	public class RealToString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RealToString(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Translates a point from one coordinate system to another coordinate system
	///</summary>
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Point", typeof(System.Object))]
	[NodeInput("FromCoordSystem", typeof(System.Object))]
	[NodeInput("ToCoordSystem", typeof(System.Object))]
	[NodeInput("Displacement", typeof(System.Int32))]
	[NodeInput("OCSNormal", typeof(System.Object))]
	public class TranslateCoordinates : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TranslateCoordinates(inputs[1],inputs[2],inputs[3],inputs[4],inputs[5]));

		}
	}


	///<summary>
	///Initializes the GetKeyword method
	///</summary>
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Bits", typeof(System.Int32))]
	[NodeInput("KeyWordList", typeof(System.Object))]
	public class InitializeUserInput : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.InitializeUserInput(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Gets an integer value from the user
	///</summary>
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Prompt", typeof(System.Object))]
	public class GetInteger : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetInteger(inputs[1]));

		}
	}


	///<summary>
	///double) value from the user
	///</summary>
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Prompt", typeof(System.Object))]
	public class GetReal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetReal(inputs[1]));

		}
	}


	///<summary>
	///Converts an input string from the user into a keyword index
	///</summary>
	[NodeInput("nanoCADUtility", typeof(object))]
	public class GetInput : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetInput);

		}
	}


	///<summary>
	///Gets a keyword string from the user
	///</summary>
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Prompt", typeof(System.Object))]
	public class GetKeyword : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetKeyword(inputs[1]));

		}
	}


	///<summary>
	///Gets a string from the user
	///</summary>
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("HasSpaces", typeof(System.Int32))]
	[NodeInput("Prompt", typeof(System.Object))]
	public class GetString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetString(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Gets the angle specified. Considers the setting of the ANGBASE system variable
	///</summary>
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Point", typeof(System.Object))]
	[NodeInput("Prompt", typeof(System.Object))]
	public class GetAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetAngle(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Gets the angle of a line from the X axis
	///</summary>
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("StartPoint", typeof(System.Object))]
	[NodeInput("EndPoint", typeof(System.Object))]
	public class AngleFromXAxis : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AngleFromXAxis(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Gets a corner of a rectangle
	///</summary>
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Point", typeof(System.Object))]
	[NodeInput("Prompt", typeof(System.Object))]
	public class GetCorner : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCorner(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Gets the distance from the prompt line or a selected set of points on the screen
	///</summary>
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Point", typeof(System.Object))]
	[NodeInput("Prompt", typeof(System.Object))]
	public class GetDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetDistance(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Gets the angle specified. Ignores the setting of the ANGBASE system variable
	///</summary>
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Point", typeof(System.Object))]
	[NodeInput("Prompt", typeof(System.Object))]
	public class GetOrientation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetOrientation(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Gets the point selected
	///</summary>
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Point", typeof(System.Object))]
	[NodeInput("Prompt", typeof(System.Object))]
	public class GetPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPoint(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Gets the point at a specified angle and distance from a given point
	///</summary>
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Point", typeof(System.Object))]
	[NodeInput("Angle", typeof(System.Double))]
	[NodeInput("Distance", typeof(System.Double))]
	public class PolarPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PolarPoint(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Creates a variant that contains an array of typed arguments
	///</summary>
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("varArr", typeof(System.Object))]
	[NodeInput("Type", typeof(System.Int32))]
	public class CreateTypedArray : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateTypedArray(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Gets an object interactively
	///</summary>
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Object", typeof(System.Object))]
	[NodeInput("PickedPoint", typeof(System.Object))]
	[NodeInput("Prompt", typeof(System.Object))]
	public class GetEntity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetEntity(inputs[1],inputs[2],inputs[3]);
			return null;
		}
	}


	///<summary>
	///Posts a prompt to the command line
	///</summary>
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Message", typeof(System.String))]
	public class Prompt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Prompt(inputs[1]);
			return null;
		}
	}


	///<summary>
	///Gets an object or subentity interactively
	///</summary>
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Object", typeof(System.Object))]
	[NodeInput("PickedPoint", typeof(System.Object))]
	[NodeInput("transMatrix", typeof(System.Object))]
	[NodeInput("ContextData", typeof(System.Object))]
	[NodeInput("Prompt", typeof(System.Object))]
	public class GetSubEntity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetSubEntity(inputs[1],inputs[2],inputs[3],inputs[4],inputs[5]);
			return null;
		}
	}


	///<summary>
	///Validates a given URL
	///</summary>
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("URL", typeof(System.String))]
	public class IsURL : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsURL(inputs[1]));

		}
	}


	///<summary>
	///Downloads the file specified by a URL
	///</summary>
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("URL", typeof(System.String))]
	[NodeInput("LocalFile", typeof(System.String))]
	[NodeInput("IgnoreCache", typeof(System.Object))]
	public class GetRemoteFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetRemoteFile(inputs[1],inputs[2],inputs[3]);
			return null;
		}
	}


	///<summary>
	///Uploads a file to a remote location specified by a URL
	///</summary>
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("URL", typeof(System.String))]
	[NodeInput("LocalFile", typeof(System.String))]
	public class PutRemoteFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PutRemoteFile(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Returns the URL that a remote file was downloaded from
	///</summary>
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("LocalFile", typeof(System.String))]
	[NodeInput("URL", typeof(System.Object))]
	public class IsRemoteFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsRemoteFile(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Launches the Web Browser dialog that allows the user to navigate to any URL and select a URL
	///</summary>
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("SelectedURL", typeof(System.String))]
	[NodeInput("DialogTitle", typeof(System.String))]
	[NodeInput("OpenButtonCaption", typeof(System.String))]
	[NodeInput("StartPageURL", typeof(System.String))]
	[NodeInput("RegistryRootKey", typeof(System.String))]
	[NodeInput("OpenButtonAlwaysEnabled", typeof(System.Object))]
	public class LaunchBrowserDialog : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LaunchBrowserDialog(inputs[1],inputs[2],inputs[3],inputs[4],inputs[5],inputs[6]));

		}
	}


	///<summary>
	///Creates a safearray from variant
	///</summary>
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("varVec", typeof(System.Object))]
	public class CreateSafeArrayFromVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CreateSafeArrayFromVector(inputs[1]);
			return null;
		}
	}


	///<summary>
	///Creates a safearray from variant
	///</summary>
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Type", typeof(System.Int32))]
	[NodeInput("varJSArray", typeof(System.Object))]
	public class CreateTypedArrayFromJSArray : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateTypedArrayFromJSArray(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Analyze an ent
	///</summary>
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("ent", typeof(System.Object))]
	public class AnalyzeEnt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AnalyzeEnt(inputs[1]);
			return null;
		}
	}


	///<summary>
	///Analyze an ent
	///</summary>
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Prompt", typeof(System.Object))]
	[NodeInput("secondPrompt", typeof(System.Object))]
	[NodeInput("closed", typeof(System.Object))]
	public class GetPolyline : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPolyline(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///Create Matrix - safe array
	///</summary>
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("str", typeof(System.String))]
	public class Matrix4x4 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Matrix4x4(inputs[1]));

		}
	}


	///<summary>
	///Translates string
	///</summary>
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("inStr", typeof(System.String))]
	public class TranslateString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TranslateString(inputs[1]));

		}
	}


	///<summary>
	///Displays ChooseFile dialog
	///</summary>
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("title", typeof(System.String))]
	[NodeInput("format", typeof(System.String))]
	[NodeInput("flags", typeof(System.Object))]
	[NodeInput("folder", typeof(System.String))]
	public class ChooseFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ChooseFile(inputs[1],inputs[2],inputs[3],inputs[4]));

		}
	}


	///<summary>
	///Displays ChooseFolder dialog
	///</summary>
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("title", typeof(System.String))]
	[NodeInput("inifolder", typeof(System.String))]
	public class ChooseFolder : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ChooseFolder(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///ShellExec
	///</summary>
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("op", typeof(System.String))]
	[NodeInput("file", typeof(System.String))]
	[NodeInput("param", typeof(System.String))]
	[NodeInput("dir", typeof(System.String))]
	[NodeInput("flags", typeof(System.Object))]
	public class ShellExec : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShellExec(inputs[1],inputs[2],inputs[3],inputs[4],inputs[5]);
			return null;
		}
	}


	///<summary>
	///Create new empty database
	///</summary>
	[NodeInput("nanoCADUtility", typeof(object))]
	public class NewDatabase : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NewDatabase);

		}
	}


	///<summary>
	///Open database
	///</summary>
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Name", typeof(System.String))]
	public class OpenDatabase : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OpenDatabase(inputs[1]));

		}
	}


	///<summary>
	///Save database
	///</summary>
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("FullFileName", typeof(System.String))]
	[NodeInput("SaveAsType", typeof(System.Object))]
	[NodeInput("vSecurityParams", typeof(System.Object))]
	public class SaveDatabase : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SaveDatabase(inputs[1],inputs[2],inputs[3]);
			return null;
		}
	}


	///<summary>
	///Show menu
	///</summary>
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("menu", typeof(System.Object))]
	[NodeInput("x", typeof(System.Object))]
	[NodeInput("y", typeof(System.Object))]
	public class ShowMenu : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShowMenu(inputs[1],inputs[2],inputs[3]));

		}
	}


	///<summary>
	///hostGetWinNum
	///</summary>
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Point", typeof(System.Object))]
	public class GetWinNum : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetWinNum(inputs[1]));

		}
	}


	///<summary>
	///hostCoordFromPixelToWorld
	///</summary>
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("num", typeof(System.Object))]
	[NodeInput("Point", typeof(System.Object))]
	public class CoordFromPixelToWorld : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CoordFromPixelToWorld(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///hostCoordFromWorldToPixel
	///</summary>
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("num", typeof(System.Object))]
	[NodeInput("Point", typeof(System.Object))]
	public class CoordFromWorldToPixel : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CoordFromWorldToPixel(inputs[1],inputs[2]));

		}
	}


	///<summary>
	///Converts ObjectId to string
	///</summary>
	[NodeInput("nanoCADUtility", typeof(object))]
	[NodeInput("Object", typeof(System.Object))]
	[NodeInput("asHex", typeof(System.Object))]
	public class GetObjectIdString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetObjectIdString(inputs[1],inputs[2]));

		}
	}
}
