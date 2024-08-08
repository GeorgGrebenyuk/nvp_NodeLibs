using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Table item formatter
///</summary>
namespace McCOM2.SymTableFormat 
{

	[NVP_Manifest(
		Id = "F2037553-4ACE-42F2-9FCE-7FE5F2B338BE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableFormat.SymTableFormat_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableFormat", 
		NodeName = "_SymTableFormat_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymTableFormat_Constructor : INode 
	{
		public McCOM2.ISymTableFormat _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymTableFormat;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "BE6FDF67-8DAE-4F15-A352-F641DA1D47FB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableFormat.SymTableFormat_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableFormat", 
		NodeName = "_SymTableFormat_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymTableFormat_ConstructorCast : INode 
	{
		public McCOM2.ISymTableFormat _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymTableFormat;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "ACCE2F9F-C554-473D-A63D-A8F82D01DDA2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableFormat.BorderWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableFormat", 
		NodeName = "BorderWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000501", 
		ViewType = "Data")]
	[NodeInput("SymTableFormat", typeof(object))]
	[NodeInput("McCOM2.SymTableBorder", typeof(System.Object))]

	///<summary>
	///0x00000501
	///</summary>
	public class BorderWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BorderWeight(((McCOM2.SymTableBorder)inputs[1].Value)));

		}
	}


	[NVP_Manifest(
		Id = "CDA657D3-761E-44A4-8F66-681A77F1B7D4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableFormat.Set_BorderWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableFormat", 
		NodeName = "Set_BorderWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000501", 
		ViewType = "Modifier")]
	[NodeInput("SymTableFormat", typeof(object))]
	[NodeInput("McCOM2.SymTableBorder", typeof(System.Object))]
	[NodeInput("prValue", typeof(System.Double))]

	///<summary>
	///0x00000501
	///</summary>
	public class Set_BorderWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BorderWeight[inputs[1]] = inputs[2];
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7F97D551-1133-45B1-AB04-D70E49BDA44A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableFormat.BorderColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableFormat", 
		NodeName = "BorderColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000500", 
		ViewType = "Data")]
	[NodeInput("SymTableFormat", typeof(object))]
	[NodeInput("McCOM2.SymTableBorder", typeof(System.Object))]

	///<summary>
	///0x00000500
	///</summary>
	public class BorderColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BorderColor(((McCOM2.SymTableBorder)inputs[1].Value)));

		}
	}


	[NVP_Manifest(
		Id = "3D46AD29-A0AF-460D-AA58-5AA478D11E06", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableFormat.Set_BorderColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableFormat", 
		NodeName = "Set_BorderColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000500", 
		ViewType = "Modifier")]
	[NodeInput("SymTableFormat", typeof(object))]
	[NodeInput("McCOM2.SymTableBorder", typeof(System.Object))]
	[NodeInput("pnValue", typeof(System.Object))]

	///<summary>
	///0x00000500
	///</summary>
	public class Set_BorderColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BorderColor[inputs[1]] = inputs[2];
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3587F9DE-F714-4659-9C85-0B3580F51B7D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableFormat.TextStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableFormat", 
		NodeName = "TextStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000508", 
		ViewType = "Data")]
	[NodeInput("SymTableFormat", typeof(object))]

	///<summary>
	///0x00000508
	///</summary>
	public class TextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextStyle);

		}
	}


	[NVP_Manifest(
		Id = "829B4500-A8C6-4CD9-A7E1-629108E6D207", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableFormat.Set_TextStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableFormat", 
		NodeName = "Set_TextStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000508", 
		ViewType = "Modifier")]
	[NodeInput("SymTableFormat", typeof(object))]
	[NodeInput("pbstrResult", typeof(System.String))]

	///<summary>
	///0x00000508
	///</summary>
	public class Set_TextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextStyle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4EE89F92-3749-4EC4-9A88-D25B4899A459", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableFormat.TextHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableFormat", 
		NodeName = "TextHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000505", 
		ViewType = "Data")]
	[NodeInput("SymTableFormat", typeof(object))]

	///<summary>
	///0x00000505
	///</summary>
	public class TextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextHeight);

		}
	}


	[NVP_Manifest(
		Id = "5C5C63EE-8C4F-429E-BCF8-CF463F67E419", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableFormat.Set_TextHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableFormat", 
		NodeName = "Set_TextHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000505", 
		ViewType = "Modifier")]
	[NodeInput("SymTableFormat", typeof(object))]
	[NodeInput("prResult", typeof(System.Double))]

	///<summary>
	///0x00000505
	///</summary>
	public class Set_TextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextHeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "839F5653-5101-48F1-9B0B-911DFFF130EF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableFormat.TextAlign", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableFormat", 
		NodeName = "TextAlign", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000503", 
		ViewType = "Data")]
	[NodeInput("SymTableFormat", typeof(object))]

	///<summary>
	///0x00000503
	///</summary>
	public class TextAlign : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextAlign);

		}
	}


	[NVP_Manifest(
		Id = "119F5D9B-E896-4ED6-A80A-5436AE0A058D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableFormat.Set_TextAlign", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableFormat", 
		NodeName = "Set_TextAlign", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000503", 
		ViewType = "Modifier")]
	[NodeInput("SymTableFormat", typeof(object))]
	[NodeInput("McCOM2.TextAlignment", typeof(System.Object))]

	///<summary>
	///0x00000503
	///</summary>
	public class Set_TextAlign : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextAlign = ((McCOM2.TextAlignment)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DA102751-B9BC-465B-BF70-5D9ACD09B11E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableFormat.TextMargin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableFormat", 
		NodeName = "TextMargin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000506", 
		ViewType = "Data")]
	[NodeInput("SymTableFormat", typeof(object))]

	///<summary>
	///0x00000506
	///</summary>
	public class TextMargin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextMargin);

		}
	}


	[NVP_Manifest(
		Id = "9B5865F9-DFD4-4090-BEDE-55345597E774", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableFormat.Set_TextMargin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableFormat", 
		NodeName = "Set_TextMargin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000506", 
		ViewType = "Modifier")]
	[NodeInput("SymTableFormat", typeof(object))]
	[NodeInput("prResult", typeof(System.Double))]

	///<summary>
	///0x00000506
	///</summary>
	public class Set_TextMargin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextMargin = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "53F95040-F302-43AF-912A-3FAC90B4A4A1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableFormat.TextAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableFormat", 
		NodeName = "TextAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000504", 
		ViewType = "Data")]
	[NodeInput("SymTableFormat", typeof(object))]

	///<summary>
	///0x00000504
	///</summary>
	public class TextAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextAngle);

		}
	}


	[NVP_Manifest(
		Id = "B551ECE7-A579-4E7C-946B-74325D2EAA72", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableFormat.Set_TextAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableFormat", 
		NodeName = "Set_TextAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000504", 
		ViewType = "Modifier")]
	[NodeInput("SymTableFormat", typeof(object))]
	[NodeInput("pnAngle", typeof(System.Object))]

	///<summary>
	///0x00000504
	///</summary>
	public class Set_TextAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextAngle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "82198293-8B44-4348-9748-6CB47AD26898", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableFormat.TextWrap", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableFormat", 
		NodeName = "TextWrap", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000509", 
		ViewType = "Data")]
	[NodeInput("SymTableFormat", typeof(object))]

	///<summary>
	///0x00000509
	///</summary>
	public class TextWrap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextWrap);

		}
	}


	[NVP_Manifest(
		Id = "97847699-D6E5-4B0A-8E56-C7CDEE933F03", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableFormat.Set_TextWrap", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableFormat", 
		NodeName = "Set_TextWrap", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000509", 
		ViewType = "Modifier")]
	[NodeInput("SymTableFormat", typeof(object))]
	[NodeInput("pvbResult", typeof(System.Object))]

	///<summary>
	///0x00000509
	///</summary>
	public class Set_TextWrap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextWrap = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5A27FA93-E545-4909-AB88-31156D6B2421", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableFormat.TextScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableFormat", 
		NodeName = "TextScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000507", 
		ViewType = "Data")]
	[NodeInput("SymTableFormat", typeof(object))]

	///<summary>
	///0x00000507
	///</summary>
	public class TextScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextScale);

		}
	}


	[NVP_Manifest(
		Id = "AD2D8595-FAE4-4F41-ADED-731E4A0295A5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableFormat.Set_TextScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableFormat", 
		NodeName = "Set_TextScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000507", 
		ViewType = "Modifier")]
	[NodeInput("SymTableFormat", typeof(object))]
	[NodeInput("pvbResult", typeof(System.Object))]

	///<summary>
	///0x00000507
	///</summary>
	public class Set_TextScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F712470C-4101-4567-A2EF-1C20B0EAA381", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableFormat.Enabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableFormat", 
		NodeName = "Enabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000502", 
		ViewType = "Data")]
	[NodeInput("SymTableFormat", typeof(object))]

	///<summary>
	///0x00000502
	///</summary>
	public class Enabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Enabled);

		}
	}


	[NVP_Manifest(
		Id = "E8478D8D-4D0D-434B-A0E4-9AB35D1B1F9E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableFormat.Set_Enabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableFormat", 
		NodeName = "Set_Enabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000502", 
		ViewType = "Modifier")]
	[NodeInput("SymTableFormat", typeof(object))]
	[NodeInput("pvbResult", typeof(System.Object))]

	///<summary>
	///0x00000502
	///</summary>
	public class Set_Enabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Enabled = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8B9A1FE2-BA16-4402-8581-26E514B69A5B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTableFormat.CopyFrom", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTableFormat", 
		NodeName = "CopyFrom", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000004ff", 
		ViewType = "Modifier")]
	[NodeInput("SymTableFormat", typeof(object))]
	[NodeInput("pFrom", typeof(System.Object))]

	///<summary>
	///0x000004ff
	///</summary>
	public class CopyFrom : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CopyFrom(inputs[1].Value);
			return null;
		}
	}
}
