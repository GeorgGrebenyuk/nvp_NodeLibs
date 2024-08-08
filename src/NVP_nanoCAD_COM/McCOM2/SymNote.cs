using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Note mark
///</summary>
namespace McCOM2.SymNote 
{

	[NVP_Manifest(
		Id = "DE8E2B87-F16D-4032-A02A-7C9B9B01EE80", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymNote.SymNote_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymNote", 
		NodeName = "_SymNote_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymNote_Constructor : INode 
	{
		public McCOM2.ISymNote _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymNote;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "66DCE81E-6207-44A7-9C43-EB8FB5D36B65", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymNote.SymNote_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymNote", 
		NodeName = "_SymNote_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymNote_ConstructorCast : INode 
	{
		public McCOM2.ISymNote _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymNote;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "27EA3438-6BDF-473F-8C5C-44033CFE6572", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymNote.Text", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymNote", 
		NodeName = "Text", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000298", 
		ViewType = "Data")]
	[NodeInput("SymNote", typeof(object))]

	///<summary>
	///0x00000298
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
		Id = "8A9183D8-E9E7-4FC1-B519-E8522958B2EF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymNote.Set_Text", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymNote", 
		NodeName = "Set_Text", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000298", 
		ViewType = "Modifier")]
	[NodeInput("SymNote", typeof(object))]
	[NodeInput("pbstrText", typeof(System.String))]

	///<summary>
	///0x00000298
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
		Id = "3E93B52B-F985-435C-9E04-494BECEF8DB9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymNote.Lines", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymNote", 
		NodeName = "Lines", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000028f", 
		ViewType = "Data")]
	[NodeInput("SymNote", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///0x0000028f
	///</summary>
	public class Lines : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Lines(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "964DA366-A91F-43F7-8E15-92B5CC7E6F87", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymNote.Set_Lines", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymNote", 
		NodeName = "Set_Lines", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000028f", 
		ViewType = "Modifier")]
	[NodeInput("SymNote", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]
	[NodeInput("vbstrResult", typeof(System.String))]

	///<summary>
	///0x0000028f
	///</summary>
	public class Set_Lines : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Lines[inputs[1]] = inputs[2];
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1BC35C11-7FAD-4AE8-B862-D51D54D088A8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymNote.LinesCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymNote", 
		NodeName = "LinesCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000290", 
		ViewType = "Data")]
	[NodeInput("SymNote", typeof(object))]

	///<summary>
	///0x00000290
	///</summary>
	public class LinesCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LinesCount);

		}
	}


	[NVP_Manifest(
		Id = "1606B023-621F-4174-8601-013DFF9D8E11", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymNote.Set_LinesCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymNote", 
		NodeName = "Set_LinesCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000290", 
		ViewType = "Modifier")]
	[NodeInput("SymNote", typeof(object))]
	[NodeInput("pnResult", typeof(System.Object))]

	///<summary>
	///0x00000290
	///</summary>
	public class Set_LinesCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LinesCount = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F75EC1BF-59A5-4437-9945-5CA8B02E1D83", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymNote.Align", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymNote", 
		NodeName = "Align", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000286", 
		ViewType = "Data")]
	[NodeInput("SymNote", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///0x00000286
	///</summary>
	public class Align : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Align(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "8959A6EC-FDF3-400E-AA52-C2FA21E7461E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymNote.Set_Align", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymNote", 
		NodeName = "Set_Align", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000286", 
		ViewType = "Modifier")]
	[NodeInput("SymNote", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]
	[NodeInput("McCOM2.TextAlignment", typeof(System.Object))]

	///<summary>
	///0x00000286
	///</summary>
	public class Set_Align : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Align[inputs[1]] = inputs[2];
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C55F3F9F-D071-45A1-B206-4224EEE49142", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymNote.TextPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymNote", 
		NodeName = "TextPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000299", 
		ViewType = "Data")]
	[NodeInput("SymNote", typeof(object))]

	///<summary>
	///0x00000299
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
		Id = "429C7387-2500-48C7-9D2F-02FA42004AE3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymNote.Set_TextPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymNote", 
		NodeName = "Set_TextPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000299", 
		ViewType = "Modifier")]
	[NodeInput("SymNote", typeof(object))]
	[NodeInput("pvResult", typeof(System.Object))]

	///<summary>
	///0x00000299
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
		Id = "70CBC32A-1EF5-4F1F-BCC4-F23006257C1C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymNote.Direction", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymNote", 
		NodeName = "Direction", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000028b", 
		ViewType = "Data")]
	[NodeInput("SymNote", typeof(object))]

	///<summary>
	///0x0000028b
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
		Id = "F8195814-C9FC-46A5-BADF-01F073C02524", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymNote.Set_Direction", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymNote", 
		NodeName = "Set_Direction", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000028b", 
		ViewType = "Modifier")]
	[NodeInput("SymNote", typeof(object))]
	[NodeInput("prResult", typeof(System.Double))]

	///<summary>
	///0x0000028b
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
		Id = "6F2BAD0D-DE69-4A6A-BDF3-D6A52F60CE01", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymNote.Multiline", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymNote", 
		NodeName = "Multiline", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000294", 
		ViewType = "Data")]
	[NodeInput("SymNote", typeof(object))]

	///<summary>
	///0x00000294
	///</summary>
	public class Multiline : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Multiline);

		}
	}


	[NVP_Manifest(
		Id = "90254EC7-9BB6-41A8-916F-8A943628224B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymNote.Set_Multiline", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymNote", 
		NodeName = "Set_Multiline", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000294", 
		ViewType = "Modifier")]
	[NodeInput("SymNote", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x00000294
	///</summary>
	public class Set_Multiline : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Multiline = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "CA56B46A-FE31-4D7F-969B-05232CD2810C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymNote.Leaders", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymNote", 
		NodeName = "Leaders", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000028e", 
		ViewType = "Data")]
	[NodeInput("SymNote", typeof(object))]

	///<summary>
	///0x0000028e
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
