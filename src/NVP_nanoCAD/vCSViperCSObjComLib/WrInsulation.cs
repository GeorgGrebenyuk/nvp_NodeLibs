using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrInsulation Interface
///</summary>
namespace vCSViperCSObjComLib.WrInsulation 
{

	[NVP_Manifest(
		Id = "89306F26-3CBA-47B8-A43B-BBAEFC8C2D92", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInsulation.WrInsulation_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInsulation", 
		NodeName = "_WrInsulation_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrInsulation_Constructor : INode 
	{
		public vCSViperCSObjComLib.IWrInsulation _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as vCSViperCSObjComLib.IWrInsulation;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "C7B023F7-06C6-42FD-B9C0-22DE3BC021B3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInsulation.WrInsulation_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInsulation", 
		NodeName = "_WrInsulation_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrInsulation_ConstructorCast : INode 
	{
		public vCSViperCSObjComLib.IWrInsulation _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as vCSViperCSObjComLib.IWrInsulation;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "7194EBC8-A0BD-4CA4-BA4C-917168C0D6B5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInsulation.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInsulation", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметры", 
		ViewType = "Data")]
	[NodeInput("WrInsulation", typeof(object))]

	///<summary>
	///Параметры
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
		Id = "BDAF1021-7A14-4E28-B219-05D870B3D625", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInsulation.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInsulation", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметры", 
		ViewType = "Modifier")]
	[NodeInput("WrInsulation", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Параметры
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
		Id = "45E13AB8-9A6B-4983-A4EE-15A48A47A932", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInsulation.ViewMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInsulation", 
		NodeName = "ViewMode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ViewMode", 
		ViewType = "Data")]
	[NodeInput("WrInsulation", typeof(object))]

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
		Id = "06E8B562-546B-4FD7-8266-412CEF6F2D51", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInsulation.Set_ViewMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInsulation", 
		NodeName = "Set_ViewMode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ViewMode", 
		ViewType = "Modifier")]
	[NodeInput("WrInsulation", typeof(object))]
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
		Id = "3138D47F-840F-46CA-9E92-B7B4866A8E15", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInsulation.PipeCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInsulation", 
		NodeName = "PipeCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PipeCount", 
		ViewType = "Data")]
	[NodeInput("WrInsulation", typeof(object))]

	///<summary>
	///property PipeCount
	///</summary>
	public class PipeCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PipeCount);

		}
	}


	[NVP_Manifest(
		Id = "3214E111-6E3A-46C8-8C7C-404964D2D441", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInsulation.GetPipe", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInsulation", 
		NodeName = "GetPipe", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method GetPipe", 
		ViewType = "Data")]
	[NodeInput("WrInsulation", typeof(object))]
	[NodeInput("index", typeof(System.Object))]

	///<summary>
	///method GetPipe
	///</summary>
	public class GetPipe : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPipe(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "BBF1F990-352A-4815-98C2-70DA196076A8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInsulation.Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInsulation", 
		NodeName = "Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Thickness", 
		ViewType = "Data")]
	[NodeInput("WrInsulation", typeof(object))]

	///<summary>
	///property Thickness
	///</summary>
	public class Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Thickness);

		}
	}


	[NVP_Manifest(
		Id = "1C157D3E-D89B-47EB-897C-609357BEF25E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrInsulation.Set_Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrInsulation", 
		NodeName = "Set_Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Thickness", 
		ViewType = "Modifier")]
	[NodeInput("WrInsulation", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Thickness
	///</summary>
	public class Set_Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Thickness = inputs[1].Value;
			return null;
		}
	}
}
