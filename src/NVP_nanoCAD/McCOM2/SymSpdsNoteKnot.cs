using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///ISymSpdsNoteKnot interface
///</summary>
namespace McCOM2.SymSpdsNoteKnot 
{

	[NVP_Manifest(
		Id = "92E64B13-F848-4E3D-ADEE-E06406480BA8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteKnot.SymSpdsNoteKnot_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteKnot", 
		NodeName = "_SymSpdsNoteKnot_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsNoteKnot_Constructor : INode 
	{
		public McCOM2.ISymSpdsNoteKnot _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymSpdsNoteKnot;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "209C83B2-112C-40F0-B56D-4826E666663E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteKnot.SymSpdsNoteKnot_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteKnot", 
		NodeName = "_SymSpdsNoteKnot_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsNoteKnot_ConstructorCast : INode 
	{
		public McCOM2.ISymSpdsNoteKnot _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymSpdsNoteKnot;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "7A37A33C-D523-4557-B0B1-22909C07CBD6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteKnot.Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteKnot", 
		NodeName = "Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000003fe", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteKnot", typeof(object))]

	///<summary>
	///0x000003fe
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
		Id = "8AD5022A-FE4C-4202-9F21-5E69D5617989", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteKnot.Set_Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteKnot", 
		NodeName = "Set_Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000003fe", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteKnot", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x000003fe
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
		Id = "75A17B02-F979-4A30-8598-8F7FEED81FA9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteKnot.TextPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteKnot", 
		NodeName = "TextPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000405", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteKnot", typeof(object))]

	///<summary>
	///0x00000405
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
		Id = "7ACAF05F-CC44-4F9B-9A59-20157488C270", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteKnot.Set_TextPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteKnot", 
		NodeName = "Set_TextPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000405", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteKnot", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000405
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
		Id = "4F65550D-890D-4AFE-9085-F929574515DB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteKnot.Align", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteKnot", 
		NodeName = "Align", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000003f0", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteKnot", typeof(object))]

	///<summary>
	///0x000003f0
	///</summary>
	public class Align : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Align);

		}
	}


	[NVP_Manifest(
		Id = "4AFD1ECD-5AEE-4BE2-A3E5-6A6E345CFC1B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteKnot.Set_Align", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteKnot", 
		NodeName = "Set_Align", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000003f0", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteKnot", typeof(object))]
	[NodeInput("McCOM2.TextAlignment", typeof(System.Object))]

	///<summary>
	///0x000003f0
	///</summary>
	public class Set_Align : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Align = ((McCOM2.TextAlignment)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6BA09D4B-4E35-46B9-970B-8D9A82EA4704", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteKnot.Text", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteKnot", 
		NodeName = "Text", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000404", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteKnot", typeof(object))]

	///<summary>
	///0x00000404
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
		Id = "0D9CFE07-3B79-4770-A391-DF873729E5BA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteKnot.Set_Text", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteKnot", 
		NodeName = "Set_Text", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000404", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteKnot", typeof(object))]
	[NodeInput("pbstrResult", typeof(System.String))]

	///<summary>
	///0x00000404
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
		Id = "AE3947B6-4A2E-4BD4-BC1A-0C116B7623BC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteKnot.Direction", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteKnot", 
		NodeName = "Direction", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000003f5", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteKnot", typeof(object))]

	///<summary>
	///0x000003f5
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
		Id = "A62D7461-8BE6-4110-8722-506E1BF867AF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteKnot.Set_Direction", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteKnot", 
		NodeName = "Set_Direction", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000003f5", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteKnot", typeof(object))]
	[NodeInput("prResult", typeof(System.Double))]

	///<summary>
	///0x000003f5
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
		Id = "D0C9C8BB-8479-4584-8BD7-EF057301ABC1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteKnot.Footer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteKnot", 
		NodeName = "Footer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000003f6", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteKnot", typeof(object))]

	///<summary>
	///0x000003f6
	///</summary>
	public class Footer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Footer);

		}
	}


	[NVP_Manifest(
		Id = "F5C00703-F5E3-4DA4-8C29-3FB5891B4737", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteKnot.Set_Footer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteKnot", 
		NodeName = "Set_Footer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000003f6", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteKnot", typeof(object))]
	[NodeInput("pbstrResult", typeof(System.String))]

	///<summary>
	///0x000003f6
	///</summary>
	public class Set_Footer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Footer = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "CD4B7F27-2032-4617-9FBF-EE0D3463D932", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteKnot.RadiusPerp", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteKnot", 
		NodeName = "RadiusPerp", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000401", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteKnot", typeof(object))]

	///<summary>
	///0x00000401
	///</summary>
	public class RadiusPerp : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RadiusPerp);

		}
	}


	[NVP_Manifest(
		Id = "3CD4C0C4-B3FF-4042-A468-B14E1299A984", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteKnot.Set_RadiusPerp", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteKnot", 
		NodeName = "Set_RadiusPerp", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000401", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteKnot", typeof(object))]
	[NodeInput("prResult", typeof(System.Double))]

	///<summary>
	///0x00000401
	///</summary>
	public class Set_RadiusPerp : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RadiusPerp = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "CBC5F644-79C0-45DE-93CC-0E6794FC438D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteKnot.RadiusRef", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteKnot", 
		NodeName = "RadiusRef", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000402", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteKnot", typeof(object))]

	///<summary>
	///0x00000402
	///</summary>
	public class RadiusRef : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RadiusRef);

		}
	}


	[NVP_Manifest(
		Id = "67FFFD50-1623-488C-A71A-807F0B970BA9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteKnot.Set_RadiusRef", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteKnot", 
		NodeName = "Set_RadiusRef", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000402", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteKnot", typeof(object))]
	[NodeInput("prResult", typeof(System.Double))]

	///<summary>
	///0x00000402
	///</summary>
	public class Set_RadiusRef : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RadiusRef = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8FFD63A9-A585-4A8C-8637-24CC87EAB788", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteKnot.RadiusDirection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteKnot", 
		NodeName = "RadiusDirection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000400", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteKnot", typeof(object))]

	///<summary>
	///0x00000400
	///</summary>
	public class RadiusDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RadiusDirection);

		}
	}


	[NVP_Manifest(
		Id = "C87775B0-7C9E-4F01-98E9-F2EEF937CD43", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteKnot.Set_RadiusDirection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteKnot", 
		NodeName = "Set_RadiusDirection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000400", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteKnot", typeof(object))]
	[NodeInput("prValue", typeof(System.Double))]

	///<summary>
	///0x00000400
	///</summary>
	public class Set_RadiusDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RadiusDirection = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DE53E1C6-85A7-4B01-A5C9-F5DE5D075146", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteKnot.Sheet", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteKnot", 
		NodeName = "Sheet", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000403", 
		ViewType = "Data")]
	[NodeInput("SymSpdsNoteKnot", typeof(object))]

	///<summary>
	///0x00000403
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
		Id = "909DE8B5-7289-4663-B9B8-29E87F0836A2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsNoteKnot.Set_Sheet", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsNoteKnot", 
		NodeName = "Set_Sheet", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000403", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsNoteKnot", typeof(object))]
	[NodeInput("pbstrResult", typeof(System.String))]

	///<summary>
	///0x00000403
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
