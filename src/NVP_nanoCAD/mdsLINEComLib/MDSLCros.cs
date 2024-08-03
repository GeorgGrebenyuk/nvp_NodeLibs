using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Пересечение
///</summary>
namespace mdsLINEComLib.MDSLCros 
{

	[NVP_Manifest(
		Id = "132A9546-C3D2-44A6-BD0D-291F20137DC3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLCros.MDSLCros_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLCros", 
		NodeName = "_MDSLCros_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLCros_Constructor : INode 
	{
		public mdsLINEComLib.IMDSLCros _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsLINEComLib.IMDSLCros;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "E4499F53-443A-45F9-B595-38BACA396E6F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLCros.MDSLCros_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLCros", 
		NodeName = "_MDSLCros_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLCros_ConstructorCast : INode 
	{
		public mdsLINEComLib.IMDSLCros _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsLINEComLib.IMDSLCros;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "50426D23-F04A-4666-9754-6C4CC891E524", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLCros.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLCros", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

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
		Id = "9AB3A2D2-0B0F-4460-AD81-2173C825080C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLCros.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLCros", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Modifier")]
	[NodeInput("MDSLCros", typeof(object))]
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
		Id = "9E569A30-3796-4BCA-81FF-6B65FB7763FE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLCros.Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLCros", 
		NodeName = "Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Position", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

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
		Id = "D1B983C6-58A3-4DE1-B5AF-7513C3DF56F2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLCros.Set_Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLCros", 
		NodeName = "Set_Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Position", 
		ViewType = "Modifier")]
	[NodeInput("MDSLCros", typeof(object))]
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
		Id = "728729B1-D782-4BFC-97CF-F544DCABCF29", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLCros.HeightMark", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLCros", 
		NodeName = "HeightMark", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property HeightMark", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

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
		Id = "E3615511-EEF8-4709-8C79-5A24CC31D44B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLCros.Set_HeightMark", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLCros", 
		NodeName = "Set_HeightMark", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property HeightMark", 
		ViewType = "Modifier")]
	[NodeInput("MDSLCros", typeof(object))]
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
		Id = "D57FFA1F-FD2B-432B-8F6C-FA78A5BA50F3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLCros.DistGroundMark", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLCros", 
		NodeName = "DistGroundMark", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DistGroundMark", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

