using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Roughness of surface
///</summary>
namespace McCOM2.SymRoughness 
{

	[NVP_Manifest(
		Id = "8B02FE6C-61C7-4FBA-A02C-AB7FB16CCDF9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymRoughness.SymRoughness_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymRoughness", 
		NodeName = "_SymRoughness_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymRoughness_Constructor : INode 
	{
		public McCOM2.ISymRoughness _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymRoughness;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "7C7B608A-3F0B-45EF-8B9F-69DACAC87AE1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymRoughness.SymRoughness_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymRoughness", 
		NodeName = "_SymRoughness_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymRoughness_ConstructorCast : INode 
	{
		public McCOM2.ISymRoughness _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymRoughness;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "EE517D96-1EAA-4929-969A-0EDE5A4B8414", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymRoughness.TextPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymRoughness", 
		NodeName = "TextPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000002f2", 
		ViewType = "Data")]
	[NodeInput("SymRoughness", typeof(object))]

	///<summary>
	///0x000002f2
	///</summary>
	public class TextPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextPosition);

		}
	}


	[NVP_Manifest(
		Id = "3286DC4D-9CEF-46B1-B162-4F35A3C7E8A5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymRoughness.Set_TextPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymRoughness", 
		NodeName = "Set_TextPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000002f2", 
		ViewType = "Modifier")]
	[NodeInput("SymRoughness", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x000002f2
	///</summary>
	public class Set_TextPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextPosition = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6B311943-E049-4600-AB18-8AE5B1FCF573", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymRoughness.Angle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymRoughness", 
		NodeName = "Angle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000002dc", 
		ViewType = "Data")]
	[NodeInput("SymRoughness", typeof(object))]

	///<summary>
	///0x000002dc
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
		Id = "89EA59DB-6625-464C-A06B-08C2A3ACDDBB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymRoughness.Set_Angle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymRoughness", 
		NodeName = "Set_Angle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000002dc", 
		ViewType = "Modifier")]
	[NodeInput("SymRoughness", typeof(object))]
	[NodeInput("prValue", typeof(System.Double))]

	///<summary>
	///0x000002dc
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
		Id = "A2DD3BA4-D92E-4FE7-977D-0F5D180465E0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymRoughness.Direction", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymRoughness", 
		NodeName = "Direction", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000002e3", 
		ViewType = "Data")]
	[NodeInput("SymRoughness", typeof(object))]

	///<summary>
	///0x000002e3
	///</summary>
	public class Direction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Direction);

		}
	}


	[NVP_Manifest(
		Id = "94039EBD-A247-4D8E-955A-FCF202735E95", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymRoughness.Set_Direction", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymRoughness", 
		NodeName = "Set_Direction", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000002e3", 
		ViewType = "Modifier")]
	[NodeInput("SymRoughness", typeof(object))]
	[NodeInput("prDirection", typeof(System.Object))]

	///<summary>
	///0x000002e3
	///</summary>
	public class Set_Direction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Direction = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DD020E66-6B61-45EA-A637-5C7495D822E0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymRoughness.Technology", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymRoughness", 
		NodeName = "Technology", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000002f1", 
		ViewType = "Data")]
	[NodeInput("SymRoughness", typeof(object))]

	///<summary>
	///0x000002f1
	///</summary>
	public class Technology : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Technology);

		}
	}


	[NVP_Manifest(
		Id = "7915628B-D823-4740-B3C4-903C0CA47868", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymRoughness.Set_Technology", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymRoughness", 
		NodeName = "Set_Technology", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000002f1", 
		ViewType = "Modifier")]
	[NodeInput("SymRoughness", typeof(object))]
	[NodeInput("pbstrValue", typeof(System.String))]

	///<summary>
	///0x000002f1
	///</summary>
	public class Set_Technology : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Technology = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9C663C70-18D6-42AF-AF47-883FE719D1C5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymRoughness.Parameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymRoughness", 
		NodeName = "Parameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000002ed", 
		ViewType = "Data")]
	[NodeInput("SymRoughness", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///0x000002ed
	///</summary>
	public class Parameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Parameter(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "E455ABD1-5217-453A-A18D-1433035CCBEF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymRoughness.Set_Parameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymRoughness", 
		NodeName = "Set_Parameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000002ed", 
		ViewType = "Modifier")]
	[NodeInput("SymRoughness", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]
	[NodeInput("pbstrValue", typeof(System.String))]

	///<summary>
	///0x000002ed
	///</summary>
	public class Set_Parameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Parameter[inputs[1]] = inputs[2];
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7D3A30A0-2066-4E99-86A9-B78F7F716EAE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymRoughness.Default", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymRoughness", 
		NodeName = "Default", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000002e1", 
		ViewType = "Data")]
	[NodeInput("SymRoughness", typeof(object))]

	///<summary>
	///0x000002e1
	///</summary>
	public class Default : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Default);

		}
	}


	[NVP_Manifest(
		Id = "5DC9DEF3-2CF1-469E-AD3E-224116B19878", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymRoughness.Set_Default", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymRoughness", 
		NodeName = "Set_Default", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000002e1", 
		ViewType = "Modifier")]
	[NodeInput("SymRoughness", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x000002e1
	///</summary>
	public class Set_Default : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Default = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "079B330F-3880-44C7-8E8A-B7A162D3E792", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymRoughness.Closed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymRoughness", 
		NodeName = "Closed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000002df", 
		ViewType = "Data")]
	[NodeInput("SymRoughness", typeof(object))]

	///<summary>
	///0x000002df
	///</summary>
	public class Closed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Closed);

		}
	}


	[NVP_Manifest(
		Id = "99AB0264-B973-49DC-B9BD-9173CEF38D43", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymRoughness.Set_Closed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymRoughness", 
		NodeName = "Set_Closed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000002df", 
		ViewType = "Modifier")]
	[NodeInput("SymRoughness", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x000002df
	///</summary>
	public class Set_Closed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Closed = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0D50377F-02C9-4E7A-9876-AA1EA799E058", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymRoughness.ProcessingType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymRoughness", 
		NodeName = "ProcessingType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000002ef", 
		ViewType = "Data")]
	[NodeInput("SymRoughness", typeof(object))]

	///<summary>
	///0x000002ef
	///</summary>
	public class ProcessingType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ProcessingType);

		}
	}


	[NVP_Manifest(
		Id = "433A9B51-E7D9-4ABD-AE7F-AAA2F8EDCCB6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymRoughness.Set_ProcessingType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymRoughness", 
		NodeName = "Set_ProcessingType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000002ef", 
		ViewType = "Modifier")]
	[NodeInput("SymRoughness", typeof(object))]
	[NodeInput("McCOM2.RoughnessProcessingType", typeof(System.Object))]

	///<summary>
	///0x000002ef
	///</summary>
	public class Set_ProcessingType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ProcessingType = ((McCOM2.RoughnessProcessingType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "412BD92F-7EED-4305-899A-3BFA5359E2C2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymRoughness.Frame", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymRoughness", 
		NodeName = "Frame", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000002e4", 
		ViewType = "Data")]
	[NodeInput("SymRoughness", typeof(object))]

	///<summary>
	///0x000002e4
	///</summary>
	public class Frame : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Frame);

		}
	}


	[NVP_Manifest(
		Id = "CEEBA03D-C6C8-4C28-AFD2-F078CF03A9E6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymRoughness.Set_Frame", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymRoughness", 
		NodeName = "Set_Frame", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000002e4", 
		ViewType = "Modifier")]
	[NodeInput("SymRoughness", typeof(object))]
	[NodeInput("ppFrame", typeof(System.Object))]

	///<summary>
	///0x000002e4
	///</summary>
	public class Set_Frame : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Frame = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0E601A19-D85B-41CB-8B5A-B57AC29E5BDA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymRoughness.ProcessingDir", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymRoughness", 
		NodeName = "ProcessingDir", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000002ee", 
		ViewType = "Data")]
	[NodeInput("SymRoughness", typeof(object))]

	///<summary>
	///0x000002ee
	///</summary>
	public class ProcessingDir : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ProcessingDir);

		}
	}


	[NVP_Manifest(
		Id = "CE9B0C7D-5F13-4016-B0F6-BF4A17052B81", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymRoughness.Set_ProcessingDir", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymRoughness", 
		NodeName = "Set_ProcessingDir", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000002ee", 
		ViewType = "Modifier")]
	[NodeInput("SymRoughness", typeof(object))]
	[NodeInput("McCOM2.RoughnessProcessingDirection", typeof(System.Object))]

	///<summary>
	///0x000002ee
	///</summary>
	public class Set_ProcessingDir : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ProcessingDir = ((McCOM2.RoughnessProcessingDirection)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "29864EAF-D1F0-48A4-9C15-02F966D1B782", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymRoughness.Leaders", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymRoughness", 
		NodeName = "Leaders", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000002e7", 
		ViewType = "Data")]
	[NodeInput("SymRoughness", typeof(object))]

	///<summary>
	///0x000002e7
	///</summary>
	public class Leaders : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Leaders);

		}
	}
}
