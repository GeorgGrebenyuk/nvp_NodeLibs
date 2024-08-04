using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Text formatting engine interface
///</summary>
namespace McCOM2.Text 
{

	[NVP_Manifest(
		Id = "C1A45376-EF28-4E9F-AFA6-EFDBBD905FA6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Text.Text_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Text", 
		NodeName = "_Text_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Text_Constructor : INode 
	{
		public McCOM2.IText _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.IText;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "A1014DC2-0A20-4338-A9B5-758DAD630E49", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Text.Text_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Text", 
		NodeName = "_Text_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Text_ConstructorCast : INode 
	{
		public McCOM2.IText _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.IText;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "2FD66859-AC0D-4663-90C6-E1B91C9B4D64", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Text.Text", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Text", 
		NodeName = "Text", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000576", 
		ViewType = "Data")]
	[NodeInput("Text", typeof(object))]

	///<summary>
	///0x00000576
	///</summary>
	public class Text : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Text);

		}
	}


	[NVP_Manifest(
		Id = "E87A04EC-3227-4BF3-AE3C-D98F4D260DCB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Text.Set_Text", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Text", 
		NodeName = "Set_Text", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000576", 
		ViewType = "Modifier")]
	[NodeInput("Text", typeof(object))]
	[NodeInput("pbstrText", typeof(System.String))]

	///<summary>
	///0x00000576
	///</summary>
	public class Set_Text : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Text = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "74242E85-FE20-418F-9616-DE54D063CCE2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Text.Raw", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Text", 
		NodeName = "Raw", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000573", 
		ViewType = "Data")]
	[NodeInput("Text", typeof(object))]

	///<summary>
	///0x00000573
	///</summary>
	public class Raw : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Raw);

		}
	}


	[NVP_Manifest(
		Id = "2F7361C8-D8AA-4BE1-96BE-A8A263EAA066", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Text.Set_Raw", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Text", 
		NodeName = "Set_Raw", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000573", 
		ViewType = "Modifier")]
	[NodeInput("Text", typeof(object))]
	[NodeInput("pbstrRawText", typeof(System.String))]

	///<summary>
	///0x00000573
	///</summary>
	public class Set_Raw : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Raw = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C0CBABA6-C43B-4C50-A7B6-C8B70F2706EB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Text.Native", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Text", 
		NodeName = "Native", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000572", 
		ViewType = "Data")]
	[NodeInput("Text", typeof(object))]

	///<summary>
	///0x00000572
	///</summary>
	public class Native : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Native);

		}
	}


	[NVP_Manifest(
		Id = "A5879B50-3BED-43FC-B160-5903235F533B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Text.Set_Native", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Text", 
		NodeName = "Set_Native", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000572", 
		ViewType = "Modifier")]
	[NodeInput("Text", typeof(object))]
	[NodeInput("pbstrNative", typeof(System.String))]

	///<summary>
	///0x00000572
	///</summary>
	public class Set_Native : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Native = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "340D036C-7012-4F41-8A8B-49B3277DEF66", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Text.Simple", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Text", 
		NodeName = "Simple", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000575", 
		ViewType = "Data")]
	[NodeInput("Text", typeof(object))]

	///<summary>
	///0x00000575
	///</summary>
	public class Simple : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Simple);

		}
	}


	[NVP_Manifest(
		Id = "A8F4B0E1-2B9C-4D7A-8222-1ACB4F829B8E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Text.RichEdit", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Text", 
		NodeName = "RichEdit", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000574", 
		ViewType = "Data")]
	[NodeInput("Text", typeof(object))]

	///<summary>
	///0x00000574
	///</summary>
	public class RichEdit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RichEdit);

		}
	}


	[NVP_Manifest(
		Id = "69945D60-7754-4B86-8755-0ADB22BAB4D7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Text.InsertSub", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Text", 
		NodeName = "InsertSub", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000056e", 
		ViewType = "Modifier")]
	[NodeInput("Text", typeof(object))]
	[NodeInput("bstrSubscript", typeof(System.String))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///0x0000056e
	///</summary>
	public class InsertSub : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.InsertSub(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "441A23CE-3331-46D7-A270-BCCC0B912BB6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Text.InsertSup", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Text", 
		NodeName = "InsertSup", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000056f", 
		ViewType = "Modifier")]
	[NodeInput("Text", typeof(object))]
	[NodeInput("bstrSuperscript", typeof(System.String))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///0x0000056f
	///</summary>
	public class InsertSup : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.InsertSup(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "48A0F57A-BD8A-4563-BD25-9F4D0ACEB1A6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Text.Insert", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Text", 
		NodeName = "Insert", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000056b", 
		ViewType = "Modifier")]
	[NodeInput("Text", typeof(object))]
	[NodeInput("bstrText", typeof(System.String))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///0x0000056b
	///</summary>
	public class Insert : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Insert(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8A8083AC-9BA0-4008-A471-BF4F407E42F5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Text.InsertNum", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Text", 
		NodeName = "InsertNum", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000056d", 
		ViewType = "Modifier")]
	[NodeInput("Text", typeof(object))]
	[NodeInput("rNumber", typeof(System.Double))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///0x0000056d
	///</summary>
	public class InsertNum : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.InsertNum(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B6552EC6-A306-439A-BCD1-158F516DCBBB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Text.InsertDivision", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Text", 
		NodeName = "InsertDivision", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000056c", 
		ViewType = "Modifier")]
	[NodeInput("Text", typeof(object))]
	[NodeInput("bstrUpper", typeof(System.String))]
	[NodeInput("bstrLower", typeof(System.String))]
	[NodeInput("vbLine", typeof(System.Object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///0x0000056c
	///</summary>
	public class InsertDivision : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.InsertDivision(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E9B26372-CCFF-4307-9BCF-940FC1506E08", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Text.Delete", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Text", 
		NodeName = "Delete", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000569", 
		ViewType = "Modifier")]
	[NodeInput("Text", typeof(object))]
	[NodeInput("idsFrom", typeof(System.Object))]
	[NodeInput("nCount", typeof(System.Object))]

	///<summary>
	///0x00000569
	///</summary>
	public class Delete : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Delete(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "40B0E051-020D-4246-82E6-5597215A66D2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Text.Split", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Text", 
		NodeName = "Split", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000571", 
		ViewType = "Data")]
	[NodeInput("Text", typeof(object))]
	[NodeInput("bstrDelimiter", typeof(System.String))]

	///<summary>
	///0x00000571
	///</summary>
	public class Split : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Split(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "31317258-70B2-427D-A507-31CF26E7798B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Text.Find", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Text", 
		NodeName = "Find", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000056a", 
		ViewType = "Data")]
	[NodeInput("Text", typeof(object))]
	[NodeInput("bstrSubstring", typeof(System.String))]
	[NodeInput("Start", typeof(System.Object))]
	[NodeInput("vbMatchCase", typeof(System.Object))]

	///<summary>
	///0x0000056a
	///</summary>
	public class Find : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Find(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "BBEF52D0-A901-47BA-A7C8-C935DB8CBACE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Text.Replace", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Text", 
		NodeName = "Replace", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000570", 
		ViewType = "Data")]
	[NodeInput("Text", typeof(object))]
	[NodeInput("bstrWhat", typeof(System.String))]
	[NodeInput("bstrWith", typeof(System.String))]
	[NodeInput("vbMatchCase", typeof(System.Object))]

	///<summary>
	///0x00000570
	///</summary>
	public class Replace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Replace(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}
}
