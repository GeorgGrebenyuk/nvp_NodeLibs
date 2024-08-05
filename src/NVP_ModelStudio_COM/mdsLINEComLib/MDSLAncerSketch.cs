using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Графическое представление анкерной опоры
///</summary>
namespace mdsLINEComLib.MDSLAncerSketch 
{

	[NVP_Manifest(
		Id = "B5EE7B42-2ACC-4685-9105-35ED5929E5A6", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.MDSLAncerSketch_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "_MDSLAncerSketch_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLAncerSketch_Constructor : INode 
	{
		public mdsLINEComLib.IMDSLAncerSketch _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsLINEComLib.IMDSLAncerSketch;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "C42332BC-3150-4453-83E6-D9CFC0857644", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.MDSLAncerSketch_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "_MDSLAncerSketch_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLAncerSketch_ConstructorCast : INode 
	{
		public mdsLINEComLib.IMDSLAncerSketch _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsLINEComLib.IMDSLAncerSketch;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "3247EA5D-66B4-44A5-A4CE-5E630870A396", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///property Element
	///</summary>
	public class Element : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Element);

		}
	}


	[NVP_Manifest(
		Id = "83216DE7-FB58-4674-B6D9-2D0E60D8D5F4", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Element
	///</summary>
	public class Set_Element : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Element = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "84CDB137-0DF1-4CE4-A251-B33E9B2893E2", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Position", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///property Position
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
		Id = "512AB3ED-D2F0-4253-AA24-08DAD8D5AC18", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Set_Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Set_Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Position", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Position
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
		Id = "62761667-332F-4358-808D-A3EEFE2213A4", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.GetPositionMM", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "GetPositionMM", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method GetPositionMM", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///method GetPositionMM
	///</summary>
	public class GetPositionMM : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPositionMM);

		}
	}


