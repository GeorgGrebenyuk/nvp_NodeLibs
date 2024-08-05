using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrMpInsul Interface
///</summary>
namespace vCSViperCSObjComLib.WrMpInsul 
{

	[NVP_Manifest(
		Id = "B8D4ED1E-C734-4CB4-982A-5836689AB36F", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrMpInsul.WrMpInsul_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrMpInsul", 
		NodeName = "_WrMpInsul_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrMpInsul_Constructor : INode 
	{
		public vCSViperCSObjComLib.IWrMpInsul _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as vCSViperCSObjComLib.IWrMpInsul;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "308E1A17-D678-4430-9F49-9FAD0C82FE1A", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrMpInsul.WrMpInsul_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrMpInsul", 
		NodeName = "_WrMpInsul_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrMpInsul_ConstructorCast : INode 
	{
		public vCSViperCSObjComLib.IWrMpInsul _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as vCSViperCSObjComLib.IWrMpInsul;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "0AC054DF-E36C-4A42-A37E-1F73B2D72354", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrMpInsul.ViewMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrMpInsul", 
		NodeName = "ViewMode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ViewMode", 
		ViewType = "Data")]
	[NodeInput("WrMpInsul", typeof(object))]

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
		Id = "8636B570-9F08-4C70-B125-CD03176D010F", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrMpInsul.Set_ViewMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrMpInsul", 
		NodeName = "Set_ViewMode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ViewMode", 
		ViewType = "Modifier")]
	[NodeInput("WrMpInsul", typeof(object))]
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
		Id = "DC528F51-1E50-4FB9-98B3-7499E7337AFD", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrMpInsul.PipeCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrMpInsul", 
		NodeName = "PipeCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PipeCount", 
		ViewType = "Data")]
	[NodeInput("WrMpInsul", typeof(object))]

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
		Id = "160B80F5-9F03-4FEA-BF94-C66C8D66667C", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrMpInsul.GetPipe", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrMpInsul", 
		NodeName = "GetPipe", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method GetPipe", 
		ViewType = "Data")]
	[NodeInput("WrMpInsul", typeof(object))]
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
		Id = "6FF64C3B-57E5-4AF2-84D0-E0C2DAFE19AC", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrMpInsul.Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrMpInsul", 
		NodeName = "Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Thickness", 
		ViewType = "Data")]
	[NodeInput("WrMpInsul", typeof(object))]

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
		Id = "63F4A81B-FCE0-4C46-9B22-4501348085BB", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrMpInsul.Set_Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrMpInsul", 
		NodeName = "Set_Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Thickness", 
		ViewType = "Modifier")]
	[NodeInput("WrMpInsul", typeof(object))]
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
