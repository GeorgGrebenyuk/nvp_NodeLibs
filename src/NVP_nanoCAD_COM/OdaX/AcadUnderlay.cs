using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.AcadUnderlay 
{

	[NVP_Manifest(
		Id = "663A2C7A-2FB3-4A29-ABCC-64CDBBC1C3E4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadUnderlay.AcadUnderlay_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadUnderlay", 
		NodeName = "_AcadUnderlay_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadUnderlay_Constructor : INode 
	{
		public OdaX.IAcadUnderlay _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadUnderlay;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "8B7E5F98-0273-4CBF-A831-C1FB14C4852E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadUnderlay.AcadUnderlay_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadUnderlay", 
		NodeName = "_AcadUnderlay_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadUnderlay_ConstructorCast : INode 
	{
		public OdaX.IAcadUnderlay _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadUnderlay;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "158B9A15-5997-40C2-BD06-1DB4B34C41C6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadUnderlay.Contrast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadUnderlay", 
		NodeName = "Contrast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the contrast of the underlay.", 
		ViewType = "Data")]
	[NodeInput("AcadUnderlay", typeof(object))]

	///<summary>
	///Specifies or returns the contrast of the underlay.
	///</summary>
	public class Contrast : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Contrast);

		}
	}


	[NVP_Manifest(
		Id = "85050490-D15E-4198-8DC7-5DE786E4204B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadUnderlay.Set_Contrast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadUnderlay", 
		NodeName = "Set_Contrast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the contrast of the underlay.", 
		ViewType = "Modifier")]
	[NodeInput("AcadUnderlay", typeof(object))]
	[NodeInput("Contrast", typeof(System.Object))]

	///<summary>
	///Specifies or returns the contrast of the underlay.
	///</summary>
	public class Set_Contrast : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Contrast = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C30766F1-1327-4638-8F5D-619F90E69FB8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadUnderlay.Fade", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadUnderlay", 
		NodeName = "Fade", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the fade of the underlay.", 
		ViewType = "Data")]
	[NodeInput("AcadUnderlay", typeof(object))]

	///<summary>
	///Specifies or returns the fade of the underlay.
	///</summary>
	public class Fade : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Fade);

		}
	}


	[NVP_Manifest(
		Id = "63F63BF2-2206-4251-AD15-C0E2EDD52E93", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadUnderlay.Set_Fade", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadUnderlay", 
		NodeName = "Set_Fade", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the fade of the underlay.", 
		ViewType = "Modifier")]
	[NodeInput("AcadUnderlay", typeof(object))]
	[NodeInput("Fade", typeof(System.Object))]

	///<summary>
	///Specifies or returns the fade of the underlay.
	///</summary>
	public class Set_Fade : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Fade = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D000B7BF-379B-40B5-AA6D-2DD3C86A4192", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadUnderlay.Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadUnderlay", 
		NodeName = "Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the lower left point of the underlay position.", 
		ViewType = "Data")]
	[NodeInput("AcadUnderlay", typeof(object))]

	///<summary>
	///Specifies or returns the lower left point of the underlay position.
	///</summary>
	public class Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Position);

		}
	}


	[NVP_Manifest(
		Id = "74852430-6ED1-4912-BDA9-313584E6A9EE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadUnderlay.Set_Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadUnderlay", 
		NodeName = "Set_Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the lower left point of the underlay position.", 
		ViewType = "Modifier")]
	[NodeInput("AcadUnderlay", typeof(object))]
	[NodeInput("pos", typeof(System.Object))]

	///<summary>
	///Specifies or returns the lower left point of the underlay position.
	///</summary>
	public class Set_Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Position = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5104F9B4-4BB2-4995-A213-6E67B36074F2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadUnderlay.Rotation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadUnderlay", 
		NodeName = "Rotation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the rotation of the underlay.", 
		ViewType = "Data")]
	[NodeInput("AcadUnderlay", typeof(object))]

	///<summary>
	///Specifies or returns the rotation of the underlay.
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
		Id = "1A481EFF-5B30-4620-AB52-602B313ABEB9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadUnderlay.Set_Rotation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadUnderlay", 
		NodeName = "Set_Rotation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the rotation of the underlay.", 
		ViewType = "Modifier")]
	[NodeInput("AcadUnderlay", typeof(object))]
	[NodeInput("rotAngle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the rotation of the underlay.
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
		Id = "27878859-FDED-423A-9BA4-42C6BEDC2801", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadUnderlay.Width", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadUnderlay", 
		NodeName = "Width", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the width of the underlay.", 
		ViewType = "Data")]
	[NodeInput("AcadUnderlay", typeof(object))]

	///<summary>
	///Specifies or returns the width of the underlay.
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
		Id = "1313647A-0444-4CC0-9F2D-825B22E8D4D5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadUnderlay.Set_Width", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadUnderlay", 
		NodeName = "Set_Width", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the width of the underlay.", 
		ViewType = "Modifier")]
	[NodeInput("AcadUnderlay", typeof(object))]
	[NodeInput("Width", typeof(System.Double))]

	///<summary>
	///Specifies or returns the width of the underlay.
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
		Id = "6989E222-3878-4F65-8DA5-A0058887A151", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadUnderlay.Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadUnderlay", 
		NodeName = "Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the height of the underlay.", 
		ViewType = "Data")]
	[NodeInput("AcadUnderlay", typeof(object))]

	///<summary>
	///Specifies or returns the height of the underlay.
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
		Id = "55EC5E32-B97F-456E-8425-17E3FF740066", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadUnderlay.Set_Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadUnderlay", 
		NodeName = "Set_Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the height of the underlay.", 
		ViewType = "Modifier")]
	[NodeInput("AcadUnderlay", typeof(object))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Specifies or returns the height of the underlay.
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
		Id = "8CA65894-48A6-44EE-A0F1-AD36032905ED", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadUnderlay.UnderlayName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadUnderlay", 
		NodeName = "UnderlayName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the name of the underlay file.", 
		ViewType = "Data")]
	[NodeInput("AcadUnderlay", typeof(object))]

	///<summary>
	///Specifies or returns the name of the underlay file.
	///</summary>
	public class UnderlayName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UnderlayName);

		}
	}


	[NVP_Manifest(
		Id = "BE4C7879-8568-4103-AAE2-42E245375946", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadUnderlay.Set_UnderlayName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadUnderlay", 
		NodeName = "Set_UnderlayName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the name of the underlay file.", 
		ViewType = "Modifier")]
	[NodeInput("AcadUnderlay", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Specifies or returns the name of the underlay file.
	///</summary>
	public class Set_UnderlayName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UnderlayName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D8B8137D-31E9-4188-9B43-8EC57FE6FE3A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadUnderlay.Set_ItemName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadUnderlay", 
		NodeName = "Set_ItemName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the item name of the underlay file.", 
		ViewType = "Modifier")]
	[NodeInput("AcadUnderlay", typeof(object))]
	[NodeInput("sheetName", typeof(System.String))]

	///<summary>
	///Specifies or returns the item name of the underlay file.
	///</summary>
	public class Set_ItemName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ItemName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7BDD58CF-940E-45C0-B120-5C36E6383EB5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadUnderlay.ItemName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadUnderlay", 
		NodeName = "ItemName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the item name of the underlay file.", 
		ViewType = "Data")]
	[NodeInput("AcadUnderlay", typeof(object))]

	///<summary>
	///Specifies or returns the item name of the underlay file.
	///</summary>
	public class ItemName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ItemName);

		}
	}


	[NVP_Manifest(
		Id = "24936B72-2640-483E-A908-99AD18AE8277", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadUnderlay.Monochrome", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadUnderlay", 
		NodeName = "Monochrome", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the underlay displays in monochrome.", 
		ViewType = "Data")]
	[NodeInput("AcadUnderlay", typeof(object))]

	///<summary>
	///Specifies or returns whether the underlay displays in monochrome.
	///</summary>
	public class Monochrome : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Monochrome);

		}
	}


	[NVP_Manifest(
		Id = "05FAF8A1-76BB-4BB5-92A6-EF91C17C5EA5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadUnderlay.Set_Monochrome", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadUnderlay", 
		NodeName = "Set_Monochrome", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the underlay displays in monochrome.", 
		ViewType = "Modifier")]
	[NodeInput("AcadUnderlay", typeof(object))]
	[NodeInput("bMono", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the underlay displays in monochrome.
	///</summary>
	public class Set_Monochrome : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Monochrome = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "53B357F1-686F-4043-85AA-EAD10AF1CDFE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadUnderlay.AdjustForBackground", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadUnderlay", 
		NodeName = "AdjustForBackground", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether underlay colors are adjusted according to the background color.", 
		ViewType = "Data")]
	[NodeInput("AcadUnderlay", typeof(object))]

	///<summary>
	///Specifies or returns whether underlay colors are adjusted according to the background color.
	///</summary>
	public class AdjustForBackground : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AdjustForBackground);

		}
	}


	[NVP_Manifest(
		Id = "FFCDC5AA-C8AA-413B-A70C-4187FE9F3D64", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadUnderlay.Set_AdjustForBackground", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadUnderlay", 
		NodeName = "Set_AdjustForBackground", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether underlay colors are adjusted according to the background color.", 
		ViewType = "Modifier")]
	[NodeInput("AcadUnderlay", typeof(object))]
	[NodeInput("Value", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether underlay colors are adjusted according to the background color.
	///</summary>
	public class Set_AdjustForBackground : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AdjustForBackground = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DAEB0EB4-B800-4752-BC69-5035182168F6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadUnderlay.ClipBoundary", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadUnderlay", 
		NodeName = "ClipBoundary", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies an area for displaying and printing the underlay.", 
		ViewType = "Modifier")]
	[NodeInput("AcadUnderlay", typeof(object))]
	[NodeInput("boundry", typeof(System.Object))]

	///<summary>
	///Specifies an area for displaying and printing the underlay.
	///</summary>
	public class ClipBoundary : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ClipBoundary(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DEB02E26-0790-44E9-BB12-344B86BD5B66", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadUnderlay.ScaleFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadUnderlay", 
		NodeName = "ScaleFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the scale factor of the underlay.", 
		ViewType = "Data")]
	[NodeInput("AcadUnderlay", typeof(object))]

	///<summary>
	///Specifies or returns the scale factor of the underlay.
	///</summary>
	public class ScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ScaleFactor);

		}
	}


	[NVP_Manifest(
		Id = "95D0E057-255F-4833-A8A0-CAB67689DAA7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadUnderlay.Set_ScaleFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadUnderlay", 
		NodeName = "Set_ScaleFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the scale factor of the underlay.", 
		ViewType = "Modifier")]
	[NodeInput("AcadUnderlay", typeof(object))]
	[NodeInput("ScaleFactor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the scale factor of the underlay.
	///</summary>
	public class Set_ScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ScaleFactor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "252391F7-2595-4CD7-8542-AB42E57958FC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadUnderlay.File", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadUnderlay", 
		NodeName = "File", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path to the underlay file.", 
		ViewType = "Data")]
	[NodeInput("AcadUnderlay", typeof(object))]

	///<summary>
	///Specifies or returns the path to the underlay file.
	///</summary>
	public class File : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.File);

		}
	}


	[NVP_Manifest(
		Id = "23540CC6-4D7A-4072-B5A3-411BB1495EAE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadUnderlay.Set_File", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadUnderlay", 
		NodeName = "Set_File", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path to the underlay file.", 
		ViewType = "Modifier")]
	[NodeInput("AcadUnderlay", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Specifies or returns the path to the underlay file.
	///</summary>
	public class Set_File : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.File = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8AFBD98B-6DB3-4F06-B29D-3A7AEDA02AB9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadUnderlay.UnderlayVisibility", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadUnderlay", 
		NodeName = "UnderlayVisibility", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether underlay displays in the drawing.", 
		ViewType = "Data")]
	[NodeInput("AcadUnderlay", typeof(object))]

	///<summary>
	///Specifies or returns whether underlay displays in the drawing.
	///</summary>
	public class UnderlayVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UnderlayVisibility);

		}
	}


	[NVP_Manifest(
		Id = "270D4968-5599-478E-8B66-E4920AA541A1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadUnderlay.Set_UnderlayVisibility", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadUnderlay", 
		NodeName = "Set_UnderlayVisibility", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether underlay displays in the drawing.", 
		ViewType = "Modifier")]
	[NodeInput("AcadUnderlay", typeof(object))]
	[NodeInput("fVisible", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether underlay displays in the drawing.
	///</summary>
	public class Set_UnderlayVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UnderlayVisibility = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E156CE91-48E6-4BCD-BEC9-B73FE8BC20E5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadUnderlay.ClippingEnabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadUnderlay", 
		NodeName = "ClippingEnabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the clipping boundary of the underlay is turned on.", 
		ViewType = "Data")]
	[NodeInput("AcadUnderlay", typeof(object))]

	///<summary>
	///Specifies or returns whether the clipping boundary of the underlay is turned on.
	///</summary>
	public class ClippingEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ClippingEnabled);

		}
	}


	[NVP_Manifest(
		Id = "393344BC-8137-4B9E-B9B4-37EA460A4508", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadUnderlay.Set_ClippingEnabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadUnderlay", 
		NodeName = "Set_ClippingEnabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the clipping boundary of the underlay is turned on.", 
		ViewType = "Modifier")]
	[NodeInput("AcadUnderlay", typeof(object))]
	[NodeInput("kClip", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the clipping boundary of the underlay is turned on.
	///</summary>
	public class Set_ClippingEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ClippingEnabled = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "47A6B675-6EFF-43B4-8449-17277AAE115C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadUnderlay.UnderlayLayerOverrideApplied", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadUnderlay", 
		NodeName = "UnderlayLayerOverrideApplied", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the layers of a DWF underlay are applied.", 
		ViewType = "Data")]
	[NodeInput("AcadUnderlay", typeof(object))]

	///<summary>
	///Specifies or returns whether the layers of a DWF underlay are applied.
	///</summary>
	public class UnderlayLayerOverrideApplied : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UnderlayLayerOverrideApplied);

		}
	}


	[NVP_Manifest(
		Id = "8A9B1A08-235F-4977-A741-2FF77C65C1C4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadUnderlay.Set_UnderlayLayerOverrideApplied", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadUnderlay", 
		NodeName = "Set_UnderlayLayerOverrideApplied", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the layers of a DWF underlay are applied.", 
		ViewType = "Modifier")]
	[NodeInput("AcadUnderlay", typeof(object))]
	[NodeInput("OdaX.AcUnderlayLayerOverrideType", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the layers of a DWF underlay are applied.
	///</summary>
	public class Set_UnderlayLayerOverrideApplied : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UnderlayLayerOverrideApplied = ((OdaX.AcUnderlayLayerOverrideType)inputs[1].Value);
			return null;
		}
	}
}