	[NVP_Manifest(
		Id = "9BD68096-AADB-4360-83E0-DF7F3D34BB1C", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.HeightMark", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "HeightMark", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property HeightMark", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///property HeightMark
	///</summary>
	public class HeightMark : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HeightMark);

		}
	}


	[NVP_Manifest(
		Id = "DA870E96-2AEC-4FB5-B656-0139A87B7BD8", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Set_HeightMark", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Set_HeightMark", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property HeightMark", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property HeightMark
	///</summary>
	public class Set_HeightMark : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HeightMark = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7B5E39DA-D676-452B-B399-A2750C581A96", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Azimuth1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Azimuth1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Azimuth1", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///property Azimuth1
	///</summary>
	public class Azimuth1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Azimuth1);

		}
	}


	[NVP_Manifest(
		Id = "48F569B9-684B-45ED-952B-B772FDFDD65E", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Set_Azimuth1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Set_Azimuth1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Azimuth1", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Azimuth1
	///</summary>
	public class Set_Azimuth1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Azimuth1 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8433FCC8-4F67-4F7E-B2D4-3FDDF6D1C4C5", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Azimuth2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Azimuth2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Azimuth2", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///property Azimuth2
	///</summary>
	public class Azimuth2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Azimuth2);

		}
	}


	[NVP_Manifest(
		Id = "2F9ABE02-C09A-4128-9D2E-96DB23A456AA", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Set_Azimuth2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Set_Azimuth2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Azimuth2", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Azimuth2
	///</summary>
	public class Set_Azimuth2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Azimuth2 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "43FFD96B-D77B-4ABB-BB9F-B86E892A34EE", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Angle1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Angle1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Angle1", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///property Angle1
	///</summary>
	public class Angle1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Angle1);

		}
	}


	[NVP_Manifest(
		Id = "82409634-8E57-4534-B0E4-C5DB34F47ED6", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Set_Angle1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Set_Angle1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Angle1", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Angle1
	///</summary>
	public class Set_Angle1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Angle1 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DC669EB0-0A84-46BB-870F-8C397E44F372", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Angle2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Angle2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Angle2", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///property Angle2
	///</summary>
	public class Angle2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Angle2);

		}
	}


	[NVP_Manifest(
		Id = "58E9A6FB-6591-4025-B4DE-446592B5C9D6", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Set_Angle2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Set_Angle2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Angle2", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Angle2
	///</summary>
	public class Set_Angle2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Angle2 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "CB26331A-E3C5-4DB8-9709-92D66D3C1EB9", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.ScaleH_BTR_ListBox", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "ScaleH_BTR_ListBox", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ScaleH_BTR_ListBox", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///property ScaleH_BTR_ListBox
	///</summary>
	public class ScaleH_BTR_ListBox : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ScaleH_BTR_ListBox);

		}
	}


	[NVP_Manifest(
		Id = "CDB18657-73BF-4394-82ED-F4DC43B9D9D2", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Set_ScaleH_BTR_ListBox", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Set_ScaleH_BTR_ListBox", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ScaleH_BTR_ListBox", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Int32))]

	///<summary>
	///property ScaleH_BTR_ListBox
	///</summary>
	public class Set_ScaleH_BTR_ListBox : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ScaleH_BTR_ListBox = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7246B2AA-617C-420A-8420-18B24E2C0C98", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.ScaleH_BTR", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "ScaleH_BTR", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ScaleH_BTR", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///property ScaleH_BTR
	///</summary>
	public class ScaleH_BTR : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ScaleH_BTR);

		}
	}


	[NVP_Manifest(
		Id = "20E9A4DF-BDAD-4D9F-A98B-35C252A2E6E1", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Set_ScaleH_BTR", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Set_ScaleH_BTR", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ScaleH_BTR", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property ScaleH_BTR
	///</summary>
	public class Set_ScaleH_BTR : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ScaleH_BTR = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "CBA00D68-9D5C-4942-8DEC-E84F3FF5726A", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.ScaleV_BTR_ListBox", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "ScaleV_BTR_ListBox", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ScaleV_BTR_ListBox", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///property ScaleV_BTR_ListBox
	///</summary>
	public class ScaleV_BTR_ListBox : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ScaleV_BTR_ListBox);

		}
	}


	[NVP_Manifest(
		Id = "AFF3BD7E-4C8F-44E9-999E-AEC43E51DC9A", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Set_ScaleV_BTR_ListBox", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Set_ScaleV_BTR_ListBox", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ScaleV_BTR_ListBox", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Int32))]

	///<summary>
	///property ScaleV_BTR_ListBox
	///</summary>
	public class Set_ScaleV_BTR_ListBox : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ScaleV_BTR_ListBox = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "841E0077-4B66-4928-AE51-4180870BD9B6", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.ScaleV_BTR", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "ScaleV_BTR", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ScaleV_BTR", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///property ScaleV_BTR
	///</summary>
	public class ScaleV_BTR : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ScaleV_BTR);

		}
	}


	[NVP_Manifest(
		Id = "F64CF17B-D26A-4D66-BDCE-FD5666F014E0", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Set_ScaleV_BTR", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Set_ScaleV_BTR", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ScaleV_BTR", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property ScaleV_BTR
	///</summary>
	public class Set_ScaleV_BTR : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ScaleV_BTR = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3CC0ACA5-DB77-45E5-8D6F-A0E1DAA66566", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.NameBTR", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "NameBTR", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property NameBTR", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///property NameBTR
	///</summary>
	public class NameBTR : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NameBTR);

		}
	}


	[NVP_Manifest(
		Id = "D0D89598-6B3D-4D98-8C6B-04F61B5E958E", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Set_NameBTR", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Set_NameBTR", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property NameBTR", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property NameBTR
	///</summary>
	public class Set_NameBTR : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.NameBTR = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "93C564AA-B22A-4374-99EC-03A6921316CA", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.NearLeft", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "NearLeft", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property NearLeft", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///property NearLeft
	///</summary>
	public class NearLeft : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NearLeft);

		}
	}


	[NVP_Manifest(
		Id = "AA8BCEB5-D522-49D3-99E0-8F9305363DC8", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Set_NearLeft", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Set_NearLeft", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property NearLeft", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property NearLeft
	///</summary>
	public class Set_NearLeft : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.NearLeft = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6BC8B5A8-9322-4622-A301-2DAC80799B76", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.NearRight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "NearRight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property NearRight", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///property NearRight
	///</summary>
	public class NearRight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NearRight);

		}
	}


	[NVP_Manifest(
		Id = "49CF7BE4-F45C-493A-B517-48F3B858C83A", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Set_NearRight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Set_NearRight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property NearRight", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property NearRight
	///</summary>
	public class Set_NearRight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.NearRight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "91912232-E44E-4DEE-96DB-909B46A811AB", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.PlanPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "PlanPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Точка вставки", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Точка вставки
	///</summary>
	public class PlanPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlanPoint);

		}
	}


	[NVP_Manifest(
		Id = "E039D15E-8EAA-4D15-AC77-573449134730", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.WireAverageHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "WireAverageHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Центр масс проводов", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Центр масс проводов
	///</summary>
	public class WireAverageHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WireAverageHeight);

		}
	}


	[NVP_Manifest(
		Id = "7B3C163E-A306-491D-A873-CF74D85F5301", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.TrosAverageHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "TrosAverageHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Центр масс тросов", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Центр масс тросов
	///</summary>
	public class TrosAverageHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TrosAverageHeight);

		}
	}


	[NVP_Manifest(
		Id = "4FB7879F-C1EE-4B72-B93E-CD85A76E4ECE", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.OpticalAverageHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "OpticalAverageHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Центр масс ВОК", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Центр масс ВОК
	///</summary>
	public class OpticalAverageHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OpticalAverageHeight);

		}
	}


	[NVP_Manifest(
		Id = "E74ADFA8-8131-4888-BAFB-0E4A8C160724", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.GarlandWireEnabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "GarlandWireEnabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Имеются гирлянды на проводе", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Имеются гирлянды на проводе
	///</summary>
	public class GarlandWireEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandWireEnabled);

		}
	}


	[NVP_Manifest(
		Id = "0A980D6E-F7F0-40E6-9E84-1532C1B71905", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Set_GarlandWireEnabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Set_GarlandWireEnabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Имеются гирлянды на проводе", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Имеются гирлянды на проводе
	///</summary>
	public class Set_GarlandWireEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandWireEnabled = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9B0E224E-EC1C-47D3-981F-49F1DB607733", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.GarlandWireCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "GarlandWireCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Количество гирлянд на проводе", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Количество гирлянд на проводе
	///</summary>
	public class GarlandWireCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandWireCount);

		}
	}


	[NVP_Manifest(
		Id = "A675B24D-21BA-493E-8D52-D7CB3ECBC328", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.GarlandWireInsulatorType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "GarlandWireInsulatorType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Тип изолятора", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Тип изолятора
	///</summary>
	public class GarlandWireInsulatorType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandWireInsulatorType);

		}
	}


	[NVP_Manifest(
		Id = "17A592BA-5193-4B09-B2C5-FE26054A1022", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Set_GarlandWireInsulatorType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Set_GarlandWireInsulatorType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Тип изолятора", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Тип изолятора
	///</summary>
	public class Set_GarlandWireInsulatorType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandWireInsulatorType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "63E4D90E-3AE4-429E-B854-819B0E2FCBBF", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.GarlandWireLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "GarlandWireLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Длина гирлянды на проводе", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Длина гирлянды на проводе
	///</summary>
	public class GarlandWireLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandWireLength);

		}
	}


	[NVP_Manifest(
		Id = "618722A4-06A6-4BF3-882A-7D0386D044F7", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Set_GarlandWireLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Set_GarlandWireLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Длина гирлянды на проводе", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Длина гирлянды на проводе
	///</summary>
	public class Set_GarlandWireLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandWireLength = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "30C4C51B-5CCA-41D5-B7C5-5963336CF323", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.GarlandWireWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "GarlandWireWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Масса гирлянды на проводе", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Масса гирлянды на проводе
	///</summary>
	public class GarlandWireWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandWireWeight);

		}
	}


	[NVP_Manifest(
		Id = "F3A7B609-3761-4DC5-AB36-17C4917BE9A3", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Set_GarlandWireWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Set_GarlandWireWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Масса гирлянды на проводе", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Масса гирлянды на проводе
	///</summary>
	public class Set_GarlandWireWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandWireWeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9A606167-B6B9-4705-B869-D75EF166D076", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.GarlandWireDiameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "GarlandWireDiameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "мм)", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///мм)
	///</summary>
	public class GarlandWireDiameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandWireDiameter);

		}
	}


	[NVP_Manifest(
		Id = "36641BDA-0319-47D2-9F12-237F82685F33", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Set_GarlandWireDiameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Set_GarlandWireDiameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "мм)", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///мм)
	///</summary>
	public class Set_GarlandWireDiameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandWireDiameter = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1524D4CE-B3E0-43D2-9BD2-CCB745696172", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.GarlandWireChainCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "GarlandWireChainCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Число цепей изоляторов гирлянды на проводе", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Число цепей изоляторов гирлянды на проводе
	///</summary>
	public class GarlandWireChainCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandWireChainCount);

		}
	}


	[NVP_Manifest(
		Id = "1854EC5B-5843-436E-B57F-B47B3AD0C026", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Set_GarlandWireChainCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Set_GarlandWireChainCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Число цепей изоляторов гирлянды на проводе", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Число цепей изоляторов гирлянды на проводе
	///</summary>
	public class Set_GarlandWireChainCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandWireChainCount = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "11E30895-A749-4814-BBAE-505E13C01D59", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.GarlandWireChainLayout", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "GarlandWireChainLayout", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расположение цепей изоляторов гирлянды на проводе", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Расположение цепей изоляторов гирлянды на проводе
	///</summary>
	public class GarlandWireChainLayout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandWireChainLayout);

		}
	}


	[NVP_Manifest(
		Id = "B14C47F0-3F9A-4D86-ACBC-907E4ECF150F", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Set_GarlandWireChainLayout", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Set_GarlandWireChainLayout", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расположение цепей изоляторов гирлянды на проводе", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Расположение цепей изоляторов гирлянды на проводе
	///</summary>
	public class Set_GarlandWireChainLayout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandWireChainLayout = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2FEDC29C-38B8-4F89-BC8A-EAB6EE81C904", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.GarlandWireChainDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "GarlandWireChainDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расстояние между цепями изоляторов гирлянды на проводе", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Расстояние между цепями изоляторов гирлянды на проводе
	///</summary>
	public class GarlandWireChainDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandWireChainDistance);

		}
	}


	[NVP_Manifest(
		Id = "7FD22AAD-69D6-4A1F-BA24-BFE9D839CE21", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Set_GarlandWireChainDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Set_GarlandWireChainDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расстояние между цепями изоляторов гирлянды на проводе", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Расстояние между цепями изоляторов гирлянды на проводе
	///</summary>
	public class Set_GarlandWireChainDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandWireChainDistance = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B5E033AF-53F7-409E-AD8D-DAC4B8557B5C", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.GarlandTrosEnabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "GarlandTrosEnabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Имеются гирлянды на тросе", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Имеются гирлянды на тросе
	///</summary>
	public class GarlandTrosEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandTrosEnabled);

		}
	}


	[NVP_Manifest(
		Id = "2F45FAD6-F2FE-4A4D-8FBD-1A76DBD169A5", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Set_GarlandTrosEnabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Set_GarlandTrosEnabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Имеются гирлянды на тросе", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Имеются гирлянды на тросе
	///</summary>
	public class Set_GarlandTrosEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandTrosEnabled = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "16505AD1-A345-4EB1-8BEA-4653EB56937A", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.GarlandTrosCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "GarlandTrosCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Количество гирлянд на тросе", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Количество гирлянд на тросе
	///</summary>
	public class GarlandTrosCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandTrosCount);

		}
	}


	[NVP_Manifest(
		Id = "67CE9711-F824-44EE-B822-D57A74630879", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.GarlandTrosInsulatorType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "GarlandTrosInsulatorType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Тип изолятора", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Тип изолятора
	///</summary>
	public class GarlandTrosInsulatorType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandTrosInsulatorType);

		}
	}


	[NVP_Manifest(
		Id = "15983C54-9BAE-4F8F-9722-EE92BF4AFFF9", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Set_GarlandTrosInsulatorType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Set_GarlandTrosInsulatorType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Тип изолятора", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Тип изолятора
	///</summary>
	public class Set_GarlandTrosInsulatorType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandTrosInsulatorType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "29D3E82C-0721-4376-B605-1AF051DB8812", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.GarlandTrosLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "GarlandTrosLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Длина гирлянды на тросе", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Длина гирлянды на тросе
	///</summary>
	public class GarlandTrosLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandTrosLength);

		}
	}


	[NVP_Manifest(
		Id = "32C048DC-F33D-4DE6-9DA2-B628C1BB6F71", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Set_GarlandTrosLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Set_GarlandTrosLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Длина гирлянды на тросе", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Длина гирлянды на тросе
	///</summary>
	public class Set_GarlandTrosLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandTrosLength = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A845F578-56D8-4DDB-BB3E-8814687C378F", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.GarlandTrosWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "GarlandTrosWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Масса гирлянды на тросе", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Масса гирлянды на тросе
	///</summary>
	public class GarlandTrosWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandTrosWeight);

		}
	}


	[NVP_Manifest(
		Id = "38031647-C502-4677-A733-AAD3F78DF318", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Set_GarlandTrosWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Set_GarlandTrosWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Масса гирлянды на тросе", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Масса гирлянды на тросе
	///</summary>
	public class Set_GarlandTrosWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandTrosWeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1FA99CCB-9DDD-4849-9CBA-21CCB5BEC25F", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.GarlandTrosDiameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "GarlandTrosDiameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "мм)", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///мм)
	///</summary>
	public class GarlandTrosDiameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandTrosDiameter);

		}
	}


	[NVP_Manifest(
		Id = "43EC8185-6FE7-4EB8-9624-09EEC683ADB6", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Set_GarlandTrosDiameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Set_GarlandTrosDiameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "мм)", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///мм)
	///</summary>
	public class Set_GarlandTrosDiameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandTrosDiameter = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "45D17C64-5645-4BE0-A671-4A76C6972636", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.GarlandTrosChainCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "GarlandTrosChainCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Число цепей изоляторов гирлянды на тросе", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Число цепей изоляторов гирлянды на тросе
	///</summary>
	public class GarlandTrosChainCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandTrosChainCount);

		}
	}


	[NVP_Manifest(
		Id = "C7104F1C-C19F-40AD-9287-81D82909146B", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Set_GarlandTrosChainCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Set_GarlandTrosChainCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Число цепей изоляторов гирлянды на тросе", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Число цепей изоляторов гирлянды на тросе
	///</summary>
	public class Set_GarlandTrosChainCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandTrosChainCount = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "46C94EDE-EECD-458E-856A-A9B7E363C192", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.GarlandTrosChainLayout", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "GarlandTrosChainLayout", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расположение цепей изоляторов гирлянды на тросе", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Расположение цепей изоляторов гирлянды на тросе
	///</summary>
	public class GarlandTrosChainLayout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandTrosChainLayout);

		}
	}


	[NVP_Manifest(
		Id = "617720B3-71C6-4A03-BEB0-7F5D095D8CAC", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Set_GarlandTrosChainLayout", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Set_GarlandTrosChainLayout", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расположение цепей изоляторов гирлянды на тросе", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Расположение цепей изоляторов гирлянды на тросе
	///</summary>
	public class Set_GarlandTrosChainLayout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandTrosChainLayout = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5BF9244E-6399-49D1-B811-7B64BF218D68", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.GarlandTrosChainDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "GarlandTrosChainDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расстояние между цепями изоляторов гирлянды на тросе", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Расстояние между цепями изоляторов гирлянды на тросе
	///</summary>
	public class GarlandTrosChainDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandTrosChainDistance);

		}
	}


	[NVP_Manifest(
		Id = "8D433736-FA87-4969-AA3C-C7C44129C554", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Set_GarlandTrosChainDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Set_GarlandTrosChainDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расстояние между цепями изоляторов гирлянды на тросе", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Расстояние между цепями изоляторов гирлянды на тросе
	///</summary>
	public class Set_GarlandTrosChainDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandTrosChainDistance = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "00C229C3-6293-4CB5-9E16-C0149E15CC0B", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.HeightMinNode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "HeightMinNode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method HeightMinNode", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///method HeightMinNode
	///</summary>
	public class HeightMinNode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HeightMinNode);

		}
	}


	[NVP_Manifest(
		Id = "4B4B27CE-809A-4CB6-B280-9B3178083CC6", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.numInLine", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "numInLine", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method numInLine", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///method numInLine
	///</summary>
	public class numInLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.numInLine);

		}
	}


	[NVP_Manifest(
		Id = "86452D31-617B-43C0-95AD-EB19652FCD1A", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.hasGarlands", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "hasGarlands", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method hasGarlands", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///method hasGarlands
	///</summary>
	public class hasGarlands : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.hasGarlands);

		}
	}


	[NVP_Manifest(
		Id = "A2EEA129-F195-4BC8-BAAB-6F9FFA84E8F0", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.GarlandOpticalEnabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "GarlandOpticalEnabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Имеются гирлянды на ВОК", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Имеются гирлянды на ВОК
	///</summary>
	public class GarlandOpticalEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandOpticalEnabled);

		}
	}


	[NVP_Manifest(
		Id = "BE9DC422-79E6-49EB-AAC1-9BD017092D81", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Set_GarlandOpticalEnabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Set_GarlandOpticalEnabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Имеются гирлянды на ВОК", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Имеются гирлянды на ВОК
	///</summary>
	public class Set_GarlandOpticalEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandOpticalEnabled = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "039DF1E1-D4D4-4C36-85B8-21222DF4E050", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.GarlandOpticalCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "GarlandOpticalCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Количество гирлянд на ВОК", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Количество гирлянд на ВОК
	///</summary>
	public class GarlandOpticalCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandOpticalCount);

		}
	}


	[NVP_Manifest(
		Id = "1A9D5B04-2CA2-4451-B92C-F3619877EFD9", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.GarlandOpticalInsulatorType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "GarlandOpticalInsulatorType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Тип изолятора", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Тип изолятора
	///</summary>
	public class GarlandOpticalInsulatorType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandOpticalInsulatorType);

		}
	}


	[NVP_Manifest(
		Id = "35D6F277-56B3-4AFF-AFB6-93E552981C4A", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Set_GarlandOpticalInsulatorType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Set_GarlandOpticalInsulatorType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Тип изолятора", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Тип изолятора
	///</summary>
	public class Set_GarlandOpticalInsulatorType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandOpticalInsulatorType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "CE227688-CBF5-4F95-B5EF-C5052499B3C5", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.GarlandOpticalLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "GarlandOpticalLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Длина гирлянды на ВОК", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Длина гирлянды на ВОК
	///</summary>
	public class GarlandOpticalLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandOpticalLength);

		}
	}


	[NVP_Manifest(
		Id = "414F5B63-4BB6-4FD1-9E49-5D4D60B73702", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Set_GarlandOpticalLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Set_GarlandOpticalLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Длина гирлянды на ВОК", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Длина гирлянды на ВОК
	///</summary>
	public class Set_GarlandOpticalLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandOpticalLength = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0D813906-1389-4558-9BD3-CFDD7664A5AB", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.GarlandOpticalWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "GarlandOpticalWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Масса гирлянды на ВОК", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Масса гирлянды на ВОК
	///</summary>
	public class GarlandOpticalWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandOpticalWeight);

		}
	}


	[NVP_Manifest(
		Id = "CA3B717E-4C08-4AD8-A8E8-3EA408C3F727", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Set_GarlandOpticalWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Set_GarlandOpticalWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Масса гирлянды на ВОК", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Масса гирлянды на ВОК
	///</summary>
	public class Set_GarlandOpticalWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandOpticalWeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DEF9AC29-4BA7-4CAA-9B6C-076ACF935479", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.GarlandOpticalDiameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "GarlandOpticalDiameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "мм)", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///мм)
	///</summary>
	public class GarlandOpticalDiameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandOpticalDiameter);

		}
	}


	[NVP_Manifest(
		Id = "78EE48BE-9DE8-410A-8EBD-F1DBD755D00A", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Set_GarlandOpticalDiameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Set_GarlandOpticalDiameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "мм)", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///мм)
	///</summary>
	public class Set_GarlandOpticalDiameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandOpticalDiameter = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "936E8225-C8A3-4410-91E4-D3ADE706BF11", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.GarlandOpticalChainCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "GarlandOpticalChainCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Число цепей изоляторов гирлянды на ВОК", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Число цепей изоляторов гирлянды на ВОК
	///</summary>
	public class GarlandOpticalChainCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandOpticalChainCount);

		}
	}


	[NVP_Manifest(
		Id = "DD8923A9-A8A0-46D2-95D1-7A5D4F435D9D", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Set_GarlandOpticalChainCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Set_GarlandOpticalChainCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Число цепей изоляторов гирлянды на ВОК", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Число цепей изоляторов гирлянды на ВОК
	///</summary>
	public class Set_GarlandOpticalChainCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandOpticalChainCount = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A3AEE17C-751E-4615-BB02-02B17C8B9C79", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.GarlandOpticalChainLayout", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "GarlandOpticalChainLayout", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расположение цепей изоляторов гирлянды на ВОК", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Расположение цепей изоляторов гирлянды на ВОК
	///</summary>
	public class GarlandOpticalChainLayout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandOpticalChainLayout);

		}
	}


	[NVP_Manifest(
		Id = "CED93076-81CD-4D67-ACDE-30DD82732575", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Set_GarlandOpticalChainLayout", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Set_GarlandOpticalChainLayout", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расположение цепей изоляторов гирлянды на ВОК", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Расположение цепей изоляторов гирлянды на ВОК
	///</summary>
	public class Set_GarlandOpticalChainLayout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandOpticalChainLayout = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F674E219-D59F-4BD4-8C75-662DF354CFCF", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.GarlandOpticalChainDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "GarlandOpticalChainDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расстояние между цепями изоляторов гирлянды на ВОК", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Расстояние между цепями изоляторов гирлянды на ВОК
	///</summary>
	public class GarlandOpticalChainDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandOpticalChainDistance);

		}
	}


	[NVP_Manifest(
		Id = "38D288B2-7E1A-4AD9-8129-8694338FBCD2", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Set_GarlandOpticalChainDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Set_GarlandOpticalChainDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расстояние между цепями изоляторов гирлянды на ВОК", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Расстояние между цепями изоляторов гирлянды на ВОК
	///</summary>
	public class Set_GarlandOpticalChainDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandOpticalChainDistance = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8C5DFAB7-9475-4AD7-9AFA-1FCFF989D3CF", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Phi", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Phi", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Phi", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///property Phi
	///</summary>
	public class Phi : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Phi);

		}
	}


	[NVP_Manifest(
		Id = "1FED15EA-FCA4-441E-A31F-00FA1A266EB1", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLAncerSketch.Set_Phi", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLAncerSketch", 
		NodeName = "Set_Phi", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Phi", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Phi
	///</summary>
	public class Set_Phi : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Phi = inputs[1].Value;
			return null;
		}
	}
}
