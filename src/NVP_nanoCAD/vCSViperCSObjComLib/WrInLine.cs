using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrInLine Interface
///</summary>
namespace vCSViperCSObjComLib.WrInLine 
{

	[NVP_Manifest(
		Id = "401797C2-3218-4FCF-B1DB-D400E364F62F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.WrInLine_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "_WrInLine_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrInLine_Constructor : INode 
	{
		public vCSViperCSObjComLib.IWrInLine _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as vCSViperCSObjComLib.IWrInLine;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "D94B4F9B-D9E7-406A-B18F-8B8054306931", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.WrInLine_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "_WrInLine_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrInLine_ConstructorCast : INode 
	{
		public vCSViperCSObjComLib.IWrInLine _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as vCSViperCSObjComLib.IWrInLine;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "D71DF194-4DB8-4D2F-90CB-B7C60F301534", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.PipeLayer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "PipeLayer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Слой по умолчанию", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///Слой по умолчанию
	///</summary>
	public class PipeLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PipeLayer);

		}
	}


	[NVP_Manifest(
		Id = "913900FC-A205-401B-9B4F-37F2EEDE3115", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_PipeLayer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_PipeLayer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Слой по умолчанию", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Слой по умолчанию
	///</summary>
	public class Set_PipeLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PipeLayer = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "ECB6AD2B-163C-40F9-A516-C68A6411E61B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

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
		Id = "0A7636A2-6312-4BBB-B66B-2C220A8F84D0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
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
		Id = "F257AC07-92FA-47BA-A187-B7ADA743CBB9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.OwnerSegId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "OwnerSegId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property OwnerSegId", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property OwnerSegId
	///</summary>
	public class OwnerSegId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OwnerSegId);

		}
	}


