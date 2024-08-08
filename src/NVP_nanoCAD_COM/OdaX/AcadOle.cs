using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of Ole object
///</summary>
namespace OdaX.AcadOle 
{

	[NVP_Manifest(
		Id = "A8114044-2636-4DD0-843B-3F980CF901AC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadOle.AcadOle_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadOle", 
		NodeName = "_AcadOle_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadOle_Constructor : INode 
	{
		public OdaX.IAcadOle _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadOle;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "D40A0759-633B-468C-A043-F109A2E97F3B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadOle.AcadOle_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadOle", 
		NodeName = "_AcadOle_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadOle_ConstructorCast : INode 
	{
		public OdaX.IAcadOle _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadOle;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "AB65639C-8246-4AE0-91E8-E7FD179460CC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadOle.InsertionPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadOle", 
		NodeName = "InsertionPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "upper left corner) of the OLE object", 
		ViewType = "Data")]
	[NodeInput("AcadOle", typeof(object))]

	///<summary>
	///upper left corner) of the OLE object
	///</summary>
	public class InsertionPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.InsertionPoint);

		}
	}


	[NVP_Manifest(
		Id = "BB442118-45D0-4A94-8D09-6D13BE43D9B8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadOle.Set_InsertionPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadOle", 
		NodeName = "Set_InsertionPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "upper left corner) of the OLE object", 
		ViewType = "Modifier")]
	[NodeInput("AcadOle", typeof(object))]
	[NodeInput("insPoint", typeof(System.Object))]

	///<summary>
	///upper left corner) of the OLE object
	///</summary>
	public class Set_InsertionPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.InsertionPoint = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1AAA1086-EFC1-4A9B-9C96-C025F8958DEE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadOle.Rotation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadOle", 
		NodeName = "Rotation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the rotation angle of the OLE object", 
		ViewType = "Data")]
	[NodeInput("AcadOle", typeof(object))]

	///<summary>
	///Specifies the rotation angle of the OLE object
	///</summary>
	public class Rotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Rotation);

		}
	}


	[NVP_Manifest(
		Id = "108CB43B-C042-4C0C-8822-A6513E88EC59", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadOle.Set_Rotation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadOle", 
		NodeName = "Set_Rotation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the rotation angle of the OLE object", 
		ViewType = "Modifier")]
	[NodeInput("AcadOle", typeof(object))]
	[NodeInput("rot", typeof(System.Object))]

	///<summary>
	///Specifies the rotation angle of the OLE object
	///</summary>
	public class Set_Rotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Rotation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9C846D5A-4CEC-45BB-AC8D-819128CA8692", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadOle.Width", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadOle", 
		NodeName = "Width", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the width of the OLE object box", 
		ViewType = "Data")]
	[NodeInput("AcadOle", typeof(object))]

	///<summary>
	///Specifies the width of the OLE object box
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
		Id = "628470C7-324A-4979-B026-A412C9EBFE24", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadOle.Set_Width", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadOle", 
		NodeName = "Set_Width", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the width of the OLE object box", 
		ViewType = "Modifier")]
	[NodeInput("AcadOle", typeof(object))]
	[NodeInput("Width", typeof(System.Double))]

	///<summary>
	///Specifies the width of the OLE object box
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
		Id = "FAE9DB3A-63FC-41A4-A722-C66314BB0915", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadOle.Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadOle", 
		NodeName = "Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the height of the OLE object box", 
		ViewType = "Data")]
	[NodeInput("AcadOle", typeof(object))]

	///<summary>
	///Specifies the height of the OLE object box
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
		Id = "4996C0DC-D418-4629-8425-B454405BF786", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadOle.Set_Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadOle", 
		NodeName = "Set_Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the height of the OLE object box", 
		ViewType = "Modifier")]
	[NodeInput("AcadOle", typeof(object))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Specifies the height of the OLE object box
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
		Id = "1D0D4999-453A-43C5-A1BF-910E27A5FC43", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadOle.ScaleWidth", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadOle", 
		NodeName = "ScaleWidth", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the width of the object as a percentage of original width", 
		ViewType = "Data")]
	[NodeInput("AcadOle", typeof(object))]

	///<summary>
	///Specifies the width of the object as a percentage of original width
	///</summary>
	public class ScaleWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ScaleWidth);

		}
	}


	[NVP_Manifest(
		Id = "302FA75F-93BD-420D-98B5-D8C48C5B14F9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadOle.Set_ScaleWidth", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadOle", 
		NodeName = "Set_ScaleWidth", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the width of the object as a percentage of original width", 
		ViewType = "Modifier")]
	[NodeInput("AcadOle", typeof(object))]
	[NodeInput("swidth", typeof(System.Double))]

	///<summary>
	///Specifies the width of the object as a percentage of original width
	///</summary>
	public class Set_ScaleWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ScaleWidth = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "06703ADB-98B5-47FE-A2CE-920AA3325BF9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadOle.ScaleHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadOle", 
		NodeName = "ScaleHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the height of the object as a percentage of original height", 
		ViewType = "Data")]
	[NodeInput("AcadOle", typeof(object))]

	///<summary>
	///Specifies the height of the object as a percentage of original height
	///</summary>
	public class ScaleHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ScaleHeight);

		}
	}


	[NVP_Manifest(
		Id = "F3D273F3-293F-4A7B-891E-D1E42B69270F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadOle.Set_ScaleHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadOle", 
		NodeName = "Set_ScaleHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the height of the object as a percentage of original height", 
		ViewType = "Modifier")]
	[NodeInput("AcadOle", typeof(object))]
	[NodeInput("sheight", typeof(System.Double))]

	///<summary>
	///Specifies the height of the object as a percentage of original height
	///</summary>
	public class Set_ScaleHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ScaleHeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6482114D-1C51-4FBD-AA70-F5C12A8060A4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadOle.LockAspectRatio", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadOle", 
		NodeName = "LockAspectRatio", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Ensures the width and height of the object stay in proportion", 
		ViewType = "Data")]
	[NodeInput("AcadOle", typeof(object))]

	///<summary>
	///Ensures the width and height of the object stay in proportion
	///</summary>
	public class LockAspectRatio : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LockAspectRatio);

		}
	}


	[NVP_Manifest(
		Id = "4F036901-FFB4-4D93-934B-4B39A1B49162", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadOle.Set_LockAspectRatio", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadOle", 
		NodeName = "Set_LockAspectRatio", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Ensures the width and height of the object stay in proportion", 
		ViewType = "Modifier")]
	[NodeInput("AcadOle", typeof(object))]
	[NodeInput("aspect", typeof(System.Object))]

	///<summary>
	///Ensures the width and height of the object stay in proportion
	///</summary>
	public class Set_LockAspectRatio : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LockAspectRatio = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9C46056C-5DA3-4179-A53C-575D77E83B57", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadOle.OleItemType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadOle", 
		NodeName = "OleItemType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies whether the OLE object is linked to the original pasted file when opening object for editing", 
		ViewType = "Data")]
	[NodeInput("AcadOle", typeof(object))]

	///<summary>
	///Specifies whether the OLE object is linked to the original pasted file when opening object for editing
	///</summary>
	public class OleItemType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OleItemType);

		}
	}


	[NVP_Manifest(
		Id = "70EE47F1-8623-4331-B5CB-86735CE61509", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadOle.Set_OleItemType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadOle", 
		NodeName = "Set_OleItemType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies whether the OLE object is linked to the original pasted file when opening object for editing", 
		ViewType = "Modifier")]
	[NodeInput("AcadOle", typeof(object))]
	[NodeInput("OdaX.AcOleType", typeof(System.Object))]

	///<summary>
	///Specifies whether the OLE object is linked to the original pasted file when opening object for editing
	///</summary>
	public class Set_OleItemType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OleItemType = ((OdaX.AcOleType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8E79EA24-9B75-4ECC-A28C-819EA9530CB6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadOle.OlePlotQuality", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadOle", 
		NodeName = "OlePlotQuality", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Controls plot quality of OLE object based on file type selected from list", 
		ViewType = "Data")]
	[NodeInput("AcadOle", typeof(object))]

	///<summary>
	///Controls plot quality of OLE object based on file type selected from list
	///</summary>
	public class OlePlotQuality : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OlePlotQuality);

		}
	}


	[NVP_Manifest(
		Id = "3BFD2424-2B94-4866-8753-15CCE6CCCC4D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadOle.Set_OlePlotQuality", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadOle", 
		NodeName = "Set_OlePlotQuality", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Controls plot quality of OLE object based on file type selected from list", 
		ViewType = "Modifier")]
	[NodeInput("AcadOle", typeof(object))]
	[NodeInput("OdaX.AcOlePlotQuality", typeof(System.Object))]

	///<summary>
	///Controls plot quality of OLE object based on file type selected from list
	///</summary>
	public class Set_OlePlotQuality : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OlePlotQuality = ((OdaX.AcOlePlotQuality)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0FE5EFA1-3FF8-4FCA-A573-3C46F0E3352E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadOle.OleSourceApp", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadOle", 
		NodeName = "OleSourceApp", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Application for editing OLE object", 
		ViewType = "Data")]
	[NodeInput("AcadOle", typeof(object))]

	///<summary>
	///Application for editing OLE object
	///</summary>
	public class OleSourceApp : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OleSourceApp);

		}
	}


	[NVP_Manifest(
		Id = "7D262ADA-FE89-433D-9F4A-8185C17F7A0D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadOle.Set_OleSourceApp", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadOle", 
		NodeName = "Set_OleSourceApp", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Application for editing OLE object", 
		ViewType = "Modifier")]
	[NodeInput("AcadOle", typeof(object))]
	[NodeInput("srcApp", typeof(System.String))]

	///<summary>
	///Application for editing OLE object
	///</summary>
	public class Set_OleSourceApp : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OleSourceApp = inputs[1].Value;
			return null;
		}
	}
}
