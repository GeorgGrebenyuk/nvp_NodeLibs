using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Cutted surface index mark
///</summary>
namespace McCOM2.SymDimNumber 
{

	[NVP_Manifest(
		Id = "C9AE2DBF-4199-47E1-A09D-D85B48A43C12", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimNumber.SymDimNumber_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimNumber", 
		NodeName = "_SymDimNumber_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymDimNumber_Constructor : INode 
	{
		public McCOM2.ISymDimNumber _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymDimNumber;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "7DD7CB4D-331C-4A42-9F5E-7C0F5EB06199", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimNumber.SymDimNumber_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimNumber", 
		NodeName = "_SymDimNumber_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymDimNumber_ConstructorCast : INode 
	{
		public McCOM2.ISymDimNumber _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymDimNumber;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "3D1E265E-9C04-45F4-AF7F-FFFF68C2745B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimNumber.TextPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimNumber", 
		NodeName = "TextPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000001d9", 
		ViewType = "Data")]
	[NodeInput("SymDimNumber", typeof(object))]

	///<summary>
	///0x000001d9
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
		Id = "50D85D85-CE64-44C2-ACD9-69747D0EF384", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimNumber.Set_TextPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimNumber", 
		NodeName = "Set_TextPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000001d9", 
		ViewType = "Modifier")]
	[NodeInput("SymDimNumber", typeof(object))]
	[NodeInput("pvResult", typeof(System.Object))]

	///<summary>
	///0x000001d9
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
		Id = "1D0BA996-0B13-4406-BEC2-2F49D07EB0D6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimNumber.Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimNumber", 
		NodeName = "Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000001d6", 
		ViewType = "Data")]
	[NodeInput("SymDimNumber", typeof(object))]

	///<summary>
	///0x000001d6
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
		Id = "7C573BC6-0CAE-48C1-AA03-3D25105BE096", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimNumber.Set_Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimNumber", 
		NodeName = "Set_Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000001d6", 
		ViewType = "Modifier")]
	[NodeInput("SymDimNumber", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x000001d6
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
		Id = "39D48E08-6D79-4778-80B9-94C94F6F381E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimNumber.Index", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimNumber", 
		NodeName = "Index", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000001cf", 
		ViewType = "Data")]
	[NodeInput("SymDimNumber", typeof(object))]

	///<summary>
	///0x000001cf
	///</summary>
	public class Index : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Index);

		}
	}


	[NVP_Manifest(
		Id = "B6693A4A-0FEA-48D0-A5F2-398DA195583C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimNumber.Set_Index", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimNumber", 
		NodeName = "Set_Index", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000001cf", 
		ViewType = "Modifier")]
	[NodeInput("SymDimNumber", typeof(object))]
	[NodeInput("pResult", typeof(System.Object))]

	///<summary>
	///0x000001cf
	///</summary>
	public class Set_Index : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Index = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "97EE32F7-7063-4340-9CA6-157470BA2C21", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimNumber.Autonum", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimNumber", 
		NodeName = "Autonum", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000001c8", 
		ViewType = "Data")]
	[NodeInput("SymDimNumber", typeof(object))]

	///<summary>
	///0x000001c8
	///</summary>
	public class Autonum : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Autonum);

		}
	}


	[NVP_Manifest(
		Id = "A04956FE-C333-4EC8-BDE4-2676D5BE71B1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimNumber.Set_Autonum", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimNumber", 
		NodeName = "Set_Autonum", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000001c8", 
		ViewType = "Modifier")]
	[NodeInput("SymDimNumber", typeof(object))]
	[NodeInput("pvbResult", typeof(System.Object))]

	///<summary>
	///0x000001c8
	///</summary>
	public class Set_Autonum : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Autonum = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0225036F-DC76-4481-BD70-8A2D06D7ED83", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimNumber.Text", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimNumber", 
		NodeName = "Text", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000001d8", 
		ViewType = "Data")]
	[NodeInput("SymDimNumber", typeof(object))]

	///<summary>
	///0x000001d8
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
		Id = "292EE685-4DE5-4029-B546-FC6807A542D1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimNumber.Set_Text", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimNumber", 
		NodeName = "Set_Text", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000001d8", 
		ViewType = "Modifier")]
	[NodeInput("SymDimNumber", typeof(object))]
	[NodeInput("pbstrResult", typeof(System.String))]

	///<summary>
	///0x000001d8
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
		Id = "EB33FCC1-F531-47F2-9591-4079699518F1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimNumber.DisplayText", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimNumber", 
		NodeName = "DisplayText", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000001cd", 
		ViewType = "Data")]
	[NodeInput("SymDimNumber", typeof(object))]

	///<summary>
	///0x000001cd
	///</summary>
	public class DisplayText : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DisplayText);

		}
	}


	[NVP_Manifest(
		Id = "E80A8DF7-A2BB-4458-BCE9-72A0C128D416", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimNumber.Align", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimNumber", 
		NodeName = "Align", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000001c0", 
		ViewType = "Modifier")]
	[NodeInput("SymDimNumber", typeof(object))]
	[NodeInput("vBounds", typeof(System.Object))]

	///<summary>
	///0x000001c0
	///</summary>
	public class Align : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Align(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5665C963-ADBC-431C-B416-64D14C441E27", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimNumber.Arrow", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimNumber", 
		NodeName = "Arrow", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000001c7", 
		ViewType = "Data")]
	[NodeInput("SymDimNumber", typeof(object))]

	///<summary>
	///0x000001c7
	///</summary>
	public class Arrow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Arrow);

		}
	}


	[NVP_Manifest(
		Id = "69402722-7943-4C38-BA9B-CB21208A1B5F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimNumber.Set_Arrow", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimNumber", 
		NodeName = "Set_Arrow", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000001c7", 
		ViewType = "Modifier")]
	[NodeInput("SymDimNumber", typeof(object))]
	[NodeInput("McCOM2.ArrowType", typeof(System.Object))]

	///<summary>
	///0x000001c7
	///</summary>
	public class Set_Arrow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Arrow = ((McCOM2.ArrowType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C095A556-2727-4785-9954-33F2B150153D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimNumber.Owner", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimNumber", 
		NodeName = "Owner", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005b7", 
		ViewType = "Data")]
	[NodeInput("SymDimNumber", typeof(object))]

	///<summary>
	///0x000005b7
	///</summary>
	public class Owner : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Owner);

		}
	}


	[NVP_Manifest(
		Id = "B252D2F9-0C75-4D7F-B328-9622A7637607", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimNumber.Set_Owner", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimNumber", 
		NodeName = "Set_Owner", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005b7", 
		ViewType = "Modifier")]
	[NodeInput("SymDimNumber", typeof(object))]
	[NodeInput("ppValue", typeof(System.Object))]

	///<summary>
	///0x000005b7
	///</summary>
	public class Set_Owner : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Owner = inputs[1].Value;
			return null;
		}
	}
}
