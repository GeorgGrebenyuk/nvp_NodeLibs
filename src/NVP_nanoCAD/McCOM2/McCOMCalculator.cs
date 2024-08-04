using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMcCOMCalculator Interface
///</summary>
namespace McCOM2.McCOMCalculator 
{

	[NVP_Manifest(
		Id = "D5EA1B3C-D6C9-448C-BFE9-B5E677CCCC39", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.McCOMCalculator.McCOMCalculator_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.McCOMCalculator", 
		NodeName = "_McCOMCalculator_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class McCOMCalculator_Constructor : INode 
	{
		public McCOM2.IMcCOMCalculator _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.IMcCOMCalculator;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "A6831137-0E40-467A-BB6D-80C23CF31064", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.McCOMCalculator.McCOMCalculator_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.McCOMCalculator", 
		NodeName = "_McCOMCalculator_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class McCOMCalculator_ConstructorCast : INode 
	{
		public McCOM2.IMcCOMCalculator _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.IMcCOMCalculator;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "576E0883-EB48-4841-A218-D99419452083", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.McCOMCalculator.OnCreate", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.McCOMCalculator", 
		NodeName = "OnCreate", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method OnCreate", 
		ViewType = "Modifier")]
	[NodeInput("McCOMCalculator", typeof(object))]
	[NodeInput("HWND", typeof(System.Object))]

	///<summary>
	///method OnCreate
	///</summary>
	public class OnCreate : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OnCreate(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5F4FA167-86B1-4AA8-AB21-5777875705FB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.McCOMCalculator.OnEdit", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.McCOMCalculator", 
		NodeName = "OnEdit", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method OnEdit", 
		ViewType = "Modifier")]
	[NodeInput("McCOMCalculator", typeof(object))]
	[NodeInput("HWND", typeof(System.Object))]

	///<summary>
	///method OnEdit
	///</summary>
	public class OnEdit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OnEdit(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "FD26AF35-34D4-4AF6-8376-A8B3DEF56038", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.McCOMCalculator.GetValueByName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.McCOMCalculator", 
		NodeName = "GetValueByName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method Value", 
		ViewType = "Data")]
	[NodeInput("McCOMCalculator", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///method Value
	///</summary>
	public class GetValueByName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetValueByName(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "8A7DE76D-B5BA-4471-8143-567035F62666", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.McCOMCalculator.PutValueByName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.McCOMCalculator", 
		NodeName = "PutValueByName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method Value", 
		ViewType = "Modifier")]
	[NodeInput("McCOMCalculator", typeof(object))]
	[NodeInput("Name", typeof(System.String))]
	[NodeInput("newVal", typeof(System.Object))]

	///<summary>
	///method Value
	///</summary>
	public class PutValueByName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PutValueByName(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "70E8E649-BD9B-45F5-BBF4-0BC9411BA188", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.McCOMCalculator.OnRead", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.McCOMCalculator", 
		NodeName = "OnRead", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method OnRead", 
		ViewType = "Modifier")]
	[NodeInput("McCOMCalculator", typeof(object))]
	[NodeInput("vArray", typeof(System.Object))]

	///<summary>
	///method OnRead
	///</summary>
	public class OnRead : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OnRead(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8533F6AC-4689-45EF-9FC2-D982B7C5E570", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.McCOMCalculator.OnWrite", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.McCOMCalculator", 
		NodeName = "OnWrite", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method OnWrite", 
		ViewType = "Data")]
	[NodeInput("McCOMCalculator", typeof(object))]

	///<summary>
	///method OnWrite
	///</summary>
	public class OnWrite : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OnWrite);

		}
	}


	[NVP_Manifest(
		Id = "60D62494-44F9-471B-AA15-3B221B0270C4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.McCOMCalculator.GetValueByIndex", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.McCOMCalculator", 
		NodeName = "GetValueByIndex", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method ValueByIndex", 
		ViewType = "Data")]
	[NodeInput("McCOMCalculator", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///method ValueByIndex
	///</summary>
	public class GetValueByIndex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetValueByIndex(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "706AA924-714F-4F71-8423-1B21DF2CA57A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.McCOMCalculator.PutValueByIndex", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.McCOMCalculator", 
		NodeName = "PutValueByIndex", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method ValueByIndex", 
		ViewType = "Modifier")]
	[NodeInput("McCOMCalculator", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]
	[NodeInput("newVal", typeof(System.Object))]

	///<summary>
	///method ValueByIndex
	///</summary>
	public class PutValueByIndex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PutValueByIndex(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0E9D4EC7-30B6-4E09-ADAD-DBA6167595D6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.McCOMCalculator.GetKeywords", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.McCOMCalculator", 
		NodeName = "GetKeywords", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method Keywords for report", 
		ViewType = "Modifier")]
	[NodeInput("McCOMCalculator", typeof(object))]
	[NodeInput("pManager", typeof(System.Object))]

	///<summary>
	///method Keywords for report
	///</summary>
	public class GetKeywords : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetKeywords(inputs[1].Value);
			return null;
		}
	}
}