	///<summary>
	///property DistGroundMark
	///</summary>
	public class DistGroundMark : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DistGroundMark);

		}
	}


	[NVP_Manifest(
		Id = "3E8C0458-B6C7-48CD-8A5F-90C1D20428CD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLCros.NearLeft", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLCros", 
		NodeName = "NearLeft", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property NearLeft", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

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
		Id = "DF02DD95-CB92-44B4-B367-79721E3E64F2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLCros.Set_NearLeft", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLCros", 
		NodeName = "Set_NearLeft", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property NearLeft", 
		ViewType = "Modifier")]
	[NodeInput("MDSLCros", typeof(object))]
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
		Id = "2DC9D883-B96C-4B2F-AE4B-2ADAFE7E500A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLCros.NearRight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLCros", 
		NodeName = "NearRight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property NearRight", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

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
		Id = "DBB15F95-A4C4-444B-8741-1B9595B6F4CD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLCros.Set_NearRight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLCros", 
		NodeName = "Set_NearRight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property NearRight", 
		ViewType = "Modifier")]
	[NodeInput("MDSLCros", typeof(object))]
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
		Id = "48A74AC3-EDEA-4BF5-A13F-D9633AB19DFF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLCros.MarkType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLCros", 
		NodeName = "MarkType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property MarkType", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

	///<summary>
	///property MarkType
	///</summary>
	public class MarkType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MarkType);

		}
	}


	[NVP_Manifest(
		Id = "CF351504-817A-4AF3-958B-7716C9037DA6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLCros.Set_MarkType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLCros", 
		NodeName = "Set_MarkType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property MarkType", 
		ViewType = "Modifier")]
	[NodeInput("MDSLCros", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property MarkType
	///</summary>
	public class Set_MarkType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MarkType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B0544F98-2271-4ACB-9B86-92E10BC6033D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLCros.PosLineMark", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLCros", 
		NodeName = "PosLineMark", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PosLineType", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

	///<summary>
	///property PosLineType
	///</summary>
	public class PosLineMark : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PosLineMark);

		}
	}


	[NVP_Manifest(
		Id = "ED6750EE-527C-4DE8-B0C9-0E6006BE19CB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLCros.Set_PosLineMark", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLCros", 
		NodeName = "Set_PosLineMark", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PosLineType", 
		ViewType = "Modifier")]
	[NodeInput("MDSLCros", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property PosLineType
	///</summary>
	public class Set_PosLineMark : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PosLineMark = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "48A2B58A-F558-40C7-8D74-05A950B8B7DE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLCros.Scalability", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLCros", 
		NodeName = "Scalability", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Scalability", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

	///<summary>
	///property Scalability
	///</summary>
	public class Scalability : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Scalability);

		}
	}


	[NVP_Manifest(
		Id = "EE8DA9F2-4507-4CC2-8878-CA0EC406ECD6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLCros.Set_Scalability", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLCros", 
		NodeName = "Set_Scalability", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Scalability", 
		ViewType = "Modifier")]
	[NodeInput("MDSLCros", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Scalability
	///</summary>
	public class Set_Scalability : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Scalability = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "19B5F36E-EBA8-4EBA-98B6-2082C2E3055D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLCros.NameBTR", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLCros", 
		NodeName = "NameBTR", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property NameBTR", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

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
		Id = "76ED7E03-4BAA-4187-AA5C-15FAD2AFEE4F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLCros.Set_NameBTR", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLCros", 
		NodeName = "Set_NameBTR", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property NameBTR", 
		ViewType = "Modifier")]
	[NodeInput("MDSLCros", typeof(object))]
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
		Id = "1800CDC2-8289-43E5-A250-AD6DA474845A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLCros.ScaleH_BTR", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLCros", 
		NodeName = "ScaleH_BTR", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ScaleH_BTR", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

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
		Id = "315B27CB-D782-4B7B-8960-9FE03707C28C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLCros.Set_ScaleH_BTR", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLCros", 
		NodeName = "Set_ScaleH_BTR", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ScaleH_BTR", 
		ViewType = "Modifier")]
	[NodeInput("MDSLCros", typeof(object))]
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
		Id = "3DA7ACF9-1952-4B2D-B316-34AA547C47B0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLCros.ScaleV_BTR", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLCros", 
		NodeName = "ScaleV_BTR", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ScaleV_BTR", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

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
		Id = "E9920079-779C-4BEA-83EF-B69C569799FC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLCros.Set_ScaleV_BTR", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLCros", 
		NodeName = "Set_ScaleV_BTR", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ScaleV_BTR", 
		ViewType = "Modifier")]
	[NodeInput("MDSLCros", typeof(object))]
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
		Id = "DADFEB09-D51D-4711-B6E4-FD6C6890D8F8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLCros.Radius", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLCros", 
		NodeName = "Radius", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Radius", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

	///<summary>
	///property Radius
	///</summary>
	public class Radius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Radius);

		}
	}


	[NVP_Manifest(
		Id = "B65E5B28-FDCA-458B-94F0-5A981BB767BD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLCros.Set_Radius", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLCros", 
		NodeName = "Set_Radius", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Radius", 
		ViewType = "Modifier")]
	[NodeInput("MDSLCros", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Radius
	///</summary>
	public class Set_Radius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Radius = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E3C57FAD-5B60-4B57-9683-C3BFA497C083", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLCros.DXLeft", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLCros", 
		NodeName = "DXLeft", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DXLeft", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

	///<summary>
	///property DXLeft
	///</summary>
	public class DXLeft : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DXLeft);

		}
	}


	[NVP_Manifest(
		Id = "AE777E2B-50E1-4E4F-A482-2FD3E620170A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLCros.Set_DXLeft", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLCros", 
		NodeName = "Set_DXLeft", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DXLeft", 
		ViewType = "Modifier")]
	[NodeInput("MDSLCros", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property DXLeft
	///</summary>
	public class Set_DXLeft : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DXLeft = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "22315076-50F3-4089-BBC0-8CAFE38D0DE1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLCros.DXRight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLCros", 
		NodeName = "DXRight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DXRight", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

	///<summary>
	///property DXRight
	///</summary>
	public class DXRight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DXRight);

		}
	}


	[NVP_Manifest(
		Id = "7AC779B7-71F6-4B08-ADD0-BA2A2B1DB8DD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLCros.Set_DXRight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLCros", 
		NodeName = "Set_DXRight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property DXRight", 
		ViewType = "Modifier")]
	[NodeInput("MDSLCros", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property DXRight
	///</summary>
	public class Set_DXRight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DXRight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B391CC48-E072-4E22-AA80-E58F65BABC6E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLCros.BindType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLCros", 
		NodeName = "BindType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property BindType", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

	///<summary>
	///property BindType
	///</summary>
	public class BindType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BindType);

		}
	}


	[NVP_Manifest(
		Id = "5D6FC1A5-9413-4F41-A613-FE3AB5CB4A82", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLCros.Set_BindType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLCros", 
		NodeName = "Set_BindType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property BindType", 
		ViewType = "Modifier")]
	[NodeInput("MDSLCros", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property BindType
	///</summary>
	public class Set_BindType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BindType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "19D40DBA-605F-46F0-9E7E-F225BFC6E56D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLCros.wireInSpan", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLCros", 
		NodeName = "wireInSpan", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method wireInSpan", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

	///<summary>
	///method wireInSpan
	///</summary>
	public class wireInSpan : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.wireInSpan);

		}
	}


	[NVP_Manifest(
		Id = "8BB9798A-4E24-4D95-A13D-6C1076312FDD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLCros.prevTower", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLCros", 
		NodeName = "prevTower", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method prevTower", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

	///<summary>
	///method prevTower
	///</summary>
	public class prevTower : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.prevTower);

		}
	}


	[NVP_Manifest(
		Id = "31F34E5C-BBC3-4B57-AEC4-95E678BF4CCF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLCros.nextTower", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLCros", 
		NodeName = "nextTower", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method nextTower", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

	///<summary>
	///method nextTower
	///</summary>
	public class nextTower : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.nextTower);

		}
	}


	[NVP_Manifest(
		Id = "E11D92E6-7A36-4698-848E-F8D924653154", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLCros.isPrevTower", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLCros", 
		NodeName = "isPrevTower", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method isPrevTower", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

	///<summary>
	///method isPrevTower
	///</summary>
	public class isPrevTower : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.isPrevTower);

		}
	}


	[NVP_Manifest(
		Id = "2472C779-4262-4C5A-8565-8E80A907E4E9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLCros.isNextTower", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLCros", 
		NodeName = "isNextTower", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method isNextTower", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

	///<summary>
	///method isNextTower
	///</summary>
	public class isNextTower : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.isNextTower);

		}
	}


	[NVP_Manifest(
		Id = "F93F0989-FCFF-4833-B3D3-1BD3B9E3CF4F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLCros.isThereWireInSpan", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLCros", 
		NodeName = "isThereWireInSpan", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method isThereWireInSpan", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

	///<summary>
	///method isThereWireInSpan
	///</summary>
	public class isThereWireInSpan : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.isThereWireInSpan);

		}
	}


	[NVP_Manifest(
		Id = "ABC84132-5C74-4A17-99F4-BD622D3CCC96", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLCros.TransientNumber", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLCros", 
		NodeName = "TransientNumber", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method TransientNumber", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

	///<summary>
	///method TransientNumber
	///</summary>
	public class TransientNumber : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TransientNumber);

		}
	}


	[NVP_Manifest(
		Id = "92CE9AEB-4EC3-4116-8F16-40A6BA1E97AB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLCros.owner", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLCros", 
		NodeName = "owner", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method owner", 
		ViewType = "Data")]
	[NodeInput("MDSLCros", typeof(object))]

	///<summary>
	///method owner
	///</summary>
	public class owner : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.owner);

		}
	}
}
