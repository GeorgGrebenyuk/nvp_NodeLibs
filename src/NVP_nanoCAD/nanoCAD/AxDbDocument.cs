using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Provides access to database without document.
///</summary>
namespace nanoCAD.AxDbDocument 
{

	[NVP_Manifest(
		Id = "213E96E0-4424-4CB1-9AD8-3DFE56B8C2E6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.AxDbDocument.AxDbDocument_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.AxDbDocument", 
		NodeName = "_AxDbDocument_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AxDbDocument_Constructor : INode 
	{
		public nanoCAD.IAxDbDocument _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.IAxDbDocument;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "9A8E2510-9511-43F6-BD74-F7715F981885", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.AxDbDocument.AxDbDocument_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.AxDbDocument", 
		NodeName = "_AxDbDocument_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AxDbDocument_ConstructorCast : INode 
	{
		public nanoCAD.IAxDbDocument _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.IAxDbDocument;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "D8548F8D-D3CB-4D81-AC29-7F7338964B29", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.AxDbDocument.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.AxDbDocument", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the name of the document", 
		ViewType = "Data")]
	[NodeInput("AxDbDocument", typeof(object))]

	///<summary>
	///Specifies the name of the document
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
		Id = "D785D4DB-FE32-4107-BCAB-DEBA2FDA2850", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.AxDbDocument.Set_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.AxDbDocument", 
		NodeName = "Set_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the name of the document", 
		ViewType = "Modifier")]
	[NodeInput("AxDbDocument", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Specifies the name of the document
	///</summary>
	public class Set_Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Name = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C7E928AB-4992-4E84-802F-2A2E93A62B49", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.AxDbDocument.Open", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.AxDbDocument", 
		NodeName = "Open", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Opens document.", 
		ViewType = "Modifier")]
	[NodeInput("AxDbDocument", typeof(object))]
	[NodeInput("FileName", typeof(System.String))]
	[NodeInput("Password", typeof(System.Object))]

	///<summary>
	///Opens document.
	///</summary>
	public class Open : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Open(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A5F86D5A-5EE4-4196-A23E-37E195B28F59", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.AxDbDocument.Save", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.AxDbDocument", 
		NodeName = "Save", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Saves document.", 
		ViewType = "Modifier")]
	[NodeInput("AxDbDocument", typeof(object))]

	///<summary>
	///Saves document.
	///</summary>
	public class Save : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Save();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B3DDC5D1-2D2E-4BEE-AFE5-8606ACFC4790", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.AxDbDocument.SaveAs", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.AxDbDocument", 
		NodeName = "SaveAs", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Saves document with new name.", 
		ViewType = "Modifier")]
	[NodeInput("AxDbDocument", typeof(object))]
	[NodeInput("FileName", typeof(System.String))]
	[NodeInput("vSecurityParams", typeof(System.Object))]

	///<summary>
	///Saves document with new name.
	///</summary>
	public class SaveAs : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SaveAs(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B34FF219-FEF1-4EA8-8121-A209C81926C7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.AxDbDocument.DxfIn", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.AxDbDocument", 
		NodeName = "DxfIn", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "DxfIn.", 
		ViewType = "Modifier")]
	[NodeInput("AxDbDocument", typeof(object))]
	[NodeInput("FileName", typeof(System.String))]
	[NodeInput("LogFileName", typeof(System.Object))]

	///<summary>
	///DxfIn.
	///</summary>
	public class DxfIn : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DxfIn(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7FEAF453-CDE5-440E-9866-8E722BBFFED1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.AxDbDocument.DxfOut", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.AxDbDocument", 
		NodeName = "DxfOut", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "DxfOut.", 
		ViewType = "Modifier")]
	[NodeInput("AxDbDocument", typeof(object))]
	[NodeInput("FileName", typeof(System.String))]
	[NodeInput("precision", typeof(System.Object))]
	[NodeInput("SaveThumbnailImage", typeof(System.Object))]

	///<summary>
	///DxfOut.
	///</summary>
	public class DxfOut : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DxfOut(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C759B850-D44D-4B64-BE2A-12C137C77026", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.AxDbDocument.Application", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.AxDbDocument", 
		NodeName = "Application", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Retrieves an Application object", 
		ViewType = "Data")]
	[NodeInput("AxDbDocument", typeof(object))]

	///<summary>
	///Retrieves an Application object
	///</summary>
	public class Application : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Application);

		}
	}


	[NVP_Manifest(
		Id = "C073A3CB-C240-4BBD-895B-7E34D3FA3E2B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.AxDbDocument.Database", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.AxDbDocument", 
		NodeName = "Database", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Retrieves an database object", 
		ViewType = "Data")]
	[NodeInput("AxDbDocument", typeof(object))]

	///<summary>
	///Retrieves an database object
	///</summary>
	public class Database : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Database);

		}
	}
}
