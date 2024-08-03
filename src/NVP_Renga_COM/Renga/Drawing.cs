using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.Drawing 
{

	[NVP_Manifest(
		Id = "0CE4B655-163F-46C9-9710-4CBDBBB56BD9", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Drawing.Drawing_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Drawing", 
		NodeName = "_Drawing_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Drawing_Constructor : INode 
	{
		public Renga.IDrawing _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IDrawing;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "4E2DB7AB-0892-4A73-9C05-70DEE47C267C", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Drawing.Drawing_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Drawing", 
		NodeName = "_Drawing_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Drawing_ConstructorCast : INode 
	{
		public Renga.IDrawing _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IDrawing;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "BB6FF0ED-7BFE-4FFA-BF49-97D2DEDDC2DA", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Drawing.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Drawing", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Drawing", typeof(object))]

	///<summary>
	///
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
		Id = "4A121387-5978-491F-B0CF-E0404897B367", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Drawing.ExportToDxf", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Drawing", 
		NodeName = "ExportToDxf", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Drawing", typeof(object))]
	[NodeInput("FilePath", typeof(System.String))]
	[NodeInput("Renga.AutocadVersion", typeof(System.Object))]
	[NodeInput("overwrite", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class ExportToDxf : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ExportToDxf(inputs[1].Value,((Renga.AutocadVersion)inputs[2].Value),inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "E79CCE4B-F82F-4076-BF66-ABF113D3FF0C", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Drawing.ExportToDwg", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Drawing", 
		NodeName = "ExportToDwg", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Drawing", typeof(object))]
	[NodeInput("FilePath", typeof(System.String))]
	[NodeInput("Renga.AutocadVersion", typeof(System.Object))]
	[NodeInput("overwrite", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class ExportToDwg : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ExportToDwg(inputs[1].Value,((Renga.AutocadVersion)inputs[2].Value),inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "89A6EE3E-70B9-4C60-B846-A6D5F6FCE107", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Drawing.Id", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Drawing", 
		NodeName = "Id", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Drawing", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Id : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Id);

		}
	}


	[NVP_Manifest(
		Id = "76128FF9-BF1D-423C-9AD1-F813A1DB45BC", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Drawing.IdS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Drawing", 
		NodeName = "IdS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Drawing", typeof(object))]

	///<summary>
	///
	///</summary>
	public class IdS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IdS);

		}
	}


	[NVP_Manifest(
		Id = "97D9AB63-B70D-444B-9B37-95493191D620", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Drawing.ExportToPdf", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Drawing", 
		NodeName = "ExportToPdf", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Drawing", typeof(object))]
	[NodeInput("FilePath", typeof(System.String))]
	[NodeInput("overwrite", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class ExportToPdf : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ExportToPdf(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "CCCFFD86-663C-4ACF-9B4E-B962C7393A9B", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Drawing.ExportToOpenXps", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Drawing", 
		NodeName = "ExportToOpenXps", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Drawing", typeof(object))]
	[NodeInput("FilePath", typeof(System.String))]
	[NodeInput("overwrite", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class ExportToOpenXps : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ExportToOpenXps(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "EDD1B678-D16A-4FFC-AA71-DCDCABD91DDE", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Drawing.TitleBlockInstanceCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Drawing", 
		NodeName = "TitleBlockInstanceCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Drawing", typeof(object))]

	///<summary>
	///
	///</summary>
	public class TitleBlockInstanceCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TitleBlockInstanceCount);

		}
	}


	[NVP_Manifest(
		Id = "9FF75A44-7D89-4402-90F7-03F8EA70B316", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Drawing.GetTitleBlockInstance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Drawing", 
		NodeName = "GetTitleBlockInstance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Drawing", typeof(object))]
	[NodeInput("index", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class GetTitleBlockInstance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetTitleBlockInstance(inputs[1].Value));

		}
	}
}