	[NVP_Manifest(
		Id = "416FEA8B-7C38-4A4B-AC4D-BF4433FFFE8E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_OwnerSegId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_OwnerSegId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property OwnerSegId", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property OwnerSegId
	///</summary>
	public class Set_OwnerSegId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OwnerSegId = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "CBC5291C-AC70-4A7A-A52D-7B9413943ED3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.ViewMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "ViewMode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ViewMode", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property ViewMode
	///</summary>
	public class ViewMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ViewMode);

		}
	}


	[NVP_Manifest(
		Id = "75AF2AEE-4131-4882-9D51-8A6F663E88FD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_ViewMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_ViewMode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ViewMode", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property ViewMode
	///</summary>
	public class Set_ViewMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ViewMode = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "73F997F9-26BF-4ACE-8C39-EE375A930907", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.ElementAxis", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "ElementAxis", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ElementAxis", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property ElementAxis
	///</summary>
	public class ElementAxis : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ElementAxis);

		}
	}


	[NVP_Manifest(
		Id = "B4C3E6D6-352B-4744-8348-8DA40DA22B7E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_ElementAxis", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_ElementAxis", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ElementAxis", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property ElementAxis
	///</summary>
	public class Set_ElementAxis : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ElementAxis = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8E6EED51-78EF-4C31-B244-A643659FB4B8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Reverse", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Reverse", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Reverse", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Reverse
	///</summary>
	public class Reverse : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Reverse);

		}
	}


	[NVP_Manifest(
		Id = "7C611910-BCF9-4B87-AE1F-0074C245B2FE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_Reverse", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_Reverse", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Reverse", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Reverse
	///</summary>
	public class Set_Reverse : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Reverse = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2892193B-1748-4E06-B383-011B8C7D0ECD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Angle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Angle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Angle", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Angle
	///</summary>
	public class Angle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Angle);

		}
	}


	[NVP_Manifest(
		Id = "5B2E96F1-E0E4-4E72-82C9-B94CD33EB752", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_Angle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_Angle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Angle", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Angle
	///</summary>
	public class Set_Angle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Angle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8D2E6D3F-BD53-4D3C-9010-C50CBFBDAA77", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.TeeType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "TeeType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property TeeType", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property TeeType
	///</summary>
	public class TeeType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TeeType);

		}
	}


	[NVP_Manifest(
		Id = "1411E0F9-6885-4670-814B-7778F10E3C1E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_TeeType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_TeeType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property TeeType", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property TeeType
	///</summary>
	public class Set_TeeType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TeeType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "364ABDBB-8AB5-4131-B978-3609D51C5DA3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.FlowDependence", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "FlowDependence", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property FlowDependence", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property FlowDependence
	///</summary>
	public class FlowDependence : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FlowDependence);

		}
	}


	[NVP_Manifest(
		Id = "4FA740E2-323C-44C3-9252-321FAA27A21E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_FlowDependence", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_FlowDependence", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property FlowDependence", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property FlowDependence
	///</summary>
	public class Set_FlowDependence : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FlowDependence = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "FDC1E027-708D-42B0-8A70-A037D31FA070", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.FixAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "FixAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property FixAngle", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property FixAngle
	///</summary>
	public class FixAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FixAngle);

		}
	}


	[NVP_Manifest(
		Id = "8B69CC18-C99A-4211-911F-C8F06EA8E7A1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_FixAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_FixAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property FixAngle", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property FixAngle
	///</summary>
	public class Set_FixAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FixAngle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E8563735-88AF-4C61-BA10-4CC502CF8C1D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Part_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Part_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Name", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Part_Name
	///</summary>
	public class Part_Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Name);

		}
	}


	[NVP_Manifest(
		Id = "78EB1985-F07E-4FCF-8BEF-9A39BEA37ABF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_Part_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_Part_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Name", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Name
	///</summary>
	public class Set_Part_Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Name = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0B4CC97C-F8A3-4CA1-87FF-D306B42CD921", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Part_Tag", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Part_Tag", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Tag", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Part_Tag
	///</summary>
	public class Part_Tag : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Tag);

		}
	}


	[NVP_Manifest(
		Id = "D51B6112-DDA8-403F-AF2D-0958C8FD0819", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_Part_Tag", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_Part_Tag", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Tag", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Tag
	///</summary>
	public class Set_Part_Tag : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Tag = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9729EBED-EEBB-47A3-ACE5-A1CE47C6A28F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Part_Manufacturer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Part_Manufacturer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Manufacturer", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Part_Manufacturer
	///</summary>
	public class Part_Manufacturer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Manufacturer);

		}
	}


	[NVP_Manifest(
		Id = "4FBCD2C2-7B49-48D7-B771-D1A737DF39FD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_Part_Manufacturer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_Part_Manufacturer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Manufacturer", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Manufacturer
	///</summary>
	public class Set_Part_Manufacturer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Manufacturer = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "54A18111-299A-44DC-84F8-6F3593D024D0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Part_Standard", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Part_Standard", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Standard", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Part_Standard
	///</summary>
	public class Part_Standard : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Standard);

		}
	}


	[NVP_Manifest(
		Id = "FCEE5A85-C683-4150-851D-2ECCE65A746A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_Part_Standard", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_Part_Standard", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Standard", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Standard
	///</summary>
	public class Set_Part_Standard : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Standard = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "626398A4-ABFA-4A4E-B22A-1D727F86C091", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Part_Refdrawing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Part_Refdrawing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Refdrawing", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Part_Refdrawing
	///</summary>
	public class Part_Refdrawing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Refdrawing);

		}
	}


	[NVP_Manifest(
		Id = "C7EB775F-0F45-494D-9162-08EA40C223B6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_Part_Refdrawing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_Part_Refdrawing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Refdrawing", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Refdrawing
	///</summary>
	public class Set_Part_Refdrawing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Refdrawing = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "022A44C3-1F3C-486F-BE21-10065EAF83CC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Part_Material", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Part_Material", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Material", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Part_Material
	///</summary>
	public class Part_Material : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Material);

		}
	}


	[NVP_Manifest(
		Id = "59DF6C23-4974-4410-B7D4-2FF0BDE87349", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_Part_Material", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_Part_Material", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Material", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Material
	///</summary>
	public class Set_Part_Material : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Material = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4A2F6205-1DA4-4460-9AD6-E8B8B12737DC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Part_Material_Standard", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Part_Material_Standard", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Material_Standard", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Part_Material_Standard
	///</summary>
	public class Part_Material_Standard : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Material_Standard);

		}
	}


	[NVP_Manifest(
		Id = "A5AD7666-F034-40F1-9E26-AC06144A5776", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_Part_Material_Standard", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_Part_Material_Standard", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Material_Standard", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Material_Standard
	///</summary>
	public class Set_Part_Material_Standard : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Material_Standard = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7823F301-8F8A-4D76-93A3-78298811A76B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Part_Weight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Part_Weight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Weight", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Part_Weight
	///</summary>
	public class Part_Weight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Weight);

		}
	}


	[NVP_Manifest(
		Id = "C01A4C32-9633-4233-AFFF-B56FB4D5122D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_Part_Weight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_Part_Weight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Weight", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Weight
	///</summary>
	public class Set_Part_Weight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Weight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3F9875EE-316C-44EC-8E26-383FF1D27B0D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Part_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Part_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Comment", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Part_Comment
	///</summary>
	public class Part_Comment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Comment);

		}
	}


	[NVP_Manifest(
		Id = "F3CBC0EC-0607-4D06-8B45-994394623E9B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_Part_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_Part_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Comment", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Comment
	///</summary>
	public class Set_Part_Comment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Comment = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "753392DC-E394-4123-A68F-3E2AE2AB3FA7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.PointStart", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "PointStart", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Начальная точка", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///Начальная точка
	///</summary>
	public class PointStart : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PointStart);

		}
	}


	[NVP_Manifest(
		Id = "A0E34A6C-6A85-4BC3-8367-E7C26AB7DAE5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.PointEnd", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "PointEnd", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Конечная точка", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///Конечная точка
	///</summary>
	public class PointEnd : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PointEnd);

		}
	}


	[NVP_Manifest(
		Id = "66500D53-23C1-47FE-B050-AEA720CDCF7B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.OrderOnLine", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "OrderOnLine", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Номер на линии", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///Номер на линии
	///</summary>
	public class OrderOnLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OrderOnLine);

		}
	}


	[NVP_Manifest(
		Id = "F1BDD294-7F8B-4F07-9D56-AD4A7DA4A07C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Insulation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Insulation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Объект изоляции", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///Объект изоляции
	///</summary>
	public class Insulation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Insulation);

		}
	}


	[NVP_Manifest(
		Id = "971CCA79-0534-4E8F-B247-8B0CB7D76A66", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_Insulation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_Insulation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Объект изоляции", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Объект изоляции
	///</summary>
	public class Set_Insulation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Insulation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D97F25E9-5D09-477E-A66F-F257CFE09E66", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.HasInsulation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "HasInsulation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Наличие изоляции", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///Наличие изоляции
	///</summary>
	public class HasInsulation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasInsulation);

		}
	}


	[NVP_Manifest(
		Id = "5638DD35-4EA8-412B-9471-8AB37FA8411D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.PartPipe_PN", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "PartPipe_PN", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_PN", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property PartPipe_PN
	///</summary>
	public class PartPipe_PN : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PartPipe_PN);

		}
	}


	[NVP_Manifest(
		Id = "5EF23DCF-BCA9-4958-9504-E247CF540B08", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_PartPipe_PN", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_PartPipe_PN", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_PN", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property PartPipe_PN
	///</summary>
	public class Set_PartPipe_PN : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PartPipe_PN = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9A4CA495-E5E4-47D7-B83B-C2D9F522A70A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.PartPipe_DN", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "PartPipe_DN", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_DN", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property PartPipe_DN
	///</summary>
	public class PartPipe_DN : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PartPipe_DN);

		}
	}


	[NVP_Manifest(
		Id = "0918E4B1-97C2-444F-9CCB-289EF4ABA08C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_PartPipe_DN", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_PartPipe_DN", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_DN", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property PartPipe_DN
	///</summary>
	public class Set_PartPipe_DN : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PartPipe_DN = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F6F47ED7-E5C8-4CBE-8E5A-D38A8AED29AD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.PartPipe_Diam", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "PartPipe_Diam", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_Diam", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property PartPipe_Diam
	///</summary>
	public class PartPipe_Diam : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PartPipe_Diam);

		}
	}


	[NVP_Manifest(
		Id = "B3BA11E5-DE34-4CCF-94D4-F9D904BF5F49", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_PartPipe_Diam", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_PartPipe_Diam", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_Diam", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property PartPipe_Diam
	///</summary>
	public class Set_PartPipe_Diam : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PartPipe_Diam = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "79FB21D4-9858-4BE6-8162-CD1705820A03", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.PartPipe_DN1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "PartPipe_DN1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_DN1", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property PartPipe_DN1
	///</summary>
	public class PartPipe_DN1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PartPipe_DN1);

		}
	}


	[NVP_Manifest(
		Id = "4ED4FEF1-4B4A-43C5-B94B-133B1A5FB40A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_PartPipe_DN1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_PartPipe_DN1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_DN1", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property PartPipe_DN1
	///</summary>
	public class Set_PartPipe_DN1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PartPipe_DN1 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3407B61A-3BFC-4121-BDBF-3DD08709CF2F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.PartPipe_Diam1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "PartPipe_Diam1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_Diam1", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property PartPipe_Diam1
	///</summary>
	public class PartPipe_Diam1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PartPipe_Diam1);

		}
	}


	[NVP_Manifest(
		Id = "E208C3BD-8EA0-4F99-9937-9DA804F63F1E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_PartPipe_Diam1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_PartPipe_Diam1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_Diam1", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property PartPipe_Diam1
	///</summary>
	public class Set_PartPipe_Diam1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PartPipe_Diam1 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A525BD2E-EDEF-4414-94A3-BA71F74FFB76", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.PartPipe_DN2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "PartPipe_DN2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_DN2", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property PartPipe_DN2
	///</summary>
	public class PartPipe_DN2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PartPipe_DN2);

		}
	}


	[NVP_Manifest(
		Id = "EBD3F705-DDA3-4ED7-A6A2-9F0270CEE2B4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_PartPipe_DN2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_PartPipe_DN2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_DN2", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property PartPipe_DN2
	///</summary>
	public class Set_PartPipe_DN2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PartPipe_DN2 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "52C2B406-6ABA-480F-AFC8-F4BC079706C4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.PartPipe_Diam2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "PartPipe_Diam2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_Diam2", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property PartPipe_Diam2
	///</summary>
	public class PartPipe_Diam2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PartPipe_Diam2);

		}
	}


	[NVP_Manifest(
		Id = "5EC814FB-5412-4CAC-BEB7-1975F785D534", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_PartPipe_Diam2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_PartPipe_Diam2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_Diam2", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property PartPipe_Diam2
	///</summary>
	public class Set_PartPipe_Diam2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PartPipe_Diam2 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A6C713D9-551F-4A94-A092-A0D034606929", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.PartPipe_Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "PartPipe_Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_Thickness", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property PartPipe_Thickness
	///</summary>
	public class PartPipe_Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PartPipe_Thickness);

		}
	}


	[NVP_Manifest(
		Id = "28163D4F-1F06-4B67-BFFF-17BB0ED7E258", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_PartPipe_Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_PartPipe_Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_Thickness", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property PartPipe_Thickness
	///</summary>
	public class Set_PartPipe_Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PartPipe_Thickness = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "391A0231-A826-4005-96CF-128E0CD23CC8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.PartPipe_Thickness1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "PartPipe_Thickness1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_Thickness1", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property PartPipe_Thickness1
	///</summary>
	public class PartPipe_Thickness1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PartPipe_Thickness1);

		}
	}


	[NVP_Manifest(
		Id = "4920625D-3E78-4DBF-8445-D76F94CB5F5D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_PartPipe_Thickness1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_PartPipe_Thickness1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_Thickness1", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property PartPipe_Thickness1
	///</summary>
	public class Set_PartPipe_Thickness1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PartPipe_Thickness1 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B70B317C-8862-43DA-9644-8886F58F2D22", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.PartPipe_Thickness2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "PartPipe_Thickness2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_Thickness2", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property PartPipe_Thickness2
	///</summary>
	public class PartPipe_Thickness2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PartPipe_Thickness2);

		}
	}


	[NVP_Manifest(
		Id = "2DF0A789-F70D-41FC-8E88-486A5F9905F8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_PartPipe_Thickness2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_PartPipe_Thickness2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_Thickness2", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property PartPipe_Thickness2
	///</summary>
	public class Set_PartPipe_Thickness2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PartPipe_Thickness2 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5F1B9769-0472-45B3-AC5A-61894A12A474", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.PartPipe_Length", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "PartPipe_Length", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_Length", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property PartPipe_Length
	///</summary>
	public class PartPipe_Length : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PartPipe_Length);

		}
	}


	[NVP_Manifest(
		Id = "DB9E516D-B114-4E8A-AD87-4148ED4D95E4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_PartPipe_Length", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_PartPipe_Length", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_Length", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property PartPipe_Length
	///</summary>
	public class Set_PartPipe_Length : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PartPipe_Length = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "AF42C212-293D-48C5-978D-95A185DA9A0B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Part_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Part_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Group", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Part_Group
	///</summary>
	public class Part_Group : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Group);

		}
	}


	[NVP_Manifest(
		Id = "1E3FCB08-FD67-4B9F-A563-DB4A2464566D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_Part_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_Part_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Group", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Group
	///</summary>
	public class Set_Part_Group : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Group = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3EE0B81D-0FE8-48C7-82AD-516DC9364533", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Part_Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Part_Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Type", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Part_Type
	///</summary>
	public class Part_Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Type);

		}
	}


	[NVP_Manifest(
		Id = "43FFC18D-C797-4A5F-B495-E66CAFA6C240", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_Part_Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_Part_Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Type", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Type
	///</summary>
	public class Set_Part_Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Type = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "61FB8D43-CA06-43E1-A0CB-F18FC686462A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Part_Reference", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Part_Reference", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Reference", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Part_Reference
	///</summary>
	public class Part_Reference : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Reference);

		}
	}


	[NVP_Manifest(
		Id = "C9F3338A-E820-414A-BAAE-F09BABFC08AB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_Part_Reference", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_Part_Reference", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Reference", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Reference
	///</summary>
	public class Set_Part_Reference : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Reference = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D6C05275-0D8F-4EE0-83F2-42919EDF7CDF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Part_Weight_Netto", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Part_Weight_Netto", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Weight_Netto", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Part_Weight_Netto
	///</summary>
	public class Part_Weight_Netto : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Weight_Netto);

		}
	}


	[NVP_Manifest(
		Id = "6A78ED81-F0B4-4403-9D02-2262246182A5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_Part_Weight_Netto", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_Part_Weight_Netto", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Weight_Netto", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Weight_Netto
	///</summary>
	public class Set_Part_Weight_Netto : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Weight_Netto = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B14F8709-74CA-403C-A9F9-008A47F4095D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Part_Weight_Bruto", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Part_Weight_Bruto", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Weight_Bruto", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Part_Weight_Bruto
	///</summary>
	public class Part_Weight_Bruto : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Weight_Bruto);

		}
	}


	[NVP_Manifest(
		Id = "48228AFD-37D1-4D55-856D-F973757A1B49", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_Part_Weight_Bruto", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_Part_Weight_Bruto", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Weight_Bruto", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Weight_Bruto
	///</summary>
	public class Set_Part_Weight_Bruto : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Weight_Bruto = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7EAD9B56-19D7-4941-B078-84DCFB4F428D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Part_Insulation_Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Part_Insulation_Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Insulation_Thickness", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Part_Insulation_Thickness
	///</summary>
	public class Part_Insulation_Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Insulation_Thickness);

		}
	}


	[NVP_Manifest(
		Id = "057EE753-1332-4545-9EFE-8661858AC185", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_Part_Insulation_Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_Part_Insulation_Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Insulation_Thickness", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Part_Insulation_Thickness
	///</summary>
	public class Set_Part_Insulation_Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Insulation_Thickness = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "FBF980D4-EB9B-4145-A983-41A7B2AB11CF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Part_Insulation_Disableview", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Part_Insulation_Disableview", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Insulation_Disableview", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Part_Insulation_Disableview
	///</summary>
	public class Part_Insulation_Disableview : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Insulation_Disableview);

		}
	}


	[NVP_Manifest(
		Id = "CAA92D28-8760-4852-9474-00C3D979F1EF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_Part_Insulation_Disableview", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_Part_Insulation_Disableview", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Insulation_Disableview", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Part_Insulation_Disableview
	///</summary>
	public class Set_Part_Insulation_Disableview : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Insulation_Disableview = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6BA533F8-DB10-479B-8F57-E69A7C4D59D1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Axis_Insulation_Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Axis_Insulation_Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Axis_Insulation_Thickness", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Axis_Insulation_Thickness
	///</summary>
	public class Axis_Insulation_Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Axis_Insulation_Thickness);

		}
	}


	[NVP_Manifest(
		Id = "DF22EDDB-9C20-487B-B7EC-AE4D34442D7B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_Axis_Insulation_Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_Axis_Insulation_Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Axis_Insulation_Thickness", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Axis_Insulation_Thickness
	///</summary>
	public class Set_Axis_Insulation_Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Axis_Insulation_Thickness = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "62963EED-E7E8-48D3-88B1-47EB6B03A8EF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Axis_Insulation_Disableview", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Axis_Insulation_Disableview", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Axis_Insulation_Disableview", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Axis_Insulation_Disableview
	///</summary>
	public class Axis_Insulation_Disableview : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Axis_Insulation_Disableview);

		}
	}


	[NVP_Manifest(
		Id = "4D7D2F90-B6F1-43F6-8DAB-7DE4190CCB66", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_Axis_Insulation_Disableview", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_Axis_Insulation_Disableview", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Axis_Insulation_Disableview", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Axis_Insulation_Disableview
	///</summary>
	public class Set_Axis_Insulation_Disableview : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Axis_Insulation_Disableview = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F3E207CF-3CFF-49CF-9AD3-3C5ED2A0F2E1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Axis_Insulation_LineInsulation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Axis_Insulation_LineInsulation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Axis_Insulation_LineInsulation", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Axis_Insulation_LineInsulation
	///</summary>
	public class Axis_Insulation_LineInsulation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Axis_Insulation_LineInsulation);

		}
	}


	[NVP_Manifest(
		Id = "28A793FC-7B08-4475-AC6C-682F17625CFB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_Axis_Insulation_LineInsulation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_Axis_Insulation_LineInsulation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Axis_Insulation_LineInsulation", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Axis_Insulation_LineInsulation
	///</summary>
	public class Set_Axis_Insulation_LineInsulation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Axis_Insulation_LineInsulation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "975F9A16-9AD3-4AB6-BB98-B27BFC01AA85", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Axis_Insulation_LineTrace", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Axis_Insulation_LineTrace", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Axis_Insulation_LineTrace", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Axis_Insulation_LineTrace
	///</summary>
	public class Axis_Insulation_LineTrace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Axis_Insulation_LineTrace);

		}
	}


	[NVP_Manifest(
		Id = "FA925BFA-991B-4C0A-9F49-CF1D3C221DC2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_Axis_Insulation_LineTrace", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_Axis_Insulation_LineTrace", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Axis_Insulation_LineTrace", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Axis_Insulation_LineTrace
	///</summary>
	public class Set_Axis_Insulation_LineTrace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Axis_Insulation_LineTrace = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DE0FA413-DD6B-4B07-8E1E-561848B9F6D6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.GetAxisParamValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "GetAxisParamValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method GetAxisParamValue", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("ParameterName", typeof(System.String))]

	///<summary>
	///method GetAxisParamValue
	///</summary>
	public class GetAxisParamValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetAxisParamValue(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "44A280DD-E0B7-4297-B4F3-D7AB87BC9EF1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Explication_Include", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Explication_Include", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Include", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Explication_Include
	///</summary>
	public class Explication_Include : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Explication_Include);

		}
	}


	[NVP_Manifest(
		Id = "E590437D-F204-4565-ABB9-4941F087465B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_Explication_Include", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_Explication_Include", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Include", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Explication_Include
	///</summary>
	public class Set_Explication_Include : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Explication_Include = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "FE83D9EE-150D-485E-BA4B-810EE24D7F64", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Explication_Number", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Explication_Number", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Number", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Explication_Number
	///</summary>
	public class Explication_Number : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Explication_Number);

		}
	}


	[NVP_Manifest(
		Id = "D0B56CC4-A6E3-4414-B860-625E90B582BB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_Explication_Number", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_Explication_Number", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Number", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Explication_Number
	///</summary>
	public class Set_Explication_Number : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Explication_Number = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B5D690DE-A811-40BC-9CE7-A0D49F367CA3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Explication_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Explication_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Group", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Explication_Group
	///</summary>
	public class Explication_Group : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Explication_Group);

		}
	}


	[NVP_Manifest(
		Id = "A5F459AB-3E32-4F39-81E4-5AD3246FDED0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_Explication_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_Explication_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Group", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Explication_Group
	///</summary>
	public class Set_Explication_Group : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Explication_Group = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6F4CD7E5-B51E-4B77-A99D-BBA4E5639D58", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Explication_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Explication_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Comment", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Explication_Comment
	///</summary>
	public class Explication_Comment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Explication_Comment);

		}
	}


	[NVP_Manifest(
		Id = "0079F533-5D45-4826-8B4B-AC4ADF0A3FE0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_Explication_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_Explication_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Comment", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Explication_Comment
	///</summary>
	public class Set_Explication_Comment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Explication_Comment = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "BC90ACC4-9089-4AAF-8394-AEFF2975D46A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Bom_Include", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Bom_Include", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Include", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Bom_Include
	///</summary>
	public class Bom_Include : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Bom_Include);

		}
	}


	[NVP_Manifest(
		Id = "35AC9E85-11BD-4896-9516-4EE97D8C2468", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_Bom_Include", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_Bom_Include", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Include", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Bom_Include
	///</summary>
	public class Set_Bom_Include : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Bom_Include = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "67288563-BFAE-4AA8-87DB-D73CC72176D1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Bom_Number", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Bom_Number", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Number", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Bom_Number
	///</summary>
	public class Bom_Number : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Bom_Number);

		}
	}


	[NVP_Manifest(
		Id = "B4C3F54E-394F-4E11-A8D0-4A8CBFBFD9CF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_Bom_Number", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_Bom_Number", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Number", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Bom_Number
	///</summary>
	public class Set_Bom_Number : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Bom_Number = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3807ECFC-F824-40B6-B2BE-0C41C8E4A8ED", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Bom_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Bom_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Group", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Bom_Group
	///</summary>
	public class Bom_Group : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Bom_Group);

		}
	}


	[NVP_Manifest(
		Id = "FFFA92B0-A871-4D4D-9CF1-46ECD212E2C3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_Bom_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_Bom_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Group", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Bom_Group
	///</summary>
	public class Set_Bom_Group : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Bom_Group = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9C905A8C-5BB9-4A9E-AD83-A29487F75BF7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Bom_Qty", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Bom_Qty", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Qty", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Bom_Qty
	///</summary>
	public class Bom_Qty : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Bom_Qty);

		}
	}


	[NVP_Manifest(
		Id = "D4BFBABC-CBD9-43B7-8696-8913F44E35A8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_Bom_Qty", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_Bom_Qty", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Qty", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Bom_Qty
	///</summary>
	public class Set_Bom_Qty : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Bom_Qty = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "92D32303-CBC1-4FDE-8B71-6C2AAF72FCB6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Bom_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Bom_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Comment", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Bom_Comment
	///</summary>
	public class Bom_Comment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Bom_Comment);

		}
	}


	[NVP_Manifest(
		Id = "B0FC517A-D592-43B2-83B3-C4A6B0FCB21E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_Bom_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_Bom_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Comment", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Bom_Comment
	///</summary>
	public class Set_Bom_Comment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Bom_Comment = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "354386AD-B334-4843-945F-ED513278B42E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.BranchAxis", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "BranchAxis", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property BranchAxis", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property BranchAxis
	///</summary>
	public class BranchAxis : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BranchAxis);

		}
	}


	[NVP_Manifest(
		Id = "C5295939-2655-49BB-AF52-0DC9ECF00F5C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.HasBranch", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "HasBranch", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property HasBranch", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property HasBranch
	///</summary>
	public class HasBranch : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasBranch);

		}
	}


	[NVP_Manifest(
		Id = "7AE0E025-9BD1-4B97-A2A2-8F810CCB6CBE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.PartPipe_Lock", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "PartPipe_Lock", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property LockComponent", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property LockComponent
	///</summary>
	public class PartPipe_Lock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PartPipe_Lock);

		}
	}


	[NVP_Manifest(
		Id = "CD655EEF-57B3-4799-9D71-11E518A943E8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.Set_PartPipe_Lock", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "Set_PartPipe_Lock", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property LockComponent", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property LockComponent
	///</summary>
	public class Set_PartPipe_Lock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PartPipe_Lock = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B072A8B1-A30A-40FE-BCD3-05DC7764E84D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.GetArea", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "GetArea", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method GetArea", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("Element", typeof(System.Object))]
	[NodeInput("bodyOptions", typeof(System.Object))]

	///<summary>
	///method GetArea
	///</summary>
	public class GetArea : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetArea(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "5EFA8201-41D7-4A68-9989-E9B23E349F2E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInLine.GetVolume", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInLine", 
		NodeName = "GetVolume", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method GetVolume", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("Element", typeof(System.Object))]
	[NodeInput("bodyOptions", typeof(System.Object))]

	///<summary>
	///method GetVolume
	///</summary>
	public class GetVolume : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetVolume(inputs[1].Value,inputs[2].Value));

		}
	}
}
