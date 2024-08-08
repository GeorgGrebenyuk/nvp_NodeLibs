using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Section or cut designation mark
///</summary>
namespace McCOM2.SymSection 
{

	[NVP_Manifest(
		Id = "6C037F95-DE0A-4104-A85A-40F44556206E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSection.SymSection_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSection", 
		NodeName = "_SymSection_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSection_Constructor : INode 
	{
		public McCOM2.ISymSection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymSection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "3780DCD7-E963-4537-BB87-8264ECA348BE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSection.SymSection_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSection", 
		NodeName = "_SymSection_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSection_ConstructorCast : INode 
	{
		public McCOM2.ISymSection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymSection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "5CEFCD14-7D31-4C63-A0A2-93284E694348", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSection.Edges", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSection", 
		NodeName = "Edges", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000302", 
		ViewType = "Data")]
	[NodeInput("SymSection", typeof(object))]

	///<summary>
	///0x00000302
	///</summary>
	public class Edges : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Edges);

		}
	}


	[NVP_Manifest(
		Id = "FBD2ED11-F406-48F6-A5C7-3DF11CE5F641", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSection.Set_Edges", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSection", 
		NodeName = "Set_Edges", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000302", 
		ViewType = "Modifier")]
	[NodeInput("SymSection", typeof(object))]
	[NodeInput("pvPointArray", typeof(System.Object))]

	///<summary>
	///0x00000302
	///</summary>
	public class Set_Edges : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Edges = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A05CC0BB-CDC6-4959-B91C-45F921232959", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSection.Direction", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSection", 
		NodeName = "Direction", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000301", 
		ViewType = "Data")]
	[NodeInput("SymSection", typeof(object))]

	///<summary>
	///0x00000301
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
		Id = "45E30B56-C8C5-4796-A999-95383DBAE94B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSection.Set_Direction", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSection", 
		NodeName = "Set_Direction", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000301", 
		ViewType = "Modifier")]
	[NodeInput("SymSection", typeof(object))]
	[NodeInput("pvVector", typeof(System.Object))]

	///<summary>
	///0x00000301
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
		Id = "6F25E9CE-0EE2-4848-9C70-EB979120F690", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSection.Cut", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSection", 
		NodeName = "Cut", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000002ff", 
		ViewType = "Data")]
	[NodeInput("SymSection", typeof(object))]

	///<summary>
	///0x000002ff
	///</summary>
	public class Cut : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Cut);

		}
	}


	[NVP_Manifest(
		Id = "9B26461C-CCD6-4544-9C31-0981F0ECFC89", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSection.Set_Cut", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSection", 
		NodeName = "Set_Cut", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000002ff", 
		ViewType = "Modifier")]
	[NodeInput("SymSection", typeof(object))]
	[NodeInput("pvbResult", typeof(System.Object))]

	///<summary>
	///0x000002ff
	///</summary>
	public class Set_Cut : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Cut = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E89BF713-4E66-425F-8B5C-4A71AE7EC579", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSection.Prefix", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSection", 
		NodeName = "Prefix", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000030b", 
		ViewType = "Data")]
	[NodeInput("SymSection", typeof(object))]

	///<summary>
	///0x0000030b
	///</summary>
	public class Prefix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Prefix);

		}
	}


	[NVP_Manifest(
		Id = "0995E5A1-7F86-491F-BE90-D18F0F3D22CF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSection.Set_Prefix", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSection", 
		NodeName = "Set_Prefix", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000030b", 
		ViewType = "Modifier")]
	[NodeInput("SymSection", typeof(object))]
	[NodeInput("pbstrResult", typeof(System.String))]

	///<summary>
	///0x0000030b
	///</summary>
	public class Set_Prefix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Prefix = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "EDCB3EB0-3B8B-4A7F-8721-930B18D99081", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSection.Text", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSection", 
		NodeName = "Text", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000030e", 
		ViewType = "Data")]
	[NodeInput("SymSection", typeof(object))]

	///<summary>
	///0x0000030e
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
		Id = "ED5498E6-892A-4C43-9C25-954110781068", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSection.Set_Text", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSection", 
		NodeName = "Set_Text", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000030e", 
		ViewType = "Modifier")]
	[NodeInput("SymSection", typeof(object))]
	[NodeInput("pbstrResult", typeof(System.String))]

	///<summary>
	///0x0000030e
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
		Id = "A2212710-93D0-4DF8-A4A6-6A20331880A5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSection.Index", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSection", 
		NodeName = "Index", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000304", 
		ViewType = "Data")]
	[NodeInput("SymSection", typeof(object))]

	///<summary>
	///0x00000304
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
		Id = "9B296074-58B2-4BF7-BF94-02B8446B70DD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSection.Set_Index", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSection", 
		NodeName = "Set_Index", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000304", 
		ViewType = "Modifier")]
	[NodeInput("SymSection", typeof(object))]
	[NodeInput("pbstrResult", typeof(System.String))]

	///<summary>
	///0x00000304
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
		Id = "A46F5913-5328-4C67-B44B-7FFD991C26B3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSection.Zone", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSection", 
		NodeName = "Zone", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000311", 
		ViewType = "Data")]
	[NodeInput("SymSection", typeof(object))]

	///<summary>
	///0x00000311
	///</summary>
	public class Zone : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Zone);

		}
	}


	[NVP_Manifest(
		Id = "31BBF7DA-D6FC-4CC4-B7D6-24CA2AF0A2EB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSection.Set_Zone", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSection", 
		NodeName = "Set_Zone", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000311", 
		ViewType = "Modifier")]
	[NodeInput("SymSection", typeof(object))]
	[NodeInput("pbstrResult", typeof(System.String))]

	///<summary>
	///0x00000311
	///</summary>
	public class Set_Zone : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Zone = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "58C60B22-355F-431D-A0E3-AAE6E6EC590B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSection.Sheet", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSection", 
		NodeName = "Sheet", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000030d", 
		ViewType = "Data")]
	[NodeInput("SymSection", typeof(object))]

	///<summary>
	///0x0000030d
	///</summary>
	public class Sheet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Sheet);

		}
	}


	[NVP_Manifest(
		Id = "B3CDE4BB-4297-4620-9A51-03243CC5FE5E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSection.Set_Sheet", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSection", 
		NodeName = "Set_Sheet", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000030d", 
		ViewType = "Modifier")]
	[NodeInput("SymSection", typeof(object))]
	[NodeInput("pnResult", typeof(System.Object))]

	///<summary>
	///0x0000030d
	///</summary>
	public class Set_Sheet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Sheet = inputs[1].Value;
			return null;
		}
	}
}
